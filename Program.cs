using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lesson1
{
    class Program
    {

        static void Task1()
        {
            char a;
            while ((a = (char)Console.Read()) != '.')
            {
                Console.Write((a));

            }
        }
        static void Task2()
        {
            Console.WriteLine("Enter numb 6 sumbols");
            string numb = Console.ReadLine();
            if (numb.Length > 6 || numb.Length < 6)
            {
                Console.WriteLine("Erooro numb");
            }
            else
            {
                Console.WriteLine("GOOD");

                Console.WriteLine($"sum 1 polovnu{(numb[0] - 48) + (numb[1] - 48) + (numb[2] - 48)}");

                Console.WriteLine($"sum 2 polovnu{(numb[3] - 48) + (numb[4] - 48) + (numb[5] - 48)}");
                int a = (numb[0] - 48) + (numb[1] - 48) + (numb[2] - 48);
                int b = (numb[3] - 48) + (numb[4] - 48) + (numb[5] - 48);
                if (a == b)
                {
                    Console.WriteLine("tickec good");
                }
                else
                {
                    Console.WriteLine("ticket bad");
                }
            }
            
        }
        static void Task3()
        {
            char a;
            while ((a = (char)Console.Read()) != '.')
            {
                if (char.IsLower(a))
                {
                    Console.Write(char.ToUpper(a));
                }
                if (char.IsUpper(a))
                {
                    Console.Write(char.ToLower(a));
                }
            }
            
        }
       
        static void Task4()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            while (a <= b)
            {
                for (int i = 1; i <= a; i++)
                    Console.Write("{0}", a);
                a++;
                Console.WriteLine();
            }

        }
        static void Task5()
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            string revers = "";

            while (num > 9)
            {
                revers += (num % 10).ToString();
                num = num / 10;
            }

            revers += num.ToString();
            Console.WriteLine("number reverse  " + revers);
        }


        static void WorkMan(string typeWork,int quanituClockWork)
        {
            int salary = 0;
            switch (typeWork) {

                case "Builder":
                    salary = quanituClockWork * 20;
                    Console.WriteLine($"Salary : {typeWork} for {quanituClockWork} hours = {salary} $");
                    break;
                case "Teacher":
                    salary = quanituClockWork * 30;
                    Console.WriteLine($"Salary : {typeWork} for {quanituClockWork} hours = {salary} $");
                    break;

                case "Driver":
                    salary = quanituClockWork * 40;
                    Console.WriteLine($"Salary : {typeWork} for {quanituClockWork} hours = {salary} $");
                    break;
     
                case "Footbaler":
                    salary = quanituClockWork * 50;
                    Console.WriteLine($"Salary : {typeWork} for {quanituClockWork} hours = {salary} $");
                    break;



            }



        }
        static void Main(string[] args)
        {
            //Program.Task1();
            //Program.Task2();
             //Program.Task3();
             //Program.Task4();
            //Program.Task5();
            Program.WorkMan("Footbaler",9);


















            //int numberTicket = Convert.ToInt32(Console.ReadLine());
            //if(numberTicket.)
            /*
           //string a = "123";
           //Console.WriteLine($"{a.Reverse()}");
          /*



               /* double val = 12.456F;
                Console.WriteLine(val);

                System.Int32 valint = 1234;
                decimal valueDecimal = 23445.1234m;
                Console.WriteLine($"decimal {valueDecimal,20:N2}");
                Console.WriteLine($"{valint} Sqr: {Math.Pow(valint, 2)} sqrt {Math.Sqrt(valint)}");

                //string name = Console.ReadLine();
                //Console.WriteLine($"your str {name.Length} sumbols");
                //want input number
                //1.convert
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(number);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"erroor : {ex.Message}");
                }
                //2.Method static parse

                double numb = Double.Parse(Console.ReadLine());
                Console.WriteLine(numb + 1);

                //3.static try parse
               if(double.TryParse(Console.ReadLine(),out numb))

                {
                    Console.WriteLine($"hc{numb}");
                }
                else
                {
                    Console.WriteLine("incoreacr");
                }



                string test = Console.ReadLine();
                char symbol = Convert.ToChar(test);
                Console.WriteLine($"you entered {test}");

                symbol = (char)Console.Read();

                Console.WriteLine($"sumbol{symbol}");
                if (System.Char.IsDigit(symbol))
                {
                    Console.WriteLine("eneter digits");
                }
                else
                {
                    Console.WriteLine("not digits");
                }*/


        }

    }
   
}
