namespace FirstProgram
{
    //Polymorphism example
    public class Dog
    {
        //We need virtual  so that we can OVERRIDE or WRITE OVER

        public string Name;
        public string Colour;

        //Virtual gör så att vi kan ändra en existerande metod när någon klass äver metoden.
        public virtual void bark()
        {
            Console.WriteLine(Name + " släppte ut ett högt skäll.");
        }
    }

    //Vi ärver ifrån Dog
    public class Chihuahua : Dog
    {           
        //Vi överskriver bark metoden så att den passar den nya klassen.
        public override void bark()
        {
            Console.WriteLine(Name + " släppte ut ett högt men ljust skäll. Hur en hund så liten kan låta så högt är en bra fråga.");
        }
    }

}