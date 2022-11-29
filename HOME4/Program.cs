using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GAME;

namespace HOME4
{
    internal class Program
    {
        static void Print(ref List<Game> games)
        {
            Console.Clear();
            bool flag;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    flag = false;
                    for (int k = 0; k < games.Count; k++)
                    {
                        if (games[k].IntX == i && games[k].IntY == j)
                        {
                            Console.Write($" _{games[k].CharS}_ ");
                            flag = true;
                            break;
                        }
                    }
                    if (!flag) Console.Write(" ___ ");
                }
                Console.WriteLine("\n");
            }
        }

        static void HodComp(ref int x, ref int y, ref List<Game> games)
        {
            Random random = new Random();
            bool flag = false;
            while (!flag)
            {
                x = random.Next(3);
                y = random.Next(3);

                for (int k = 0; k < games.Count; k++)
                {
                    flag = true;
                    if (games[k].IntX == x && games[k].IntY == y)
                    {
                        flag = false;
                        break;
                    }
                }
                if (games.Count==0)flag= true;
            }
        }

        static bool Win(ref List<Game> games)
        {
            int leftX = 0, rightX = 0, upX = 0, downX = 0, x1X = 0, x2X = 0, vertX = 0, gorX = 0;
            int leftY = 0, rightY = 0, upY = 0, downY = 0, x1Y = 0, x2Y = 0, vertY = 0, gorY = 0;
            bool flag = false;
            for (int i = 0; i < games.Count; i++)
            {
                if (!flag)
                {
                    if (games[i].IntX == 0 && games[i].IntY == 0 && games[i].CharS == 'X') { leftX++; upX++; x1X++; }
                    else if (games[i].IntX == 0 && games[i].IntY == 0 && games[i].CharS == 'O') { leftY++; upY++; x1Y++; }
                    else if (games[i].IntX == 1 && games[i].IntY == 0 && games[i].CharS == 'X') { leftX++; gorX++; }
                    else if (games[i].IntX == 1 && games[i].IntY == 0 && games[i].CharS == 'O') { leftY++; gorY++; }
                    else if (games[i].IntX == 2 && games[i].IntY == 0 && games[i].CharS == 'X') { leftX++; downX++; x2X++; }
                    else if (games[i].IntX == 2 && games[i].IntY == 0 && games[i].CharS == 'O') { leftY++; downY++; x2Y++; }
                    else if (games[i].IntX == 0 && games[i].IntY == 1 && games[i].CharS == 'X') { upX++; vertX++; }
                    else if (games[i].IntX == 0 && games[i].IntY == 1 && games[i].CharS == 'O') { upY++; vertY++; }
                    else if (games[i].IntX == 1 && games[i].IntY == 1 && games[i].CharS == 'X') { vertX++; gorX++; x1X++; x2X++; }
                    else if (games[i].IntX == 1 && games[i].IntY == 1 && games[i].CharS == 'O') { vertY++; gorY++; x1Y++; x2Y++; }
                    else if (games[i].IntX == 2 && games[i].IntY == 1 && games[i].CharS == 'X') { downX++; vertX++; }
                    else if (games[i].IntX == 2 && games[i].IntY == 1 && games[i].CharS == 'O') { downY++; vertY++; }
                    else if (games[i].IntX == 0 && games[i].IntY == 2 && games[i].CharS == 'X') { rightX++; x2X++; upX++; }
                    else if (games[i].IntX == 0 && games[i].IntY == 2 && games[i].CharS == 'O') { rightY++; x2Y++; upY++; }
                    else if (games[i].IntX == 1 && games[i].IntY == 2 && games[i].CharS == 'X') { rightX++; gorX++; }
                    else if (games[i].IntX == 1 && games[i].IntY == 2 && games[i].CharS == 'O') { rightY++; gorY++; }
                    else if (games[i].IntX == 2 && games[i].IntY == 2 && games[i].CharS == 'X') { rightX++; downX++; x1X++; }
                    else if (games[i].IntX == 2 && games[i].IntY == 2 && games[i].CharS == 'O') { rightY++; downY++; x1Y++; }
                }
                if (leftX == 3 || leftY == 3 || rightX == 3 || rightY == 3 || upX == 3 || upY == 3 || downX == 3 || downY == 3 || x1X == 3 || x1Y == 3 || x2X == 3 || x2Y == 3 || vertX == 3 || vertY == 3 || gorX == 3 || gorY == 3) { return true; }
            }
            return false;
        }

        static void Gamer(char s,int k)
        {
            List<Game> game = new List<Game>();
            bool flag2=false;
            bool flag3;
            while (!flag2)
            {
                flag3 = false;
                if (s == 'X')
                {
                    Print(ref game);
                    Console.WriteLine("Ход игрока 1\nВведите координаты\n");
                    Console.WriteLine("Выберите строку от 0 до 2\n");
                    int x;
                    bool flag=int.TryParse(Console.ReadLine(),out x);
                    if(x<0||x>2) { flag=false; }
                    while(!flag)
                    {
                        Console.WriteLine("не верно выбрана строка, ПОВТОРИТЕ\n");
                        flag = int.TryParse(Console.ReadLine(), out x);
                        if (x < 0 || x > 2) { flag = false; }
                    }
                    Console.WriteLine("Выберите столбец от 0 до 2\n");
                    int y;
                    flag = int.TryParse(Console.ReadLine(), out y);
                    if (y < 0 || y > 2) { flag = false; }
                    while (!flag)
                    {
                        Console.WriteLine("не верно выбрана строка, ПОВТОРИТЕ\n");
                        flag = int.TryParse(Console.ReadLine(), out y);
                        if (y < 0 || y > 2) { flag = false; }
                    }
                    
                    Game buf = new Game(x, y, 'X');
                    
                    for (int i = 0; i < game.Count; i++)
                    {
                        if (buf.Sravnenie(game[i]))
                        {
                            flag3 = true;
                            
                            break;
                        }
                    }
                    if (flag3) continue;
                    game.Add(buf);
                    if (Win(ref game))
                    {
                        Print(ref game);
                        Console.WriteLine("Победа Игрока 1");
                        flag2 = true;
                    }
                    else if (game.Count == 9)
                    {
                        Print(ref game);
                        Console.WriteLine("НИЧЬЯ");
                        flag2 = true;
                    }                    
                    s = 'O';
                }
                else if (k == 2)
                {
                    Print(ref game);
                    Console.WriteLine("Ход игрока 2\nВведите координаты\n");
                    Console.WriteLine("Выберите строку от 0 до 2\n");
                    int x;
                    bool flag = int.TryParse(Console.ReadLine(), out x);
                    if (x < 0 || x > 2) { flag = false; }
                    while (!flag)
                    {
                        Console.WriteLine("не верно выбрана строка, ПОВТОРИТЕ\n");
                        flag = int.TryParse(Console.ReadLine(), out x);
                        if (x < 0 || x > 2) { flag = false; }
                    }
                    Console.WriteLine("Выберите столбец от 0 до 2\n");
                    int y;
                    flag = int.TryParse(Console.ReadLine(), out y);
                    if (y < 0 || y > 2) { flag = false; }
                    while (!flag)
                    {
                        Console.WriteLine("не верно выбрана строка, ПОВТОРИТЕ\n");
                        flag = int.TryParse(Console.ReadLine(), out y);
                        if (y < 0 || y > 2) { flag = false; }
                    }
                    
                    Game buf = new Game(x, y, 'O');
                    for (int i = 0; i < game.Count; i++)
                    {
                        if (buf.Sravnenie(game[i]))
                        {
                            flag3= true;
                            break;
                        }
                    }
                    if (flag3) continue;
                    game.Add(buf);
                    if (Win(ref game))
                    {
                        Print(ref game);
                        Console.WriteLine("Победа Игрока 2");
                        flag2 = true;
                    }
                    else if (game.Count == 9)
                    {
                        Print(ref game);
                        Console.WriteLine("НИЧЬЯ");
                        flag2 = true;
                    }
                    s = 'X';
                }
                else
                {
                    Print(ref game);
                    int x = -1;
                    int y = -1;
                    HodComp(ref x, ref y,ref game);
                    Game buf = new Game(x, y, 'O');
                    game.Add(buf);
                    if (Win(ref game))
                    {
                        Print(ref game);
                        Console.WriteLine("Победа Компьютера");
                        flag2 = true;
                    }
                    else if (game.Count == 9)
                    {
                        Print(ref game);
                        Console.WriteLine("НИЧЬЯ");
                        flag2 = true;
                    }
                    s = 'X';
                }                
            }
        }
        static void Main(string[] args)
        {

            Random random = new Random();
            int first_move = random.Next(2);
            char s;
            if(first_move==0) { s= 'X'; }
            else { s = 'O'; }
            int k;
            Console.WriteLine("ВЫБЕРИТЕ КОЛИЧЕСТВО ИГРОКОВ ОТ 1 ДО 2");
            bool flag = int.TryParse(Console.ReadLine(), out k);
            if (k < 1 || k > 2) flag = !flag;
            while (!flag)
            {
                flag = int.TryParse(Console.ReadLine(), out k);
                if (k < 1 || k > 2) flag = !flag;
            }
            Gamer('X',k);

        }
    }
}
namespace GAME
{
    class Game
    {
        int x;
        int y;
        char symbol = '_';
        public Game(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }
        public int IntX
        {
            get { return x; }
            set { x = value; }
        }
        public int IntY
        {
            get { return y; }
            set { y = value; }
        }
        public char CharS
        {
            get { return symbol; }
            set { symbol = value; }
        }
        public bool Sravnenie(Game ob2)
        {
            if (this.IntX == ob2.IntX && this.y == ob2.y) return true;
            return false;
        }
    }
}
