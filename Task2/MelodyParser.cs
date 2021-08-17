using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //static class MelodyParser
    //{
    //    public static Note[] ParseMelody(string melody)
    //    {
    //        int index = 0;
    //        string[] melodyArr = melody.Split(" ");
    //        Note[] arr = new Note[melodyArr.Length * 2];

    //        foreach (dynamic x in melodyArr)
    //        {
    //            arr[index] = new Note(Int32.Parse(x), 200, false);
    //            index++;
    //        }

    //        return arr;
    //    }
    //}

    
    static class MelodyParser
    {
        public static Note[] ParseMelody(string melody)
        {
            int index = 0;
            char[] melodyArr = melody.ToCharArray();
            Note[] notes = new Note[melodyArr.Length];

            for (int i =0; i < melodyArr.Length; i++)
            {
                switch (melodyArr[i]) 
                {
                    case '0':
                        notes[i] = Note.CreateNoteDO(1, 200);
                        index++;
                        break;
                    case '1':
                        notes[i] = Note.CreateNoteRE(1, 200);
                        index++;
                        break;
                    case '2':
                        notes[i] = Note.CreateNoteMI(1, 200);
                        index++;
                        break;
                    case '3':
                        notes[i] = Note.CreateNoteFA(1, 200);
                        index++;
                        break;
                    case '4':
                        notes[i] = Note.CreateNoteSOL(1, 200);
                        index++;
                        break;
                    case '5':
                        notes[i] = Note.CreateNoteLA(1, 200);
                        index++;
                        break;
                    case '6':
                        notes[i] = Note.CreateNoteSI(1, 200);
                        index++;
                        break;
                    case '7':
                        notes[i] = Note.CreateNoteDO(1, 200);
                        index++;
                        break;
                    case '8':
                        notes[i] = Note.CreateNoteRE(1, 200);
                        index++;
                        break;
                    case '9':
                        notes[i] = Note.CreateNoteMI(1, 200);
                        index++;
                        break;

                    case ' ':
                        notes[i] = Note.CreateNoteDO(0, 200);
                        index++;
                        break;
                }

            }
            

            return notes;
        }
    }
}
