using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMD db = new CMD();
            db.Database.Log = Console.WriteLine;
            Appointment appointment = new Appointment();
            Patient p1 = new Patient
            {
                FirstName = "Patient1",
            };
            Doctor d1 = new Doctor { FirstName = "D1" };
            db.Patients.Add(p1);
            db.Doctors.Add(d1);
            appointment.Doctor = d1;
            appointment.Patient = p1;
            appointment.AppointmentDate = DateTime.Now;
            appointment.AppointmentTime = DateTime.Now.TimeOfDay;
            db.Appointments.Add(appointment);
            db.SaveChanges();

        }
    }
}
