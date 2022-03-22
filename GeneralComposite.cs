using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kompozyt
{
    class GeneralComposite : IUnitComponent
    {
        private List<IUnitComponent> _children = new List<IUnitComponent>();

        public void Move()
        {
            Console.WriteLine("General coming first!");

            foreach (var item in _children)
            {
                item.Move();
            }
        }

        public void AddChild(IUnitComponent entity)
        {
            _children.Add(entity);
        }
        public void RemoveChild(IUnitComponent entity)
        {
            _children.Remove(entity);
        }

        public List<IUnitComponent> GetChild()
        {
            return _children;
        }
    }
}
