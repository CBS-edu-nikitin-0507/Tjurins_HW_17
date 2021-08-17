using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Note
    {
        public int Frequency { get; set; }
        public int Duration { get; set; }
        public bool PauseNote  { get; set; }
        
        public Note(int freq, int dur, bool pause)
        {
            Frequency = freq;
            Duration = dur;
            PauseNote = pause;
        }

        public static Note CreateNoteDO(int octave, int duration) 
        {
            if (octave == 0)
                return new Note(0, 200, true);
            int freq;
            switch (octave)
            {
                case '1':
                    freq = 261;
                    break;
                case '2':
                    freq = 523;
                    break;
                case '3':
                    freq = 1046;
                    break;
                case '4':
                    freq = 2093;
                    break;
                case '5':
                    freq = 4186;
                    break;
                
                default:
                    freq = 261;
                    break;
            }
            return new Note(freq,duration,false);
        }
        public static Note CreateNoteRE(int octave, int duration)
        {
            int freq;
            switch (octave)
            {
                case '1':
                    freq = 293;
                    break;
                case '2':
                    freq = 587;
                    break;
                case '3':
                    freq = 1174;
                    break;
                case '4':
                    freq = 2349;
                    break;
                case '5':
                    freq = 4698;
                    break;

                default:
                    freq = 293;
                    break;
            }
            return new Note(freq, duration, false);
        }
        public static Note CreateNoteMI(int octave, int duration)
        {
            int freq;
            switch (octave)
            {
                case '1':
                    freq = 329;
                    break;
                case '2':
                    freq = 659;
                    break;
                case '3':
                    freq = 1318;
                    break;
                case '4':
                    freq = 2637;
                    break;
                case '5':
                    freq = 5274;
                    break;

                default:
                    freq = 329;
                    break;
            }
            return new Note(freq, duration, false);
        }
        public static Note CreateNoteFA(int octave, int duration)
        {
            int freq;
            switch (octave)
            {
                case '1':
                    freq = 349;
                    break;
                case '2':
                    freq = 698;
                    break;
                case '3':
                    freq = 1396;
                    break;
                case '4':
                    freq = 2793;
                    break;

                default:
                    freq = 261;
                    break;
            }
            return new Note(freq, duration, false);
        }
        public static Note CreateNoteSOL(int octave, int duration)
        {
            int freq;
            switch (octave)
            {
                case '1':
                    freq = 392;
                    break;
                case '2':
                    freq = 784;
                    break;
                case '3':
                    freq = 1568;
                    break;
                case '4':
                    freq = 3136;
                    break;

                default:
                    freq = 392;
                    break;
            }
            return new Note(freq, duration, false);
        }
        public static Note CreateNoteLA(int octave, int duration)
        {
            int freq;
            switch (octave)
            {
                case '1':
                    freq = 440;
                    break;
                case '2':
                    freq = 880;
                    break;
                case '3':
                    freq = 1720;
                    break;
                case '4':
                    freq = 3440;
                    break;

                default:
                    freq = 440;
                    break;
            }
            return new Note(freq, duration, false);
        }
        public static Note CreateNoteSI(int octave, int duration)
        {
            int freq;
            switch (octave)
            {
                case '1':
                    freq = 493;
                    break;
                case '2':
                    freq = 987;
                    break;
                case '3':
                    freq = 1975;
                    break;
                case '4':
                    freq = 3951;
                    break;

                default:
                    freq = 493;
                    break;
            }
            return new Note(freq, duration, false);
        }
    }
}
