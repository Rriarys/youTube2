using System.ComponentModel.DataAnnotations;

internal class Program
{
    static void Main()
    {
        /* Console.Write("Enter positive number: "); int user_num = Convert.ToInt32(Console.ReadLine());

         int num = 0;

         if (user_num > 0)
         {
             while (num <= user_num)
             {
                 Console.Write($"\n{num} ");
                 num++;
             }    
         }
         else
         {
             Console.WriteLine("Incorect number, try another\n");
             Console.Write("Enter positive number: "); user_num = Convert.ToInt32(Console.ReadLine());

             while (num <= user_num)
             {
                 Console.Write($"\n{num} ");
                 num++;
             }
         }*/






        /*//RANGE

        Console.Write("Enter start number: "); int start_num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter end number: "); int end_num = Convert.ToInt32(Console.ReadLine());

        if (start_num < end_num)
        {
            while (start_num <= end_num)
            {
                Console.Write($"{start_num} ");
                start_num++;
            }
        }
        else if (end_num < start_num)
        {
            while (end_num <= start_num)
            {
                Console.Write($"{end_num} ");
                end_num++;
            }
        }
        else
        {
            Console.WriteLine("0");
        }*/




        /*  //same, but with Math.

          Console.Write("Enter start number: "); int start_num = Convert.ToInt32(Console.ReadLine());
          Console.Write("Enter end number: "); int end_num = Convert.ToInt32(Console.ReadLine());

          int min = Math.Min(start_num, end_num), max = Math.Max(start_num, end_num);

          if (min == max)
              Console.WriteLine("0");
          else
          {
              while (min <= max)
              {
                  Console.Write($"{min} ");
                  min++;
              }
          }*/






        /*//GUESS MY NUMBER

        const int PC_NUMBER = 27;
        int attemptsCount = 0;

        Console.WriteLine("Guess my number?\n");

        Console.Write("Your number is :"); int user_number = Convert.ToInt32(Console.ReadLine());

        while (user_number != PC_NUMBER)
        {
            Console.WriteLine("------------\nTry again\n");
            attemptsCount++;

            Console.Write("Your number is :"); user_number = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"\nYou win! Count of Attempts: {attemptsCount}");*/






        /* //same, but with advices

         const int PC_NUMBER = 27;
         int attemptsCount = 0;

         Console.WriteLine("Guess my number?\n");

         Console.Write("Your number is :"); int user_number = Convert.ToInt32(Console.ReadLine());

         while (user_number != PC_NUMBER)
         {
             if (user_number > PC_NUMBER)
             {
                 Console.WriteLine("\nI guessed a lower number\n-------------\n");
                 attemptsCount++;

                 Console.Write("Your number is :"); user_number = Convert.ToInt32(Console.ReadLine());
             }
             else if (user_number < PC_NUMBER)
             {
                 Console.WriteLine("\nI guessed a higher number\n-------------\n");
                 attemptsCount++;

                 Console.Write("Your number is :"); user_number = Convert.ToInt32(Console.ReadLine());
             }
         }

         Console.WriteLine($"\nYou win! Count of Attempts: {attemptsCount}");*/

        /*//BANK DEPOSIT, NO ANNUAL CAPITALIZATION

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int interestRate = 5;

        Console.WriteLine("---------BANK DEPOSIT---------\n");

        Console.Write("Deposit amount: "); decimal user_deposit = Convert.ToDecimal(Console.ReadLine());

        Console.Write("\nNumber of years for deposit: "); int user_years = Convert.ToInt32(Console.ReadLine());

        decimal accountBalance = user_deposit * (1 + (interestRate * user_years) / 100m); //'m' в конце, иначе при целочисленном делении отбрасывается дробная часть

        Console.WriteLine($"\n--> Expected amount from {user_deposit:c3} after {user_years} years: {accountBalance:c3}");*/



        /*//same, but WITH ANNUAL CAPITALIZATION and annual report

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int interestRate = 5, yearCounter = 1;

        Console.WriteLine("---------BANK DEPOSIT---------\n");

        Console.Write("Deposit amount: "); decimal user_deposit = Convert.ToDecimal(Console.ReadLine());

        Console.Write("\nNumber of years for deposit: "); int user_years = Convert.ToInt32(Console.ReadLine());

        decimal accountBalance = user_deposit;

        Console.WriteLine("\n------------------------------\nYearly results:\n");

        while (yearCounter <= user_years)
        {
            accountBalance += accountBalance * (interestRate / 100m); //'m' в конце, иначе при целочисленном делении отбрасывается дробная часть

            Console.WriteLine($"After {yearCounter} year: {accountBalance:c3}");

            yearCounter++;
        }

        Console.WriteLine($"\n--> Expected amount from {user_deposit:c3} after {user_years} years: {accountBalance:c3}");*/


        //Разность конечных доходов (в последних двух программах) обусловлена тем что в первом варианте отсутствует ежегодная капитализация, доход каждый год будет стабильным и не изменным.
        //Во втором варианте есть ежегодная капитализация (процент берется заново каждый год от суммы на балансе), отсюда конечная сумма выходит больше, при больших сроках вклада.
    }
}
