﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petStore
{
    internal class Cat : IPet
    {
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public string Speak()
        {
            return "Meow!";
        }
        public void DontPeeOnTheRug()
        {

        }
        public void DontScratchTheFurniture()
        {

        }
        public void CleanYourLitterBox()
        {

        }
    }
}
