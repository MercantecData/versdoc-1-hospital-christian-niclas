using System;
using System.Dynamic;

namespace AnimalHospital
{
    class Program
    {
        //Makes it possible to call functions and list from Hospital.cs
        public static Hospital hospital;
         
        static void Main(string[] args)
        {
            //Tags data from InitializeHospital(); and send it to Hospital constructor
            hospital = InitializeHospital();
            //runs MainMenu(); on repeat
            while (MainMenu()) {}

            Console.WriteLine("Goodbye!");
        }
        /// <summary>
        /// All user options is create her
        /// </summary>
        /// <returns></returns>
        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to {0}. You have the following options:", hospital.name);
            Console.WriteLine("1. Admit a patient to the hospital");
            Console.WriteLine("2. Discharge a patient");
            Console.WriteLine("3. See a list of all patients in the hospital");
            Console.WriteLine("4. See a list of all doctors in the hospital");
            Console.WriteLine("5. Assign a specific doctor to a specific patient");
            Console.WriteLine("0. Quit the Program");
            Console.WriteLine();

            //Var is the option the use choice 
            var k = Console.ReadKey().KeyChar;
            if(k == '1')
            {
                AdmitPatient();
            } 
            else if(k == '2')
            {
                Console.WriteLine(" ");
                Console.WriteLine("Patient name: ");
                CheckoutPatient();
            } 
            else if(k == '3')
            {
                Console.WriteLine(" ");
                ListPatients();
            }
            else if (k == '4')
            {
                Console.WriteLine(" ");
                ListDoctors();
            }
            else if (k == '5')
            {
                Fahk();
            }
            else if (k == '0')
            {
                return false;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return true;
        }
        /// <summary>
        /// Prints out all the doctors found in DoctorList();
        /// </summary>
        static void ListDoctors()
        {
            hospital.DoctorList();
        }
        /// <summary>
        /// Prints out all the patients found in PatientsList();
        /// </summary>
        static void ListPatients()
        {
            hospital.PatientList();
        }
        /// <summary>
        /// Tages 2 user inputs and insert them into Together();
        /// </summary>
        static void Fahk()
        {
            Console.WriteLine("Doctors name:");
            string doctorname = Console.ReadLine();
            Console.WriteLine("Patient name:");
            string patientname = Console.ReadLine();
            hospital.Together(doctorname, hospital.FindPatientByName(patientname));
        }
        /// <summary>
        /// Tages a user input and inserts it into DischargePatient();
        /// </summary>
        static void CheckoutPatient()
        {
            string patientname = Console.ReadLine();
            hospital.DischargePatient(hospital.FindPatientByName(patientname));
        }
        /// <summary>
        /// Tages 2 user inputs and inserts them into AdmitTo();
        /// </summary>
        static void AdmitPatient()
        {
            string name;
            int age;

            Console.WriteLine("What is the patients name?");
            name = Console.ReadLine();

            Console.WriteLine("What is the patients age?");
            while(!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("You must write a number, try again");
            }

            new Patient(name, age).AdmitTo(hospital);
        }
        /// <summary>
        /// Creates 4 doctors and adds them to doctors list
        /// </summary>
        /// <returns></returns>
        static Hospital InitializeHospital()
        {
            Hospital hospital = new Hospital("Animal Hospital");

            hospital.doctors.AddRange(new Doctor[]
            {
                new Doctor("Matt Tennant", "Spinal Injury"),
                new Doctor("David Smith", "Knee Injury"),
                new Doctor("Jodie Tyler", "Oncology"),
                new Doctor("Rose Whitaker", "Intensive Care")
            });

            return hospital;
        }
    }
}
