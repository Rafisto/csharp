using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarScales
{
    class Program
    { 
        public static string[] notes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        public static string[] tuning = { "E", "B", "G", "D", "A", "E" };
        public static string[] current_notes = { "-  ", "-  ", "-  ", "-  ", "-  ", "-  ", "-  ", "-  ", "-  ", "-  ", "-  ", "-  " };
        public static string[] dur_levels = { "I  ", "ii ", "iii", "IV ", "V  ", "VI ", "Vii" };
        public static string[] mol_levels = { "I  ", "ii ", "iii", "IV ", "V  ", "VI ", "Vii" };

        // stopnie skali
        public static bool scale_relation = false;
        public static List<string> current_scale = new List<string>();
        public static string root = "";
        public static bool dur = true;
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    string command = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("IN " + command);


                    if (command == "R")
                    {
                        foreach (string current_note in current_notes)
                        {
                            current_notes[Array.IndexOf(current_notes, current_note)] = "-  ";
                        }
                    }
                    else if (command.Contains("T"))
                    {                      
                        if (command.Length == 4)
                        {
                            root += command[2] + command[3];
                        }
                        else
                        {
                            root += command[2];
                        }
                        if (command[1] == 'd')
                        {
                            dur = true;
                        }
                        else
                        {
                            dur = false;
                        }
                        scale_relation = true;
                    }
                    else if (command.Contains("d") || command.Contains("m"))
                    {
                        //skale
                        string start_note = "";
                        if (command.Contains("#"))
                        {
                            start_note = command[0] + "#";
                            if (command[2] == 'd')
                            {
                                dur = true;
                            }
                            else
                            {
                                dur = false;
                            }
                        }
                        else
                        {
                            start_note = command[0].ToString();
                            if (command[1] == 'd')
                            {
                                dur = true;
                            }
                            else
                            {
                                dur = false;
                            }
                        }
                        int offset = Array.IndexOf(notes, start_note);
                        string[] note_list = new string[23];
                        for (int i = 0; i < 23; i++)
                        {
                            if (i < 12) note_list[i] = notes[i];
                            else note_list[i] = notes[i - 12];

                        }
                        // skala durowa
                        if (dur)
                        {
                            //WWHWWWH
                            addNote(note_list[offset]);
                            addNote(note_list[offset + 2]);
                            addNote(note_list[offset + 4]);
                            addNote(note_list[offset + 5]);
                            addNote(note_list[offset + 7]);
                            addNote(note_list[offset + 9]);
                            addNote(note_list[offset + 11]);
                            Console.Write("DUR  ( ");
                        }
                        // skala molowa
                        else
                        {
                            //WHWWWHW
                            Console.Write("MOLL ( ");
                            addNote(note_list[offset]);
                            addNote(note_list[offset + 2]);
                            addNote(note_list[offset + 3]);
                            addNote(note_list[offset + 5]);
                            addNote(note_list[offset + 7]);
                            addNote(note_list[offset + 8]);
                            addNote(note_list[offset + 10]);
                        }
                        foreach (string current_note in current_notes)
                        {
                            if (current_note != "-  ")
                            {
                                current_scale.Add(current_note);
                                Console.Write(current_note);
                            }
                        }
                        Console.WriteLine(")");
                    }   
                    else if (command == "HELP")
                    {
                        Console.WriteLine("USE <#> to add a note from the chromatic scale");
                        Console.WriteLine("USE <#(d/m)> to add a major/minor scale");
                        Console.WriteLine("USE <R> to reset");
                    }
                    else
                    {
                        addNote(command);
                    }                   
                    Console.WriteLine("0  |1  2  3  4  5  6  7  8  9  10 11 12");
                    foreach (string start in tuning)
                    {
                        string constr = "";
                        if (start.Contains("#"))
                        {
                            constr = start + " |";
                        }
                        else
                        {
                            constr = start + "  |";
                        }
                        int offset = Array.IndexOf(notes, start);
                        foreach (string note in notes)
                        {
                            if (Array.IndexOf(notes, note) + offset + 1 < 12)
                            {
                                if (!scale_relation)
                                {
                                    constr += current_notes[Array.IndexOf(notes, note) + offset + 1];
                                }
                                else
                                {
                                    if (dur)
                                    {
                                        constr += dur_levels[Array.IndexOf(current_scale.ToArray(), current_notes[Array.IndexOf(notes, note) + offset + 1])];
                                    }
                                    else
                                    {

                                    }
                                }
                            }                      
                            else
                            {
                                if (!scale_relation)
                                {
                                    constr += current_notes[Array.IndexOf(notes, note) + offset - 11];
                                }
                                else
                                {
                                    if (dur)
                                    {
                                        constr += dur_levels[Array.IndexOf(current_scale.ToArray(), current_notes[Array.IndexOf(notes, note) + offset - 11])];
                                    }
                                    else
                                    {

                                    }
                                }
                            }

                        }
                        Console.WriteLine(constr);
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("IN - COMMAND UNRECOGNIZED" + e.ToString());
                }
            }

        }

        static void addNote(string command)
        {
            foreach (string note in notes)
            {
                if (command == note)
                {
                    if (command.Contains("#"))
                    {
                        current_notes[Array.IndexOf(notes, note)] = note + " ";
                    }
                    else
                    {
                        current_notes[Array.IndexOf(notes, note)] = note + "  ";
                    }
                }
            }
        }
    }
}
