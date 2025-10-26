using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternExample1
{
    internal class Program
    {
        // Subsystem classes
        public class DVDPlayer
        {
            public void On() => Console.WriteLine("DVD Player ON");
            public void Play(string movie) => Console.WriteLine($"Playing movie: {movie}");
            public void Off() => Console.WriteLine("DVD Player OFF");
        }
    
        public class Projector
        {
            public void On() => Console.WriteLine("Projector ON");
            public void SetInput(string source)
            {
                Console.WriteLine($"Projector input set to {source}");
            }
            public void Off() => Console.WriteLine("Projector OFF");
        }
              
        public class SoundSystem
        {
            public void On() => Console.WriteLine("Sound System ON");
            public void SetVolume(int level) => Console.WriteLine($"Volume set to {level}");
            public void Off() => Console.WriteLine("Sound System OFF");
        }

       public class HomeTheaterFacade
        {
            private DVDPlayer dvd;
            private Projector projector;
            private SoundSystem sound;
            public HomeTheaterFacade(DVDPlayer dvd, Projector projector, SoundSystem sound)
            {
                this.dvd = dvd;
                this.projector = projector;
                this.sound = sound;
            }
            public void WatchMovie(string movie)
            {
                Console.WriteLine("\n--- Starting Movie ---");
                projector.On();
                projector.SetInput("DVD");
                sound.On();
                sound.SetVolume(10);
                dvd.On();
                dvd.Play(movie);
            }
            public void EndMovie()
            {
                Console.WriteLine("\n--- Shutting Down Theater ---");
                dvd.Off();
                sound.Off();
                projector.Off();
            }
        }
        static void Main(string[] args)
        {
            DVDPlayer dvd = new DVDPlayer();
            Projector projector = new Projector();
            SoundSystem sound = new SoundSystem();
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(dvd, projector, sound);

            homeTheater.WatchMovie("Inception");
            homeTheater.EndMovie();



        }
    }
}
