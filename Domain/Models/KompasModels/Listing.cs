using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpcConverter.Domain.Models.KompasModels
{
    /// <summary>
    /// Класс-представление перечня покупных изделий формата СПО "Компас 3D".
    /// </summary>
    internal class Listing
    {
        public string FileName { get; private set; }

        public List<ListingSubsection> Subsections { get; set; }

        public Listing(string fileName)
        {
            this.FileName = fileName;
            this.Subsections = new List<ListingSubsection>();
        }

        public void Print()
        {
            foreach (ListingSubsection s in Subsections)
            {
                var c = s.AsRowList();
                foreach (var x in c)
                {
                    Console.WriteLine(x.ToString());
                }
            }
        }

        public class ListingSubsection
        {
            public string Type { get; private set; }
            public List<ListingRow> Rows { get; private set; }

            public ListingSubsection(string type, List<ListingRow> rows)
            {
                this.Type = type;
                this.Rows = rows;
            }

            public List<ListingRow> AsRowList()
            {
                List<ListingRow> rows = new List<ListingRow>();

                rows.Add(new ListingRow());
                rows.Add(new ListingRow(Type));
                rows.Add(new ListingRow());

                foreach (ListingRow row in Rows)
                {
                    rows.Add(row);
                    rows.Add(new ListingRow());
                }


                return rows;
            }
        }

        public class ListingRow
        {
            public string Format { get; set; } = "";

            public string Zone { get; set; } = "";

            public string Position { get; set; } = "";

            public string Mark { get; set; } = "";

            public string Name { get; set; } = "";

            public decimal Quantity { get; set; } = 0;

            public string Comment { get; set; } = "";

            public string Type { get; set; } = "";

            public ListingRow() { }

            public ListingRow(string Name) { this.Name = Name; }

            public override string ToString()
            {
                return $"{Type} {Name} {Quantity}";
            }
        }
    }
}
