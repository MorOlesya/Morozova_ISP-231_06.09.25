using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            string anime = "D.Gray-man";
            int number = 0;
            float pi = 3.14f;
            char alf = 'w';
            Console.WriteLine(anime);
            Console.WriteLine(number);
            Console.WriteLine(pi);
            Console.WriteLine(alf);

            //Задание 2
            Console.WriteLine("I need more power!");
            Console.WriteLine("I need more power!");
            Console.WriteLine("I need more power!");
            Console.WriteLine("I need more power!");

            //Задание 3
            Console.WriteLine('"' + "Hello there" + '"');

            //Задание 4
            int cost_monitor = int.Parse(Console.ReadLine());
            int cost_systemBlock = int.Parse(Console.ReadLine());
            int cost_keybord = int.Parse(Console.ReadLine());
            int cost_mouse = int.Parse(Console.ReadLine());
            Console.WriteLine(3 * (cost_mouse + cost_systemBlock + cost_monitor + cost_keybord));

            //Задание 5
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result;
            result = 3 * ((a + b) ^ 3) + 275 * (b ^ 2) - 127 * a - 41;
            Console.WriteLine(result);

            //Задание 6
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Привет, {name}!");
            Console.WriteLine($"Сейчас тебе {age} лет.");
            Console.WriteLine($"В следующем году тебе будет {age + 1}.");

            //Задание 7
            string name1 = "Ray";
            int age1 = 15;
            string city = "Vol";
            Console.WriteLine($"Привет, {name1}!Тебе {age1} лет и ты живёшь в городе {city}.");

            //Задание 8
            Console.Write("Введите температуру цельсия: ");
            int temp_cel = int.Parse(Console.ReadLine());
            int temp_far = (temp_cel * 9 / 5) + 32;
            Console.WriteLine($"Температура: {temp_far}");
        }
    }
}