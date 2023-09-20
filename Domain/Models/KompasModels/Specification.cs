using SpcConverter.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpcConverter.Domain.Models.KompasModels
{
    /// <summary>
    /// Класс-представление спецификации формата СПО "Компас 3D".
    /// </summary>
    internal class Specification
    {
        public string FileName { get; private set; }

        public List<SpecificationSubsection> Subsections { get; set; }

        public Specification(string fileName)
        {
            this.FileName = fileName;
        }

        public class SpecificationSubsection
        {
            public string RefDes { get; private set; }

            public string Type { get; private set; }

            public List<SpecificationRow> Rows { get; private set; }

            public SpecificationSubsection(string refDes, List<SpecificationRow> rows)
            {
                this.RefDes = refDes;
                this.Rows = rows;
            }

            public List<SpecificationRow> AsRowList(Table table)
            {
                List<SpecificationRow> rows = new List<SpecificationRow>();

                rows.Add(new SpecificationRow());
                rows.Add(new SpecificationRow(table.GetSubsectionNameByRefDes(RefDes)));
                rows.Add(new SpecificationRow());

                foreach (SpecificationRow row in Rows.OrderBy(u => u.Name))
                    rows.Add(row);

                return rows;
            }
        }

        public class SpecificationRow
        {
            public string Format { get; set; } = "";

            public string Zone { get; set; } = "";

            public string Position { get; set; } = "";

            public string Mark { get; set; } = "";

            public string Name { get; set; } = "";

            public decimal Quantity { get; set; } = 0;

            public string Comment { get; set; } = "";

            public string Type { get; set; } = "";

            public SpecificationRow() { }

            public SpecificationRow(string Name) { this.Name = Name; }

        }
    }
}
