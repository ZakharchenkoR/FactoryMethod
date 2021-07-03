using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Enemy
{
    public class Vampir : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Vampir Attack");
        }

        public override string ToString()
        {
            return "Vampir";
        }
    }
}
