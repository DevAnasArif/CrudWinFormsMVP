using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CrudWinFormsMVP.View
{
    public partial class PetView : Form,IPetView
    {
        //field
        private bool isEdit;
        private bool isSuccesfull;
        private string message;

        //construtor
        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            TabControl.TabPages.Remove(tabPetdetails);
            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            Searchbtn.Click += delegate
            {
                Searchevent?.Invoke(this, EventArgs.Empty);
            };

            Seachlist.KeyDown += (s ,e)=>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Searchevent?.Invoke(this, EventArgs.Empty);
                }
            };
            //Add
            Addnewbtn.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                TabControl.TabPages.Remove(tabPetlist);
                TabControl.TabPages.Add(tabPetdetails);
                tabPetdetails.Text = "Add New Pet";
                
            };
            //Edit
            editbtn.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                TabControl.TabPages.Remove(tabPetlist);
                TabControl.TabPages.Add(tabPetdetails);
                tabPetdetails.Text = "Edit Pet";
            };
            //cancel
            cancelbtn.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                TabControl.TabPages.Remove(tabPetdetails);
                TabControl.TabPages.Add(tabPetlist);
            };
            //save changes
            savebtn.Click += delegate
            {
                    SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccesfull)
                {
                    TabControl.TabPages.Remove(tabPetdetails);
                    TabControl.TabPages.Add(tabPetlist);
                }
                else
                {
                    MessageBox.Show(Message);
                }
            };
            //Delete
            delbtn.Click += delegate
            {
                var  result = MessageBox.Show("Are you Sure You Want to Delete the Selected Pet?","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result==(DialogResult.Yes))
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show(Message);
                }
            };
        }

        public string PetId
        { 
            get { return petidtextbox.Text; }
            set { petidtextbox.Text=value; } 
        }
        public string PetName 
        { 
            get { return petnametextBox.Text; }
            set { petnametextBox.Text = value;}
        }
        public string PetType 
        { 
            get { return pettypetextbox.Text; } 
            set { pettypetextbox.Text = value; }
        }
        public string PetColour 
        { 
            get { return petcolortextBox.Text; }
            set { petcolortextBox.Text = value; }
        }
        public string Searchvalue 
        { 
            get { return Seachlist.Text; }
            set { Seachlist.Text=value; }
        }
        public string Message 
        { 
            get { return message;}
            set { message = value; }
        }
        public bool IsSuccesfull 
        { 
            get { return isSuccesfull;}
            set { isSuccesfull=value;}
        }
        public bool IsEdit 
        {
            get { return isEdit;}
            set { isEdit = value; } 
        }


        public event EventHandler Searchevent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        //Method
        public void SetPetListBindingSource(BindingSource PetList)
        {
            dataGridView1.DataSource = PetList;
        }
        //SingleTon pattern (Open a single form instance)
        public static PetView Instance;
        public static PetView GetInstance(Form ParentConateainer) 
        {
            if(Instance==null || Instance.IsDisposed)
            {
                Instance = new PetView();
                Instance.MdiParent = ParentConateainer;
                Instance.FormBorderStyle = FormBorderStyle.None;
                Instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (Instance.WindowState == FormWindowState.Minimized)
                {
                    Instance.WindowState = FormWindowState.Normal;
                    Instance.BringToFront();
                }
            }
            return Instance; 
        }
    }
}
