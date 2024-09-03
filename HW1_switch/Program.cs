internal class Program
{
    static void Main()
    {
        /* Character move control */


        /* 
         int direction = 2;

         const int UP = 1, RIGHT = 2, DOWN = 3, LEFT = 4;

         const int UP = 1, RIGHT = 2, DOWN = 3, LEFT = 4;

         switch (direction)
         {
             case UP:
                 Console.WriteLine("UP");
                 break;

             case RIGHT:
                 Console.WriteLine("RIGHT");
                 break;

             case DOWN:
                 Console.WriteLine("DOWN");
                 break;

             case LEFT:
                 Console.WriteLine("LEFT");
                 break;

             default:
                 Console.WriteLine("ERROR");
                 break;
         }
         */


        /* Character move coordinates */

        /*
        int x = 0, y = -7;

        switch (x, y)
        {
            case (10, 20):
                Console.WriteLine("Character in the Blacklight city.");
                break;

            case (-25, 10):
                Console.WriteLine("Character in the forest.");
                break;

            case (-50, 3):
                Console.WriteLine("Character in the Racoon city.");
                break;

            case (70, 65):
                Console.WriteLine("Character in the cave.");
                break;

            default:
                Console.WriteLine("Character lost in Nirn");
                break;
        }
        */

        int age = -12;

        switch (age)
        {
            case > 0 and < 18:
                Console.WriteLine("Kid");
                break;

            case > 18 and < 60:
                Console.WriteLine("Adult");
                break;

            case > 60 and < 120:
                Console.WriteLine("Old");
                break;

            case > 120:
                Console.WriteLine("Very old");
                break;

            default:
                Console.WriteLine("Incorrect value");
                break;
        }
    }
}

