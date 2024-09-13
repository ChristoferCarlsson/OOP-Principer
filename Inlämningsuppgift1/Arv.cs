namespace FirstProgram
{
    //Arv är när en klass kan ärva olika attributer, och metoder ifrån en annan klass.
    public class Building
    {
        //Olika attributer som klassen har
        public string Colour;
        public int Size;
        public string typeOfBuilding;

        //En metod som klassen har och kan använda
        public void UnlockDoor()
        {
            Console.WriteLine("Dörren till din/ditt " + typeOfBuilding + " är upplåst!");
        }

        public void Leave()
        {
            Console.WriteLine("Du lämnade din/ditt " + typeOfBuilding + ", låste dörren och gick.");
        }
    }

    // Apartment ärver ifrån Building klassen.
    public class Apartment : Building
    {
        public string Stairway;

        public void Leave()
        {
            Console.WriteLine("Du lämnade din " + typeOfBuilding + ", låste dörren och hälsade på dina grannar.");
        }
    }



}

//Här gör vi inherit exempel, där en class kan ärva saker ifrån en annan klass.
