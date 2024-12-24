using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudWinFormsMVP.View
{
    public partial class MainView : Form,IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnPets.Click += (s, e) =>
            {
                btnPets?.Invoke(ShowPetView, EventArgs.Empty);
            };
        }

        public event EventHandler ShowPetView;
    }
}
