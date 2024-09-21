using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_aedb1.Model
{
    public class Editora
    {
        private int _id;

        private string _Nome;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome { get => _Nome; set => _Nome = value.Replace("'", " "); }
    }
}
