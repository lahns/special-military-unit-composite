using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompozyt
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneralComposite general = new GeneralComposite();
            general.AddChild(new EntityLeaf());
            general.AddChild(new EntityLeaf());
            general.AddChild(new EntityLeaf());
            general.AddChild(new EntityLeaf());
            general.AddChild(new EntityLeaf());
            general.Move();
            Console.Read();
        }
    }
}
