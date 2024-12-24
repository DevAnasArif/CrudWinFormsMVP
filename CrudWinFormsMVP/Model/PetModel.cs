using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CrudWinFormsMVP.Model
{
    public class PetModel
    {
        //field
        private int id;
        private string name;
        private string type;
        private string colour;

        //property-validation
        [DisplayName("Pet ID")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DisplayName("Pet Name")]
        [Required(ErrorMessage ="Pet Name is Required")]
        [StringLength(50,MinimumLength=3,ErrorMessage ="Pet Name must between be 3 to 50 Characters")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DisplayName("Pet Type")]
        [Required(ErrorMessage = "Pet Type is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet Type must between be 3 to 50 Characters")]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        [DisplayName("Pet Color")]
        [Required(ErrorMessage = "Pet Color is Required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet Color must between be 3 to 50 Characters")]
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
    }
}
