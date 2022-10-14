namespace PianoLastPick
{
    internal class Program
    {
        static void Sound(int[] OctavaArr)
        {
            while (true)
            {
                ConsoleKeyInfo music = Console.ReadKey(true);
                switch (music.Key)
                {
                    case ConsoleKey.S:
                        {
                            Console.Beep(OctavaArr[0], 200);
                            break;
                        }
                    case ConsoleKey.X:
                        {
                            Console.Beep(OctavaArr[1], 200);
                            break;
                        }
                    case ConsoleKey.D:
                        {
                            Console.Beep(OctavaArr[2], 200);
                            break;
                        }
                    case ConsoleKey.C:
                        {
                            Console.Beep(OctavaArr[3], 200);
                            break;
                        }
                    case ConsoleKey.F:
                        {
                            Console.Beep(OctavaArr[4], 200);
                            break;
                        }
                    case ConsoleKey.G:
                        {
                            Console.Beep(OctavaArr[5], 200);
                            break;
                        }
                    case ConsoleKey.B:
                        {
                            Console.Beep(OctavaArr[6], 200);
                            break;
                        }
                    case ConsoleKey.H:
                        {
                            Console.Beep(OctavaArr[7], 200);
                            break;
                        }
                    case ConsoleKey.N:
                        {
                            Console.Beep(OctavaArr[8], 200);
                            break;
                        }
                    case ConsoleKey.J:
                        {
                            Console.Beep(OctavaArr[9], 200);
                            break;
                        }
                    case ConsoleKey.M:
                        {
                            Console.Beep(OctavaArr[10], 200);
                            break;
                        }
                    case ConsoleKey.K:
                        {
                            Console.Beep(OctavaArr[11], 200);
                            break;
                        }
                }
                if (music.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите октаву - F4, F5, F6." +
                        "\nНажмите Esc, чтобы выйти из программы");
                    break;
                }

            }
        }
        static void FourthOctave()
        {
            int[] fourthOctaveArr = new int[] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
            Sound(fourthOctaveArr);
        }
        static void FifthOctave()
        {
            int[] fifthOctaveArr = new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
            Sound(fifthOctaveArr);
        }
        static void SixthOctave()
        {
            int[] sixthOctaveArr = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            Sound(sixthOctaveArr);
        }
        static void ChangeOctave()
        {
            ConsoleKeyInfo octave = Console.ReadKey(true);
            switch (octave.Key)
            {
                case ConsoleKey.F4:
                    {
                        Console.Clear();
                        Console.WriteLine("Четвертая октава");
                        FourthOctave();
                        break;
                    }
                case ConsoleKey.F5:
                    {
                        Console.Clear();
                        Console.WriteLine("Пятая октава");
                        FifthOctave();
                        break;
                    }
                case ConsoleKey.F6:
                    {
                        Console.Clear();
                        Console.WriteLine("Шестая октава");
                        SixthOctave();
                        break;
                    }
                case ConsoleKey.Escape:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Переключение между октавами - F4, F5, F6 (Esc - выйти из октавы)" +
                "\nНажмите Esc, чтобы выйти из программы");
            while (true)
            {
                ChangeOctave();
            }
        }
    }
}