using System.Numerics;

internal class Program
{
    static void Main()
    {
        /* //geometric progression

         int currentNumber = 2;

         for (int i = 0; i < 20; i++)
         {
             Console.WriteLine(currentNumber);
             currentNumber *= 2;
         }
         */

        /*//pow sequence

        BigInteger currentNumber = 2; //ulong маловат для ожидаемых чисел

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(currentNumber);
            currentNumber *= currentNumber;
        }*/



        /* //sum of sequence numbers

         Console.Write("Enter number: "); int user_number = Convert.ToInt32(Console.ReadLine());

         int sum = 0;

         for (int i = 0; i <= user_number; i++)
             sum += i;

         Console.WriteLine($"Sum of all numbers in {user_number}: {sum}");*/





        /*//Pow function, using FOR

        Console.Write("Enter your number: "); double user_number = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter degree: "); int user_degree = Convert.ToInt32(Console.ReadLine());

        double result = 1;

        if (user_number == 0)
            result = 0;
        else if (user_degree == 0)
            result = 1;

        int positiveDeggree = Math.Abs(user_degree); // отрицательная степень вычисляется так же как и обычная,
                                                     //только в конце 1 делим на результат
        for (int i = 0; i < positiveDeggree; i++)
            result *= user_number;

        if (user_degree < 0)
            result = 1 / result;


        Console.WriteLine($"Result: {result}"); // double хранит как целые так и дробные числа,
                                                // если число целое (2 в степени 3 = 8) его выведет как целое (8)
                                                // если дробное (2 в степени -3 = 0,125) - выведет дробью (0.125)*/




        /*// from A to Z

        *//*Console.OutputEncoding = System.Text.Encoding.UTF8;

        for (int i = 65; i <= 90; i++) // unicode A = 65 ... Z = 90
            Console.Write($"{(char)i}, ");*//*

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        for (int i = 'A'; i <= 'Z'; i++) // ez
            Console.Write($"{(char)i}, ");*/




        // amoun of digits in number and reverse 

        Console.Write("Enter number: "); int user_number = Convert.ToInt32(Console.ReadLine());

        int counter = 0, reversedNumber = 0;

        int user_numberModulus = Math.Abs(user_number); // на случай если число отрицательное

        int modulusForReverse = user_numberModulus; //поскольку не используем методы, нужно зарезервировать число

        if (user_numberModulus == 0)
            Console.WriteLine($"Result: {counter = 1}");
        else
        {
            for (; user_numberModulus > 0; user_numberModulus /= 10) //двигаем запятую
                counter++;
            Console.WriteLine($"Result: {counter}");
        }
        
        // реверсируем число

        for (; modulusForReverse > 0; modulusForReverse /= 10 )
        {
            int lastDigit = modulusForReverse % 10;  //123 / 10 = 12,3 <- 0,3 будет записано как 3
            reversedNumber = reversedNumber * 10 + lastDigit; // 0 * 10 + 3 = 3; 3 * 10 + 2 = 32; 32 * 10 + 1 = 321
        }

        if (user_number < 0)
            reversedNumber = -reversedNumber;

        Console.WriteLine($"Reversed number: {reversedNumber}");
    }
}



