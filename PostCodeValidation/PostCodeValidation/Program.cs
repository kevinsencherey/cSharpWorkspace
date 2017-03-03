using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PostCodeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            PostCodeValidation postCodeValidation = new PostCodeValidation();

            string[] postCodes = {  "$%± ()()",
                                    "XX XXX",
                                    "A1 9A",
                                    "LS44PL",
                                    "Q1A 9AA",
                                    "V1A 9AA",
                                    "X1A 9BB",
                                    "LI10 3QP",
                                    "LJ10 3QP",
                                    "LZ10 3QP",
                                    "A9Q 9AA",
                                    "AA9C 9AA",
                                    "FY10 4PL",
                                    "SO1 4QQ",
                                    "EC1A 1BB",
                                    "W1A 0AX",
                                    "M1 1AE",
                                    "B33 8TH",
                                    "CR2 6XH",
                                    "DN55 1PT",
                                    "GIR 0AA",
                                    "SO10 9AA",
                                    "FY9 9AA",
                                    "WC1A 9AA"};

            foreach (var postCode in postCodes)
            {
                postCodeValidation.PostCodeValidator(postCode);
            }
            Console.ReadLine();

            //postCodeValidation.PostCodeBulkImportValidator();
            //postCodeValidation.CSVSorter();
        }
    }
}