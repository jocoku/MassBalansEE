using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MassBalans.screens.outputScreens
{
    class excelOutput
    {
        public void Export_to_POS ()
        {
            excelFilePath = System.IO.Path.Combine(Environment.CurrentDirectory, @"database\POS_Template.xls");
            MessageBox.Show(System.IO.Directory.GetCurrentDirectory() + "\n" + excelFilePath);
            openExcel();
        }

        private string excelFilePath = string.Empty;
        private int rowNumber = 1; // define first row number to enter data in excel

        Excel.Application myExcelApplication;
        Excel.Workbook myExcelWorkbook;
        Excel.Worksheet myExcelWorkSheet;

        public string ExcelFilePath
        {
            get { return excelFilePath; }
            set { excelFilePath = value; }
        }

        public int Rownumber
        {
            get { return rowNumber; }
            set { rowNumber = value; }
        }

        public void openExcel()
        {
            myExcelApplication = null;

            myExcelApplication = new Excel.Application(); // create Excell App
            myExcelApplication.DisplayAlerts = false; // turn off alerts


            myExcelWorkbook = (Excel.Workbook)(myExcelApplication.Workbooks._Open(excelFilePath, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
               System.Reflection.Missing.Value, System.Reflection.Missing.Value)); // open the existing excel file

            myExcelWorkSheet = (Excel.Worksheet)myExcelWorkbook.Worksheets[1]; // define in which worksheet, do you want to add data
            MessageBox.Show(myExcelWorkSheet.Name);

            try
            {
                _ = myExcelWorkSheet.OLEObjects();

            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            



            /*
             * Public Class CheckboxReader
                    Dim xlApp As Excel.Application = Nothing
                    Dim xlWorkBooks As Excel.Workbooks = Nothing
                    Dim xlWorkBook As Excel.Workbook = Nothing
                    Dim xlWorkSheet As Excel.Worksheet = Nothing

                    Public Sub New(ByVal excelFilename As String, ByVal worksheetName As String)
                        xlApp = New Excel.Application
                        xlApp.DisplayAlerts = False
                        xlWorkBooks = xlApp.Workbooks
                        xlWorkBook = xlWorkBooks.Open(excelFilename)
                        For Each worksheet As Excel.Worksheet In xlWorkBook.Worksheets
                            If worksheet.Name = worksheetName Then
                                xlWorkSheet = worksheet
                                Exit For
                            End If
                        Next
                    End Sub

                    Public Function GetCheckBoxValue(ByVal Name As String) As Boolean
                        Dim found As Boolean = False
                        Dim result As Boolean = False
                        If Not found Then
                            result = xlWorkSheet.OLEObjects(Name).Object.Value()
                            found = True
                        End If
                        Return result
                    End Function
                End Class
             */
        }

        public void addDataToExcel(string firstname, string lastname, string language, string email, string company)
        {

            myExcelWorkSheet.Cells[rowNumber, "H"] = firstname;
            myExcelWorkSheet.Cells[rowNumber, "J"] = lastname;
            myExcelWorkSheet.Cells[rowNumber, "Q"] = language;
            myExcelWorkSheet.Cells[rowNumber, "BH"] = email;
            myExcelWorkSheet.Cells[rowNumber, "CH"] = company;
            rowNumber++;  // if you put this method inside a loop, you should increase rownumber by one or wat ever is your logic

        }

        public void closeExcel()
        {
            try
            {
                myExcelWorkbook.SaveAs(excelFilePath, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value, Excel.XlSaveAsAccessMode.xlNoChange,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value); // Save data in excel


                myExcelWorkbook.Close(true, excelFilePath, System.Reflection.Missing.Value); // close the worksheet


            }
            finally
            {
                if (myExcelApplication != null)
                {
                    myExcelApplication.Quit(); // close the excel application
                }
            }

        }
    }
}

