using FirstProgram;

namespace Inlämningsuppgift1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Arv
            Building building = new Building();
            building.typeOfBuilding = "Hus";
            building.Leave();

            Apartment apartment = new Apartment();
            apartment.typeOfBuilding = "lägenhet";
            apartment.Leave();


            /*------------------------------------------------*/

            //Polymorfism
            Dog dog = new Dog();
            dog.Name = "Leya";
            dog.bark();

            Chihuahua chihuahua = new Chihuahua();
            chihuahua.Name = "Thomas";
            chihuahua.bark();


            /*------------------------------------------------*/

            //Inkapsling
            Patient patient = new Patient("Johan");
            Console.WriteLine("Patientens namn är " + patient.getPatientName() + ", och är säkert.");


            /*------------------------------------------------*/

            //Abstraktion
            Bike bike = new Bike();
            bike.Ride();


            Console.ReadLine();
        }
    }
}
