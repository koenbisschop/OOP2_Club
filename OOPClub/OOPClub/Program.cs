using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClub
{
    class Program
    {
        public static List<Member> members = new List<Member>();
        static void Main(string[] args)
        {

            bool end = false;

            while (!end)
            {
                string name = GetName();
                if (name.ToUpper() == "STOP")
                    end = true;
                else
                {
                    DateTime dob = GetDob();
                    members.Add(new Member(name, dob));
                }
                Console.Clear();
            }

            decimal totalMoney = MonthlyPay(members);

            foreach (Member m in members)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine($"Maandelijks inkomen: {totalMoney.ToString("C2")}");
            Console.ReadLine();
        }

        static string GetName()
        {
            Console.WriteLine("Geef uw volledige naam.");
            return Console.ReadLine();
        }

        static DateTime GetDob()
        {
            DateTime dob = DateTime.Today;
            bool inputOK = false;
            while (!inputOK)
            {
                Console.WriteLine("Geef uw geboortedatum. (MM/DD/YYYY)"); // MM/DD/YY omdat mijn laptop en PC in het Engels(verenigde Staten) staan
                try
                {
                    dob = Convert.ToDateTime(Console.ReadLine());
                    inputOK = true;
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
            }
            return dob;

        }

        static decimal MonthlyPay(List<Member> members)
        {
            decimal money = 0M;
            foreach (Member m in members)
            {
                money += m.Price;
            }
            return money;
        }
    }

}
