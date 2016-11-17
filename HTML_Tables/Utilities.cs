using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace HTML_Tables
{
    public class Utilities
    {

        static List<TableDataCollection> _tableDataCollections = new List<TableDataCollection>();        //odczytuje dane z tabeli i zapisuje je w datacollection (lista)


        public static void ReadTable(IWebElement table)                    
        {
            
            //Get the data from the table

            var columns = table.FindElements(By.TagName("th"));     // zwraca listę kolumn

            // Get all the rows

            var rows = table.FindElements(By.TagName("tr"));         // zwraca listę wierszy

            //create row index

            var rowIndex = 0;

            foreach(var row in rows)
            {
                int colIndex = 0;

                var colDatas = row.FindElements(By.TagName("td"));    //zwraca dane z wierszy


                foreach (var colValue in colDatas)
                {
                    _tableDataCollections.Add(new TableDataCollection
                    {
                        RowNumber = rowIndex,
                        ColumnlName = columns[colIndex].Text,
                        ColumnlValue = colValue.Text
                    });

                    //Move to next column

                    colIndex++;

                    
                }
                rowIndex++;
            }


        }
        public static string  ReadCell(string columnName, int rowNumber)                                          //odczytywanie komórki
        {
            var data = (from e in _tableDataCollections
                       where e.ColumnlName == columnName && e.RowNumber == rowNumber
                       select e.ColumnlValue).SingleOrDefault();

            return data;




        }
    }


    public class TableDataCollection
    {
        public int RowNumber { get ; set; }
        public string ColumnlName { get; set; }
        public string ColumnlValue { get; set; }
    }


}
