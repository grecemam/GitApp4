using System.ComponentModel;
using System.ComponentModel.Design;

namespace Практическая__4__ежедневник_
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {


                List<YaUstala> myZametki = MakeZametki();
                DateTime date = DateTime.Now;
                int position = 1;
                ConsoleKeyInfo key = Console.ReadKey();
                while (key.Key != ConsoleKey.Enter)
                {

                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                    }
                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        date = data(date, 1);
                    }
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        date = data(date, -1);
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Environment.Exit(0);
                    }

                    Console.Clear();
                    List<YaUstala> sortedZam = myZametki.Where(yaUstala => yaUstala.Date.Date == date.Date).ToList();
                    Menu(date, sortedZam);
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("=>");

                    key = Console.ReadKey();
                }
                Console.Clear();
                List<YaUstala> sZam = myZametki.Where(yaUstala => yaUstala.Date.Date == date.Date).ToList();
                Console.WriteLine(sZam[position - 1].Description);
                if (key.Key == ConsoleKey.Tab)
                {
                    break;
                }
            }
        }

        static void Menu(DateTime selectedDAte, List<YaUstala> zametki)
        {
            Console.WriteLine("Выбрана дата: " + selectedDAte);
            foreach (YaUstala yaUstala in zametki)
            {
                Console.WriteLine("  " + yaUstala.Name);
            }
        }

        static DateTime data(DateTime dateTime, int add)
        {
            return dateTime.AddDays(add);
        }

        static List<YaUstala> MakeZametki()
        {
            YaUstala zam1 = new YaUstala();
            zam1.Name = "Пойти на пары";
            zam1.Description = "Название:\n" +
                "Пойти на пары\n" +
                "-----------\n" +
                "Описание:\n" +
                "Не забыть поесть перед выходом\n" +
                "-----------\n" +
                "Дата:\n" +
                "18.10.2022";
            zam1.Date = new DateTime(2022, 10, 18);

            YaUstala zam2 = new YaUstala();
            zam2.Name = "Посмотреть тик ток";
            zam2.Description = "Название:\n" +
                "Посмотреть тик ток\n" +
                "-----------\n" +
                "Описание:\n" +
                "Разбаньте тик ток\n" +
                "-----------\n" +
                "Дата:\n" +
                "19.10.2022";
            zam2.Date = new DateTime(2022, 10, 19);

            YaUstala zam3 = new YaUstala();
            zam3.Name = "Сходить в магазин";
            zam3.Description = "Название:\n" +
                "Сходить в магазин\n" +
                "-----------\n" +
                "Описание:\n" +
                "Купить пельмени\n" +
                "-----------\n" +
                "Дата:\n" +
                "20.10.2022";
            zam3.Date = new DateTime(2022, 10, 20);

            YaUstala zam4 = new YaUstala();
            zam4.Name = "Посмотреть мх";
            zam4.Description = "Название:\n" +
                "Посмотреть мх\n" +
                "-----------\n" +
                "Описание:\n" +
                "Словить лютый кринж\n" +
                "-----------\n" +
                "Дата:\n" +
                "21.10.2022";
            zam4.Date = new DateTime(2022, 10, 21);

            YaUstala zam5 = new YaUstala();
            zam5.Name = "выгулить собаку";
            zam5.Description = "Название:\n" +
                "Выгулить собаку\n" +
                "-----------\n" +
                "Описание:\n" +
                "Не забыть покурить\n" +
                "-----------\n" +
                "Дата:\n" +
                "21.10.2022";
            zam5.Date = new DateTime(2022, 10, 21);


            List<YaUstala> list = new List<YaUstala>();
            list.Add(zam1);
            list.Add(zam2);
            list.Add(zam3);
            list.Add(zam4);
            list.Add(zam5);

            return list;
        }
    }
}
