using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CrudWinFormsMVP.Model;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace CrudWinFormsMVP.Repositories
{
    public class PetRepository : Form, IPetRepository
    {
        public string conectionstring;
        public PetRepository(String connectionString)
        {
            this.conectionstring = connectionString;
        }

        public void Add(PetModel petModel)
        {
            using (MySqlConnection connection = new MySqlConnection(conectionstring))
            using (MySqlCommand command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Pet (Pet_Name, Pet_Type, Pet_Colour) VALUES (@name, @type, @colour);";
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = petModel.Name;
                command.Parameters.Add("@type", MySqlDbType.VarChar).Value = petModel.Type;
                command.Parameters.Add("@colour", MySqlDbType.VarChar).Value = petModel.Colour;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(conectionstring))
            using (MySqlCommand command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Delete From pet Where Pet_Id=@id";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(PetModel petModel)
        {
            using (MySqlConnection connection = new MySqlConnection(conectionstring))
            using (MySqlCommand command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Update pet Set Pet_Name=@name, Pet_Type=@type, Pet_Colour=@colour Where Pet_Id=@id;";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = petModel.Id;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = petModel.Name;
                command.Parameters.Add("@type", MySqlDbType.VarChar).Value = petModel.Type;
                command.Parameters.Add("@colour", MySqlDbType.VarChar).Value = petModel.Colour;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<PetModel> GetAll()
        {
            var PetList = new List<PetModel>();
            using (MySqlConnection connection = new MySqlConnection(conectionstring))
            using (MySqlCommand command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select * from pet order by Pet_Id Asc";
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pet = new PetModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Type = reader.GetString(2),
                            Colour = reader.GetString(3)
                        };
                        PetList.Add(pet);
                    }
                }
            }
            return PetList;
        }

        public IEnumerable<PetModel> GetByValue(string value)
        {
            int PetId = int.TryParse(value, out PetId) ? Convert.ToInt32(value) : 0;
            string Pet_Name = value;
            var PetList = new List<PetModel>();
            using (MySqlConnection connection = new MySqlConnection(conectionstring))
            using (MySqlCommand command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM pet WHERE Pet_id = @id OR Pet_Name LIKE @name ORDER BY Pet_Id ASC";
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = PetId;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Pet_Name + '%';

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
/*                        var Pet = new PetModel();
                        Pet.Id = (int)reader[0];
                        Pet.Name = reader[1].ToString();
                        Pet.Type = reader[2].ToString();
                        Pet.Colour = reader[3].ToString();
                        PetList.Add(Pet);*/
                        var pet = new PetModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Type = reader.GetString(2),
                            Colour = reader.GetString(3)
                        };
                        PetList.Add(pet);
                    }
                }
            }
            return PetList;
        }
    }
}
