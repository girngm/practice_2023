using System;
using System.Collections.Generic;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Linq;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace reader
{
    class Program
    {
        static void Main()
        {
            // 11 винда не поддерживает команду
            //Console.BufferHeight = 32766;

            Console.Write("Введите имя файла: ");
            string namefile = Console.ReadLine();

            string filePath = namefile;

            List<Maker> excelEntities_Maker = new List<Maker>();
            List<ECN> excelEntities_ECN = new List<ECN>();
            List<Motor> excelEntities_Motor = new List<Motor>();
            List<SHVN_Nasos> excelEntities_SHVN_Nasos = new List<SHVN_Nasos>();

            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(filePath, false))
            {
                WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
                WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();

                SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();
                foreach (Row r in sheetData.Elements<Row>())
                {
                    if (namefile == "Maker.xlsx")
                    {
                        Maker excelEntity = Maker_e.CreateExcelEntity(spreadsheetDocument, r);
                        excelEntities_Maker.Add(excelEntity);
                    }
                    else if (namefile == "ECN.xlsx")
                    {
                        ECN excelEntity = ECN_e.CreateExcelEntity(spreadsheetDocument, r);
                        excelEntities_ECN.Add(excelEntity);
                    }
                    else if (namefile == "Motor.xlsx")
                    {
                        Motor excelEntity = Motor_e.CreateExcelEntity(spreadsheetDocument, r);
                        excelEntities_Motor.Add(excelEntity);
                    }
                    else if (namefile == "SHVN_Nasos.xlsx")
                    {
                        SHVN_Nasos excelEntity = SHVN_Nasos_e.CreateExcelEntity(spreadsheetDocument, r);
                        excelEntities_SHVN_Nasos.Add(excelEntity);
                    }

                }
            }

            if (namefile == "Maker.xlsx")
            {
                foreach (var entity in excelEntities_Maker)
                {
                    Console.WriteLine(entity);
                }
            }
            else if (namefile == "ECN.xlsx")
            {
                foreach (var entity in excelEntities_ECN)
                {
                    Console.WriteLine(entity);
                }
            }
            else if (namefile == "Motor.xlsx")
            {
                foreach (var entity in excelEntities_Motor)
                {
                    Console.WriteLine(entity);
                }
            }
            else if (namefile == "SHVN_Nasos.xlsx")
            {
                foreach (var entity in excelEntities_SHVN_Nasos)
                {
                    Console.WriteLine(entity);
                }
            }
        }
    }
}