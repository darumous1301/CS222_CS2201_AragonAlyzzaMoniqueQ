using System;

class Song
{
    public string title;
    public string artist;
    public double duration;

    public Song()
    {
        title = "Unknown";
        artist = "Unknown";
        duration = 0;
    }

    public Song(string title, string artist, double duration)
    {
        this.title = title;
        this.artist = artist;
        this.duration = duration;
    }
    
    public Song(string title, string artist) : this(title, artist, 0)
    {
    }

    public void DisplaySong()
    {
        Console.WriteLine("{0,-25} {1,-20} {2,5:F2}", title, artist, duration);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Songs to add: ");
        int count = int.Parse(Console.ReadLine());

        Song[] playlist = new Song[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\nSong #" + (i + 1));
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Artist: ");
            string artist = Console.ReadLine();

            Console.Write("Duration (minutes): ");
            string durationInput = Console.ReadLine();

            double duration = 0;
            if (durationInput != "")
                duration = double.Parse(durationInput);

            if (title == "" && artist == "")
                playlist[i] = new Song();
            else
                playlist[i] = new Song(title, artist, duration);
        }

        Console.WriteLine("\n=== || MY PLAYLIST || ===");
        Console.WriteLine("{0,-25} {1,-20} {2,5}", "Title", "Artist", "Time");
        Console.WriteLine(new string('-', 52));

        double total = 0;
        for (int i = 0; i < count; i++)
        {
            playlist[i].DisplaySong();
            total += playlist[i].duration;
        }

        double average = total / count;
        Console.WriteLine("\nTotal Duration: " + total.ToString("F2") + " mins");
        Console.WriteLine("Average Duration: " + average.ToString("F2") + " mins");
    }
}
