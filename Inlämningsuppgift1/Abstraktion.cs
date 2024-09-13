namespace FirstProgram
{
    //Abstract sätter regler som alla som ärver måste följa
    public abstract class Vehicle {

        // Alla som ärver ifrån den här klassen måste använda Brake
        public abstract void Ride();
    
    }

    public class Bike : Vehicle
    {
        public override void Ride()
        {
            Console.WriteLine("Du åker fort!");
        }
    }
}
