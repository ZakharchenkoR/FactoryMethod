using FactoryMethod.Factories;
using FactoryMethod.Games;

using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // ініціалізація рівнів тяжкості гри. Користувач сам його вибирає
            IEnemyFactory[] lvls = new IEnemyFactory[] 
            { 
                new EazyLvlEnemyFactory(),
                new MiddleLvlEnemyFactory(),
                new HardLvlEnemyFactory()
            };

            Console.WriteLine("Виберіть рівень й введіть його номер:");

            // виводим всі рівні користувачу
            for (int i = 0; i < lvls.Length; i++) 
            {
                // i+1 тому що нормальні люди рахують с 1, а не с 0
                Console.WriteLine($"{i + 1}. {lvls[i].ToString()}"); 
            }

            // -1 тому що нормальні люди все ще рахують с 1, а не с 0 ))
            int lvlNumber = Convert.ToInt32(Console.ReadLine()) - 1;

            // перевірка правильності вибору рівня
            if (lvlNumber > -1 && lvlNumber < lvls.Length) 
            {
                //створюємо гру з db,hfybv hsdytv
                Game game = new Game(lvls[lvlNumber]);
                game.StartGame();
            }
            else
            {
                Console.WriteLine("Недопустиме число");
            }

            Console.ReadKey();
        }
    }
}
