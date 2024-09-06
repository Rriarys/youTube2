using System.Threading.Channels;

internal class Program
{
    static void Main()
    {
        /*//multiplication table

        for (int i = 1; i <= 9; i++) 
        { 
            Console.WriteLine();

            for (int j = 1; j <= 9; j++)
                Console.WriteLine($"{i} * {j} = {i * j}"); //поочередно каждое число переумножаем от 1 до 9
        }*/




        /*//make figure with parameters

        Console.Write("Height in characters: "); int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Width in characters: ");  int columns = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write type of character: "); char user_character  = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine();

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= columns; j++)
            { 
                Console.Write($"{user_character}");
            }

            Console.WriteLine();
        }*/



        /*//triangle

        Console.Write("Enter height of triangle: "); int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 0; j < i; j++) //номер строки ограничивает количесво звезд
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }*/





        /*//rombus

        while (true)
        
        {Console.Write("Enter height of rombus (3 and more): "); int user_rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        int half_rows = user_rows / 2; //разбиваем ромб пополам, если 5 => будет по 2 на каждую сторону

        for (int i = 1; i <= half_rows + 1; i++) //верх + 1 (центр будет рассчитан в верхней), начинаем не с 0, 
                                                 //чтобы не получить пустую строку в первом ряду
        {
            for (int j = i; j <= half_rows; j++) //пробелы, сравниваются с половиной, на последней строке нет отступов
            {
                Console.Write(' ');
            }

            for (int k = 1; k <= (2 * i - 1); k++) //звезды, должна быть хоть 1 звезда; 
            {                                      //каждую центральную обрамляет 2 дополнительные звезды
                                                   //  x     1 позиция -> всегда 1
                Console.Write("*");                // xxx  (x) 2 позиция 2 * 2 -> 4, должно получатся нечетное число, чтобы сохранить центрирование по вертикальной оси
                                                   //xxxxx (x) 3 позиция 3 * 2 -> 6, прослеживается закономерность
            }

            Console.WriteLine();
        }

            for (int i = half_rows; i >= 1; i--) //тоже самое, только точка отсчета это середина
            {
                for (int j = half_rows; j >= i; j--)
                {
                    Console.Write(' ');
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }*/















    }
}

