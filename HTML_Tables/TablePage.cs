using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace HTML_Tables
{
    public class TablePage : Base
    {

        public TablePage()
        {
            PageFactory.InitElements(Driver, this);
        }



        [FindsBy(How = How.XPath, Using = "//table")]               //identyfikacja tabeli
        public IWebElement table {get; set; }


    }
}
