using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите номер счёта числом: ");
                int count_number = int.Parse(Console.ReadLine());
                Console.Write("Введите ФИО: ");
                string full_name = Console.ReadLine();
                Console.Write("Введите баланс: ");
                double balance = double.Parse(Console.ReadLine());
                BankAccount<int> bankAccount1 = new BankAccount<int>(count_number, balance, full_name);
                Console.Write("Введите номер счёта строкой: ");
                string count_number2 = Console.ReadLine();
                Console.Write("Введите ФИО: ");
                string full_name2 = Console.ReadLine();
                Console.Write("Введите баланс: ");
                double balance2 = double.Parse(Console.ReadLine());

                BankAccount<string> bankAccount2 = new BankAccount<string>(count_number2, balance2, full_name2);
                Console.WriteLine("Номер счёта: {0} ФИО: {1} Баланс: {2}", bankAccount1.GetCount_Number(), bankAccount1.GetFull_Name(), bankAccount1.GetBalance());
                Console.WriteLine("Номер счёта: {0} ФИО: {1} Баланс: {2}", bankAccount2.GetCount_Number(), bankAccount2.GetFull_Name(), bankAccount2.GetBalance());

                bankAccount1.SetCount_Number(6584999);
                bankAccount1.SetBalance(1500.00);
                bankAccount1.SetFull_Name("Блинов Даниил Максимович");

                bankAccount2.SetCount_Number("CD53421213");
                bankAccount2.SetBalance(2500.00);
                bankAccount2.SetFull_Name("Симонова Агата Денисовна");

                Console.WriteLine("Номер счёта: {0} ФИО: {1} Баланс: {2}", bankAccount1.GetCount_Number(), bankAccount1.GetFull_Name(), bankAccount1.GetBalance());
                Console.WriteLine("Номер счёта: {0} ФИО: {1} Баланс: {2}", bankAccount2.GetCount_Number(), bankAccount2.GetFull_Name(), bankAccount2.GetBalance());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
