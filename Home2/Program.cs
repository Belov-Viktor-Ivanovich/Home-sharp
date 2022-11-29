using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home2
{
    internal class Program
    {
        
        //Добавление элемента в массив
        public static void addEl(ref int[]ar,int e)
        {
            int[] buf= new int[ar.Length+1];
            if (ar.Length == 0) buf[0]=e;
            else
            {
                ar.CopyTo(buf,0);
                buf[buf.Length-1]=e;
            }
            ar=buf;
        }
        //метод swap
        public static void swap(ref int a,ref int b)
        {
            int c = a;
            a=b;
            b=c;
        }
        public static void code(ref string str,int key)
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine(str);
            for (int i = 0; i < str.Length; i++)
            {
                st[i] = Convert.ToChar((Convert.ToInt32(st[i]) + key));
            }
            str = st.ToString();
            Console.WriteLine("Выполнено шифрование\n");
        }
        public static void decode(ref string str,int key)
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine(str);
            for (int i = 0; i < str.Length; i++)
            {
                st[i] = Convert.ToChar((Convert.ToInt32(st[i]) - key));
            }
            str= st.ToString();
            Console.WriteLine("Выполнено дешифрование\n");
        }
        public static void show(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine("\n");
        }
        public static void swowArray(int[,] array)
        {
            int row1 = array.GetLength(0);
            int col1 = array.GetLength(1);
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    Console.Write(array[i, j]+"\t");
                }
               Console.WriteLine("\n");
            }
        }
        public static string task7(string str,string str3)
        {
            string rezult = "";
            Console.WriteLine(str);
            Console.WriteLine("\n\n");
            bool flag = false;
            while (!flag)
            {
                if (str.Contains(str3))
                {
                    int index = str.IndexOf(str3);
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (index == i)
                        {
                            for (int j = 0; j < str3.Length; j++)
                            {
                                rezult += '*';

                            }
                            i += str3.Length - 1;
                        }
                        else rezult += str[i];
                    }
                    str = rezult;
                    rezult = "";
                    ;
                }
                else flag = true;
            }

            Console.WriteLine(str);
            return str;
        }
        static void Main(string[] args)
        {
            //task1
            /*Random random= new Random();
            int[] ar=new int[5];
            int[,] ar2 = new int[3, 4];
            int row = ar2.GetLength(0);
            int col = ar2.GetLength(1);
            for(int i =0;i<ar.Length;i++)
            {
                Console.WriteLine("Введите число");
                bool flag=int.TryParse(Console.ReadLine(), out ar[i]);
                while(!flag)
                {
                    Console.WriteLine("неверный ввод числа\nПовторите");
                    flag = int.TryParse(Console.ReadLine(), out ar[i]);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(ar[i]+" ");
            }
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<4;j++) 
                {
                    ar2[i, j] = random.Next(1,10);
                }

            }

            for (int i = 0; i < row; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < col; j++)
                {                   
                    Console.Write(ar2[i, j] + " ");
                }
                
            }

            int[] array = new int[0];
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    for(int k=0;k<ar.Length;k++) 
                    {
                        if (ar2[i, j] == ar[k])
                        {
                            addEl(ref array, ar[k]);
                        }
                    }
                }
            }
            Console.WriteLine("\n");
            if (array.Length == 0) Console.WriteLine("Нет одинаковых значений");
            else
            {
                Console.WriteLine("Максимальный общий элемент = " + array.Max());
                Console.WriteLine("Минимальный общий элемент = " + array.Min());
            }

            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sum+= ar2[i, j];
                }
            }
            for (int j = 0; j < ar.Length; j++)
            {
                sum += ar[j];
            }
            Console.WriteLine("Сумма всех эл = "+sum);
            double mult = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    mult *= ar2[i, j];
                }
            }
            for (int j = 0; j < ar.Length; j++)
            {
                mult *= ar[j];
            }
            Console.WriteLine("Произведение всех эл = " + mult);
            int sum2 = 0;
            for (int j = 0; j < ar.Length; j++)
            {
                if(ar[j]%2==0) sum2 += ar[j];
            }
            Console.WriteLine("Сумма четных эл первого массива = " + sum2);
            int sum3 = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j+=2)
                {
                    sum3 += ar2[i, j];
                }
            }
            Console.WriteLine("Сумма нечетных столбцов второго массива = " + sum3);*/

            //task2
            /*Random random= new Random();
            int[,]ar= new int[5,5];
            int row=ar.GetLength(0);
            int col=ar.GetLength(1);
            int[]buf= new int[row*col];
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<col;j++)
                {
                    ar[i,j]=random.Next(-100,100);
                    addEl(ref buf, ar[i,j]);
                }
            }
            int maxE=buf.Max();
            int minE=buf.Min();
            int indexMin=0;
            int indexMax=0;
            for (int i = 0; i < buf.Length; i++)
            {
                if (buf[i] == minE) indexMin = i;
            }
            for (int i = 0; i < buf.Length; i++)
            {
                if (buf[i]==maxE)indexMax = i;
            }
            if(indexMin>indexMax)swap(ref indexMin,ref indexMax);
            for(int i=indexMin;i<=indexMax;i++)
            {
                Console.WriteLine(buf[i]);
            }*/

            //task3
            /*Console.WriteLine("Введите строку");
            string str= Console.ReadLine();
            Console.WriteLine("Введите ключ");
            string str2 = Console.ReadLine();
            int key;
            bool flag = int.TryParse(str2,out key);
            while(!flag)
            {
                Console.WriteLine("Ввели неверный вормат ключа\nПовторите");
                flag = int.TryParse(str2, out key);
            }
            show(str);
            code(ref str,key);
            show(str);
            decode(ref str,key);
            show(str);*/

            //task4
            /*Random random = new Random();
            int[,] ar1 = new int[6,4];
            int[,] ar2 = new int[4,7];
            int row1 = ar1.GetLength(0);
            int row2 = ar2.GetLength(0);
            int col1 = ar1.GetLength(1);
            int col2 = ar2.GetLength(1);

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    ar1[i, j] = random.Next(1, 10);
                }

            }
            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    ar2[i, j] = random.Next(1, 10);
                }

            }
            Console.WriteLine("МАТРИЦА 1\n");
            swowArray(ar1);
            Console.WriteLine("МАТРИЦА 2\n");
            swowArray(ar2);
            int k = 4;
            Console.WriteLine("УМНОЖЕНИЕ ПЕРВОЙ МАТРИЦЫ НА ЧИСЛО = " + k+"\n");

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    ar1[i, j] *= k;
                }
            }
            Console.WriteLine("REZULT\n");
            swowArray(ar1);

            Console.WriteLine("СЛОЖЕНИЕ МАТРИЦ\n");
            int row3;
            if (row1 >= row2) row3 = row1;
            else row3 = row2;
            int col3;
            if (col1 >= col2) col3 = col1;
            else col3 = col2;
            int[,] rezultSum = new int[row3, col3];
            if(row1>=row2)
            {
                int i;
                for (i = 0; i < row2; i++)
                {
                    if (col1 > col2)
                    {
                        int j;
                        for (j = 0; j < col2; j++)
                        {
                            rezultSum[i, j] = ar1[i, j] + ar2[i, j];
                        }
                        for (; j<col1; j++)
                        {
                            rezultSum[i, j] = ar1[i, j];
                        }
                    }
                    else
                    {
                        int j;
                        for (j = 0; j < col1; j++)
                        {
                            rezultSum[i, j] = ar1[i, j] + ar2[i, j];
                        }
                        for (; j < col2; j++)
                        {
                            rezultSum[i, j] = ar2[i, j];
                        }
                    }
                }


                for (; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        rezultSum[i, j] = ar1[i, j];
                    }
                }
            }
            else
            {
                int i;
                for (i = 0; i < row1; i++)
                {
                    if (col1 > col2)
                    {
                        int j;
                        for (j = 0; j < col2; j++)
                        {
                            rezultSum[i, j] = ar1[i, j] + ar2[i, j];
                        }
                        for (; j < col1; j++)
                        {
                            rezultSum[i, j] = ar1[i, j];
                        }
                    }
                    else
                    {
                        int j;
                        for (j = 0; j < col1; j++)
                        {
                            rezultSum[i, j] = ar1[i, j] + ar2[i, j];
                        }
                        for (; j < col2; j++)
                        {
                            rezultSum[i, j] = ar2[i, j];
                        }
                    }
                }


                for (; i < row2; i++)
                {
                    for (int j = 0; j < col2; j++)
                    {
                        rezultSum[i, j] = ar2[i, j];
                    }
                }

            }
            swowArray(rezultSum);
            rezultSum = new int[row3, col3];

            Console.WriteLine("УМНОЖЕНИЕ МАТРИЦ\n");
            if (row1 >= row2)
            {
                int i;
                for (i = 0; i < row2; i++)
                {
                    if (col1 > col2)
                    {
                        int j;
                        for (j = 0; j < col2; j++)
                        {
                            rezultSum[i, j] = ar1[i, j] * ar2[i, j];
                        }
                        for (; j < col1; j++)
                        {
                            rezultSum[i, j] = ar1[i, j];
                        }
                    }
                    else
                    {
                        int j;
                        for (j = 0; j < col1; j++)
                        {
                            rezultSum[i, j] = ar1[i, j] * ar2[i, j];
                        }
                        for (; j < col2; j++)
                        {
                            rezultSum[i, j] = ar2[i, j];
                        }
                    }
                }


                for (; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        rezultSum[i, j] = ar1[i, j];
                    }
                }
            }
            else
            {
                int i;
                for (i = 0; i < row1; i++)
                {
                    if (col1 > col2)
                    {
                        int j;
                        for (j = 0; j < col2; j++)
                        {
                            rezultSum[i, j] = ar1[i, j] * ar2[i, j];
                        }
                        for (; j < col1; j++)
                        {
                            rezultSum[i, j] = ar1[i, j];
                        }
                    }
                    else
                    {
                        int j;
                        for (j = 0; j < col1; j++)
                        {
                            rezultSum[i, j] = ar1[i, j] * ar2[i, j];
                        }
                        for (; j < col2; j++)
                        {
                            rezultSum[i, j] = ar2[i, j];
                        }
                    }
                }


                for (; i < row2; i++)
                {
                    for (int j = 0; j < col2; j++)
                    {
                        rezultSum[i, j] = ar2[i, j];
                    }
                }

            }
            swowArray(rezultSum);*/

            //task5
            /*string str = "5+5";
            object result = new DataTable().Compute(str, null);
            Console.WriteLine(result);
            int a = Convert.ToInt32(result.ToString());
            Console.WriteLine(a);*/

            //task6

            /*Console.WriteLine("Введите текст");
            //string str = "today is a good\r\nday for walking. i will try to walk near the sea.";//Console.ReadLine();
            bool flag=false;
            string str= Console.ReadLine(); 
            while(!flag)
            {
               
                for (int i = 0; i < str.Length; i++)
                {
                    flag= true;
                    if (str[i]=='.'&& i + 1 < str.Length && str[i+1]!=' ')
                    {
                        flag = false;
                        break;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine("Не верный формат. После точки следует пробел.\nПовторите");
                    str = Console.ReadLine();
                }
            }
            string strUp = str.ToUpper();
            string rezult="";
            rezult += strUp[0];
            flag = false;
            for (int i = 1; i < str.Length; i++)
            {
                if(flag) { rezult+= strUp[i]; flag = false; }
                else if (str[i] == '.' && i+1<str.Length) { flag = true; rezult += str[i];rezult +=str[i+1]; i++; }
                else rezult+= str[i];
            }

            Console.WriteLine(rezult);*/

            //task7

            /*string str = "To be, or not to be, that is the question,\r\nWhether 'tis nobler in the mind to suffer\r\nThe slings and arrows of outrageous fortune,\r\nOr to take arms against a sea of troubles,\r\nAnd by opposing end them? To die : to sleep;\r\nNo more; and by a sleep to say we end\r\nThe heart-ache and the thousand natural shocks\r\nThat flesh is heir to, 'tis a consummation\r\nDevoutly to be wish'd. To die, to sleep";
            string str3 = "die";
            str=task7(str,str3);*/
        }
    }
}
