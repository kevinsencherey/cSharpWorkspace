using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PostCodeValidation
{
    public class PostCodeValidation
    {
        public int PostCodeValidator(string postCode)
        {
            //string validationExpression = "(GIR 0AA)|" +
            //        "((([A-PR-UWYZ][0-9][0-9]?)|" +
            //        "(([A-PR-UWYZ][A-HK-Y][0-9](?<!(BR|FY|HA|HD|HG|HR|HS|HX|JE|LD|SM|SR|WC|WN|ZE)[0-9])[0-9])|" +
            //        "([A-PR-UWYZ][A-HK-Y](?<!AB|LL|SO)[0-9])|" +
            //        "(WC[0-9][A-Z])|" +
            //        "(([A-PR-UWYZ][0-9][A-HJKPSTUW])|" +
            //        "([A-PR-UWYZ][A-HK-Y][0-9][ABEHMNPRVWXY]))))" +
            //        "[0-9][ABD-HJLNP-UW-Z]{2})";

            string validationExpression = "^([A-PR-UWYZ0-9][A-HK-Y0-9][AEHMNPRTVXY0-9]?[ABEHMNPRVWXY0-9]? {1,2}[0-9][ABD-HJLN-UW-Z]{2}|GIR 0AA)";

                if (Regex.IsMatch(postCode, validationExpression))
                {
                    Console.WriteLine(postCode + ": Valid");
                    return 0;
                }
                else
                {
                    Console.WriteLine(postCode + ": Invalid");
                    return 1;
                }
        }

        public void PostCodeBulkImportValidator()
        {
            string path = @"C:\Users\kevin.sencherey\CSharpworkspace\PostCodeValidation\PostCodeValidation";
            var reader = new StreamReader(File.OpenRead(path + @"\import_data.csv"));
            var writerFailed = new StreamWriter(File.OpenWrite(path + @"\failed_validation.csv"));
            var writerSucceeded = new StreamWriter(File.OpenWrite(path + @"\succeeded_validation.csv"));
            writerSucceeded.WriteLine("row_id,postcode");
            writerFailed.WriteLine("row_id,postcode");
            
            List<string> listOfRowIds = new List<string>();
            List<string> listOfPostCodes = new List<string>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                listOfRowIds.Add(values[0]);
                listOfPostCodes.Add(values[1]);
            }

            for (int i = 1; i <= listOfRowIds.Count()-1; i++)
            {
                if (PostCodeValidator(listOfPostCodes[i]) == 0)
                {
                    writerSucceeded.WriteLine(listOfRowIds[i]+","+listOfPostCodes[i]);
                }
                else
                {
                    writerFailed.WriteLine(listOfRowIds[i] + "," + listOfPostCodes[i]);
                }
            }

            writerSucceeded.Close();
            writerFailed.Close();
        }

        public void CSVSorter()
        {
            string[] csvToRead = 
            {
                @"C:\Users\kevin.sencherey\CSharpworkspace\PostCodeValidation\PostCodeValidation\failed_validation.csv",
                @"C:\Users\kevin.sencherey\CSharpworkspace\PostCodeValidation\PostCodeValidation\succeeded_validation.csv"
            };

            for (int i = 0; i <= csvToRead.Count()-1; i++)
            {
                string[] lines = File.ReadAllLines(csvToRead[i]);
                var data = lines.Skip(1);
                var sorted = data.Select(line => new
                {
                    SortKey = Int32.Parse(line.Split(',')[0]),
                    Line = line
                })
                            .OrderBy(x => x.SortKey)
                            .Select(x => x.Line);
                File.WriteAllLines(csvToRead[i], lines.Take(1).Concat(sorted));
            }     
        }
    }
}
