using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHospital
{
    class Patient
    {
        public string name;
        public int age;
        public Doctor doctor;

        public Patient(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        /// <summary>
        /// Sends 2 user input to AdmitPatient();
        /// </summary>
        /// <param name="hospital"></param>
        public void AdmitTo(Hospital hospital)
        {
            hospital.AdmitPatient(this);
        }
    }
}
