namespace FirstProgram
{

    //Inkapsling handlar om att dölja känslig data
    public class Patient
    {
        //Här är private attributer som vi döljer
        private string patientName;
        //Här är en konstruktor som sätter datan på ett säkert sätt
        public Patient(string patientName)
        {
            Name = patientName;
        }

        public string Name
        {
            get { return patientName; }
            set { patientName = value; }
        }

        //För att kunna nå vår data så kallar vi på en publik funktion
        public string getPatientName()
        {
            return patientName;
        }
    }
}
