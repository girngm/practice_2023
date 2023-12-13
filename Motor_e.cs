using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reader
{
    internal class Motor_e
    {
        public static Motor CreateExcelEntity(SpreadsheetDocument document, Row row)
        {
            string TYPE = GetCellValue(document, GetCellAtIndex(row, 0));
            string U = GetCellValue(document, GetCellAtIndex(row, 1));
            string N = GetCellValue(document, GetCellAtIndex(row, 2));
            string I = GetCellValue(document, GetCellAtIndex(row, 3));
            string nju = GetCellValue(document, GetCellAtIndex(row, 4));
            string Cos = GetCellValue(document, GetCellAtIndex(row, 5));
            string Slide = GetCellValue(document, GetCellAtIndex(row, 6));
            string L = GetCellValue(document, GetCellAtIndex(row, 7));
            string Omega = GetCellValue(document, GetCellAtIndex(row, 8));
            string T = GetCellValue(document, GetCellAtIndex(row, 9));
            string Polus = GetCellValue(document, GetCellAtIndex(row, 10));
            string Freq = GetCellValue(document, GetCellAtIndex(row, 11));
            string d = GetCellValue(document, GetCellAtIndex(row, 12));
            string w = GetCellValue(document, GetCellAtIndex(row, 13));
            string Maker = GetCellValue(document, GetCellAtIndex(row, 14));
            return new Motor(TYPE, U, N, I, nju, Cos, Slide, L, Omega, T, Polus, Freq, d, w, Maker);
        }

        private static Cell GetCellAtIndex(Row row, int index)
        {
            if (index < row.Elements<Cell>().Count())
            {
                return row.Elements<Cell>().ElementAt(index);
            }
            else
            {
                return new Cell();
            }
        }
        private static string GetCellValue(SpreadsheetDocument document, Cell c)
        {
            SharedStringTablePart sharedStringPart = document.WorkbookPart.SharedStringTablePart;

            if (c.DataType != null && c.DataType.Value == CellValues.SharedString)
            {
                int index = int.Parse(c.InnerText);
                return sharedStringPart.SharedStringTable.Elements<SharedStringItem>().ElementAt(index).InnerText;
            }
            else
            {
                return c.InnerText;
            }
        }
    }
}
