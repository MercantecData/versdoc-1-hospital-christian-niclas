using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHospital
{
    class Hospital
    {
        public string name;
        //List that is used to create patients
        public List<Patient> patients = new List<Patient>();
        //List that is used to create doctors
        public List<Doctor> doctors = new List<Doctor>();

        public Hospital(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Tages user inputs fropm AdmitTo(); and adds them to patients list to create a new person
        /// </summary>
        /// <param name="patient"></param>
        public void AdmitPatient(Patient patient)
        {
            if(patients.Contains(patient))
            {
                Console.WriteLine("Patient already admitted to {0}.", name);
            } else
            {
                patients.Add(patient);
                Console.WriteLine("{0} was admitted to {1} successfully", patient.name, name);
            }
        }
        /// <summary>
        /// Remove patient from patients list
        /// </summary>
        /// <param name="patient"></param>
        public void DischargePatient(Patient patient)
        {
            if(!patients.Contains(patient))
            {
                Console.WriteLine("Patient not in this hospital");
            } else
            {
                patients.Remove(patient);
                Console.WriteLine("Patient removed");
            }
        }
        /// <summary>
        /// Finds patient from list with user input
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Patient FindPatientByName(string name)
        {
            foreach(var p in patients)
            {
                if(p.name == name)
                {
                    return p;
                }
            }

            return null;
        }
        /// <summary>
        /// Finds all patients on the patients list
        /// </summary>
        public void PatientList()
        {
            foreach(Patient apatients in patients)
            {
                Console.WriteLine(apatients.name + " " + apatients.age);
            }
        }        /// <summary>
        /// Finds all doctors on the doctors list 
        /// </summary>
        public void DoctorList()
        {
            foreach (Doctor adoctors in doctors)
            {
                Console.WriteLine(adoctors.name + " " + adoctors.speciality);
            }
        }
        /// <summary>
        /// Set a patient to a doctor using 2 user inputs
        /// </summary>
        /// <param name="dname"></param>
        /// <param name="patient"></param>
        public void Together(string dname, Patient patient)
        {
            foreach(Doctor d in doctors)
            {
                if(d.name == dname)
                {
                    Console.WriteLine("Found Doctor");
                    d.assignedPatients.Add(patient);
                }
            }
        }
    }
}
