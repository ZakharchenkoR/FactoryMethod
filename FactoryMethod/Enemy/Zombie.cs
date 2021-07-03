using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Enemy
{
    public class Zombie : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Zombie Attack");
        }

        public override string ToString()
        {
            return "Zombie"; 
        }
    }
}
