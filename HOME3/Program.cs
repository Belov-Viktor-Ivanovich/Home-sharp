using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace HOME3
{

    

    internal class Program
    {

        public static void showSquare(int a, char x)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write($"{x}   ");
                }
                Console.WriteLine("\n");
            }
        }

        public static bool palindrom(int a)
        {
            string str = a.ToString();
            for (int i = 0, i2 = str.Length - 1; i < str.Length / 2; i++, i2--)
            {
                if (str[i] != str[i2])
                {
                    return false;
                }
            }
            return true;

        }


        public static string filtr(string str,string str2) 
        {
            string rezult = "";

            for (int i = 0; i < str.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str[i] == str2[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag) { rezult += str[i]; }
            }
            str= rezult;
            return str;
        }


        static void Main(string[] args)
        {
            //task1
            //showSquare(5, '@');

            //task2
            //Console.WriteLine(palindrom(21350312));

            //task3
            /*string st = "1 2 6 -1 88 7 6";
            string st2 = "6 88 7";
            Console.WriteLine(filtr(st,st2));*/

            //task4
            Web web1 = new Web();
            //web1.Input();
            //Console.WriteLine(web1.Name);
            //Console.WriteLine(web1.Url);
            //Console.WriteLine(web1.Info);
            //Console.WriteLine(web1.Ip);
            web1.show();
            
            //task5
            Journal j1= new Journal();
            j1.show();

            //task6
            Magazin m1= new Magazin();
            m1.show();

        }
    }

    class Web
    {
        public string name { get; set; } = "Turandot";
        public string url { get; set; } = "https://turandot.ru";
        public string info { get; set; } = "Магазин женского белья";
        public string ip { get; set; } = "192.168.0.1";
        public  void Input() 
        {
            Console.WriteLine("Введите название сайта");
            this.name = Console.ReadLine();
            Console.WriteLine("Введите url сайта");
            this.url = Console.ReadLine();
            Console.WriteLine("Введите информацию о сайте");
            this.info = Console.ReadLine();
            Console.WriteLine("Введите ip сайта");
            this.ip = Console.ReadLine();
        }
        public void show()
        {
            Console.WriteLine($"Название сайта : {name}\n" +
                $"Url сайта : {url}\n" +
                $"Информация о сайте : {info}\n" +
                $"ip сайта : {ip}\n");
        }
        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }
        public string Url
        {
            get { return this.url; }
            set { url = value; }
        }
        public string Info
        {
            get { return this.info; }
            set { info = value; }
        }
        public string Ip
        {
            get { return this.ip; }
            set { ip = value; }
        }

    }

    class Journal
    {
        string name = "Mans";
        int year=1940;
        string info = "Мужской журнал";
        string phone = "8889999";
        string mail="mans@mail.ru";
        public void Input()
        {
            Console.WriteLine("Введите название журнала");
            this.name = Console.ReadLine();
            Console.WriteLine("Введите год основания");
            this.year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите описание журнала");
            this.info = Console.ReadLine();
            Console.WriteLine("Введите телефон журнала");
            this.phone = Console.ReadLine();
            Console.WriteLine("Введите почту журнала");
            this.mail = Console.ReadLine();
        }
        public void show()
        {
            Console.WriteLine($"Название журнала : {name}\n" +
                $"Год основания : {year}\n" +
                $"Информация о журнале : {info}\n" +
                $"телефон журнала : {phone}\n" +
                $"Почта журнала : {mail}\n");
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Info
        {
            get { return info; }
            set { info = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

    }

    class Magazin
    {
        string name = "Пятерочка";
        string adress = "РнД, ул. Ленина 45";
        string info = "Продуктовый Магазин";
        string phone="8-999-94-56";
        string mail = "5@mail.ru";
        public void Input()
        {
            Console.WriteLine("Введите название магазина");
            this.name = Console.ReadLine();
            Console.WriteLine("Введите адрес");
            this.adress = Console.ReadLine();
            Console.WriteLine("Введите описание магазина");
            this.info = Console.ReadLine();
            Console.WriteLine("Введите телефон Магазина");
            this.phone = Console.ReadLine();
            Console.WriteLine("Введите почту магазина");
            this.mail = Console.ReadLine();
        }
        public void show()
        {
            Console.WriteLine($"Название магазина : {name}\n" +
                $"Адрес магазина : {adress}\n" +
                $"Информация о Магазине : {info}\n" +
                $"телефон Магазина : {phone}\n" +
                $"Почта Магазина : {mail}\n");
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string Info
        {
            get { return info; }
            set { info = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
    }
}
