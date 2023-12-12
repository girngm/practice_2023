using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reader
{
    internal class ECN_e
    {
        public static ECN CreateExcelEntity(SpreadsheetDocument document, Row row)
        {
            string ID = GetCellValue(document, row.Elements<Cell>().ElementAt(0));
            string N = GetCellValue(document, row.Elements<Cell>().ElementAt(1));
            string H = GetCellValue(document, row.Elements<Cell>().ElementAt(2));
            string L = GetCellValue(document, row.Elements<Cell>().ElementAt(3));

            return new ECN(ID, N, H, L);
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
