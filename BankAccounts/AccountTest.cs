/*
 CISP 405 Summer 2019 Tony Wang SID # 1443145
 
 Assignment 2 Description:
 Modify two given C# files (Account.cs and AccountTest.cs)
 for learning how to code in C# language.
 

 AccountTest.cs
 The main C# file to create the main program of this assignment,
 create two accounts from the Account class (Account.cs) and
 prompt the user to make a deposit and a withdrawal for both
 account1 and account2.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class AccountTest
    {
        static void Main()
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", -7.53m);

            // display initial balance of each object
            Console.WriteLine("  $$$  Display information of Accounts  $$$");
            Console.WriteLine(
               $"account1: {account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
               $"account2: {account2.Name}'s balance: {account2.Balance:C}");

            // deposit prompt for account1 then read input
            Console.Write("\nEnter deposit amount for account1: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
               $"adding {depositAmount:C} to account1 balance\n");
            account1.Deposit(depositAmount); // add to account1's balance

            // display balances
            Console.WriteLine("  $$$  Display information of Accounts  $$$");
            Console.WriteLine(
               $"account1: {account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
               $"account2: {account2.Name}'s balance: {account2.Balance:C}");

            // deposit prompt for account2 then read input
            Console.Write("\nEnter deposit amount for account2: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
               $"adding {depositAmount:C} to account2 balance\n");
            account2.Deposit(depositAmount); // add to account2's balance

            // display balances
            Console.WriteLine("  $$$  Display information of Accounts  $$$");
            Console.WriteLine(
               $"account1: {account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
               $"account2: {account2.Name}'s balance: {account2.Balance:C}");

            // debit prompt for account1 then read input
            Console.Write("\nEnter withdrawal amount for account1: ");
            decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
               $"subtracting {withdrawalAmount:C} from account1 balance\n");
            account1.Debit(withdrawalAmount); // subtract to account1's balance

            // display balances
            Console.WriteLine("  $$$  Display information of Accounts  $$$");
            Console.WriteLine(
               $"account1: {account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
               $"account2: {account2.Name}'s balance: {account2.Balance:C}");

            // debit prompt for account2 then read input
            Console.Write("\nEnter withdrawal amount for account2: ");
            withdrawalAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
               $"subtracting {withdrawalAmount:C} from account2 balance\n");
            account2.Debit(withdrawalAmount); // subtract to account2's balance

            // display balances
            Console.WriteLine("  $$$  Display information of Accounts  $$$");
            Console.WriteLine(
               $"account1: {account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine(
               $"account2: {account2.Name}'s balance: {account2.Balance:C}");

            /* This output line is used as a breakpoint for debug,
               enable this code line for help to see 
               the last balance result.
             */
            //Console.WriteLine("This is a breakpoint.");
        }
    }
}
