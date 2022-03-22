using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompozyt
{
    class EntityLeaf : IUnitComponent
    {
        public void Move()
        {
            Console.WriteLine("I'm following general!");
        }
    }
}
