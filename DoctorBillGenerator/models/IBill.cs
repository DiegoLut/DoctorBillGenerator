using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorBillGenerator.models
{
    internal interface IBill
    {
        int Id { get; set; }
        string Doctor { get; set; }
        string Patient { get; set; }
        decimal Price { get; set; }
        DateTime Date { get; set; }

        void PrintBill();
    }
}
