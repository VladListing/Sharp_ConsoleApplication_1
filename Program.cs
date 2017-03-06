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
                Console.WriteLine("В таком случае рекомендуем посмотреть вам следующие фильмы: ");
                Console.WriteLine("Фильм 1 ");
                Console.WriteLine("Фильм 2 ");
                Console.WriteLine("Фильм 3 ");
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
