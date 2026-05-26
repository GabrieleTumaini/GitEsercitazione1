using GitEsercitazione1;

class Program
{
    //La console è stata fatta separatamente perchè il mio compagno tumaini ha creato il progetto in cui andavano fatte le classi come libreria di classi
    static void Main(string[] args)
    {
        CD myCD = new CD("Meteora", "Linkin Park");

        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("                CD & SONG TEST SYSTEM             ");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Create a Song and add it to the CD");
            Console.WriteLine("2. Show CD details (Student 2's ToString and Duration methods)");
            Console.WriteLine("3. Test 'IsShortSong' functionality");
            Console.WriteLine("0. Exit");
            Console.WriteLine("==================================================");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("\nEnter song title: ");
                    string t = Console.ReadLine();
                    Console.Write("Enter song artist: ");
                    string a = Console.ReadLine();
                    Console.Write("Enter duration in seconds: ");
                    if (int.TryParse(Console.ReadLine(), out int d))
                    {
                        Track s = new Track(t, a, d);
                        myCD.AddSong(s);
                        Console.WriteLine("\n[OK] Song created and added to the CD.");
                    }
                    else
                    {
                        Console.WriteLine("\n[ERROR] Invalid duration.");
                    }
                    Console.ReadKey();
                    break;

                case "2":
                    Console.WriteLine($"\n--- Details of CD '{myCD.getTitle()}' ---");
                    Console.WriteLine($"Artist: {myCD.getAuthor}");
                    Console.WriteLine("Tracklist (ToString):");
                    Console.WriteLine(myCD.ToString());
                    Console.WriteLine($"Total CD Duration: {myCD.Duration()} seconds");
                    Console.ReadKey();
                    break;

                case "3":
                    var list = myCD.tracks;
                    if (list.Count == 0)
                    {
                        Console.WriteLine("\n[NOTICE] Please insert at least one song first using option 1.");
                    }
                    else
                    {
                        Track firstSong = list[0];
                        Console.Write($"\nEnter a threshold in seconds to check if '{firstSong.getTitle()}' is shorter: ");
                        if (int.TryParse(Console.ReadLine(), out int limit))
                        {
                            bool result = firstSong.shortSong(limit);
                            Console.WriteLine($"Result of IsShortSong({limit}): {result}");
                        }
                    }
                    Console.ReadKey();
                    break;

                case "0":
                    keepRunning = false;
                    break;

                default:
                    Console.WriteLine("\nInvalid option selected.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}

