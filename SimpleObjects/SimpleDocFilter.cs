using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Sbis.SimpleObjects
{
    public class SimpleDocFilter
    {
        public SimpleDocFilter()
        {
            Тип = "ДоговорДок";
        }

        public string ДатаС { get; set; }
        public string ДатаПо { get; set; }
        public string Тип { get; set; }
        public string Направление { get; set; }
        public string Состояние { get; set; }
        //контрагент
        public string Email { get; set; }
        public string ИдентификаторИС { get; set; }
        public string ИдентификаторСПП { get; set; }
        public string Телефон { get; set; }
        //контрагент СвЮл/СвФл
        public string ИНН { get; set; }
    }
}
