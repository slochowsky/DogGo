using DogGo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo1.Models.ViewModels
{
    public class DogFormViewModel
    {
        public Dog Dog { get; set; }
        public List<Owner> Owners { get; set; }
    }
}