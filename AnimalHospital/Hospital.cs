using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHospital
{
    class Hospital
    {
        public string name;

        public List<Patient> patients = new List<Patient>();
        public List<Doctor> doctors = new List<Doctor>();

        public Hospital(string name)
        {
            this.name = name;
        }

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

        public void PatientList()
        {
            foreach(Patient apatients in patients)
            {
                Console.WriteLine(apatients.name + " " + apatients.age);
            }
        }
        public void DoctorList()
        {
            foreach (Doctor adoctors in doctors)
            {
                Console.WriteLine(adoctors.name + " " + adoctors.speciality);
            }
        }

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
