using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Device> devices = new List<Device>();
            devices.Add(new WashingMachine());
            devices.Add(new VacuumCleaner());

            foreach (var item in devices)
            {
                var temp = item.GetStatus();
                Console.WriteLine(temp);
            }
            

            Television television = new Television();
            television.TurnOn();
            television.SetChannel(72);
            television.SetVolume(67);
            Console.WriteLine(television.GetStatus());
        }
    }

    public class Device
    {
        public void wyswietl(string wiadomosc)
        {
            Console.WriteLine(wiadomosc);
        }

        public virtual string GetStatus()
        {
            return "Urządzenie jest w stanie nieznanym";
        }
    }

    public class WashingMachine : Device
    {
        private int numerProgramu = 0;

        public int ustawProgram(int numer)
        {
            if (numerProgramu >= 1 && numerProgramu <= 12) numerProgramu = numer;
            else numerProgramu = 0;
            return numerProgramu;
        }
        public override string GetStatus()
        {
            return $"Pralka ma ustawiony program numer: {numerProgramu}";
        }
    }

    public class VacuumCleaner : Device
    {

        private bool VacuumCleanerOn = false;
        public void TurnOn()
        {
            if (!VacuumCleanerOn)
            {
                VacuumCleanerOn = true;
                wyswietl("Odkurzacz włączono");
            }
        }

        public override string GetStatus()
        {
            return VacuumCleanerOn ? "Odkurzacz jest włączony": "Odkurzcz jest wyłączony";
        }
    }
    public class Television : Device
    {
        private bool TelevisionOn = false;
        private int CurrentChannel;
        private int CurrentVolume;

        public void TurnOn()
        {
            if (!TelevisionOn) 
            {
                TelevisionOn = true;
                Console.WriteLine("Telewizor włączony.");
            }
        }
        public void SetChannel(int numer)
        {
            CurrentChannel = numer;
            Console.WriteLine($"Kanał ustawiony na {CurrentChannel}");
        }
        public void SetVolume(int numer)
        {
            CurrentVolume = numer;
            Console.WriteLine($"Głośność ustawiona na {CurrentVolume}");
        }
        public override string GetStatus()
        {
            return TelevisionOn? $"Telewizor jest na kanale {CurrentChannel}, a głośność jest na poziomie {CurrentVolume}." : "Telewizor jest wyłączony.";
        }
    }
}
