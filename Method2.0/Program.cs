using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Method
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите любую букву");
            string z = Console.ReadLine();
            string bao = Menu(z);
        }
        static string Menu(string z)
        {
            Console.WriteLine("Выберите ту операцию, которую хотите сделать. Для ее выбора вам нужно ввести ее первое слово. На данный момент программа вам может предоставить три операции на выбор:\n 1: Угадайка. Игра, где вы должны угадать какое-то число от одного до ста. Программа будет подсказывать вам по типу холодно-горячо \n 2: ТУМ Таблица умножения. В общем-то покажет вам таблицу умножения в виде таблицы \n 3: Деление Вывод делителей числа\nПользователь вводит число в консоль. Алгоритм должен найти _все_ числа, которые делят это число на цело, без остатка \n 4: если хотите выйти, напишите выйти");
            string q = Console.ReadLine();
            while (q != "выйти")
            {
                if (q == "Угадайка")
                {
                    string number = Ugadaika(q);
                }
                if (q == "ТУМ")
                {
                    string number = TUM(q);
                }
                if (q == "Деление")
                {
                    string number = delenie(q);
                }
                if (q == "выйти")
                {
                    Console.WriteLine("Программа завершена");
                    return "nothing";
                }
                else
                {
                    Console.WriteLine("Вы сделали ошибку, программа была завершена");
                    return "Конец программы";
                }
                string a = Console.ReadLine();
            }
            if (q == "df")
            {
                return "sd";
            }
            else
            {
                return "nm";
            }
        }
        static string Ugadaika(string game)
        {
            Random rnd = new Random();
            int secret = rnd.Next(1, 101);
            int num_vvod = 0;
            string so = "so";
            while (secret != num_vvod)
            {
                Console.Write("Введите какое-либо число: ");
                num_vvod = Convert.ToInt32(Console.ReadLine());
                if (num_vvod > secret)
                {
                    Console.WriteLine("Меньше надо");
                }
                if (num_vvod < secret)
                {
                    Console.WriteLine("Надо больше");
                }
            }
            Console.WriteLine("Верно!");
            string back = Menu(so);
            if (num_vvod == secret)
            {
                return "ev";
            }
            else
            {
                return "fknv";
            }
        }
        static string TUM(string table)
        {
            string so = "so";
            int[,] tu = new int[10, 10]
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
            };
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tu[i, j] = i * j;
                }
            }
            for (int ryad = 0; ryad < tu.GetLength(0); ryad++)
            {
                for (int mesto = 0; mesto < tu.GetLength(1); mesto++)
                {
                    Console.Write(tu[ryad, mesto] + "\t");
                }
                Console.WriteLine();
            }
            string back = Menu(so);
            int fg = 10;
            if (fg == 10)
            {
                return "eeee";
            }
            else
            {
                return "jn";
            }
        }
        static string delenie(string del)
        {
            Console.WriteLine("Введите какое-либо число. Если вам надо выйти, то так и напишите");
            string buk = "Abilyss";
            while (buk != "выход")
            {
                string bik = Console.ReadLine();
                if (bik == "выйти")
                {
                    buk = "выход";
                    string so = "so";
                    string back = Menu(so);
                }
                else
                {
                    int x = Convert.ToInt32(bik);
                    for (int i = 1; i < x; i++)
                    {
                        int per = x % i;
                        if (per == 0)
                        {
                            Console.WriteLine("числа, на которые делит: " + i);
                        }
                    }
                }
            }
            return "vrhfbjenkmcd";
        }
    }
}