using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{
		}

        //Create a private field of type double named balance with a value of 0
        private double balance = 0;


        //Define a method named Deposit that will accept a double and store that value in the balance field
        public void Deposit(double amount)
		{
			balance = amount;
		}

        //Define a method named GetBalance that will return the amount stored in the balance field
        public string GetBalance()
		{
			return $"${balance}";
		}
	}
}

