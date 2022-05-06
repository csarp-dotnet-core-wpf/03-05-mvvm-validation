using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationProject.Models
{
    class Data
    {
        private string name;

        public Data()
        {
            this.name = "Péter";
        }

        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            string result = name;
            return result;
        }
    }
}
