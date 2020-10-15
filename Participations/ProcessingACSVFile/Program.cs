using System;
using System.Collections.Generic;
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
            double jan = 0;
            double feb = 0;
            double mar = 0;
            double apr = 0;
            double may = 0;
            double jun = 0;
            double jul = 0;
            double aug = 0;
            double sep = 0;
            double oct = 0;
            double nov = 0;
            double dec = 0;

            //Dictionary<string, double> monthSums = new Dictionary<string, double>();
            List<double> monthValues = new List<double>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // 13 0's even tho there are 12 months.  This means index 0 is not for any month

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                // Looks like this:
                //10107,30,95.7,2,2871,2/24/2003 0:00,Shipped,1,2,2003,Motorcycles,95,S10_1678,Land of Toys Inc.,2125557818,897 Long Airport Avenue,,NYC,NY,10022,USA,NA,Yu,Kwai,Small
                string[] pieces = line.Split(",");
                double sale = Convert.ToDouble(pieces[4]);
                string year = pieces[9];
                //sum = sum + Convert.ToDouble(pieces[4]);
                string month = pieces[8];

                monthValues[Convert.ToInt32(month)] += sale;

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



                    //  Dictionary stuff below
                    //if (monthSums.ContainsKey(month))
                    //{
                    //    monthSums[month] += sale;
                    //}
                    //else
                    //{
                    //    monthSums.Add(month, sale);
                    //}

                    //switch (month)
                    //{
                    //    case "1":
                    //        jan += sale;
                    //        break;
                    //    case "2":
                    //        feb += sale;
                    //        break;
                    //    case "3":
                    //        mar += sale;
                    //        break;
                    //    case "4":
                    //        apr += sale;
                    //        break;
                    //    case "5":
                    //        may += sale;
                    //        break;
                    //    case "6":
                    //        jun += sale;
                    //        break;
                    //    case "7":
                    //        jul += sale;
                    //        break;
                    //    case "8":
                    //        aug += sale;
                    //        break;
                    //    case "9":
                    //        sep += sale;
                    //        break;
                    //    case "10":
                    //        oct += sale;
                    //        break;
                    //    case "11":
                    //        nov += sale;
                    //        break;
                    //    case "12":
                    //        dec += sale;
                    //        break;
                    //    default:
                    //        break;
                    //}


                    sum += sale; 
                }

            }

            Console.WriteLine($"The total sales for shipped items in 2003 is {sumFor2003.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in 2004 is {sumFor2004.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in 2005 is {sumFor2005.ToString("C")}!");

            for (int i = 1; i < monthValues.Count; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine($"The total sales for shipped items in January is {monthValues[i].ToString("C")}");
                        break;
                    case 2:

                    default:
                        break;
                }
            }

            //Dictionary stuff below
            //foreach (var month in monthSums.Keys)
            //{
            //    switch (month)
            //    {
            //        case "1":
            //            Console.WriteLine($"The total sales for January is {monthSums[month].ToString("C")}");
            //            break;
            //        case "2":
            //            feb += sale;
            //            break;
            //        case "3":
            //            mar += sale;
            //            break;
            //        case "4":
            //            apr += sale;
            //            break;
            //        case "5":
            //            may += sale;
            //            break;
            //        case "6":
            //            jun += sale;
            //            break;
            //        case "7":
            //            jul += sale;
            //            break;
            //        case "8":
            //            aug += sale;
            //            break;
            //        case "9":
            //            sep += sale;
            //            break;
            //        case "10":
            //            oct += sale;
            //            break;
            //        case "11":
            //            nov += sale;
            //            break;
            //        case "12":
            //            dec += sale;
            //            break;
            //        default:
            //            break;
            //    }
            //}

            Console.WriteLine($"The total sales for shipped items in January is {jan.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in February is {feb.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in January is {jan.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in January is {jan.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in January is {jan.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in January is {jan.ToString("C")}!");
            Console.WriteLine($"The total sales for shipped items in January is {jan.ToString("C")}!");

            Console.WriteLine($"Total sales of shipped orders is {sum.ToString("C2")}.");

            Console.ReadKey();
        }

    }
}
