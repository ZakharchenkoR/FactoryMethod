using FactoryMethod.GameObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //карта гри
    public class Map
    {
        /// <summary>
        /// Вороги на локації
        /// </summary>
        private IEnemy[] enemies;

        /// <summary>
        /// Дерев на локації 
        /// </summary>
        private Tree[] trees;

        /// <summary>
        /// Кушів на локації
        /// </summary>
        private Bush[] buches;

        public Map(IEnemy[] bidlos, Tree[] trees, Bush[] buches)
        {
            this.enemies = bidlos;
            this.trees = trees;
            this.buches = buches;
        }

        /// Виводить інфу по кількості ворогів на карті в консоль
        /// 
        /// Например:
        /// 15 Orc
        /// 100 Vampir
        /// 55 Zombie
     
        public void EnemyInfo()
        {
            var orc = enemies.Where((item) => {
                return item.ToString() == "Orc";
            }).Count();

            Console.WriteLine($"{orc} Orc");


            var vampir = enemies.Where((item) => {
                return item.ToString() == "Vampir";
            }).Count();

            Console.WriteLine($"{vampir} Vampir");


            var zombie = enemies.Where((item) => {
                return item.ToString() == "Zombie";
            }).Count();

            Console.WriteLine($"{zombie} Zombie");
        }
    }
}
