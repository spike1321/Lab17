using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class BankAccount<T>
    {
        private T Count_Number;
        private double Balance;
        private string Full_Name;

        public BankAccount(T count_number, double balance, string fulname)
        {
            this.Count_Number = count_number;
            this.Balance = balance;
            this.Full_Name = fulname;
        }
        public T GetCount_Number()
        {
            return Count_Number;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public string GetFull_Name()
        {
            return Full_Name;
        }
        public void SetCount_Number(T count_number)
        {
            this.Count_Number = count_number;
        }
        public void SetBalance(double balance)
        {
            this.Balance = balance;
        }
        public void SetFull_Name(string fulname)
        {
            this.Full_Name = fulname;
        }
        
    }
}
