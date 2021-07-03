using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Enemy
{
    public class Orc : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Orc Attack");
        }

        public override string ToString()
        {
            return "Orc";
        }
    }
}
