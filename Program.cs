/*
This tutorial demonstrated many of the techniques used in Object-Oriented programming:

You used Abstraction when you defined classes for each of the different account types. Those classes described the behavior for that type of account.
You used Encapsulation when you kept many details private in each class.
You used Inheritance when you leveraged the implementation already created in the BankAccount class to save code.
You used Polymorphism when you created virtual methods that derived classes could override to create specific behavior for that account type.

https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop
*/

using dotnet_console_bank_account_oop.Classes;
using static System.Console;

var account = new BankAccount("Steven Vidaurrazaga", 1000);
WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

//// Test that the initial balances must be positive.
//BankAccount invalidAccount;
//try
//{
//    invalidAccount = new BankAccount("invalid", -55);
//}
//catch (ArgumentOutOfRangeException e)
//{
//    WriteLine("Exception caught creating account with negative balance");
//    WriteLine(e.ToString());
//    return;
//}
account.MakeDeposit(3000, DateTime.Now, "Dotnet Work");
account.MakeWithdrawal(2000, DateTime.Now, "Rent");
account.MakeDeposit(1000, DateTime.Now, "Photography Work");
//// Test for a negative balance.
//try
//{
//    account.MakeWithdrawal(5, DateTime.Now, "Attempt to overdraw");
//}
//catch (InvalidOperationException e)
//{
//    WriteLine("Exception caught trying to overdraw");
//    WriteLine(e.ToString());
//}
WriteLine(account.GetAccountHistory());

var giftCard = new GiftCardAccount("gift card", 100, 50);
giftCard.MakeWithdrawal(20, DateTime.Now, "get expenseive coffee");
giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
giftCard.PerformMonthEndTransactions();
giftCard.MakeDeposit(27.50m, DateTime.Now, "deposit money for more spending");
WriteLine(giftCard.GetAccountHistory());

var savings = new InterestEarningAccount("savings account", 10000);
savings.MakeDeposit(750, DateTime.Now, "save some money");
savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
savings.PerformMonthEndTransactions();
WriteLine(savings.GetAccountHistory());

var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
// How much is too much to borrow?
lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
lineOfCredit.PerformMonthEndTransactions();
WriteLine(lineOfCredit.GetAccountHistory());