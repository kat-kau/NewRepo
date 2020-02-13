using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class Class1
    {
        public bool CheckVIN(string vin)
        {
            string pattern = @"^[A-HJ-NPR-Z\d]{13}\d{4}$";

            string vinHash = vin.Replace('A','1').Replace('B','2').Replace('C','3').Replace('D', '4').Replace('E', '5').Replace('F', '6').Replace('G', '7').Replace('H', '8').Replace('J', '1').Replace('K', '2').Replace('L', '3').Replace('M', '4').Replace('N', '5').Replace('P', '7').Replace('R', '9').Replace('S', '2').Replace('T', '3').Replace('U', '4').Replace('V', '5').Replace('W', '6').Replace('X', '7').Replace('Y', '8').Replace('Z', '9');

            // vinHash = string.Join("", vinHash.Select(x => x + " "));

            int[] position = { };
            int[] vinHashNum = Array.ConvertAll(vinHash.Split(), int.Parse);

            int nineNumber;
            for (int i = 0; i <= vinHashNum.Length; i++)
            {
                nineNumber = vinHashNum[i] 
            }

            if (Regex.IsMatch(vin, pattern))
            {
                return true;
            } else return false;
        }

        public string GetVINCountry(string vin)
        {
            string Country = "";
            return Country;
        }


        public int GetTransportYear(string vin)
        {
            int year = 0;
            return year;
        }
    }
}
