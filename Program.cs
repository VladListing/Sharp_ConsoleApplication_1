using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_ConsoleApplication_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа поможет вам выбрать фильм для вечернего просмотра");
            Console.WriteLine("Назовите ваше имя:");
            string name = Console.ReadLine();
            string text = "Здравствуй," + name;

            Console.WriteLine(text);

            Console.WriteLine("Фильм какого жанра вы бы хотели посмотреть : комедия , драма , фантастика, эротика");
            String genre = Console.ReadLine();



            if (genre == "комедия")
            {
                Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет текста
                //Console.BackgroundColor = ConsoleColor.White; // устанавливаем цвет фона для текста
                Console.WriteLine("В таком случае рекомендуем посмотреть вам следующие фильмы: ");
                Console.WriteLine("Фильм 1 ");
                Console.WriteLine("Фильм 2 ");
                Console.WriteLine("Фильм 3 ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Зеленый цвет текста");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Темно серый цвет текста");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Темно желтый цвет текста");
                Console.ResetColor();//Сброс цвет текста
                Console.WriteLine("Обычный цвет текста");


                Console.ResetColor(); // сбрасываем цвет в стандартный


                Console.WriteLine("Значение 123456 в разных форматах:");
                Console.WriteLine("d7: {0:d9}", 123456);//десятичный с нулями перед числом
                Console.WriteLine("d7: {0:d7}", 123456);//десятичный с нулями перед числом
                Console.WriteLine("d7: {0:d3}", 123456);//десятичный с нулями перед числом
                Console.WriteLine("d7: {0:D9}", 123456);//десятичный с нулями перед числом
                Console.WriteLine("d7: {0:D7}", 123456);//десятичный с нулями перед числом
                Console.WriteLine("d7: {0:D3}", 123456);//десятичный с нулями перед числом
                Console.WriteLine("C: {0:C}", 123456); //денежный
                Console.WriteLine("n: {0:n}", 123456); //базовое числовое форматирование (с запятыми)
                Console.WriteLine("f3: {0:f3}", 123456);//Число с фоксированной точкой
                Console.WriteLine("X: {0:X}", 123456);//Число в шеснадцатеричном представлении из десятичного
                //Console.WriteLine("d: {0:d}", 1E+240);//Число из шеснадцатеричного представления в десятичное  // НЕ РАБОТАЕТ :)

            }

            else if (genre == "драма")
            {
                Console.WriteLine("В таком случае рекомендуем посмотреть вам следующие фильмы: ");
                Console.WriteLine("Фильм 4 ");
                Console.WriteLine("Фильм 5 ");
                Console.WriteLine("Фильм 6 ");
            }

            else if (genre == "фантастика")
            {
                Console.WriteLine("В таком случае рекомендуем посмотреть вам следующие фильмы: ");
                Console.WriteLine("Фильм 7 ");
                Console.WriteLine("Фильм 8 ");
                Console.WriteLine("Фильм 9 ");
            }
            else if (genre == "эротика")
            {

                Console.WriteLine("Сколько вам лет ?");
                String yearsString = Console.ReadLine();
                int years = Int32.Parse(yearsString); //преобразование типа
                if (years < 18)
                {
                    Console.WriteLine("Эти фильмы достипны только для достигших возраста 18 лет");
                    Console.WriteLine("Приходите через " + (18 - years) + "  лет");
                }
                else if (years > 18)
                {
                    Console.WriteLine("Фильм 10 ");
                    Console.WriteLine("Фильм 11 ");
                    Console.WriteLine("Фильм 12 ");
                }
            }



            Console.ReadLine();
        }
    }
}
