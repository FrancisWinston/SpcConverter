using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpcConverter.Domain.Models.Common
{
    internal class Table
    {
        public List<List<string>> listTable { get; private set; }

        public Table(List<List<string>> listTable)
        {
            this.listTable = listTable;
        }

        public string GetSubsectionNameByRefDes(string refDes)
        {
            for (int i = 0; i < listTable.Count; i++)
                if (listTable[i][1] == refDes) return listTable[i][0];

            return "?";
        }

        public int GetSubsectionByRefDes(string refDes)
        {
            for (int i = 0; i < listTable.Count; i++)
                if (listTable[i][1] == refDes) return Convert.ToInt32(listTable[i][2]);

            return 200;
        }


        public int GetSectionByRefDes(string refDes)
        {
            for (int i = 0; i < listTable.Count; i++)
                if (listTable[i][1] == refDes) return Convert.ToInt32(listTable[i][3]);

            return 30;
        }

    }
}
