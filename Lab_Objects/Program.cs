using System;

namespace Lab_Objects
{
    class Program
    {
        public void Main(string[] args)
        {
            SunglassStore sunglassHouse = new SunglassStore();

            Lenses lense = new Lenses(Lenses.Style.mirrored);

            Sunglasses sunglasses1 = new Sunglasses(lense);

            sunglassHouse.AddSunglasses(sunglasses1);

            Sunglasses customerSunglasses = sunglassHouse.Stock[0];

            Lenses custSunLenses = customerSunglasses.Lense;

            Console.WriteLine(custSunLenses.Lense);

        }
    }
}