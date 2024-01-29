using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_u1_d1
{
    internal class Animale
    {
        private string _breed;
        public string Breed
        {
            get { return _breed; }
            set { _breed = value; } 
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
    }
}
