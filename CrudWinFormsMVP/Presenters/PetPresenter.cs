using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudWinFormsMVP.Model;
using CrudWinFormsMVP.View;
using MySql.Data.MySqlClient;


namespace CrudWinFormsMVP.Presenters
{
    public class PetPresenter
    {
        //fields
        private IPetView view;
        private IPetRepository repository;
        private BindingSource petsBindingSource;
        private IEnumerable<PetModel> petList;
        //construtor
        public PetPresenter(IPetView view, IPetRepository repository)
        {
            this.petsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //suscribe event handler methos to view events
            this.view.Searchevent += SearchPet;
            this.view.AddNewEvent += AddNewpet;
            this.view.EditEvent += LoadSelectedPetToEdit;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelAction;
            this.view.DeleteEvent += DeleteSelectedPet;
            //pet set binding source
            this.view.SetPetListBindingSource(petsBindingSource);
            //load pet list view
            LoadAllPetList();
            this.view.Show();
        }
        private void SearchPet(object sender, EventArgs e)
        {
            bool emptyvalue = string.IsNullOrWhiteSpace(this.view.Searchvalue);
            if (emptyvalue == false)
            {
                petList = repository.GetByValue(this.view.Searchvalue);
            }
            else
            {
                petList = repository.GetAll();
            }
                petsBindingSource.DataSource = petList;//set data source
        }
       
        private void AddNewpet(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            var pet = (PetModel)petsBindingSource.Current;
            view.PetId = pet.Id.ToString();
            view.PetName = pet.Name;
            view.PetType = pet.Type;
            view.PetColour = pet.Colour;
            view.IsEdit = true;
        }

        private void LoadAllPetList()
        {
             petList = repository.GetAll();
             petsBindingSource.DataSource = petList;//set data source
        }
        private void SavePet(object sender, EventArgs e)
        {
            var model = new PetModel();
            model.Id = Convert.ToInt32(view.PetId);
            model.Name = view.PetName;
            model.Type = view.PetType;
            model.Colour = view.PetColour;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Pet edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Pet added sucessfully";
                }
                view.IsSuccesfull = true;
                LoadAllPetList();
                CleanviewFields();
            }
            catch(Exception ex)
            {
                view.IsSuccesfull=false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.PetId = "0";
            view.PetName = "";
            view.PetType = "";
            view.PetColour = "";
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            try
            {
                var pet = (PetModel)petsBindingSource.Current;
                repository.Delete(pet.Id);
                view.IsSuccesfull = true;
                view.Message = "Pet deleted successfully";
                LoadAllPetList();
            }
            catch (Exception ex)
            {
                view.IsSuccesfull = false;
                view.Message = "An error ocurred, could not delete pet";
            }
        }




    }
}
