﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruits
{
    public class Orange : IFruit 
    {
        public Orange () { }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }
        public string Name
        {
            get { return "orange"; }
        }
        public bool IsPeeled { get; private set; }
        public string Peel()
        {
            if (IsPeeled)
            {
                return "It's already peeled.";
            }
            else
            {
                IsPeeled = true;
                return "You peel the orange.";
            }
        }

        public string Squeeze()
        {
            return "You squeeze the orange and juice comes out.";
        }
    }
}
