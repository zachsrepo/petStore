using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petStore
{
    internal class Dog : IPet
    {
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public string Speak()
        {
            return "Bark!!";
        }
        public void Sit()
        {
           
        }
        public void Fetch()
        {

        }
    }
}
