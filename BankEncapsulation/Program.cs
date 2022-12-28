namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var brandonsAccount = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            brandonsAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank You! Your balance is now {brandonsAccount.GetBalance()}");

        }
    }
}
