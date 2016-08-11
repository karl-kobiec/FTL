using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQ6.Core;
namespace FTL
{
    public static class FTLConst
    {
        public const int InvoiceEmailTemplateId = 1;
        public const int InvoiceDocumentTemplateId = 2;
    }
    public static class FTLExtensions
    {
        public static bool FTLCheckDate(this DateTime SDate)
        {
            if (SDate.Year < 2000)
            {
                IQApp.CR.MessageBoxOK("Please check the date you have entered. There should be no dates before the year 2000.");
                return false;
            }
            return true;
        }

    
        public static string FTLGetNextLetter(int JobNo)
        {
            string SQL = "SELECT Max(JobLLineLetter) AS Last FROM JobLine WHERE JobLJobNo=" + JobNo;
            string v1 = IQApp.DB.GetString(SQL);
            if (v1 == "Z")
            {
                SQL = "SELECT Max(JobLLineLetter) AS Last FROM JobLine WHERE Len(JobLLineLetter)=2 AND JobLJobNo=" + JobNo;
                string s = IQApp.DB.GetString(SQL);
                if (s != "") v1 = s;
            }
            switch (v1)
            {
                case "A":
                    return "B";
                case "B":
                    return "C";
                case "C":
                    return "D";
                case "D":
                    return "E";
                case "E":
                    return "F";
                case "F":
                    return "G";
                case "G":
                    return "H";
                case "H":
                    return "I";
                case "I":
                    return "J";
                case "J":
                    return "K";
                case "K":
                    return "L";
                case "L":
                    return "M";
                case "M":
                    return "N";
                case "N":
                    return "O";
                case "O":
                    return "P";
                case "P":
                    return "Q";
                case "Q":
                    return "R";
                case "R":
                    return "S";
                case "S":
                    return "T";
                case "T":
                    return "U";
                case "U":
                    return "V";
                case "V":
                    return "W";
                case "W":
                    return "X";
                case "X":
                    return "Y";
                case "Y":
                    return "Z";
                case "Z":
                    return "AA";
                case "AA":
                    return "AB";
                case "AB":
                    return "AC";
                case "AC":
                    return "AD";
                case "AD":
                    return "AE";
                case "AE":
                    return "AF";
                case "AF":
                    return "AG";
                case "AG":
                    return "AH";
                case "AH":
                    return "AI";
                case "AI":
                    return "AJ";
                case "AJ":
                    return "AK";
                case "AK":
                    return "AL";
                case "AL":
                    return "AM";
                case "AM":
                    return "AN";
                case "AN":
                    return "AO";
                case "AO":
                    return "AP";
                case "AP":
                    return "AQ";
                case "AQ":
                    return "AR";
                case "AR":
                    return "AS";
                case "AS":
                    return "AT";
                case "AT":
                    return "AU";
                case "AU":
                    return "AV";
                case "AV":
                    return "AW";
                case "AW":
                    return "AX";
                case "AX":
                    return "AY";
                case "AY":
                    return "AZ";
                default:
                    return "A";

            }
        }
    }
}