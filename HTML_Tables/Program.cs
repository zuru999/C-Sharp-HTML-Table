using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HTML_Tables
{
    class Program : Base
    {

      
        public static void Main(string[] args)
        {

            Driver = new FirefoxDriver();

            //Driver.Navigate().GoToUrl(@"C:\C#\Automatyzacja\HTML_Tables\HtmlTable.html");
            Driver.Navigate().GoToUrl("file:///c:/C%23/Automatyzacja/HTML_Tables/HtmlTable.html");

            Console.Clear();
            Console.WriteLine("Dane z tabeli HTML");


            TablePage page = new TablePage();

            //read the table
            Utilities.ReadTable(page.table);

            //get tuhe cell value from the table
            Console.WriteLine("************************************************************************");

            Console.WriteLine("The name {0} with email {1} and phone {2} ",
            Utilities.ReadCell("Name", 2), Utilities.ReadCell("Email", 2), Utilities.ReadCell("Phone", 2));
            //Utilities.ReadCell("Name", 3), Utilities.ReadCell("Email", 3), Utilities.ReadCell("Phone", 3));

            Console.WriteLine("************************************************************************");
            Console.Read();


        }
    }
}
