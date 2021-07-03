using FactoryMethod.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Games
{
    public class Game
    {
        private Map location;
        private Hero gamer;

        public Game(IEnemyFactory factory)
        {
            gamer = new Hero(); // Головний герой за якого граємо

            // Список дерев на локації
            Tree[] trees = new Tree[] 
            { 
                new Tree(),
                new Tree(),
                new Tree()
            };

            // Список кущів на локації
            Bush[] benches = new Bush[] 
            {
                new Bush(),
                new Bush(),
                new Bush()
            };

            // Список воргів на локації
            IEnemy[] bidlos = new IEnemy[100]; 

            for (int i = 0; i < bidlos.Length; i++)
            {
                // заповнення масиву що виконує фабричний метод
                bidlos[i] = factory.Create(); 
            }

            // ініціалізація ігрової локації
            location = new Map(bidlos, trees, benches);

            // Карта взагалі нічого не знає про пространство імен з
            // конкретними монстрами. Замість цього відбувається маніпуляція абстракціями і фабриками.
            // Тепер наскільки б великою не була б ієрархія успадкування ворогів, вона не буде нам заважати
            // при розробці цієї частини програми (та й взагалі якийсь іншій частині).
            // Про конкретних ворогів (Orc, Vampir, Zombie) знають тільки конкретні фабрики, які
            // працюють з ворогами. Але при цьому фабрики нічого не знають про інші частини програми.
            // Інкапсуляція
        }

        /// <summary>
        /// Здесь все игровые элементы взаимодействуют и рендерятся.
        /// (на самом деле нет, потому что не в этом суть данного урока)
        /// </summary>
        public void StartGame()
        {
            Console.WriteLine("Локація загружена");
            Console.WriteLine("Дерева розставлені");
            Console.WriteLine("Кущі розставлені");
            Console.WriteLine("Вороги на карті");
            Console.WriteLine("Гравець загружений");
            Console.WriteLine("Починається гра");

            location.EnemyInfo(); // Інфа про кількість ворогів

        }
    }
}
