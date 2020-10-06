using System;
using System.IO;

namespace ProcessingACSVFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filePath = @"C:\Users\acke9387\Downloads\sales_data_sample.csv";
            string filePath = @"sales_data_sample.csv";

            string[] lines = File.ReadAllLines(filePath);

            //ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE
            /*
             * Sales = 4
             * Status = 6
             * Month = 8
             * Year = 9  
             */
            double sum = 0;
            double sumFor2003 = 0;
            double sumFor2004 = 0;
            double sumFor2005 = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                double sale = Convert.ToDouble(pieces[4]);
                string year = pieces[9];
                //sum = sum + Convert.ToDouble(pieces[4]);
                if (pieces[6].Trim().ToLower() == "shipped")
                {
                    if (year == "2003")
                    {
                        sumFor2003 += sale;
                    }
                    else if (year == "2004")
                    {
                        sumFor2004 += sale;
                    }
                    else
                    {
                        sumFor2005 += sale;
                    }

                    sum += sale; 
                }

            }

            Console.WriteLine($"The total sales for shipped items in 2003 is {sumFor2003.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in 2004 is {sumFor2004.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in 2005 is {sumFor2005.ToString("C")}!");

            Console.WriteLine($"Total sales of shipped orders is {sum.ToString("C2")}.");

            Console.ReadKey();
        }
    }
}
