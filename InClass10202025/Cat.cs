using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass10202025
{
    public class Cat:Animal
    {
        public string Breed { get; set; }


        public string Speak()
        {
            return "I'm a Cat!";
        }
    }
}
