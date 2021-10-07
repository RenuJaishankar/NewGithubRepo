using System;
using System.Collections.Generic;

namespace finalProject
{
    public class TaxCalculator
    {
        public string stateCode { get; set; }
        public string stateName { get; set; }
        public int floor { get; set; }
        public int ceiling { get; set; }

        double taxRate { get; set; }

        public TaxCalculator(string csv)
        {
            string[] data = csv.Split(',');
            stateCode = data[0];
            stateName = data[1];
            floor = int.Parse(data[2]);
            ceiling = int.Parse(data[3]);
            taxRate = double.Parse(data[4]);
            //if (!incomeAmt >= data[1]) { }
            //throw new Exception($"The amount taxed should be greater than or equal to data[1]");
        
            // if (!incomeAmt< data[2]) { 
            //   throw new Exception($"The amount taxed should not be less than  data[2]");
            //}
       }

        
        public TaxCalculator(string stateCode,string stateName,int floor,int ceiling,double taxRate)
        {
            this.stateCode = stateCode;
            this.stateName = stateName;
            this.floor = floor;
            this.ceiling = ceiling;
            this.taxRate = taxRate;
        }

        static decimal ComputeTaxFor(string stateAbr, double incomeAmt)
        {
            return 0;
        }
        static void Main(string[] args)
        {
            //This section reads the data from the file.
            System.IO.TextReader reader = System.IO.File.OpenText("taxtable.csv");
            string line;

            Dictionary<string, List<TaxCalculator>> allData = new Dictionary<string, List<TaxCalculator>>();

            List<TaxCalculator>taxData = new List<TaxCalculator>();
            while (!string.IsNullOrWhiteSpace(reader.ReadLine())){
                line = reader.ReadLine();
                string[] b = line.Split(",");
                string id = b[0];
                try
                {
                    
                    allData.Add(id,new List<TaxCalculator>());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message); 
                }
               
            }
            reader.Close();
            //for(int i = 0; i < taxData.Count; i++)
            //{
            //    Console.WriteLine(taxData[i]);
            //}
            //ComputeTaxFor that accepts two values, a state abbreviation, and an income amount earned.The method should compute the tax due and return the tax as a decimal.
            //Console.WriteLine("Enter the State Abbreviation");
            //string abr;
            //double  inc;
            //Console.ReadLine(abr);
            //Console.WriteLine("Enter the Employee's income Amount ");
            //Console.ReadLine(inc);
            //for (int i = 0; i < taxData.Count; i++)
            //{
            //    ComputeTaxFor(abr, inc);
            //}
               
                
           



        }
    }
}
