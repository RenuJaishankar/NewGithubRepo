using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class EmployeeRecord
    {
        string ID { get; set; }
        string Name { get; set; }
        string stateCode { get; set; }
        int numberOfHrs { get; set; }
        double hourlyRate { get; set; }
        double tax { get; set; }
        public EmployeeRecord(string ID, string Name, string stateCode, int numberOfHrs, double hourlyRate)
        {
            this.ID = ID;
            this.Name = Name;
            this.stateCode = stateCode;
            this.numberOfHrs = numberOfHrs;
            this.hourlyRate = hourlyRate;
            
        }
        public EmployeeRecord(string csv)
        {
            string[] data = csv.Split(",");
            TaxCalculator T = new TaxCalculator();
            TaxCalculator.ComputeTaxFor(data[0], data[3] * data[4]);
        }
        public static void main(string[] args)
        {
            System.IO.TextReader reader = System.IO.File.OpenText("employees.csv");
            string line;
            List<finalProject.EmployeeRecord> employeedata = new List<finalProject.EmployeeRecord>();
            while (!string.IsNullOrWhiteSpace(reader.ReadLine()))
            {
                
                line = reader.ReadLine();
                try
                {
                    employeedata.Add(new EmployeeRecord(line));
                }
                catch(Exception ex){
                    Console.WriteLine(ex.Message);
                }
            }


        }

    }
}
