using FactoryMethod.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public class MiddleLvlEnemyFactory : IEnemyFactory
    {
        private static Random rnd = new Random();

        public IEnemy Create()
        {
            string[] enemies = new string[]
            {
                "Vampir",
                "Zombie"
            };

            switch (enemies[rnd.Next(0, enemies.Length)]) // Рандомно вибираємо з всіх
            {
                case "Zombie":
                    return new Zombie();
                case "Vampir":
                    return new Vampir();
                default:
                    throw new Exception("Таких конкретных классов нет D:");
            }
        }

        public override string ToString()
        {
            return "Middle level";
        }
    }
}
