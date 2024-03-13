using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DoctorBillGenerator.models
{
    internal class DentistBill : IBill
    {
        public int Id { get; set; }
        public string Doctor { get; set; }
        public string Patient { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public int TeethForDrilling { get; set; }
        public int TeethForExtraction { get; set; }


        public DentistBill(int id, string doctor, string patient, decimal price, DateTime date, int teethForDrilling, int teethForExtraction) 
        {
            Id = id;
            Doctor = doctor;
            Patient = patient;
            Price = price;
            Date = date;
            TeethForDrilling = teethForDrilling;
            TeethForExtraction = teethForExtraction;
        }
        public void PrintBill()
        {
            //Implementacja wydruku faktury dla lekarza dęytysty
            Console.WriteLine($"Faktura dla pacjenta {Patient} wystawiona przez lekarza {Doctor} na kwotę {Price} zł.");
        }
    }
}
