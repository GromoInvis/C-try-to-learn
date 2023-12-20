using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Масив з рандомним заповненням
            Console.WriteLine("\t\t\t\t Клас 1");
            int[,] myarray = new int[5, 10]; // Створення двувимірного масиву
            Random random = new Random(); // Імпорт рандому
            int height = myarray.GetLength(0);  // висота
            int width = myarray.GetLength(1);	// ширина
            double bbb = 0;
            double bbbb = 0;
            double bbbbb = 0;
            for (int i = 0; i < height; i++) // перебираємо по висоті
            
            {
                
                double mid = 0;
                double m = 0;
                
                for (int j = 0; j < width; j++) // перебираємо по ширині
                {
                    myarray[i, j] = random.Next(1, 12); //дає кожному елементу масиву випадкове число від 1 до 12
                    Console.Write(myarray[i, j] + "\t"); //вивід масиву
                    mid += myarray[i, j];
                }
                m = mid / 10;
                if (m > bbb)
                {
                    bbb = m;
                }
                
                
                Console.WriteLine("Середня оцiнка - " + m);

                Console.WriteLine(); //треба
            }
            Console.WriteLine("Найбiльша середня оцiнка цього класу - " +bbb);
            Console.WriteLine("\t\t\t\t Клас 2");
            for (int i = 0; i < height; i++) // перебираємо по висоті

            {

                double mid = 0;
                double m = 0;

                for (int j = 0; j < width; j++) // перебираємо по ширині
                {
                    myarray[i, j] = random.Next(1, 12); //дає кожному елементу масиву випадкове число від 1 до 12
                    Console.Write(myarray[i, j] + "\t"); //вивід масиву
                    mid += myarray[i, j];
                }
                m = mid / 10;
                if (m > bbbb)
                {
                    bbbb = m;
                }


                Console.WriteLine("Середня оцiнка - " + m);

                Console.WriteLine(); //треба
                
            }
            Console.WriteLine("Найбiльша середня оцiнка цього класу - " + bbbb);
            Console.WriteLine("\t\t\t\t Клас 3");
            for (int i = 0; i < height; i++) // перебираємо по висоті

            {

                double mid = 0;
                double m = 0;

                for (int j = 0; j < width; j++) // перебираємо по ширині
                {
                    myarray[i, j] = random.Next(1, 12); //дає кожному елементу масиву випадкове число від 1 до 12
                    Console.Write(myarray[i, j] + "\t"); //вивід масиву
                    mid += myarray[i, j];
                }
                m = mid / 10;
                if (m > bbbbb)
                {
                    bbbbb = m;
                }


                Console.WriteLine("Середня оцiнка - " + m);

                Console.WriteLine(); //треба

            }
            Console.WriteLine("Найбiльша середня оцiнка цього класу - " + bbbbb);
            double best = bbb;
            if (bbbb > best)
            {
                best = bbbb;
            }
            if (bbbbb > best)
            {
                best = bbbbb;
            }
            Console.WriteLine("Найкращий результат серед класiв - " + best);
            Console.ReadLine();

        }
    }
}
