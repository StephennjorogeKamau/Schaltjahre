using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chama_Bank
{
    class Accounts
    {
        private int AccountNumber;
        private int AccountBalance;
        private string Owner;
        private decimal MinBalance;
        private int Pin;


        //Konstrucktor
        public Accounts(int AccountNumber, string Owner, int AccountBalance, decimal MinBalance, int Pin)
        {
            this.AccountNumber = AccountNumber;
            this.AccountBalance = AccountBalance;
            this.Owner = Owner;
            this.MinBalance = MinBalance;
            this.Pin = Pin;

        }

        //Get accountnumber
        public void GeldEinzahlen(int Einzahlung)
        {
            AccountBalance = AccountBalance + Einzahlung;

        }
        public void GeldAuszahlen(int Auszahlung)
        {
            AccountBalance = AccountBalance - Auszahlung;
            if (Auszahlung<= MinBalance)
            {
                Console.WriteLine("Sie verfügen nicht über genügend Kontodeckung");
            }

        }

        public string GetOwner()
        {
            return Owner;
        }
        public int GetAccounBalance()
        {
            return AccountBalance;
        }

        public int GetAccountNumber()
        {
            return AccountNumber;
        }

        public int Getpin()
        {
            return Pin;
        }

        public void newPin(int NewPin)
        {
            Pin = NewPin;
        }




    }

}
