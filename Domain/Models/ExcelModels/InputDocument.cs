using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpcConverter.Domain.Models.ExcelModels
{
    internal class InputDocument
    {
        Dictionary<string, Row> rows;

        public InputDocument()
        {
            rows = new Dictionary<string, Row>();
        }

        public void AddRow(Row row)
        {
            rows.Add(row.PartNumberFrom1C, row);
        }

        public List<Row> AsRowList()
        {
            return rows.Values.ToList();
        }

        public bool ContainsName(string name)
        {
            return rows.ContainsKey(name);
        }

        public void AddToQuantity(string name, decimal quantity)
        {
            rows[name].Quantity += quantity;
        }

        public class Row
        {
            public string OrderCode = "";

            public string TypeFrom1C = "";

            public string Manufacturer = "";

            public string PartNumberFrom1C = "";

            public string Comment = "";

            public decimal Quantity = 0;

            public string Des = "";

            public override string ToString()
            {
                return $"|\t {OrderCode} |\t {TypeFrom1C} |\t {Manufacturer} |\t {PartNumberFrom1C} |\t {Comment} |\t {Quantity} |\t {Des} |";
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Row row in rows.Values)
            {
                sb.Append(row.ToString());
            }
            return sb.ToString();
        }
    }
}
