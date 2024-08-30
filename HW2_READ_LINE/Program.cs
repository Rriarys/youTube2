internal class Program
{
    static void Main()
    {
        // --------------loggin & pass validation----------------------

        /*const string VALID_LOGG = "admin", VALID_PASS = "12345";

        Console.Write("Введите логин: "); string? userLogg = Console.ReadLine();
        // ? также может быть и null, чтобы компилятор не ругался

        Console.Write("Введите пароль: "); string? userPass = Console.ReadLine();


        if (userLogg == VALID_LOGG && userPass == VALID_PASS)
            Console.WriteLine("Вы вошли в систему!");

        else if (userLogg != VALID_LOGG)
            Console.WriteLine("Логин не верный.");

        else Console.WriteLine("Пароль не верный.");*/

        // --------------same, but one error message for all situations------------------

        /*const string VALID_LOGG = "admin", VALID_PASS = "12345";

        Console.Write("Введите логин: "); string? userLogg = Console.ReadLine();
        // ? также может быть и null, чтобы компилятор не ругался

        Console.Write("Введите пароль: "); string? userPass = Console.ReadLine();

        if (userLogg != VALID_LOGG || userPass != VALID_PASS)
            Console.WriteLine("Неверный логин или пароль!");

        else Console.WriteLine("Вы вошли в систему!");*/

        //same, but add registration

        // ? также может быть и null, чтобы компилятор не ругался

        /*Console.WriteLine("\n-----------------Регистрация-----------\n");

        Console.Write("Задайте логин:"); string? regLogg = Console.ReadLine();

        Console.Write("Задайте пароль:"); string? regPass = Console.ReadLine();

        Console.WriteLine("\n-----------------Вход------------------\n");

        Console.Write("Введите логин: "); string? userLogg = Console.ReadLine();

        Console.Write("Введите пароль: "); string? userPass = Console.ReadLine();

        if (userLogg != regLogg || userPass != regPass)
            Console.WriteLine("Неверный логин или пароль!");

        else Console.WriteLine("\nВы вошли в систему!");*/

        // simple game menu

        /*Console.WriteLine("---------MENU---------");

        Console.WriteLine("""

            1 - Start new game
            2 - Load game
            3 - Options
            4 - Credits
            5 - Exit

            """);

        Console.WriteLine("----------------------\n");

        Console.Write("Write number of option: "); int? userChoice = int.Parse(Console.ReadLine());

        Console.WriteLine("\n----------------------\n");

        switch (userChoice)
        {
            case 1:
                Console.WriteLine("New game is started");
                break;

            case 2:
                Console.WriteLine("Game is loaded");
                break;

            case 3:
                Console.WriteLine("There is no options :(");
                break;

            case 4:
                Console.WriteLine("Author of this game Rriarys");
                break;

            case 5:
                Console.WriteLine("Game is closing");
                break;

            default: Console.WriteLine("Incorrect number");
                break;
        }*/


    }
}

