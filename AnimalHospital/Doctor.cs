using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalHospital
{
    class Doctor
    {
        public string name;
        public string speciality;
        public List<Patient> assignedPatients = new List<Patient>();
        /// <summary>
        /// Constructor used to create doctor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="speciality"></param>
        public Doctor(string name, string speciality)
        {
            this.name = name;
            this.speciality = speciality;
        }
    }
}
