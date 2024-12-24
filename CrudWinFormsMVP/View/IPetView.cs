using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CrudWinFormsMVP.View
{
    public interface IPetView
    {
        //Properties - field
        string PetId { get; set; }
        string PetName { get; set; }
        string PetType { get; set; }
        string PetColour { get; set; }

        string Searchvalue { get; set; }
        string Message { get; set; }
        bool IsSuccesfull { get; set; }
        bool IsEdit { get; set; }

        //Event
        event EventHandler Searchevent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetPetListBindingSource(BindingSource PetList);
        void Show();
    }
}
