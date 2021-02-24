//VuongChiHieu F2 ИУ6-71Б Part 2
using System;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Music
{
    public class Compositor
    {
        public string Name { get; set; }
        public string Surname { get; set; }

    }
    public class Album
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
    public class Song
    {
        public string Name { get; set; }
        public string Gener { get; set; }
        public int Year { get; set; }
        public Compositor[] Authors { get; set; }
        public Album Album_s { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Compositor daft_punk = new Compositor
            {
                Name = "Daft",
                Surname = "Punt"

            };
            Compositor pharrell_williams = new Compositor
            {
                Name = "Pharrell",
                Surname = "Williams"

            };
            Album ram = new Album
            {
                Name = "Random Access Memories",
                Year = 2013,
            };
            Song LFL = new Song
            {
                Name = "Get Lucky",
                Year = 2013,
                Gener = "Funk",
                Authors = new Compositor[] { daft_punk, pharrell_williams },
                Album_s = ram

            };


            string json = JsonSerializer.Serialize<Song>(LFL);
            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}