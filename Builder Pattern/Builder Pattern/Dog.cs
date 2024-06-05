using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    using System.Collections.Generic;

    public class Dog
    {
        private string _name;
        private string _breed;
        private int _age;
        private List<string> _toys;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public List<string> Toys
        {
            get { return _toys; }
            set { _toys = value; }
        }
    }

}
