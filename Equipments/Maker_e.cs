using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reader
{
    internal class Maker_e
    {
        public static Maker CreateExcelEntity(SpreadsheetDocument document, Row row)
        {
            string Code = GetCellValue(document, GetCell(row, 0));
            string Name = GetCellValue(document, GetCell(row, 1));
            string Adress = GetCellValue(document, GetCell(row, 2));

            return new Maker(Code, Name, Adress);
        }
        private static Cell GetCell(Row row, int index)
        {
            return row.Elements<Cell>().ElementAtOrDefault(index);
        }

        private static string GetCellValue(SpreadsheetDocument document, Cell c)
        {
            if (c == null)
            {
                return null;
            }

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
