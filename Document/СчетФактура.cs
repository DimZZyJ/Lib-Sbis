namespace Lib_Sbis.Document
{
    public class СчетФактура
    {
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Файл
        {

            private ФайлСвУчДокОбор свУчДокОборField;

            private ФайлДокумент документField;

            private string версПрогField;

            private decimal версФормField;

            private string идФайлField;

            /// <remarks/>
            public ФайлСвУчДокОбор СвУчДокОбор
            {
                get
                {
                    return this.свУчДокОборField;
                }
                set
                {
                    this.свУчДокОборField = value;
                }
            }

            /// <remarks/>
            public ФайлДокумент Документ
            {
                get
                {
                    return this.документField;
                }
                set
                {
                    this.документField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ВерсПрог
            {
                get
                {
                    return this.версПрогField;
                }
                set
                {
                    this.версПрогField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal ВерсФорм
            {
                get
                {
                    return this.версФормField;
                }
                set
                {
                    this.версФормField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ИдФайл
            {
                get
                {
                    return this.идФайлField;
                }
                set
                {
                    this.идФайлField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлСвУчДокОбор
        {

            private ФайлСвУчДокОборСвОЭДОтпр свОЭДОтпрField;

            private string идОтпрField;

            private string идПолField;

            /// <remarks/>
            public ФайлСвУчДокОборСвОЭДОтпр СвОЭДОтпр
            {
                get
                {
                    return this.свОЭДОтпрField;
                }
                set
                {
                    this.свОЭДОтпрField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ИдОтпр
            {
                get
                {
                    return this.идОтпрField;
                }
                set
                {
                    this.идОтпрField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ИдПол
            {
                get
                {
                    return this.идПолField;
                }
                set
                {
                    this.идПолField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлСвУчДокОборСвОЭДОтпр
        {

            private ulong иННЮЛField;

            private string идЭДОField;

            private string наимОргField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong ИННЮЛ
            {
                get
                {
                    return this.иННЮЛField;
                }
                set
                {
                    this.иННЮЛField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ИдЭДО
            {
                get
                {
                    return this.идЭДОField;
                }
                set
                {
                    this.идЭДОField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НаимОрг
            {
                get
                {
                    return this.наимОргField;
                }
                set
                {
                    this.наимОргField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокумент
        {

            private ФайлДокументСвСчФакт свСчФактField;

            private ФайлДокументТаблСчФакт таблСчФактField;

            private ФайлДокументСвПродПер свПродПерField;

            private ФайлДокументПодписант подписантField;

            private string времИнфПрField;

            private string датаИнфПрField;

            private uint кНДField;

            private string наимДокОпрField;

            private string наимЭконСубСостField;

            private string поФактХЖField;

            private string функцияField;

            /// <remarks/>
            public ФайлДокументСвСчФакт СвСчФакт
            {
                get
                {
                    return this.свСчФактField;
                }
                set
                {
                    this.свСчФактField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументТаблСчФакт ТаблСчФакт
            {
                get
                {
                    return this.таблСчФактField;
                }
                set
                {
                    this.таблСчФактField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументСвПродПер СвПродПер
            {
                get
                {
                    return this.свПродПерField;
                }
                set
                {
                    this.свПродПерField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументПодписант Подписант
            {
                get
                {
                    return this.подписантField;
                }
                set
                {
                    this.подписантField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ВремИнфПр
            {
                get
                {
                    return this.времИнфПрField;
                }
                set
                {
                    this.времИнфПрField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ДатаИнфПр
            {
                get
                {
                    return this.датаИнфПрField;
                }
                set
                {
                    this.датаИнфПрField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint КНД
            {
                get
                {
                    return this.кНДField;
                }
                set
                {
                    this.кНДField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НаимДокОпр
            {
                get
                {
                    return this.наимДокОпрField;
                }
                set
                {
                    this.наимДокОпрField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НаимЭконСубСост
            {
                get
                {
                    return this.наимЭконСубСостField;
                }
                set
                {
                    this.наимЭконСубСостField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ПоФактХЖ
            {
                get
                {
                    return this.поФактХЖField;
                }
                set
                {
                    this.поФактХЖField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Функция
            {
                get
                {
                    return this.функцияField;
                }
                set
                {
                    this.функцияField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФакт
        {

            private ФайлДокументСвСчФактИспрСчФ испрСчФField;

            private ФайлДокументСвСчФактСвПрод свПродField;

            private ФайлДокументСвСчФактГрузОт грузОтField;

            private ФайлДокументСвСчФактГрузПолуч грузПолучField;

            private ФайлДокументСвСчФактСвПокуп свПокупField;

            private ФайлДокументСвСчФактДокПодтвОтгр докПодтвОтгрField;

            private ФайлДокументСвСчФактТекстИнф[] инфПолФХЖ1Field;

            private string датаСчФField;

            private ushort кодОКВField;

            private ushort номерСчФField;

            /// <remarks/>
            public ФайлДокументСвСчФактИспрСчФ ИспрСчФ
            {
                get
                {
                    return this.испрСчФField;
                }
                set
                {
                    this.испрСчФField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументСвСчФактСвПрод СвПрод
            {
                get
                {
                    return this.свПродField;
                }
                set
                {
                    this.свПродField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументСвСчФактГрузОт ГрузОт
            {
                get
                {
                    return this.грузОтField;
                }
                set
                {
                    this.грузОтField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументСвСчФактГрузПолуч ГрузПолуч
            {
                get
                {
                    return this.грузПолучField;
                }
                set
                {
                    this.грузПолучField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументСвСчФактСвПокуп СвПокуп
            {
                get
                {
                    return this.свПокупField;
                }
                set
                {
                    this.свПокупField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументСвСчФактДокПодтвОтгр ДокПодтвОтгр
            {
                get
                {
                    return this.докПодтвОтгрField;
                }
                set
                {
                    this.докПодтвОтгрField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("ТекстИнф", IsNullable = false)]
            public ФайлДокументСвСчФактТекстИнф[] ИнфПолФХЖ1
            {
                get
                {
                    return this.инфПолФХЖ1Field;
                }
                set
                {
                    this.инфПолФХЖ1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ДатаСчФ
            {
                get
                {
                    return this.датаСчФField;
                }
                set
                {
                    this.датаСчФField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort КодОКВ
            {
                get
                {
                    return this.кодОКВField;
                }
                set
                {
                    this.кодОКВField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort НомерСчФ
            {
                get
                {
                    return this.номерСчФField;
                }
                set
                {
                    this.номерСчФField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактИспрСчФ
        {

            private string дефДатаИспрСчФField;

            private string дефНомИспрСчФField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ДефДатаИспрСчФ
            {
                get
                {
                    return this.дефДатаИспрСчФField;
                }
                set
                {
                    this.дефДатаИспрСчФField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ДефНомИспрСчФ
            {
                get
                {
                    return this.дефНомИспрСчФField;
                }
                set
                {
                    this.дефНомИспрСчФField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактСвПрод
        {

            private ФайлДокументСвСчФактСвПродИдСв идСвField;

            private ФайлДокументСвСчФактСвПродАдрес адресField;

            private ФайлДокументСвСчФактСвПродКонтакт контактField;

            private ФайлДокументСвСчФактСвПродБанкРекв банкРеквField;

            private uint оКПОField;

            /// <remarks/>
            public ФайлДокументСвСчФактСвПродИдСв ИдСв
            {
                get
                {
                    return this.идСвField;
                }
                set
                {
                    this.идСвField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументСвСчФактСвПродАдрес Адрес
            {
                get
                {
                    return this.адресField;
                }
                set
                {
                    this.адресField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументСвСчФактСвПродКонтакт Контакт
            {
                get
                {
                    return this.контактField;
                }
                set
                {
                    this.контактField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументСвСчФактСвПродБанкРекв БанкРекв
            {
                get
                {
                    return this.банкРеквField;
                }
                set
                {
                    this.банкРеквField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint ОКПО
            {
                get
                {
                    return this.оКПОField;
                }
                set
                {
                    this.оКПОField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактСвПродИдСв
        {

            private ФайлДокументСвСчФактСвПродИдСвСвЮЛУч свЮЛУчField;

            /// <remarks/>
            public ФайлДокументСвСчФактСвПродИдСвСвЮЛУч СвЮЛУч
            {
                get
                {
                    return this.свЮЛУчField;
                }
                set
                {
                    this.свЮЛУчField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактСвПродИдСвСвЮЛУч
        {

            private ulong иННЮЛField;

            private uint кППField;

            private string наимОргField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong ИННЮЛ
            {
                get
                {
                    return this.иННЮЛField;
                }
                set
                {
                    this.иННЮЛField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint КПП
            {
                get
                {
                    return this.кППField;
                }
                set
                {
                    this.кППField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НаимОрг
            {
                get
                {
                    return this.наимОргField;
                }
                set
                {
                    this.наимОргField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактСвПродАдрес
        {

            private ФайлДокументСвСчФактСвПродАдресАдрРФ адрРФField;

            /// <remarks/>
            public ФайлДокументСвСчФактСвПродАдресАдрРФ АдрРФ
            {
                get
                {
                    return this.адрРФField;
                }
                set
                {
                    this.адрРФField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактСвПродАдресАдрРФ
        {

            private byte домField;

            private uint индексField;

            private string квартField;

            private byte кодРегионField;

            private string корпусField;

            private string улицаField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Дом
            {
                get
                {
                    return this.домField;
                }
                set
                {
                    this.домField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint Индекс
            {
                get
                {
                    return this.индексField;
                }
                set
                {
                    this.индексField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Кварт
            {
                get
                {
                    return this.квартField;
                }
                set
                {
                    this.квартField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte КодРегион
            {
                get
                {
                    return this.кодРегионField;
                }
                set
                {
                    this.кодРегионField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Корпус
            {
                get
                {
                    return this.корпусField;
                }
                set
                {
                    this.корпусField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Улица
            {
                get
                {
                    return this.улицаField;
                }
                set
                {
                    this.улицаField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактСвПродКонтакт
        {

            private string тлфField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Тлф
            {
                get
                {
                    return this.тлфField;
                }
                set
                {
                    this.тлфField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактСвПродБанкРекв
        {

            private ФайлДокументСвСчФактСвПродБанкРеквСвБанк свБанкField;

            private string номерСчетаField;

            /// <remarks/>
            public ФайлДокументСвСчФактСвПродБанкРеквСвБанк СвБанк
            {
                get
                {
                    return this.свБанкField;
                }
                set
                {
                    this.свБанкField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
            public string НомерСчета
            {
                get
                {
                    return this.номерСчетаField;
                }
                set
                {
                    this.номерСчетаField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактСвПродБанкРеквСвБанк
        {

            private uint бИКField;

            private string корСчетField;

            private string наимБанкField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint БИК
            {
                get
                {
                    return this.бИКField;
                }
                set
                {
                    this.бИКField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
            public string КорСчет
            {
                get
                {
                    return this.корСчетField;
                }
                set
                {
                    this.корСчетField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НаимБанк
            {
                get
                {
                    return this.наимБанкField;
                }
                set
                {
                    this.наимБанкField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактГрузОт
        {

            private string онЖеField;

            /// <remarks/>
            public string ОнЖе
            {
                get
                {
                    return this.онЖеField;
                }
                set
                {
                    this.онЖеField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактГрузПолуч
        {

            private ФайлДокументСвСчФактГрузПолучИдСв идСвField;

            private ФайлДокументСвСчФактГрузПолучАдрес адресField;

            private ФайлДокументСвСчФактГрузПолучБанкРекв банкРеквField;

            /// <remarks/>
            public ФайлДокументСвСчФактГрузПолучИдСв ИдСв
            {
                get
                {
                    return this.идСвField;
                }
                set
                {
                    this.идСвField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументСвСчФактГрузПолучАдрес Адрес
            {
                get
                {
                    return this.адресField;
                }
                set
                {
                    this.адресField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументСвСчФактГрузПолучБанкРекв БанкРекв
            {
                get
                {
                    return this.банкРеквField;
                }
                set
                {
                    this.банкРеквField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактГрузПолучИдСв
        {

            private ФайлДокументСвСчФактГрузПолучИдСвСвЮЛУч свЮЛУчField;

            /// <remarks/>
            public ФайлДокументСвСчФактГрузПолучИдСвСвЮЛУч СвЮЛУч
            {
                get
                {
                    return this.свЮЛУчField;
                }
                set
                {
                    this.свЮЛУчField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактГрузПолучИдСвСвЮЛУч
        {

            private ulong иННЮЛField;

            private uint кППField;

            private string наимОргField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong ИННЮЛ
            {
                get
                {
                    return this.иННЮЛField;
                }
                set
                {
                    this.иННЮЛField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint КПП
            {
                get
                {
                    return this.кППField;
                }
                set
                {
                    this.кППField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НаимОрг
            {
                get
                {
                    return this.наимОргField;
                }
                set
                {
                    this.наимОргField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактГрузПолучАдрес
        {

            private ФайлДокументСвСчФактГрузПолучАдресАдрИнф адрИнфField;

            /// <remarks/>
            public ФайлДокументСвСчФактГрузПолучАдресАдрИнф АдрИнф
            {
                get
                {
                    return this.адрИнфField;
                }
                set
                {
                    this.адрИнфField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактГрузПолучАдресАдрИнф
        {

            private string адрТекстField;

            private ushort кодСтрField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string АдрТекст
            {
                get
                {
                    return this.адрТекстField;
                }
                set
                {
                    this.адрТекстField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort КодСтр
            {
                get
                {
                    return this.кодСтрField;
                }
                set
                {
                    this.кодСтрField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактГрузПолучБанкРекв
        {

            private ФайлДокументСвСчФактГрузПолучБанкРеквСвБанк свБанкField;

            private string номерСчетаField;

            /// <remarks/>
            public ФайлДокументСвСчФактГрузПолучБанкРеквСвБанк СвБанк
            {
                get
                {
                    return this.свБанкField;
                }
                set
                {
                    this.свБанкField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
            public string НомерСчета
            {
                get
                {
                    return this.номерСчетаField;
                }
                set
                {
                    this.номерСчетаField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактГрузПолучБанкРеквСвБанк
        {

            private uint бИКField;

            private string корСчетField;

            private string наимБанкField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint БИК
            {
                get
                {
                    return this.бИКField;
                }
                set
                {
                    this.бИКField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
            public string КорСчет
            {
                get
                {
                    return this.корСчетField;
                }
                set
                {
                    this.корСчетField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НаимБанк
            {
                get
                {
                    return this.наимБанкField;
                }
                set
                {
                    this.наимБанкField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактСвПокуп
        {

            private ФайлДокументСвСчФактСвПокупИдСв идСвField;

            private ФайлДокументСвСчФактСвПокупАдрес адресField;

            private ФайлДокументСвСчФактСвПокупБанкРекв банкРеквField;

            /// <remarks/>
            public ФайлДокументСвСчФактСвПокупИдСв ИдСв
            {
                get
                {
                    return this.идСвField;
                }
                set
                {
                    this.идСвField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументСвСчФактСвПокупАдрес Адрес
            {
                get
                {
                    return this.адресField;
                }
                set
                {
                    this.адресField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументСвСчФактСвПокупБанкРекв БанкРекв
            {
                get
                {
                    return this.банкРеквField;
                }
                set
                {
                    this.банкРеквField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактСвПокупИдСв
        {

            private ФайлДокументСвСчФактСвПокупИдСвСвЮЛУч свЮЛУчField;

            /// <remarks/>
            public ФайлДокументСвСчФактСвПокупИдСвСвЮЛУч СвЮЛУч
            {
                get
                {
                    return this.свЮЛУчField;
                }
                set
                {
                    this.свЮЛУчField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактСвПокупИдСвСвЮЛУч
        {

            private ulong иННЮЛField;

            private uint кППField;

            private string наимОргField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong ИННЮЛ
            {
                get
                {
                    return this.иННЮЛField;
                }
                set
                {
                    this.иННЮЛField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint КПП
            {
                get
                {
                    return this.кППField;
                }
                set
                {
                    this.кППField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НаимОрг
            {
                get
                {
                    return this.наимОргField;
                }
                set
                {
                    this.наимОргField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактСвПокупАдрес
        {

            private ФайлДокументСвСчФактСвПокупАдресАдрРФ адрРФField;

            /// <remarks/>
            public ФайлДокументСвСчФактСвПокупАдресАдрРФ АдрРФ
            {
                get
                {
                    return this.адрРФField;
                }
                set
                {
                    this.адрРФField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактСвПокупАдресАдрРФ
        {

            private byte домField;

            private uint индексField;

            private byte кодРегионField;

            private string улицаField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Дом
            {
                get
                {
                    return this.домField;
                }
                set
                {
                    this.домField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint Индекс
            {
                get
                {
                    return this.индексField;
                }
                set
                {
                    this.индексField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte КодРегион
            {
                get
                {
                    return this.кодРегионField;
                }
                set
                {
                    this.кодРегионField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Улица
            {
                get
                {
                    return this.улицаField;
                }
                set
                {
                    this.улицаField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактСвПокупБанкРекв
        {

            private ФайлДокументСвСчФактСвПокупБанкРеквСвБанк свБанкField;

            private string номерСчетаField;

            /// <remarks/>
            public ФайлДокументСвСчФактСвПокупБанкРеквСвБанк СвБанк
            {
                get
                {
                    return this.свБанкField;
                }
                set
                {
                    this.свБанкField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
            public string НомерСчета
            {
                get
                {
                    return this.номерСчетаField;
                }
                set
                {
                    this.номерСчетаField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактСвПокупБанкРеквСвБанк
        {

            private uint бИКField;

            private string корСчетField;

            private string наимБанкField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint БИК
            {
                get
                {
                    return this.бИКField;
                }
                set
                {
                    this.бИКField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
            public string КорСчет
            {
                get
                {
                    return this.корСчетField;
                }
                set
                {
                    this.корСчетField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НаимБанк
            {
                get
                {
                    return this.наимБанкField;
                }
                set
                {
                    this.наимБанкField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактДокПодтвОтгр
        {

            private string датаДокОтгрField;

            private string наимДокОтгрField;

            private ushort номДокОтгрField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ДатаДокОтгр
            {
                get
                {
                    return this.датаДокОтгрField;
                }
                set
                {
                    this.датаДокОтгрField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НаимДокОтгр
            {
                get
                {
                    return this.наимДокОтгрField;
                }
                set
                {
                    this.наимДокОтгрField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort НомДокОтгр
            {
                get
                {
                    return this.номДокОтгрField;
                }
                set
                {
                    this.номДокОтгрField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвСчФактТекстИнф
        {

            private string значенField;

            private string идентифField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Значен
            {
                get
                {
                    return this.значенField;
                }
                set
                {
                    this.значенField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Идентиф
            {
                get
                {
                    return this.идентифField;
                }
                set
                {
                    this.идентифField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументТаблСчФакт
        {

            private ФайлДокументТаблСчФактСведТов[] сведТовField;

            private ФайлДокументТаблСчФактВсегоОпл всегоОплField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("СведТов")]
            public ФайлДокументТаблСчФактСведТов[] СведТов
            {
                get
                {
                    return this.сведТовField;
                }
                set
                {
                    this.сведТовField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументТаблСчФактВсегоОпл ВсегоОпл
            {
                get
                {
                    return this.всегоОплField;
                }
                set
                {
                    this.всегоОплField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументТаблСчФактСведТов
        {

            private ФайлДокументТаблСчФактСведТовАкциз акцизField;

            private ФайлДокументТаблСчФактСведТовСумНал сумНалField;

            private ФайлДокументТаблСчФактСведТовСвТД свТДField;

            private ФайлДокументТаблСчФактСведТовДопСведТов допСведТовField;

            private ФайлДокументТаблСчФактСведТовИнфПолФХЖ2[] инфПолФХЖ2Field;

            private decimal колТовField;

            private string наимТовField;

            private string налСтField;

            private byte номСтрField;

            private byte оКЕИ_ТовField;

            private decimal стТовБезНДСField;

            private decimal стТовУчНалField;

            private decimal ценаТовField;

            /// <remarks/>
            public ФайлДокументТаблСчФактСведТовАкциз Акциз
            {
                get
                {
                    return this.акцизField;
                }
                set
                {
                    this.акцизField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументТаблСчФактСведТовСумНал СумНал
            {
                get
                {
                    return this.сумНалField;
                }
                set
                {
                    this.сумНалField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументТаблСчФактСведТовСвТД СвТД
            {
                get
                {
                    return this.свТДField;
                }
                set
                {
                    this.свТДField = value;
                }
            }

            /// <remarks/>
            public ФайлДокументТаблСчФактСведТовДопСведТов ДопСведТов
            {
                get
                {
                    return this.допСведТовField;
                }
                set
                {
                    this.допСведТовField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ИнфПолФХЖ2")]
            public ФайлДокументТаблСчФактСведТовИнфПолФХЖ2[] ИнфПолФХЖ2
            {
                get
                {
                    return this.инфПолФХЖ2Field;
                }
                set
                {
                    this.инфПолФХЖ2Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal КолТов
            {
                get
                {
                    return this.колТовField;
                }
                set
                {
                    this.колТовField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НаимТов
            {
                get
                {
                    return this.наимТовField;
                }
                set
                {
                    this.наимТовField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НалСт
            {
                get
                {
                    return this.налСтField;
                }
                set
                {
                    this.налСтField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte НомСтр
            {
                get
                {
                    return this.номСтрField;
                }
                set
                {
                    this.номСтрField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ОКЕИ_Тов
            {
                get
                {
                    return this.оКЕИ_ТовField;
                }
                set
                {
                    this.оКЕИ_ТовField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal СтТовБезНДС
            {
                get
                {
                    return this.стТовБезНДСField;
                }
                set
                {
                    this.стТовБезНДСField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal СтТовУчНал
            {
                get
                {
                    return this.стТовУчНалField;
                }
                set
                {
                    this.стТовУчНалField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal ЦенаТов
            {
                get
                {
                    return this.ценаТовField;
                }
                set
                {
                    this.ценаТовField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументТаблСчФактСведТовАкциз
        {

            private string безАкцизField;

            /// <remarks/>
            public string БезАкциз
            {
                get
                {
                    return this.безАкцизField;
                }
                set
                {
                    this.безАкцизField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументТаблСчФактСведТовСумНал
        {

            private decimal сумНалField;

            /// <remarks/>
            public decimal СумНал
            {
                get
                {
                    return this.сумНалField;
                }
                set
                {
                    this.сумНалField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументТаблСчФактСведТовСвТД
        {

            private ushort кодПроисхField;

            private string номерТДField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort КодПроисх
            {
                get
                {
                    return this.кодПроисхField;
                }
                set
                {
                    this.кодПроисхField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НомерТД
            {
                get
                {
                    return this.номерТДField;
                }
                set
                {
                    this.номерТДField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументТаблСчФактСведТовДопСведТов
        {

            private ФайлДокументТаблСчФактСведТовДопСведТовНомСредИдентТов номСредИдентТовField;

            private ushort кодТовField;

            private string наимЕдИзмField;

            private byte прТовРабField;

            private string крНаимСтрПрField;

            /// <remarks/>
            public ФайлДокументТаблСчФактСведТовДопСведТовНомСредИдентТов НомСредИдентТов
            {
                get
                {
                    return this.номСредИдентТовField;
                }
                set
                {
                    this.номСредИдентТовField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort КодТов
            {
                get
                {
                    return this.кодТовField;
                }
                set
                {
                    this.кодТовField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НаимЕдИзм
            {
                get
                {
                    return this.наимЕдИзмField;
                }
                set
                {
                    this.наимЕдИзмField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ПрТовРаб
            {
                get
                {
                    return this.прТовРабField;
                }
                set
                {
                    this.прТовРабField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string КрНаимСтрПр
            {
                get
                {
                    return this.крНаимСтрПрField;
                }
                set
                {
                    this.крНаимСтрПрField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументТаблСчФактСведТовДопСведТовНомСредИдентТов
        {

            private ulong номУпакField;

            /// <remarks/>
            public ulong НомУпак
            {
                get
                {
                    return this.номУпакField;
                }
                set
                {
                    this.номУпакField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументТаблСчФактСведТовИнфПолФХЖ2
        {

            private string значенField;

            private string идентифField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Значен
            {
                get
                {
                    return this.значенField;
                }
                set
                {
                    this.значенField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Идентиф
            {
                get
                {
                    return this.идентифField;
                }
                set
                {
                    this.идентифField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументТаблСчФактВсегоОпл
        {

            private ФайлДокументТаблСчФактВсегоОплСумНалВсего сумНалВсегоField;

            private decimal стТовБезНДСВсегоField;

            private decimal стТовУчНалВсегоField;

            /// <remarks/>
            public ФайлДокументТаблСчФактВсегоОплСумНалВсего СумНалВсего
            {
                get
                {
                    return this.сумНалВсегоField;
                }
                set
                {
                    this.сумНалВсегоField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal СтТовБезНДСВсего
            {
                get
                {
                    return this.стТовБезНДСВсегоField;
                }
                set
                {
                    this.стТовБезНДСВсегоField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal СтТовУчНалВсего
            {
                get
                {
                    return this.стТовУчНалВсегоField;
                }
                set
                {
                    this.стТовУчНалВсегоField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументТаблСчФактВсегоОплСумНалВсего
        {

            private decimal сумНалField;

            /// <remarks/>
            public decimal СумНал
            {
                get
                {
                    return this.сумНалField;
                }
                set
                {
                    this.сумНалField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвПродПер
        {

            private ФайлДокументСвПродПерСвПер свПерField;

            /// <remarks/>
            public ФайлДокументСвПродПерСвПер СвПер
            {
                get
                {
                    return this.свПерField;
                }
                set
                {
                    this.свПерField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвПродПерСвПер
        {

            private ФайлДокументСвПродПерСвПерОснПер оснПерField;

            private string содОперField;

            /// <remarks/>
            public ФайлДокументСвПродПерСвПерОснПер ОснПер
            {
                get
                {
                    return this.оснПерField;
                }
                set
                {
                    this.оснПерField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string СодОпер
            {
                get
                {
                    return this.содОперField;
                }
                set
                {
                    this.содОперField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументСвПродПерСвПерОснПер
        {

            private string наимОснField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НаимОсн
            {
                get
                {
                    return this.наимОснField;
                }
                set
                {
                    this.наимОснField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументПодписант
        {

            private ФайлДокументПодписантЮЛ юлField;

            private byte облПолнField;

            private string оснПолнField;

            private byte статусField;

            /// <remarks/>
            public ФайлДокументПодписантЮЛ ЮЛ
            {
                get
                {
                    return this.юлField;
                }
                set
                {
                    this.юлField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte ОблПолн
            {
                get
                {
                    return this.облПолнField;
                }
                set
                {
                    this.облПолнField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ОснПолн
            {
                get
                {
                    return this.оснПолнField;
                }
                set
                {
                    this.оснПолнField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte Статус
            {
                get
                {
                    return this.статусField;
                }
                set
                {
                    this.статусField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументПодписантЮЛ
        {

            private ФайлДокументПодписантЮЛФИО фИОField;

            private string должнField;

            private ulong иННЮЛField;

            private string наимОргField;

            /// <remarks/>
            public ФайлДокументПодписантЮЛФИО ФИО
            {
                get
                {
                    return this.фИОField;
                }
                set
                {
                    this.фИОField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Должн
            {
                get
                {
                    return this.должнField;
                }
                set
                {
                    this.должнField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ulong ИННЮЛ
            {
                get
                {
                    return this.иННЮЛField;
                }
                set
                {
                    this.иННЮЛField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string НаимОрг
            {
                get
                {
                    return this.наимОргField;
                }
                set
                {
                    this.наимОргField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ФайлДокументПодписантЮЛФИО
        {

            private string имяField;

            private string отчествоField;

            private string фамилияField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Имя
            {
                get
                {
                    return this.имяField;
                }
                set
                {
                    this.имяField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Отчество
            {
                get
                {
                    return this.отчествоField;
                }
                set
                {
                    this.отчествоField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Фамилия
            {
                get
                {
                    return this.фамилияField;
                }
                set
                {
                    this.фамилияField = value;
                }
            }
        }

    }
}
