using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace crazypc
{
    internal class _3
    {
        public static void threadKeyStroke()
        {
            Thread thread = new Thread(keyRan);
            thread.Start();
        }



        private static void keyRan()
        {
            while (true)
            {
                Random rand = new Random();

               
                int stringlen = rand.Next(4, 30);
                int randValue;
                string str = "";
                char letter;
                for (int i = 0; i < stringlen; i++)
                {

               
                    randValue = rand.Next(0, 26);

                  
                    letter = Convert.ToChar(randValue + 65);

                  
                    str = str + letter;
                }
                SendKeys.SendWait(str);
                Thread.Sleep(500);

            }
        }


    }
}
