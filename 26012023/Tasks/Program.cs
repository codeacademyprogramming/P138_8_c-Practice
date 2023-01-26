using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First program
            //Console.WriteLine("1-ci ededi daxil edin:");
            //string input1 = Console.ReadLine();
            //int number1 = Convert.ToInt32(input1);

            //Console.WriteLine("2-ci deyeri daxil edin");
            //string input2 = Console.ReadLine();
            //int number2 = Convert.ToInt32(input2);

            //string output = "Netice=" + (number1 + number2);

            //output = number1 + "+" + number2+"="+(number1+number2);
            //output = $"{number1}+{number2}={number1+number2}";

            //Console.WriteLine(output);

            //var sum = 0;

            //for(int i = 2; i <= 100; i+=2)
            //{
            //    sum += i;
            //}

            //sum = 0;
            //var num = 3;

            //while (num <= 100)
            //{
            //    sum += num;

            //    num += 3;
            //}

            //int[] numbers = new int[] {55,10,34,-25,10};

            //sum = 0;

            //for(var i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < 0)
            //        break;

            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);
            #endregion

            var sum = 0;

            Console.WriteLine("baslangic deyerini daxil et:");
            var fromNumberStr = Console.ReadLine();
            int fromNumber = Convert.ToInt32(fromNumberStr);

            string toNumberStr;
            int toNumber;
            do
            {
                Console.WriteLine("Bitme deyerini daxil et:");
                toNumberStr = Console.ReadLine();
                toNumber = Convert.ToInt32(toNumberStr);
            }
            while (toNumber <= fromNumber);

         

            for (int i = fromNumber; i < toNumber; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);


            Console.WriteLine("Heftenin gununu daxil edin:");
            string dayStr = Console.ReadLine();
            int day = Convert.ToInt32(dayStr);

            //if (day == 1)
            //{
            //    Console.WriteLine("Bazar ertesi");
            //}
            //else if(day == 2)
            //{
            //    Console.WriteLine("Cersenbe axsami");
            //}
            //else if(day == 3)
            //{
            //    Console.WriteLine("Cersenbe");
            //}
            //else if (day == 4)
            //{
            //    Console.WriteLine("Cume axsami");
            //}
            //else if( day == 5)
            //{
            //    Console.WriteLine("Cume");
            //}
            //else if(day == 6)
            //{
            //    Console.WriteLine("Senbe");
            //}
            //else if(day == 7)
            //{
            //    Console.WriteLine("Bazar");
            //}
            //else
            //{
            //    Console.WriteLine("Heftenin gunu yanlis daxil edilib!");
            //}

            switch (day)
            {
                case 1:
                    Console.WriteLine("Bazar ertesi");
                    break;
                case 2:
                    Console.WriteLine("Cersenbe axsami");
                    break;
                case 3:
                    Console.WriteLine("Cersenbe");
                    break;
                case 4:
                    Console.WriteLine("Cume axsami");
                    break;
                case 5:
                    Console.WriteLine("Cume");
                    break;
                case 6:
                    Console.WriteLine("Heftesonu");
                    break;
                case 7:
                    goto case 6;
                default:
                    Console.WriteLine("Yanlisdir!");
                    break;

            }





        }
    }
}
