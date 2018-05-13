using System;


namespace ReaderDocument
{
    class Program
    {
        static void Main(string[] args)
        {

            var fileName = "";
            var xlsx = new ExcelReader().Reader(fileName);
            var csv = new CsvReader().Reader(fileName);
        }
    }
}
