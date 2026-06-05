using MedicalBotLibrary;
using PatientLibrary;
class Program
{
    static void Main()
    {
        Patient patient = new Patient();
        MedicalBot bot = new MedicalBot();

        string errorMessage;

        Console.WriteLine($"Hi, I'm {MedicalBot.GetBotName()}. I'm here to help you in your medication.\n");

        Console.WriteLine("Enter your (patient) details:\n");

        Console.Write("Enter Patient Name: ");
        patient.SetName(Console.ReadLine(), out errorMessage);

        Console.Write("Enter Patient Age: ");
        patient.SetAge(Convert.ToInt32(Console.ReadLine()), out errorMessage);

        Console.Write("Enter Patient Gender: ");
        patient.SetGender(Console.ReadLine(), out errorMessage);

        Console.Write("Enter Medical History. Eg: Diabetes. Press Enter for None: ");
        patient.SetMedicalHistory(Console.ReadLine());

        Console.WriteLine($"\nWelcome, {patient.GetName()}, {patient.GetAge()}.");

        Console.WriteLine("\nWhich of the following symptoms do you have:");
        Console.WriteLine("S1. Headache");
        Console.WriteLine("S2. Skin rashes");
        Console.WriteLine("S3. Dizziness");

        Console.Write("\nEnter the symptom code from above list (S1, S2 or S3): ");

        patient.SetSymptomCode(Console.ReadLine(), out errorMessage);

        bot.PrescribeMedication(patient);

        Console.WriteLine("\nYour prescription based on your age, symptoms and medical history:\n");

        Console.WriteLine(patient.GetPrescription());

        Console.WriteLine("\nThank you for coming.");

        Console.ReadKey();
    }
}