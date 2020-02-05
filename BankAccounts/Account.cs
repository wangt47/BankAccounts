/*
 CISP 405 Summer 2019 Tony Wang SID # 1443145
 
 Assignment 2 Description:
 Modify two given C# files (Account.cs and AccountTest.cs)
 for learning how to code in C# language.
 

 Account.cs
 Making the framework of creating a Bank Account and
 providing methods to allow deposit and withdrawal
 but only accepts a valid value for the appropriate function
 (i.e. cannot withdraw if value is over the account balance, 
 can deposit if value is a positive number)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Account
    {
        public string Name { get; set; } // auto-implemented property
        private decimal balance; // instance variable

        // Account constructor that receives two parameters  
        public Account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            Balance = initialBalance; // Balance's set accessor validates
        }

        // Balance property with validation
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set // can be used only within the class
            {
                // validate that the balance is greater than 0.0; if it's not,
                // instance variable balance keeps its prior value
                if (value > 0.0m) // m indicates that 0.0 is a decimal literal
                {
                    balance = value;
                }

                // validate that the balance is 0; if it is,
                // instance variable balance is set to zero.
                else if (value == 0.0m)
                {
                    balance = 0;
                }
            }
        }

        // method that deposits (adds) only a valid amount to the balance
        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0.0m) // if the depositAmount is valid
            {
                Balance = Balance + depositAmount; // add it to the balance 
            }

            else if (depositAmount < 0.0m) // if the depositAmount is a negative number.
            {
                // Display that no action is taken because the user input is less than zero.
                Console.WriteLine($"--Deposit Amount, {depositAmount}, is less than zero.-- \n No action is taken.\n");
            }

            else  // if the depositAmount is zero.
            {
                // Display that no action is taken because the user input is zero.
                Console.WriteLine($"--Deposit Amount is zero.-- \n No action is taken.\n");
            }
        }

        // method that withdaws (subtracts) only a valid amount from the balance
        public void Debit(decimal withdrawalAmount)
        {
            if (withdrawalAmount > Balance) // if withdrawal amount exceed the Account Balance
            {
                Console.WriteLine($"--Debit Amount, {withdrawalAmount}, exceeds account balance.-- \n No action is taken.\n");
            }

            else if (withdrawalAmount < 0) // if withdrawal amount is a negative number.
            {
                Console.WriteLine($"--Debit Amount, {withdrawalAmount}, is less than zero.-- \n No action is taken.\n");
            }

            else if (withdrawalAmount == 0) // if withdrawal amount is zero.
            {
                Console.WriteLine($"--Debit Amount is zero.-- \n No action is taken.\n");
            }

            else // if the withdrawal amount is a legal value (greater than zero and does not exeed the account balance).
            {
                Balance = Balance - withdrawalAmount; // subtract the account balance by the given withdrawal ammount.
            }
        }
    }
}
