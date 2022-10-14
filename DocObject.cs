namespace SBISLib.DocumentClasses
{
    public class DocObject
    {

        public class Rootobject
        {
            public string jsonrpc { get; set; }
            public Result result { get; set; }
            public int id { get; set; }
        }

        public class Result
        {
            public Документ[] Документ { get; set; }
            public Навигация Навигация { get; set; }
        }

        public class Навигация
        {
            

            public string ЕстьЕще { get; set; }
            public string РазмерСтраницы { get; set; } 
            public string Страница { get; set; }
            public Навигация(string страница)
            {
                Страница = страница;
                РазмерСтраницы = "200";
            }
        }

        public class Документ
        {
            public Вложение[] Вложение { get; set; }
            public string Дата { get; set; }
            public string ДатаВремяСоздания { get; set; }
            public string Идентификатор { get; set; }
            public string ИдентификаторСеанса { get; set; }
            public Контрагент Контрагент { get; set; }
            public string Название { get; set; }
            public string Направление { get; set; }
            public Нашаорганизация НашаОрганизация { get; set; }
            public string Номер { get; set; }
            public Ответственный Ответственный { get; set; }
            public Подразделение Подразделение { get; set; }
            public string Подтип { get; set; }
            public string Примечание { get; set; }
            public Расширение Расширение { get; set; }
            public Регламент Регламент { get; set; }
            public Редакция1[] Редакция { get; set; }
            public Состояние Состояние { get; set; }
            public string Срок { get; set; }
            public string СсылкаДляКонтрагент { get; set; }
            public string СсылкаДляНашаОрганизация { get; set; }
            public string СсылкаНаPDF { get; set; }
            public string СсылкаНаАрхив { get; set; }
            public string Сумма { get; set; }
            public string Тип { get; set; }
            public string Удален { get; set; }
        }

        public class Контрагент
        {
            public string Email { get; set; }
            public string ИдентификаторИС { get; set; }
            public string ИдентификаторСПП { get; set; }
            public string Описание { get; set; }
            public Свюл СвЮЛ { get; set; }
            public Свфл СвФЛ { get; set; }
            public string Телефон { get; set; }
        }


        public class Нашаорганизация
        {
            public string ИдентификаторИС { get; set; }
            public string ИдентификаторСПП { get; set; }
            public string ПодписаниеОграничено { get; set; }
            public Свюл СвЮЛ { get; set; }
        }

        public class Свюл
        {
            public string АдресЮридический { get; set; }
            public string ИНН { get; set; }
            public string КПП { get; set; }
            public string КодСтраны { get; set; }
            public string Название { get; set; }
        }

        public class Ответственный
        {
            public string Идентификатор { get; set; }
            public string Имя { get; set; }
            public string Отчество { get; set; }
            public string Фамилия { get; set; }
        }

        public class Подразделение
        {
            public string Идентификатор { get; set; }
            public string Название { get; set; }
        }

        public class Расширение
        {
            public string ЗакрытОтИзменений { get; set; }
            public string ОтметкаПлюсом { get; set; }
        }

        public class Регламент
        {
            public string Идентификатор { get; set; }
            public string Название { get; set; }
        }

        public class Состояние
        {
            public string Код { get; set; }
            public string Название { get; set; }
            public string НеполнаяОбработка { get; set; }
            public string Описание { get; set; }
            public string Примечание { get; set; }
            public string Сложное { get; set; }
        }

        public class Вложение
        {
            public string ВерсияФормата { get; set; }
            public string Дата { get; set; }
            public string Зашифрован { get; set; }
            public string Идентификатор { get; set; }
            public string КоличествоОшибок { get; set; }
            public string Название { get; set; }
            public string Направление { get; set; }
            public string Номер { get; set; }
            public string ПодверсияФормата { get; set; }
            public string Подтип { get; set; }
            public Редакция Редакция { get; set; }
            public string Служебный { get; set; }
            public string СсылкаВКабинет { get; set; }
            public string СсылкаНаHTML { get; set; }
            public string СсылкаНаPDF { get; set; }
            public string Сумма { get; set; }
            public string СуммаБезНДС { get; set; }
            public string Тип { get; set; }
            public string ТипШифрования { get; set; }
            public string Удален { get; set; }
            public string Упакован { get; set; }
            public Файл Файл { get; set; }
        }

        public class Редакция//Для вложения 
        {
            public string ДатаВремя { get; set; }
            public string Номер { get; set; }
        }

        public class Файл
        {
            public string Имя { get; set; }
            public string Ссылка { get; set; }
            public string Хеш { get; set; }
        }

        public class Редакция1//для документа
        {
            public string Актуален { get; set; }
            public string ДатаВремя { get; set; }
            public string Идентификатор { get; set; }
            public string ПримечаниеИС { get; set; }
        }

    }

    public class Свфл
    {
        public string Телефон { get; set; }
        public string Email { get; set; }
        public string ИНН { get; set; }
        public string КодФилиала { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string СНИЛС { get; set; }
        public string ЧвстноеЛицо { get; set; }
    }
}
