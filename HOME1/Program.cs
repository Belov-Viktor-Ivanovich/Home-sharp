using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HOME1
{
    internal class Program
    {
        public static void swap(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        static void Main(string[] args)
        {
            //task1
            /*int low;
            bool flag = int.TryParse(Console.ReadLine(), out low);
            while (!flag||!(low >= 1 && low <= 100))
            {
                Console.WriteLine("Не верное число, повторите");
                flag = int.TryParse(Console.ReadLine(), out low);
            }
            if (low % 3 == 0 && low % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else
            {
                if(low % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (low % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(low);
            }*/

            //task2
            /*Console.WriteLine("input number");
            double num;
            bool flag= double.TryParse(Console.ReadLine(), out num);
            while(!flag)
            {
                Console.WriteLine("Не верное число, повторите");
                flag = double.TryParse(Console.ReadLine(), out num);
            }
            Console.WriteLine("input %");
            float proc;
            flag = float.TryParse(Console.ReadLine(), out proc);
            while (!flag)
            {
                Console.WriteLine("Не верное значение % , повторите");
                flag = float.TryParse(Console.ReadLine(), out proc);
            }
            Console.WriteLine(proc + " процентов от " + num + " = " + num / 100 * proc);*/

            //task3
            /*string str="";
            int rezult;
            for(int i=1; i<5; i++) 
            {
                Console.WriteLine("input " + i+" number");
                bool flag = int.TryParse(Console.ReadLine(), out rezult);
                while (!flag)
                {
                    Console.WriteLine("Не верно ввели число\nПовтороите");
                    Console.WriteLine("input " + i + " number");
                    flag = int.TryParse(Console.ReadLine(), out rezult);
                }
                str += rezult;
            }
            rezult = Convert.ToInt32(str);
            Console.WriteLine(rezult);*/

            //task4
            /*Console.WriteLine("Введите число");
            StringBuilder str = new StringBuilder(Console.ReadLine());
            int buf;
            bool flag = int.TryParse(str.ToString(), out buf);
            while (!flag || str.Length != 6)
            {
                str.Clear();
                Console.WriteLine("Ввели число не по условию, повторите");
                str = new StringBuilder(Console.ReadLine());
                flag = int.TryParse(str.ToString(), out buf);
            }
            Console.WriteLine("Введите первый разряд");
            int index1;
            flag = int.TryParse(Console.ReadLine(),out index1);
            while (!flag || index1 < 1 || index1 > str.Length)
            {
                Console.WriteLine("Ввели не верный разряд, повторите");
                flag = int.TryParse(Console.ReadLine(), out index1);
            }
            Console.WriteLine("Введите второй разряд");
            int index2;
            flag = int.TryParse(Console.ReadLine(), out index2);
            while (!flag || index2 < 1 || index2 > str.Length)
            {
                Console.WriteLine("Ввели не верный разряд, повторите");
                flag = int.TryParse(Console.ReadLine(), out index2);
            }
            char i1 = str[index1 - 1];
            char i2 = str[index2 - 1];
            str[index1 - 1] = i2;
            str[index2 - 1] = i1;
            string st = str.ToString();
            Console.WriteLine(st);*/

            //task5
            /*Console.WriteLine("Введите год");
            int year;
            bool flag = int.TryParse(Console.ReadLine(), out year);
            while (!flag || year <1)
            {
                Console.WriteLine("не верное значение года.\nПовторите");
                flag = int.TryParse(Console.ReadLine(), out year);
            }

            Console.WriteLine("Введите месяц");
            int month;
            flag = int.TryParse(Console.ReadLine(), out month);
            while (!flag || month>12 || month < 1)
            {
                Console.WriteLine("не верное значение месяца.\nПовторите");
                flag = int.TryParse(Console.ReadLine(), out month);
            }
             //МАКСИМАЛЬНОЕ КОЛЛИЧ.ДНЕЙ В МЕСЯЦЕ
            int dayMax=28+(month+month/8)%2+2%month+2*(1/month);
            //ПРОВЕРКА НА ВИСОКОСТНЫЙ ГОД
            if (month == 2)
            {
                if (year % 400 == 0) dayMax++;
                else if (year % 100 == 0) { }
                else if(year % 4== 0) dayMax++;
            }
            Console.WriteLine("Введите день");
            int day;
            flag = int.TryParse(Console.ReadLine(), out day);
            while (!flag || day > dayMax || day < 1)
            {
                Console.WriteLine("не верное значение дня.\nПовторите");
                flag = int.TryParse(Console.ReadLine(), out day);
            }

            DateTime date=new DateTime(year,month,day);
            if (month > 11 || month <3) Console.WriteLine("ЗИМА");
            else if (month > 8) Console.WriteLine("ОСЕНЬ");
            else if (month > 5) Console.WriteLine("ЛЕТО");
            else Console.WriteLine("ВЕСНА");
            Console.WriteLine(date.DayOfWeek);*/

            //task6
            /*Console.WriteLine("Введите температуру");
            string t=Console.ReadLine();
            float temp;
            bool flag = float.TryParse(t, out temp);
            while(!flag)
            {
                Console.WriteLine("Ввели неверный формат значения температуры\n\nПовторите");
                t = Console.ReadLine();
                flag = float.TryParse(t, out temp);

            }
            Console.WriteLine("Введите 1 если температура в Цельсиях\nВведите 0 если температура в Фаренгейтах");
            string str= Console.ReadLine();
            while(str!="0" && str != "1") 
            {
                Console.WriteLine("Вы ввели неверное значение,ПОВТОРИТЕ");
                Console.WriteLine("Введите 1 если температура в Цельсиях\nВведите 0 если температура в Фаренгейтах");
                str = Console.ReadLine();
            }
            
            Console.WriteLine("Во что хотите конвертировать?");
            Console.WriteLine("Введите 1 если в Цельсии\nВведите 0 если в Фаренгейты");
            string str2= Console.ReadLine();
            while (str2 != "0" && str2 != "1")
            {
                Console.WriteLine("Вы ввели неверное значение,ПОВТОРИТЕ");
                Console.WriteLine("Введите 1 если в Цельсии\nВведите 0 если в Фаренгейты");
                str2 = Console.ReadLine();
            }
            double F=temp*1.8+32;
            double C = (temp - 32) / 1.8;
            if(str=="0")
            {
                if (str2 == "0") Console.WriteLine("Температура итак  в Фаренгейтах\nТемпература = " + temp + "F");
                else Console.WriteLine("Температура = " + C + "C");
            }
            else
            {
                if (str2 == "1") Console.WriteLine("Температура итак  в Цельсиях\nТемпература = " + temp + "C");
                else Console.WriteLine("Температура = " + F + "F");
            }*/

            //task7         
            /*Console.WriteLine("Введите первую границу");
            string t=Console.ReadLine();
            int num1;
            bool flag = int.TryParse(t, out num1);
            while(!flag)
            {
                Console.WriteLine("Ввели неверный формат числа\n\nПовторите");
                t = Console.ReadLine();
                flag = int.TryParse(t, out num1);
            }
            Console.WriteLine("Введите вторую границу");
            t = Console.ReadLine();
            int num2;
            flag = int.TryParse(t, out num2);
            while (!flag)
            {
                Console.WriteLine("Ввели неверный формат числа\n\nПовторите");
                t = Console.ReadLine();
                flag = int.TryParse(t, out num2);
            }
            
            if(num1>num2)swap(ref num1,ref num2);
            if (num1 % 2 != 0) num1++;
            for(int i=num1;i<num2;i+=2)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}
