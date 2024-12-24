using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudWinFormsMVP.Model;
using CrudWinFormsMVP.View;
using CrudWinFormsMVP.Repositories;
using System.Windows.Forms;

namespace CrudWinFormsMVP.Presenters
{
    public class MainPresenter
    {
    private IMainView mainView;
    private readonly string ConnectionString;

        public MainPresenter(IMainView mainView, string ConnectionString)
        {
            this.mainView = mainView;
            this.ConnectionString = ConnectionString;
            this.mainView.ShowPetView += ShowPetsView;
        }

        private void ShowPetsView(object sender, EventArgs e)
        {
            IPetRepository repository = new PetRepository(ConnectionString);
            IPetView view = PetView.GetInstance((Form)mainView);
            new PetPresenter(view, repository);
        }
    }
}
