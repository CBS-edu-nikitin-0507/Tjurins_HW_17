using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class Player
    {
        public static void Play(Note[] notes)
        {
            for (int i = 0; i < notes.Length; i++)
            {
                if(notes[i].Frequency == 0)
                    System.Threading.Thread.Sleep(300);
                else 
                { 
                    //Console.WriteLine(notes[i].Frequency);
                    Console.Beep(notes[i].Frequency, notes[i].Duration);
                }
            }
        }
    }
}
