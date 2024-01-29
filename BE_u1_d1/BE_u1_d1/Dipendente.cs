using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_u1_d1
{
    public class Dipendente
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

        public string oreLavorate(int ore)
        {
            if (ore > 50)
            {
                return "troppi straordinari";
            }
            else
            {
                return "puo ancora lavorare";
            }
        }
    }
}
