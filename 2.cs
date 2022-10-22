using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace crazypc
{
    internal class _2
    {
        public static System.Windows.Forms.Keys ModifierKeys { get; }
        public char KeyChar { get; set; }
        public System.Windows.Forms.Keys KeyCode { get; }
        static void Main(string[] args)
        {
            //NoThread.NoThreadExample();
            //ThreadingOne.DemoThread();
            //CrazyPC.CrazyFunctionCall();
            audio.sound();
            keystrokes.threadKeyStroke();


            Console.ReadLine();
            Console.ReadKey();




        }









    }
}
