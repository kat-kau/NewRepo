using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace VIN_LIB
{
    public class Class1
    {
        public bool CheckVIN(string vin)  //Примеры VIN c правильным девятым знаком, где сходится контрольная сумма: JS1GN7DA362110088, KNEFE222855188892
        {
            string pattern = @"^[A-HJ-NPR-Z\d]{13}\d{4}$";

            if ((Regex.IsMatch(vin, pattern)))
            {
                string vinHash = vin.Replace('A', '1').Replace('B', '2').Replace('C', '3').Replace('D', '4').Replace('E', '5').Replace('F', '6').Replace('G', '7').Replace('H', '8').Replace('J', '1').Replace('K', '2').Replace('L', '3').Replace('M', '4').Replace('N', '5').Replace('P', '7').Replace('R', '9').Replace('S', '2').Replace('T', '3').Replace('U', '4').Replace('V', '5').Replace('W', '6').Replace('X', '7').Replace('Y', '8').Replace('Z', '9');
                char nineNumberChar = ' ';

                int[] position = { 8, 7, 6, 5, 4, 3, 2, 10, 0, 9, 8, 7, 6, 5, 4, 3, 2 };

                char[] vinHashNumChar = vinHash.ToCharArray();
                int[] vinHashNumInt = Array.ConvertAll(vinHashNumChar, c => (int)Char.GetNumericValue(c));

                int nineNumber = 0;
                bool vinHashBool = false;

                for (int i = 0; i <= 16; i++)
                {
                    nineNumber = nineNumber + vinHashNumInt[i] * position[i];
                }

                nineNumber = nineNumber % 11;


                if (nineNumber < 10)
                {
                    nineNumberChar = Convert.ToChar(nineNumber.ToString());
                }
                else if (nineNumber == 10)
                {
                    nineNumberChar = 'X';
                }

                char[] vinNum = vin.ToCharArray();

                if (vinNum[8] == nineNumberChar)
                {
                    vinHashBool = true;
                }

                if (vinHashBool) {
                    return true;
                } else return false;

            }
            else return false;

            

            
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
