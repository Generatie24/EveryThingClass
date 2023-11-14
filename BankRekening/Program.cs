using BankRekening.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankRekening
{
    internal class Program
    {
        
        static Bank[] banks = new Bank[2];
        static Client[] clients = new Client[2];
        static void Main(string[] args)
        {
            string line = new string('_', 50);
            Console.WriteLine(line);
            FillClientsArray();
            FillBanksArray();
            ShowClients();
            ShowBank();
        }

        private static void ShowBank()
        {
            for (int i = 0; i < banks.Length; i++)
            {
                banks[i].Withdraw(500);
                Console.WriteLine("New Saldo " + banks[i].ShowSaldo());
            }
        }

        private static void ShowClients()
        {
            for (int i = 0; i < clients.Length; i++)
            {
                Console.WriteLine(clients[i] + "  " + banks[i]);
            }
        }

        private static void FillClientsArray()
        {
            for (int i = 0; i < clients.Length; i++)
            {
                Client client = InputClientInfo();
                clients[i] = client;

            }
        }

        private static void FillBanksArray()
        {
            for (int i = 0; i < banks.Length; i++)
            {
                Bank bank = InputBankInfo();
                banks[i] = bank;
            }
        }

        static void ShowInfo(Client client, Bank bank)
        {
            Console.WriteLine($"{client.ToString()} the Saldo is: {bank.ShowSaldo()}");
        }

        static Client InputClientInfo()
        {
            Console.Clear();
            Console.Write("Enter your firstname please ");
            string fname = Console.ReadLine();
            Console.Write("Enter your lastname please ");
            string lname = Console.ReadLine();
            Console.Write("Enter your address please ");
            string address = Console.ReadLine();
            Console.Write("Enter your age please ");
            int age = Convert.ToInt32(Console.ReadLine());

            Client client = new Client(fname, lname, address, age);
            return client;
        }
        static Bank InputBankInfo()
        {
            Console.Clear();
            Console.Write("Enter your IBAN please ");
            string iban = Console.ReadLine();
            Console.Write("Enter your BankName please ");
            string bankName = Console.ReadLine();
            Console.Write("Enter your Saldo please ");
            double saldo = Convert.ToDouble(Console.ReadLine());

            Bank bank = new Bank(iban, bankName, saldo);
            return bank;
        }
    }
}
