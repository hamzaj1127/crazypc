using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace crazypc
{
    internal class _1
    {
        public static Random _random = new Random();
        public static void CrazyFunctionCall()
        {
            //int my_random_number = _random.Next(0, 100);
            //Console.WriteLine(my_random_number);
            //Console.ReadLine();
            CrazyMouseThread();
        }
        static void CrazyMouseThread()
        {
            int moveX = 0;
            int moveY = 0;
            while (true)
            {
                moveX = _random.Next(20) - 10;
                Console.WriteLine(moveX);
                moveY = _random.Next(20) - 10;
                Console.WriteLine(moveY);

                Cursor.Position = new System.Drawing.Point(Cursor.Position.X + moveX, Cursor.Position.Y + moveY);
                Thread.Sleep(300);
            }
        }
    }
}