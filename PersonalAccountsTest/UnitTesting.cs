using Microsoft.VisualStudio.TestTools.UnitTesting;
using KoalaBankApp;
using System.Collections.Generic;

namespace PersonalAccountsTest
{
    [TestClass]
    public class UnitTesting
    {


        [TestMethod]
        [Owner("Ludwig Oleby")]
        [Description("This test transfers 100:- between personal accounts and checks that the first account has a negative balance of -100:- after the transaction")]
        public void Personal_Transfer_100_result_should_be_balance_minus_100()
        {
            // Arrange

            List<User> Users = new List<User>();
            List<BankAccount> BAList1 = new List<BankAccount>();
            List<SavingsAccount> SavingsList1 = new List<SavingsAccount>();
            List<Transactions> TransactionsList1 = new List<Transactions>();
            BankAccount DAccount1 = new BankAccount("Private-USD-Account", 2500, "USD");
            BankAccount BAccount1 = new BankAccount("Privat-Konto", 25000, "SEK");
            User Account1 = new User("Lukke", "hejhej123", "Lucas", "Narfgren", "narfgren@hotmail.com", BAList1, SavingsList1, TransactionsList1, true);
            Account1.BankAccountList.Add(BAccount1);
            Account1.BankAccountList.Add(DAccount1);
            Users.Add(Account1);

            Transfer t1 = new Transfer();

            // Act
            t1.TransferMoney(BAList1, Account1, TransactionsList1, 100);
            var actual = BAccount1.Balance;
            var expected = 24900;

            // Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        [Owner("Ludwig Oleby")]
        [Description("The test transfers 100 USD from SEK account and checks the new balance of the USD account")]
        public void international_Transfer_100_Usd_Result_Should_be_plus_11USD()
        {
            //Arrange

            List<User> Users = new List<User>();
            List<BankAccount> BAList1 = new List<BankAccount>();
            List<SavingsAccount> SavingsList1 = new List<SavingsAccount>();
            List<Transactions> TransactionsList1 = new List<Transactions>();
            BankAccount DAccount1 = new BankAccount("Private-USD-Account", 2500, "USD");
            BankAccount BAccount1 = new BankAccount("Privat-Konto", 25000, "SEK");
            User Account1 = new User("Lukke", "hejhej123", "Lucas", "Narfgren", "narfgren@hotmail.com", BAList1, SavingsList1, TransactionsList1, true);
            Account1.BankAccountList.Add(BAccount1);
            Account1.BankAccountList.Add(DAccount1);
            Users.Add(Account1);

            List<CurrencyRates> Rates = new List<CurrencyRates>();
            CurrencyRates USDRates = new CurrencyRates("USD", 9.02);


            BankAccount b1 = new BankAccount();

            //Act

            //b1.InternationalTransfer(Users, Account1, USDRates); //CS0176
            BankAccount.InternationalTransfer(Users, Account1, USDRates);

            var actual = DAccount1.Balance;
            var expected = 2511.0864745011086;


            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        [Owner("Ludwig Oleby")]
        [Description("Test create user function by creating an user object with the default constructor values")]

        public void Create_new_user()
        {

            //Arrange
            User u1 = new User();
            List<User> Users = new List<User>();
            List<BankAccount> AccountTest = new List<BankAccount>();
            List<SavingsAccount> SavingsTest = new List<SavingsAccount>();
            List<Transactions> TransactionsTest = new List<Transactions>();
            BankAccount InternationalAccount = new BankAccount("Private-USD-Account", 2500, "USD");
            BankAccount RegionalAccount = new BankAccount("Privat-Konto", 25000, "SEK");

            List<CurrencyRates> testrates = new List<CurrencyRates>();
            CurrencyRates USDRates = new CurrencyRates("USD", 9.02);


            //Act
            User.CreateUser(Users, false, u1, USDRates);
            var expected = "Default First Name";
            var actual = u1.Firstname;



            //Assert
            Assert.IsNotNull(u1); // Determines that the created object is not null
            Assert.AreEqual(expected, actual); // Compares the Firstname properties to verify that the object has been constructed according to the constructor

        }


    }
}
