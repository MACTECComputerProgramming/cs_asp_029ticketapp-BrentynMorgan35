using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ASP_30
{

    class Ticket
    {

        static int studentNum;
        static int speedlimit;
        static int ticketSpeed;
        static double price;
        static Classes grade;

        enum Classes
        {
            Freshman,
            Sophmore,
            Junior,
            Senior,
        }

        public static void NewTicket()
        {
            Console.WriteLine("Enter Student Number: ");
            studentNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Speed Limit: ");
            speedlimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Speed of Student");
            ticketSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade by Number: 0 - Freshman, 1 - Sophomore, 2 - Junior, 3 - Senior");
            switch (int.Parse(Console.ReadLine()))
            {
                case 0:
                    grade = Classes.Freshman;
                        break;
                case 1:
                    grade = Classes.Sophmore;
                        break;
                case 2:
                    grade = Classes.Junior;
                        break;
                case 3:
                    grade = Classes.Senior;
                        break;

            }
            CalcFine();
            PrintTicket();


        }
        private static void CalcFine()
        {
            price = 75;
            int milesdifference = (ticketSpeed - speedlimit);
            int miles5 = (ticketSpeed - speedlimit) / 5;
            price += miles5 * 87.5;
     
        if (grade == Classes.Freshman)
            {
                if (milesdifference < 20)
                    price -= 50;
                else price += 100; 
            }
        if (grade == Classes.Senior)
            {
                if (milesdifference > 20)
                    price += 200;
                else price += 50;
            }
        if (grade == Classes.Junior || grade == Classes.Sophmore)
            {
                if (milesdifference >= 20) price += 100;
            }




        }
        private static void PrintTicket()
        {
            Console.Clear();
            Console.WriteLine("Student Number: " + studentNum);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Speed Limit:" + speedlimit);
            Console.WriteLine("Reported Speed:" + ticketSpeed);
            Console.WriteLine("Fine; " + price);

            Console.WriteLine("Press any Key for Another Ticket");
            Console.ReadKey();
            Console.Clear();
            NewTicket();
        }


    }
}
