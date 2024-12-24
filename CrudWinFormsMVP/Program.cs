using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudWinFormsMVP.Model;
using CrudWinFormsMVP.Presenters;
using CrudWinFormsMVP.Repositories;
using CrudWinFormsMVP.View;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;


namespace CrudWinFormsMVP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*PetView view = new PetView();
            string connection = "server=127.0.0.1; user=root; database=veterinarydb; password=";
            IPetRepository repository = new PetRepository(connection);
            new PetPresenter(view, repository);*/
            string connection = "server=127.0.0.1; user=root; database=veterinarydb; password=";
            IMainView view = new MainView();
            new MainPresenter(view, connection);
            Application.Run((Form)view);
        }
    }
}
