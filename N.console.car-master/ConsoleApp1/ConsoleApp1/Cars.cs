using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ncars
{
    class Car
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal MaxFuel { get; set; }
        public decimal FuelEff { get; set; }
        public decimal CurrentFuel { get; set; }
        public decimal GlobalKm { get; set; }
        public decimal LocalKm { get; set; }


        public Car(string Marka,string Model,decimal MaxFuel,decimal FuelEff,decimal CurrentFuel=60)
        {
            this.Marka = Marka;
            this.Model = Model;
            this.MaxFuel = MaxFuel;
            this.FuelEff = FuelEff;
            this.CurrentFuel = CurrentFuel;
        }
        public void Go()
        {
            Console.WriteLine("How to km want to go ");
            string neededKm=Console.ReadLine();
            if (Utilities.IsNumber(neededKm))
            {
                decimal neededKMDecimal = Convert.ToDecimal(neededKm);
                if (CurrentFuel >= neededKMDecimal * FuelEff / 100)
                {
                    CurrentFuel -= neededKMDecimal * FuelEff / 100;
                    Console.WriteLine($"siz {neededKm} qeder yol getdiniz.\n Hal hazirda {CurrentFuel}lt benzin qalib");
                    LocalKm += neededKMDecimal;
                    GlobalKm += neededKMDecimal;
                }
                else
                {
                    Console.WriteLine("Please Top Up");
                }
            }
            else
            {
                Console.WriteLine("Please write only numeric number");
            }
        }

        public void TopUp()
        {
            Console.WriteLine("How much lt want to fuel");
            string neededFuel = Console.ReadLine();
            if(Utilities.IsNumber(neededFuel))
            {
                decimal neededFuelDec = Convert.ToDecimal(neededFuel);
                if(MaxFuel<=neededFuelDec+CurrentFuel)
                {
                    CurrentFuel += neededFuelDec;
                    Console.Clear();
                    Console.WriteLine($"{neededFuel}lt successfully filled with fuel \n");
                }
                else
                {
                    Console.WriteLine("Gozun Doysun");
                }
            }
        }

        public void Reset()
        {
            LocalKm = 0;
            Console.WriteLine("Local km reset");
        }

        public void Stop()
        {
            Console.WriteLine($"Local km {LocalKm}. GlobalKm {GlobalKm}");
        }
    }
}
