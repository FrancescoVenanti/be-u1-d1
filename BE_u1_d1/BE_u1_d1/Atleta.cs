using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_u1_d1
{
    public class Atleta
    {
        private string _name;
        public string Name
        {
            get { return _name; } 
            set { _name = value; }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string etaRitiro(int eta)
        {
            if (eta > 35)
            {
                return "meglio ritirarsi";
            }
            else
            {
                return "puo ancora giocare";
            }
        }

    }
}
