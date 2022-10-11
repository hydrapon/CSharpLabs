using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwo.Common
{
    internal class SingletonPoints
    {
        private static SingletonPoints instance;

        public int X { get; set; }
        public int Y { get; set; }

        protected SingletonPoints()
        {
            
        }

        public static SingletonPoints getInstance()
        {
            if (instance == null)
                instance = new SingletonPoints();
            return instance;
        }
    }
}
