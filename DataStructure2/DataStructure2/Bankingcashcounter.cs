using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    internal class Bankingcashcounter
    {
        Queue<int> List = new Queue<int>();
        public void bank()
        {
            int amount = 40000, deposit, withdraw;
            int choice, pin = 0, token = 1, k = 1;
            Console.WriteLine("Enter the number of people in Queue:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                List.Enqueue(token);
                token++;
            }
            while (k <= number)
            {
                Console.WriteLine("WELCOME TO YES BANK ATM SERVICE");
                Console.WriteLine("Now Serving Token No:" + k);
                Console.WriteLine("1. Current Balance");
                Console.WriteLine("2. Withdraw ");
                Console.WriteLine("3. Deposit ");
                Console.WriteLine("4. Cancel ");
                Console.WriteLine("***************");
                Console.WriteLine("ENTER YOUR CHOICE : ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your 4 Digit Pin:");
                pin = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("YOUR CURRENT BALANCE IS Rs : {0}", amount);
                        List.Dequeue();
                        break;
                    case 2:
                        Console.WriteLine("ENTER THE WITHDRAW AMOUNT :");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("PLEASE ENTER THE AMOUNT IN ABOVE 100");
                        }
                        else if (withdraw > (amount - 1000))
                        {
                            Console.WriteLine("SORRY! INSUFFICENT BALANCE");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("PLEASE COLLECT YOUR CASH");
                            Console.WriteLine("CURRENT BALANCE IS Rs : {0}", amount);
                            List.Dequeue();
                        }
                        break;
                    case 3:
                        Console.WriteLine("ENTER THE DEPOSIT AMOUNT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..");
                        Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}", amount);
                        List.Dequeue();
                        break;
                    case 4:
                        Console.WriteLine("THANK YOU");
                        break;
                }
                k++;
            }
            Console.WriteLine("\n THANKS FOR USING YES ATM SERVICE");
        }
    }
}