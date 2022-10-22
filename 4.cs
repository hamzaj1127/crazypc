using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace crazypc
{
    internal class _4
    {
        public static void sound()
        {
            Thread thread = new Thread(playnoise);
            thread.Start();
        }

        private static void playnoise()
        {
            while (true)
            {
                SoundPlayer noise = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                noise.Play();
            }
        }
    }
}