using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petStore
{
    internal interface ISpeakable
    {        
        // all classes that imlement have to have a speak method.
        public string Speak();
    }
    internal interface INameable
    {
        public string Name { get; set; }
    }
    internal interface IPet : ISpeakable, INameable
    {
        public string AnimalType { get; set; }
    }
}
