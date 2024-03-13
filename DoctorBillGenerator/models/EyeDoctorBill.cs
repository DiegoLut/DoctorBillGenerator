using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorBillGenerator.models
{
    public class EyeDoctorBill : IBill
    {
        public int Id { get; set; }
        public string Doctor { get; set; }
        public string Patient { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string VisionImpairmentLevel { get; set; }
        public string CorrectionGlasses { get; set; }

        public EyeDoctorBill(int id, string doctor, string patient, decimal price, DateTime date, string visionImpairmentLevel, string correctionGlasses)
        {
            Id = id;
            Doctor = doctor;
            Patient = patient;
            Price = price;
            Date = date;
            VisionImpairmentLevel = visionImpairmentLevel;
            CorrectionGlasses = correctionGlasses;
        }

        public void PrintBill()
        {
            // Implementacja wydruku faktury dla lekarza okulisty
            Console.WriteLine($"Faktura dla pacjenta {Patient} wystawiona przez lekarza {Doctor} na kwotę {Price} zł.");
        }
    }
}
