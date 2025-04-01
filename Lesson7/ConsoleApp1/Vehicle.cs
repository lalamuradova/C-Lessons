using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //        Tapşırıq: C#-da İnheritance istifadə edərək Nəqliyyat Vasitələri Sistemi Qurun
    //Şərtlər:
    //Əsas sinif(Vehicle) yaradın:

    //            Aşağıdakı property-ləri(public) saxlasın:
    //Brand(string) – nəqliyyat vasitəsinin markası
    //Model(string) – nəqliyyat vasitəsinin modeli
    //Year(int) – istehsal ili
    //ShowInfo() metodunu yazın, hansı ki, bu məlumatları ekranda göstərsin.
    //İki fərqli sinif (Car və Motorcycle) yaradın və Vehicle sinifindən miras alsınlar:





    //Vehicle sinifindən birbaşa obyekt yaratmaq mümkün olmamalıdır.
    //ShowInfo() metodu Vehicle sinifində dəyişdirilmədən qalmalıdır.
    //Car və Motorcycle siniflərində yalnız özlərinə məxsus metodlar yazılmalıdır, override istifadə edilməməlidir.

    abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Year: " + Year);
        }

    }

    //Car sinifi
    //NumberOfDoors(int) property-sini əlavə edin(qapıların sayı).
    //ShowCarInfo() metodu olsun, ShowInfo() metodunu çağıraraq əlavə məlumatı çap etsin.

    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, string model, int year, int numberOfDoors) : base(brand, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }
        public void ShowCarInfo()
        {
            ShowInfo();
            Console.WriteLine("Number of Doors: " + NumberOfDoors);
        }

    }

    //Motorcycle sinifi
    //HasSidecar (bool) property-sini əlavə edin (sahib olduğu yan qoşqu).
    //ShowMotorcycleInfo() metodu olsun, ShowInfo() metodunu çağıraraq əlavə məlumatı çap etsin.
    class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string brand, string model, int year, bool hasSidecar) : base(brand, model, year)
        {
            HasSidecar = hasSidecar;
        }

        public void ShowMotorcycleInfo()
        {
            ShowInfo();
            Console.WriteLine("Has Side Car: " + HasSidecar);
        }

    }

}
