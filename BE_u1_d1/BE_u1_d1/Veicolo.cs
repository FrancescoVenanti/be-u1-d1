using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_u1_d1
{
    internal class Veicolo
    {
        private string _marca;
        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = value;
            }
        }
        public string kmTagliando(int attuale)
        {
            if (attuale > 10000)
            {
                return "tagliando da effettuare";
            }
            else
            {
                return "tagliando fatto";
            }
        }
    }
}
