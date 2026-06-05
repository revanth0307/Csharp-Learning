using PatientLibrary;

namespace MedicalBotLibrary
{
    public class MedicalBot
    {
        public const string BotName = "Bob";
       public static string GetBotName()
        {
           return BotName;
        }
        public void PrescribeMedication(Patient patient)
        {
            string medicine="";

            string symtom = patient.GetSymptoms().ToLower();
            if (symtom =="headache")
            {
                medicine = "ibuprofen";
            }
            else if(symtom=="skin rashes")
            {
                medicine = "diphenhydramine";
            }
            else if(symtom== "dizziness")
            {
                if (patient.GetMedicalHistory().ToLower().Contains("diabetes")) 
                { 
                    medicine = "metformin";
                }
                else
                {
                    medicine = "dimenhydrinate";
                }
            }
            string dosage=GetDosage(medicine);
            patient.SetPrescription(medicine + " " + dosage);

            string GetDosage(string medicineName)
            {
                int age = patient.GetAge();
                switch (medicineName)
                {
                    case "ibuprofen":
                        return age < 18 ? "400mg" : "800mg";
                    case "diphenhydramine":
                        return age < 18 ? "50mg" : "300mg";
                    case "dimenhydrinate":
                        return age < 18 ? "50mg" : "400mg";
                    case "metformin":
                        return "500mg";

                    default:return "";
                }
            }

        }
    }
}
