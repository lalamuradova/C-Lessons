using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OOP
            //        Tapşırıq: C#-da İnheritance istifadə edərək Nəqliyyat Vasitələri Sistemi Qurun
            //Şərtlər:
            //Əsas sinif(Vehicle) yaradın:

            //            Aşağıdakı property-ləri(public) saxlasın:
            //Brand(string) – nəqliyyat vasitəsinin markası
            //Model(string) – nəqliyyat vasitəsinin modeli
            //Year(int) – istehsal ili
            //ShowInfo() metodunu yazın, hansı ki, bu məlumatları ekranda göstərsin.
            //İki fərqli sinif (Car və Motorcycle) yaradın və Vehicle sinifindən miras alsınlar:

            //Car sinifi
            //NumberOfDoors(int) property-sini əlavə edin(qapıların sayı).
            //ShowCarInfo() metodu olsun, ShowInfo() metodunu çağıraraq əlavə məlumatı çap etsin.
            //Motorcycle sinifi
            //HasSidecar (bool) property-sini əlavə edin (sahib olduğu yan qoşqu).
            //ShowMotorcycleInfo() metodu olsun, ShowInfo() metodunu çağıraraq əlavə məlumatı çap etsin.
            //Main metodunda obyektlər yaradın və məlumatlarını çap edin:

            //Bir Car və bir Motorcycle obyekti yaradın, onlara müxtəlif dəyərlər təyin edin.
            //Hər iki obyektin məlumatlarını konsolda çap edin.
            //Müəyyən məhdudiyyətlər tətbiq edin:

            Car car = new Car("Toyota", "Carolla", 2014, 4);
            car.ShowCarInfo();

            Console.WriteLine();

            Motorcycle myMotorcycle = new Motorcycle("Harley-Davidson", "Sportster", 2023,true);
            myMotorcycle.ShowMotorcycleInfo();


            #endregion
        }
    }
}
