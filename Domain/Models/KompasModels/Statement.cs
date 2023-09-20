using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpcConverter.Domain.Models.KompasModels
{
    /// <summary>
    /// Класс-представление ведомости покупных изделий формата СПО "Компас 3D".
    /// </summary>
    internal class Statement
    {
        public string Наименование { get; set; } = "";
        public string ОбозначениеДокумента { get; set; } = "";
        public string Поставщик { get; set; } = "";
        public string ТипИзделия { get; set; } = "";

        public List<string[]> Вхождения;

        public Statement(string Наименование, string ОбозначениеДокумента, string Поставщик, string ТипИзделия, List<string[]> Вхождения)
        {
            this.Наименование = Наименование;
            this.ОбозначениеДокумента = ОбозначениеДокумента;
            this.Поставщик = Поставщик;
            this.ТипИзделия = ТипИзделия;
            this.Вхождения = Вхождения;
        }

        void Sort()
        {
            List<string[]> basic = Вхождения.Where(x => x[0].Split('-').Length == 1).ToList();

            List<string[]> notBasic = Вхождения.Where(x => x[0].Split('-').Length > 1).ToList();
            notBasic = notBasic.OrderBy(x => x[0]).ToList();

            for (int i = 0; i < notBasic.Count; i++)
            {
                if (!basic.Select(x => x[0]).Contains(notBasic[i][0].Split('-')[0]))
                {
                    basic.Add(notBasic[i]);
                    notBasic.RemoveAt(i);
                    i--;
                }
            }
            basic = basic.OrderBy(x => x[0]).ToList();


            foreach (string[] s in notBasic)
            {
                for (int i = basic.Count - 1; i >= 0; i--)
                {
                    string s1 = basic[i][0].Split('-')[0];
                    string s2 = s[0].Split('-')[0];
                    if (s1.Equals(s2))
                    {
                        basic.Insert(i + 1, s);
                        break;
                    }
                }

            }

            this.Вхождения = basic;
        }

        public List<СтрокаВедомости> ToStringsList()
        {
            List<СтрокаВедомости> output = new List<СтрокаВедомости>();

            this.Sort();

            decimal sum = 0;
            for (int i = 0; i < this.Вхождения.Count; i++)
            {
                СтрокаВедомости current = new СтрокаВедомости();
                if (i == 0)
                {
                    current.Наименование = Наименование;
                    current.ОбозначениеДокумента = ОбозначениеДокумента;
                    current.Поставщик = Поставщик;
                    current.ТипИзделия = ТипИзделия;
                }
                current.КудаВходит = Вхождения[i][0];
                current.КоличествоНаИзделие = Вхождения[i][1];
                current.КоличествоВКомплекты = Вхождения[i][2];
                current.КоличествоНаРегулировку = Вхождения[i][3];
                current.КоличествоВсего = Вхождения[i][4];
                sum += Convert.ToDecimal(current.КоличествоВсего);
                output.Add(current);
            }

            if (Вхождения.Count > 1)
            {
                СтрокаВедомости summaryRow = new СтрокаВедомости();
                summaryRow.КоличествоВсего = sum.ToString();
                output.Add(summaryRow);
            }

            return output;
        }

        public class СтрокаВедомости
        {
            public string Наименование { get; set; } = "";
            public string ОбозначениеДокумента { get; set; } = "";
            public string Поставщик { get; set; } = "";
            public string КудаВходит { get; set; } = "";
            public string КоличествоНаИзделие { get; set; } = "";
            public string КоличествоВКомплекты { get; set; } = "";
            public string КоличествоНаРегулировку { get; set; } = "";
            public string КоличествоВсего { get; set; } = "";
            public string ТипИзделия { get; set; } = "";
        }
    }
}
