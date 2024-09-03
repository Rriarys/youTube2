internal class Program
{
    static void Main()
    {
        /* //even\odd, escape, summ

         int even = 0, odd = 0, number;

         do
         {
             Console.Write("Even or odd: "); number = Convert.ToInt32(Console.ReadLine());

             if (number % 2 == 0)
             {
                 Console.WriteLine($"\n{number} is EVEN number\n");
                 even++;
             }
             else
             {
                 Console.WriteLine($"\n{number} is ODD number\n");
                 odd++;
             }

         } while (number != 0);

         Console.WriteLine($"\nSumm of even numbers: {even}.\nSum of odd numbers: {odd}.");*/


        /*// CHARACTER MOVE

        int move_direction;

        do
        {
            Console.WriteLine("""
                -----MOVE MENU-----
                
                1 - Move UP
                2 - Move RIGHT
                3 - Move DOWN
                4 - Move LEFT
                0 - END GAME

                """);

            Console.Write("Choose number of move direction: "); move_direction = Convert.ToInt32(Console.ReadLine());

            switch (move_direction)
            {
                case 1:
                    Console.WriteLine("\nUP");
                    break;

                case 2:
                    Console.WriteLine("\nRIGHT");
                    break;

                case 3:
                    Console.WriteLine("\nDOWN");
                    break;

                case 4:
                    Console.WriteLine("\nLEFT");
                    break;

                 case 0:
                    Console.WriteLine("\nEND GAME\n"); // то же число что и для прерывания цикла, для вывода текста об конце игры
                    break;
            }
        } while (move_direction != 0);*/




        /*// CHARACTER MOVE + COORDINATES (x,y) + BUILDINGS

        int move_direction, x_coordinate = 3, y_coordinate = 3;

        Console.WriteLine("""
                                  MAP
                          6
                          ^
                          | ШШШ
                          | ШШШ       
                          |           СС
                          |        I  СС
                          | ЦЦ        СС
                          | ЦЦ
                          0------------------> 6
                          """); // Типо карта. I - герой, в центре (3,3).
                                // Ш - школа (1,6) - (3,6) && (1,5) - (3,5)
                                // Ц - церковь (1,2) - (2,2) && (1,1) - (2,1)
                                // С - склад (4,4) - (5,4) && (4,2) - (5,2)

        do
        {
            Console.WriteLine($"\nYour start coordinates --> ({x_coordinate},{y_coordinate})\n");

            if (  (1 <= x_coordinate && x_coordinate  <= 3) && y_coordinate == 6 || (1 <= x_coordinate && x_coordinate <= 3) && y_coordinate == 5 )
                Console.WriteLine("""

                        -------------------
                    --> |You in the SCHOOL| <--
                        -------------------

                    """);
            else if ( (1 <= x_coordinate && x_coordinate <= 2) && y_coordinate == 2 || (1 <= x_coordinate && x_coordinate <= 2) && y_coordinate == 1 )
                Console.WriteLine("""

                        -------------------
                    --> |You in the CHURCH| <--
                        -------------------

                    """);
            else if ( (2 <= y_coordinate && y_coordinate <= 4) && x_coordinate == 4 || (2 <= y_coordinate && y_coordinate <= 4) && x_coordinate == 5 )
                Console.WriteLine("""

                         -------------------
                    --> |You in the WAREHOUSE| <--
                         -------------------

                    """);
            else
                Console.WriteLine("--> | CLEAR SKY above you | < --\n");

            Console.WriteLine("""
                -----MOVE MENU-----
                
                1 - Move UP
                2 - Move RIGHT
                3 - Move DOWN
                4 - Move LEFT
                0 - END GAME

                """);

            Console.Write("Choose number of move direction: "); move_direction = Convert.ToInt32(Console.ReadLine());

            switch (move_direction)
            {
                case 1:
                    y_coordinate++;
                    Console.WriteLine("\nYou go UP"); 
                    break;
                case 2:
                    x_coordinate++;
                    Console.WriteLine("\nYou go RIGHT");
                    break;
                case 3:
                    y_coordinate--;
                    Console.WriteLine("\nYou go DOWN");
                    break;
                case 4:
                    x_coordinate--;
                    Console.WriteLine("\nYou go LEFT");
                    break;
                case 0:
                    Console.WriteLine("\nEND GAME\n"); // то же число что и для прерывания цикла, для вывода текста об конце игры
                    break;
            }
        } while (move_direction != 0);*/

    }
}

