using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntrantAPI.ViewModels
{
    public class CreateEntrantDTO
    {

        
        [Required(ErrorMessage = "The field  First Name {0} is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "The field Last Name {0} is required")]
        public string LastName { get; set; }
    }
}
