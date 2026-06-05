namespace PatientLibrary

{
    public class Patient
    {
        private string name;
        private int age;
        private string gender;
        private string medicalHistory;
        private string symptomCode;
        private string prescription;

        public string GetName()
        {
            return name;
        }
        public bool SetName(string value,out string errorMessage)
        {
            errorMessage = "";
            if (string.IsNullOrEmpty(value) || value.Length < 2)
            {
                errorMessage = "invalid name";
                return false;
            }
            name= value;
            return true;

        }

        public int GetAge()
        {
            return age;
        }
        public bool SetAge(int value, out string errorMessage)
        {
            errorMessage = "";
            if (value < 0 || value > 100)
            {
                errorMessage = "Invalid age";
                return false;
            }
            age = value;
            return true;
        }

        public string GetGender()
        {
            return gender;
        }
        public bool SetGender(string value, out string errorMessage)
        {
            errorMessage = "";
            if (value!="Male"&&value!="Female"&&value!="Other")
            {
                errorMessage = "invalid gender";
                return false;
            }
            gender = value;
            return true;

        }


        public string GetMedicalHistory()
        {
            return medicalHistory;
        }

        public void SetMedicalHistory(string value)
        {
            medicalHistory = value;
        }

        public bool SetSymptomCode(string value, out string errorMessage)
        {
            errorMessage = "";

            value = value.ToUpper();

            if (value != "S1" &&
                value != "S2" &&
                value != "S3")
            {
                errorMessage = "Invalid Symptom Code";
                return false;
            }

            symptomCode = value;
            return true;
        }

        public string GetSymptoms()
        {
            switch (symptomCode.ToUpper())
            {
                case "S1":
                    return "Headache";

                case "S2":
                    return "Skin rashes";

                case "S3":
                    return "Dizziness";

                default:
                    return "Unknown";
            }
        }

        public string GetPrescription()
        {
            return prescription;
        }

        public void SetPrescription(string value)
        {
            prescription = value;
        }
    }
}