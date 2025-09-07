using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Задание 1");
            string anime = "D.Gray-man";
            int number = 0;
            float pi = 3.14f;
            char alf = 'w';
            Console.WriteLine(anime);
            Console.WriteLine(number);
            Console.WriteLine(pi);
            Console.WriteLine(alf);

            //Задание 2
            Console.WriteLine();
            Console.WriteLine("Задание 2");
            Console.WriteLine("I");
            Console.WriteLine("need");
            Console.WriteLine("more");
            Console.WriteLine("power!");

            //Задание 3
            Console.WriteLine();
            Console.WriteLine("Задание 3");
            char kov = '"';
            Console.WriteLine($"{kov}Hello There{kov}");

            //Задание 4
            Console.WriteLine();
            Console.WriteLine("Задание 4");
            Console.Write("Введите стоимость монитора: ");
            int cost_monitor = int.Parse(Console.ReadLine());
            Console.Write("Введите стоимость системного блока: ");
            int cost_systemBlock = int.Parse(Console.ReadLine());
            Console.Write("Введите стоимость клавиатуры: ");
            int cost_keybord = int.Parse(Console.ReadLine());
            Console.Write("Введите стоимость мыши: ");
            int cost_mouse = int.Parse(Console.ReadLine());
            Console.WriteLine($"Стоимость трёх компьюторов: {3 * (cost_mouse + cost_systemBlock + cost_monitor + cost_keybord)}");

            //Задание 5
            Console.WriteLine();
            Console.WriteLine("Задание 5");
            Console.Write("Введите значение a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            int b = int.Parse(Console.ReadLine());
            int result;
            result = 3 * ((a + b) ^ 3) + 275 * (b ^ 2) - 127 * a - 41;
            Console.WriteLine(result);

            //Задание 6
            Console.WriteLine();
            Console.WriteLine("Задание 6");
            Console.Write("Введите ваше имя: ");
            string name_6 = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            int age_6 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Привет, {name_6}!");
            Console.WriteLine($"Сейчас тебе {age_6} лет.");
            Console.WriteLine($"В следующем году тебе будет {age_6 + 1}.");

            //Задание 7
            Console.WriteLine();
            Console.WriteLine("Задание 7");
            string name_7 = "Olesya";
            int age_7 = 18;
            string city = "Volgograd25";
            Console.WriteLine($"Привет, {name_7}!Тебе {age_7} лет и ты живёшь в городе {city}.");

            //Задание 8
            Console.WriteLine();
            Console.WriteLine("Задание 8");
            Console.Write("Введите температуру цельсия: ");
            int temp_cel = int.Parse(Console.ReadLine());
            int temp_far = (temp_cel * 9 / 5) + 32;
            Console.WriteLine($"Температура: {temp_far}°F");
        }
    }
}