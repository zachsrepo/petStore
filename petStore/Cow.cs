using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petStore
{
    internal class Cow : IPet
    {
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public string Speak()
        {
            return "Moooo!!";
        }
        public void MilkYourself()
        {

        }
        public void GetYourOwnHay()
        {

        }
    }
}
