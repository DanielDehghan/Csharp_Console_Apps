using System;

namespace ATM_ConsoleApp
{
    public class cardHolder
    {
        public string cardNum;
        public  int pin;
        public string firstName;
        public string lastName;
        public double balance;

             public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
                    {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
                 }


             public string getNum()
             {

                 return cardNum;
             }

             public int getPin()
             {

                 return pin;
             }

             public string getFirstName()
             {

                 return firstName;
             }

             public string getLastName()
             {

                 return lastName;
             }

             public double getBalance()
             {
                 return balance;
             }


             public void setNum( string newCardNum)
             {

                 newCardNum = cardNum;
             }

             public void setPin( int newPin)
             {

                 newPin = pin;
             }

             public void setFirstName( string newFirstName)
             {

                 newFirstName = firstName;
             }

             public void setLastName(string newLastName)
             {

                 newLastName = lastName;    
             }

             public void setBalance(double newBalance)
             {
                 newBalance = balance;
             }



             public double withdraw2(double amount)
             {


                 var res = balance - amount;
                 return res;

             }

    }
}