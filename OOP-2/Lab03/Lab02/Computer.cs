using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab02
{
    [Serializable]
    public class Computer
    {
        public static string[] listOfRAM = new string[5]
        {
            "SDRAM","DDR","DDR2","DDR3","DDR4"
        };
        public static string[] listOfHD = new string[3]
        {
            "HDD","H-HDD","SSD"
        };
        public string TypeOfComputer { get; set; }
        public Processor Processor { get; set; }
        public GraphicCard GraphicCard { get; set; }
        public int SizeRAM { get; set; }
        public string TypeOfRAM { get; set; }
        public int SizeHD { get; set; }
        public string TypeOfHD { get; set; }
        public string PurchaseDate { get; set; }
        public int Cost { get; set; }

        public Computer() { }
        public Computer( string type, Processor proc,GraphicCard gc, int sizeRAM, string typeOfRAM, int sizeHD, string typeOfHD, string date)
        {
            TypeOfComputer = type;
            Processor = proc;
            GraphicCard = gc;
            SizeRAM = sizeRAM;
            TypeOfRAM = typeOfRAM;
            SizeHD = sizeHD;
            TypeOfHD = typeOfHD;
            PurchaseDate = date;
            Cost = cost();
        }

        public string ShowAllInformation()
        {
            Cost = cost();
            return "\rТип компьютера: "+this.TypeOfComputer + 
                "\r\nПроцессор: " +
                "\r\n\tПроизводитель: " + this.Processor.Producer +
                "\r\n\tСерия: " + this.Processor.Series +
                "\r\n\tМодель: " + this.Processor.Model +
                "\r\n\tКоличество ядер: " + this.Processor.CountOfCores +
                "\r\n\tЧастота и максимальная частота: " + this.Processor.Frequency+" ГГц, " +this.Processor.MaxFrequency+" ГГц"+
                "\r\n\tРазрядность архитектуры: х" + this.Processor.BitArchitecture +
                "\r\n\tРазмер кэша L1-L3: " + this.Processor.CacheL1+" Кб, " +this.Processor.CacheL2 + " Мб, " + this.Processor.CacheL3+" Мб"+
                "\r\nВидеокарта: " +
                "\r\n\tПроизводитель: " + this.GraphicCard.Producer +
                "\r\n\tСерия: " + this.GraphicCard.Series +
                "\r\n\tМодель: " + this.GraphicCard.Model +
                "\r\n\tЧастота: " + this.GraphicCard.Frequency +" ГГц"+
                "\r\n\tПоддержка DiretX11: " + this.GraphicCard.DiretX11 +
                "\r\n\tОбъем памяти: " + this.GraphicCard.Memory +" Гб"+
                "\r\nРазмер и тип ОЗУ: " + this.SizeRAM + " Гб, "+ this.TypeOfRAM+
                "\r\nРазмер и тип жесткого диска: " + this.SizeHD+" Тб, "+this.TypeOfHD+
                "\r\nДата приобретения: " + this.PurchaseDate+
                "\r\n\nСтоимость компьютера: " + this.Cost+"$\r\n\r\n\r\n";
        }

        public string ShowShortInfo()
        {
            Cost = cost();
            return "\rТип компьютера: " + this.TypeOfComputer +
                "\r\nПроцессор: " + this.Processor.Producer + ", " + this.Processor.Series + ", " + this.Processor.Model +
                "\r\nЧастота процессора: " + this.Processor.Frequency + " ГГц" +
                "\r\nВидеокарта: " + this.GraphicCard.Producer + ", " + this.GraphicCard.Series + ", " + this.GraphicCard.Model +
                "\r\nРазмер и тип ОЗУ: " + this.SizeRAM + " Гб, " + this.TypeOfRAM +
                "\r\nСтоимость компьютера: " + this.Cost + "$\r\n\r\n\r\n";
        }

        public int cost()
        {
            int result = 0;
            switch (TypeOfComputer)
            {
                case "сервер":
                    result += 350;
                    break;
                case "рабочая станция":
                    result += 290;
                    break;
                case "ноутбук":
                    result += 250;
                    break;
                case "планшет":
                    result += 100;
                    break;
            }
            if (SizeRAM >= 16) result += 60;
            else result += 25;
            switch (TypeOfRAM)
            {
                case "SDRAM":
                case "DDR3":
                    result += 30;
                    break;
                case "DDR2":
                    result += 25;
                    break;
                case "DDR4":
                    result +=40;
                    break;
            }
            if (SizeHD >= 3) result += 90;
            else result += 45;
            switch (TypeOfHD)
            {
                case "HDD":
                    result += 40;
                    break;
                case "H-HDD":
                    result += 60;
                    break;
                case "SSD":
                    result += 80;
                    break;
            }
            if (Processor.BitArchitecture == 64) result += 20;
            if (Processor.CountOfCores >= 4) result += 10;
            if (GraphicCard.Memory >= 4) result += 50;
            if (GraphicCard.DiretX11) result += 15;
            return result;
        }
    }
}
