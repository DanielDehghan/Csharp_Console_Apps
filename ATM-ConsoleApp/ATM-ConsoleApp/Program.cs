using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM_ConsoleApp
{
    public class Program
    {

        static void Main(string[] args)
        {
            cardHolder holder ;
     

            void printOption()
            {
                Console.WriteLine("Please choose from one of the following options...");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. show Balance");
                Console.WriteLine("4. Exit");

            }


            void deposit(cardHolder currentUser)
            {

                Console.WriteLine("How much $$ would you like to deposit?");
                double deposit1 = double.Parse(Console.ReadLine());

                var current = currentUser.getBalance();
                var newBalance = current + deposit1;
                var newBal = currentUser.balance = newBalance;
                currentUser.setBalance(newBal);

                Console.WriteLine("Thank you  for your  $$ . Your new blanace is: "+ currentUser.getBalance());

            }

            void withdraw(cardHolder currentUser)
            {

                Console.WriteLine("How much $$ would you like to withdraw?");
                double withdrawl = double.Parse(Console.ReadLine());
                // check if user has enough money

                if (currentUser.getBalance() < withdrawl)
                {
                    Console.WriteLine("Insufficient Balance! :( ");
                }
                else
                {
                    var current = currentUser.getBalance();
                    var newBalance = current - withdrawl;
                   var newBal= currentUser.balance = newBalance;
                    currentUser.setBalance(newBal);
                    currentUser.getBalance();
                    Console.WriteLine("You're Good to go Thank you!");

                }
            }

            void balance(cardHolder currentUser)
            {
                Console.WriteLine("Current balance: " + currentUser.getBalance());

            }

            // havingour fake database
            List<cardHolder> cardHolders = new List<cardHolder>();
            cardHolders.Add(new cardHolder("45820382738023679",1234,"John", "Griffith", 150.31));
            cardHolders.Add(new cardHolder("87457490815533994",4321,"Ashley", "Jones", 321.13));
            cardHolders.Add(new cardHolder("19230475109434859",9999,"Frida", "Dickerson", 105.59));
            cardHolders.Add(new cardHolder("02476016455821010",2468,"Muneeb", "Harding", 851.84));
            cardHolders.Add(new cardHolder("92615365238200621",4826,"Dawn", "Smith", 54.27));

           
            // Starting the APP
            //Prompt User
            Console.WriteLine("Welcome to SimpleATM!");
            Console.WriteLine("Please Insert Your Debit Card: ");
            string debitCardNum = "";

            cardHolder currentUser1;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    //check against our Db
                    // this FirstOrDefault() method goes through objects
                    // and look for a match that can satisfy the condition inside the peranthesis
                    currentUser1 = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                    if (currentUser1 != null)
                    {

                        break;
                    }else
                    {
                        Console.WriteLine("Card Not recognized. Please try again");
                    }
                }
                catch
                {
                    Console.WriteLine("Card Not recognized. Please try again");

                }
            }

            Console.WriteLine("Please Enter your pin: ");
            int userPin = 0;


            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());

                    // so here we already have current user we don't have to search anymore with FirstOrDefault

                    if (currentUser1.getPin() == userPin)
                    {

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Pin!  Please Try again");
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect Pin! Please Try again");

                }

            }

            Console.WriteLine("Welcome " + currentUser1.getFirstName()+ " :)");
                int option = 0;

                do
                {

                    printOption();
                    try
                    {
                        option = int.Parse(Console.ReadLine());
                    }
                    catch 
                    {

                    }

                    if (option == 1)
                    {
                        deposit(currentUser1);
                    }
                    else if (option == 2)
                    {
                        withdraw(currentUser1);
                    }
                    else if (option == 3)
                    {
                        balance(currentUser1);
                    }
                    else if(option == 4)
                    {
                        // so it should be 4 to exit
                        break;

                    }
                    else
                    {
                        option = 0;
                    }


                } while (option != 4);
            
        }
    }
}
