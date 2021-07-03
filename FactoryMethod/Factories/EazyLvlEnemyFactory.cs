using FactoryMethod.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public class EazyLvlEnemyFactory : IEnemyFactory
    {
        private static Random rnd = new Random();

        public IEnemy Create()
        {
            string[] enemies = new string[] 
            {
                "Orc",
                "Vampir",
                "Zombie"
            };

            switch (enemies[rnd.Next(0, enemies.Length)]) // Рандомно вибираємо з всіх
            {
                case "Zombie":
                    return new Zombie();
                case "Orc":
                    return new Orc();
                case "Vampir":
                    return new Vampir();
                default:
                    throw new Exception("Таких конкретных классов нет D:");
            }
        }

        public override string ToString() 
        {
            return "Eazy level";
        }
    }
}
