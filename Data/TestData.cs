using Microsoft.VisualBasic.FileIO;
using System.Reflection;

namespace BlazorInfraTest.Data
{
    public class TestData
    {
        private string csvData = "0";
        public TestData()
        {
            //var assemblyLoc = Assembly.Location;
            //var outPutDirectory = Path.GetDirectoryName();
            //var iconPath = Path.Combine(outPutDirectory, "Data\\TestData.csv");
            //string icon_path = new Uri(iconPath).LocalPath;

            string pathToIcoFile = AppDomain.CurrentDomain.BaseDirectory + "//Data//TestData.csv";
            //var path = @".\TestData.csv"; // Habeeb, "Dubai Media City, Dubai"
            using (TextFieldParser csvParser = new TextFieldParser(pathToIcoFile))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;
                csvData = csvParser.ReadToEnd();
                // Skip the row with the column names
                /*csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    string Colors = fields[0];
                    string Address = fields[1];
                }
                */
            }

        }
        public string GetData()
        {
            return csvData;
        }
    }
}
