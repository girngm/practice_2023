using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reader
{
    internal class SHVN_Nasos_e
    {
        public static SHVN_Nasos CreateExcelEntity(SpreadsheetDocument document, Row row)
        {
            string Name = GetCellValue(document, GetCellAtIndex(row, 0));
            string q100 = GetCellValue(document, GetCellAtIndex(row, 1));
            string H = GetCellValue(document, GetCellAtIndex(row, 2));
            string Dgabarit = GetCellValue(document, GetCellAtIndex(row, 3));
            string d = GetCellValue(document, GetCellAtIndex(row, 4));
            string L = GetCellValue(document, GetCellAtIndex(row, 5));
            string Nju = GetCellValue(document, GetCellAtIndex(row, 6));
            string Hopt = GetCellValue(document, GetCellAtIndex(row, 7));
            string Freq = GetCellValue(document, GetCellAtIndex(row, 8));
            string Maker = GetCellValue(document, GetCellAtIndex(row, 9));
            return new SHVN_Nasos(Name, q100, H, Dgabarit, d, L, Nju, Hopt, Freq, Maker);
        }

        private static Cell GetCellAtIndex(Row row, int index)
        {
            // Проверяем, что индекс находится в пределах допустимого диапазона
            if (index < row.Elements<Cell>().Count())
            {
                return row.Elements<Cell>().ElementAt(index);
            }
            else
            {
                // Возвращаем фиктивную ячейку или обрабатываем выход за пределы диапазона по необходимости
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
