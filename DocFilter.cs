using static SBISLib.DocumentClasses.DocObject;

namespace SBISLib.DocumentClasses
{
    public class DocFilter
    {
        public string ДатаС { get; set; }
        public string ДатаПо { get; set; }
        public string Тип { get; set; }
        public string Направление { get; set; }
        public string Состояние { get; set; }
        public string Маска { get; set; }
        public Нашаорганизация НашаОрганизация { get; set; }
        public Контрагент Контрагент { get; set; }
        public Подразделение Подразделение { get; set; }
        public Ответственный Ответственный { get; set; }
        public Навигация Навигация { get; set; }
        
    }
}
