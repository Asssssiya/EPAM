using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgram.Game.Core
{
    public class GameObject
    {
        public GameObject()
        {
            Transform = new Transform();
        }

        public Transform Transform { get; private set; }

      
        public void Destroy()
        {
            throw new NotImplementedException();
        }
    }
}
