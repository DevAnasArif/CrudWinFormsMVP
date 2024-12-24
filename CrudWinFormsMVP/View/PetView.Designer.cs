namespace CrudWinFormsMVP.View
{
    partial class PetView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPetlist = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.Addnewbtn = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Seachlist = new System.Windows.Forms.TextBox();
            this.searchlist = new System.Windows.Forms.Label();
            this.tabPetdetails = new System.Windows.Forms.TabPage();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.petcolortextBox = new System.Windows.Forms.TextBox();
            this.petcolour = new System.Windows.Forms.Label();
            this.pettype = new System.Windows.Forms.Label();
            this.petname = new System.Windows.Forms.Label();
            this.pettypetextbox = new System.Windows.Forms.TextBox();
            this.petnametextBox = new System.Windows.Forms.TextBox();
            this.petidtextbox = new System.Windows.Forms.TextBox();
            this.petid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPetlist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPetdetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PETS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 64);
            this.panel1.TabIndex = 1;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Snow;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Red;
            this.BtnClose.Location = new System.Drawing.Point(599, 10);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(37, 33);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "x";
            this.BtnClose.UseVisualStyleBackColor = false;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPetlist);
            this.TabControl.Controls.Add(this.tabPetdetails);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 64);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(648, 386);
            this.TabControl.TabIndex = 2;
            // 
            // tabPetlist
            // 
            this.tabPetlist.BackColor = System.Drawing.Color.Aqua;
            this.tabPetlist.Controls.Add(this.dataGridView1);
            this.tabPetlist.Controls.Add(this.delbtn);
            this.tabPetlist.Controls.Add(this.editbtn);
            this.tabPetlist.Controls.Add(this.Addnewbtn);
            this.tabPetlist.Controls.Add(this.Searchbtn);
            this.tabPetlist.Controls.Add(this.Seachlist);
            this.tabPetlist.Controls.Add(this.searchlist);
            this.tabPetlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPetlist.Location = new System.Drawing.Point(4, 22);
            this.tabPetlist.Name = "tabPetlist";
            this.tabPetlist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPetlist.Size = new System.Drawing.Size(640, 360);
            this.tabPetlist.TabIndex = 0;
            this.tabPetlist.Text = "Pet List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(462, 232);
            this.dataGridView1.TabIndex = 7;
            // 
            // delbtn
            // 
            this.delbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delbtn.BackColor = System.Drawing.Color.Red;
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(514, 190);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(98, 36);
            this.delbtn.TabIndex = 6;
            this.delbtn.Text = "Delete";
            this.delbtn.UseVisualStyleBackColor = false;
            // 
            // editbtn
            // 
            this.editbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.Location = new System.Drawing.Point(514, 148);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(98, 36);
            this.editbtn.TabIndex = 5;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = false;
            // 
            // Addnewbtn
            // 
            this.Addnewbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Addnewbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Addnewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addnewbtn.Location = new System.Drawing.Point(514, 106);
            this.Addnewbtn.Name = "Addnewbtn";
            this.Addnewbtn.Size = new System.Drawing.Size(98, 36);
            this.Addnewbtn.TabIndex = 4;
            this.Addnewbtn.Text = "Add New";
            this.Addnewbtn.UseVisualStyleBackColor = false;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(396, 49);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(98, 36);
            this.Searchbtn.TabIndex = 3;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = false;
            // 
            // Seachlist
            // 
            this.Seachlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Seachlist.Location = new System.Drawing.Point(32, 49);
            this.Seachlist.Multiline = true;
            this.Seachlist.Name = "Seachlist";
            this.Seachlist.Size = new System.Drawing.Size(340, 36);
            this.Seachlist.TabIndex = 2;
            // 
            // searchlist
            // 
            this.searchlist.AutoSize = true;
            this.searchlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchlist.Location = new System.Drawing.Point(29, 15);
            this.searchlist.Name = "searchlist";
            this.searchlist.Size = new System.Drawing.Size(91, 18);
            this.searchlist.TabIndex = 1;
            this.searchlist.Text = "Search Pet";
            // 
            // tabPetdetails
            // 
            this.tabPetdetails.BackColor = System.Drawing.Color.Aqua;
            this.tabPetdetails.Controls.Add(this.cancelbtn);
            this.tabPetdetails.Controls.Add(this.savebtn);
            this.tabPetdetails.Controls.Add(this.petcolortextBox);
            this.tabPetdetails.Controls.Add(this.petcolour);
            this.tabPetdetails.Controls.Add(this.pettype);
            this.tabPetdetails.Controls.Add(this.petname);
            this.tabPetdetails.Controls.Add(this.pettypetextbox);
            this.tabPetdetails.Controls.Add(this.petnametextBox);
            this.tabPetdetails.Controls.Add(this.petidtextbox);
            this.tabPetdetails.Controls.Add(this.petid);
            this.tabPetdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPetdetails.Location = new System.Drawing.Point(4, 22);
            this.tabPetdetails.Name = "tabPetdetails";
            this.tabPetdetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPetdetails.Size = new System.Drawing.Size(640, 360);
            this.tabPetdetails.TabIndex = 1;
            this.tabPetdetails.Text = "Pet Details";
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.White;
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(205, 276);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(125, 39);
            this.cancelbtn.TabIndex = 9;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.White;
            this.savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(52, 276);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(125, 39);
            this.savebtn.TabIndex = 8;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            // 
            // petcolortextBox
            // 
            this.petcolortextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petcolortextBox.Location = new System.Drawing.Point(51, 221);
            this.petcolortextBox.Multiline = true;
            this.petcolortextBox.Name = "petcolortextBox";
            this.petcolortextBox.Size = new System.Drawing.Size(394, 30);
            this.petcolortextBox.TabIndex = 7;
            // 
            // petcolour
            // 
            this.petcolour.AutoSize = true;
            this.petcolour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petcolour.Location = new System.Drawing.Point(48, 185);
            this.petcolour.Name = "petcolour";
            this.petcolour.Size = new System.Drawing.Size(93, 20);
            this.petcolour.TabIndex = 6;
            this.petcolour.Text = "Pet Colour";
            // 
            // pettype
            // 
            this.pettype.AutoSize = true;
            this.pettype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pettype.Location = new System.Drawing.Point(268, 98);
            this.pettype.Name = "pettype";
            this.pettype.Size = new System.Drawing.Size(79, 20);
            this.pettype.TabIndex = 5;
            this.pettype.Text = "Pet Type";
            // 
            // petname
            // 
            this.petname.AutoSize = true;
            this.petname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petname.Location = new System.Drawing.Point(47, 98);
            this.petname.Name = "petname";
            this.petname.Size = new System.Drawing.Size(87, 20);
            this.petname.TabIndex = 4;
            this.petname.Text = "Pet Name";
            // 
            // pettypetextbox
            // 
            this.pettypetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pettypetextbox.Location = new System.Drawing.Point(272, 133);
            this.pettypetextbox.Multiline = true;
            this.pettypetextbox.Name = "pettypetextbox";
            this.pettypetextbox.Size = new System.Drawing.Size(173, 30);
            this.pettypetextbox.TabIndex = 3;
            // 
            // petnametextBox
            // 
            this.petnametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petnametextBox.Location = new System.Drawing.Point(51, 133);
            this.petnametextBox.Multiline = true;
            this.petnametextBox.Name = "petnametextBox";
            this.petnametextBox.Size = new System.Drawing.Size(173, 30);
            this.petnametextBox.TabIndex = 2;
            // 
            // petidtextbox
            // 
            this.petidtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petidtextbox.Location = new System.Drawing.Point(51, 49);
            this.petidtextbox.Multiline = true;
            this.petidtextbox.Name = "petidtextbox";
            this.petidtextbox.ReadOnly = true;
            this.petidtextbox.Size = new System.Drawing.Size(173, 30);
            this.petidtextbox.TabIndex = 1;
            this.petidtextbox.Text = "0";
            // 
            // petid
            // 
            this.petid.AutoSize = true;
            this.petid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petid.Location = new System.Drawing.Point(47, 16);
            this.petid.Name = "petid";
            this.petid.Size = new System.Drawing.Size(57, 20);
            this.petid.TabIndex = 0;
            this.petid.Text = "Pet Id";
            // 
            // PetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.panel1);
            this.Name = "PetView";
            this.Text = "PetView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabPetlist.ResumeLayout(false);
            this.tabPetlist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPetdetails.ResumeLayout(false);
            this.tabPetdetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPetlist;
        private System.Windows.Forms.TabPage tabPetdetails;
        private System.Windows.Forms.TextBox Seachlist;
        private System.Windows.Forms.Label searchlist;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button Addnewbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox petidtextbox;
        private System.Windows.Forms.Label petid;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox petcolortextBox;
        private System.Windows.Forms.Label petcolour;
        private System.Windows.Forms.Label pettype;
        private System.Windows.Forms.Label petname;
        private System.Windows.Forms.TextBox pettypetextbox;
        private System.Windows.Forms.TextBox petnametextBox;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button BtnClose;
    }
}