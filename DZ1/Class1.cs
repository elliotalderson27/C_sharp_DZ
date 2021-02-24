//VuongChiHieu F ИУ6-71Б Part 1
using System;


namespace Music
{
    public class Compositor
    {
        public string Name, Surname;

        public Compositor()
        {
            Name = "Unknown";
            Surname = "Unknown";
            Console.WriteLine("Name: {0}\nSurname: {1}\n", Name, Surname);
        }
        public Compositor(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Console.WriteLine("Name: {0}\nSurname: {1}\n", Name, Surname);
        }
        public string Represent()
        {
            string author = Name + ' ' + Surname;
            return author;
        }
    }
    public class Album
    {
        public string Name;
        public int Year;

        public Album()
        {
            Name = "Unknown";
            Year = 0;
            Console.WriteLine("Title: {0}\nYear: {1}\n", Name, Year);
        }
        public Album(string name, int year)
        {
            Name = name;
            Year = year;
            Console.WriteLine("Title: {0}\nYear: {1}\n", Name, year);
        }
        public string Represent()
        {
            string album = Name + " Year: " + Year.ToString();
            return album;
        }
    }
    public class Song
    {
        public string Name, Gener;
        public int Year;
        public Compositor Author, Author1, Author2;
        public Album Album;
        public Song()
        {
            Name = "Unknown";
            Gener = "Unknown";
            Year = 0;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\n", Name, Gener, "Неизвесто");
        }
        public Song(string name, string gener, int year)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\n", Name, Gener, Year);
        }
        public Song(string name, string gener, int year, Compositor author)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author = author;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\nAuthor: {3}\n", Name, Gener, Year, Author.Represent());

        }
        public Song(string name, string gener, int year, Compositor author1, Compositor author2)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author1 = author1;
            Author2 = author2;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\nAuthors: {3}, {4}\n", Name, Gener, Year, Author1.Represent(), Author2.Represent());

        }
        public Song(string name, string gener, int year, Compositor author, Compositor author1, Compositor author2)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author = author;
            Author1 = author1;
            Author2 = author2;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\nAuthors: {3}, {4}, {5}\n", Name, Gener, Year, Author.Represent(), Author1.Represent(), Author2.Represent());

        }
        public Song(string name, string gener, int year, Album album)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Album = album;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\nAlbum: {3}\n", Name, Gener, Year, Album.Represent()); ;
        }
        public Song(string name, string gener, int year, Compositor author, Album album)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author = author;
            Album = album;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\nAuthor: {3}\nAlbum: {4}\n", Name, Gener, Year, Author.Represent(), Album.Represent());

        }
        public Song(string name, string gener, int year, Compositor author1, Compositor author2, Album album)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author1 = author1;
            Author2 = author2;
            Album = album;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\nAuthors: {3}, {4}\nAlbum: {5}\n", Name, Gener, Year, Author1.Represent(), Author2.Represent(), Album.Represent());

        }
        public Song(string name, string gener, int year, Compositor author, Compositor author1, Compositor author2, Album album)
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author = author;
            Author1 = author1;
            Author2 = author2;
            Album = album;
            Console.WriteLine("Title: {0}\nGenre: {1}\nYear: {2}\nAuthors: {3}, {4}, {5}\nAlbum: {6}\n", Name, Gener, Year, Author.Represent(), Author1.Represent(), Author2.Represent(), Album.Represent());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Compositor glass_animals = new Compositor("Glass", "Animals");
            Compositor tame_impala = new Compositor("Tame", "Impala");
            Compositor nirvana = new Compositor("Nirvana", "");
            Compositor benny_sings = new Compositor("Benny", "Sings");
            Album dreamland = new Album("Dreamlend", 2020);
            Song tangerine = new Song("Tangerine", "Indie", 2020, glass_animals, tame_impala, benny_sings, dreamland);
            Song polly = new Song("Polly", "Grunge", 1990, nirvana);

            Console.ReadKey();
        }
    }
}
