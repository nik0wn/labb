using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vers3
{
    internal class Gun
    {
        private double square;
        private double tariffElectricity;
        private double tariffHotWater;
        private double tariffColdWater;
        private double TariffmajorRepairs;
        private double Tariffheating;
        private double Indicationselectricity;
        private double IndicationshotWater;
        private double IndicationscoldWater;
        public double Square
        {
            get { return square; }
            set { square = value; }
        }
        public double TariffElectricity
        {
            get { return tariffElectricity; }
            set { tariffElectricity = value; }
        }
        public double TariffHotWater
        {
            get { return tariffHotWater; }
            set{ tariffHotWater = value; }
        }
        public double TariffColdWater
        {
            get { return tariffColdWater; }
            set { tariffColdWater = value; }
        }
        public double TariffMajorRepairs
        {
            get { return TariffmajorRepairs; }
            set { TariffmajorRepairs = value; }
        }
        public double TariffHeating
        {
            get { return Tariffheating; }
            set
            { Tariffheating = value; }
        }
        public double IndicationsElectricity
        {
            get { return Indicationselectricity; }
            set {Indicationselectricity = value;}
        }
        public double IndicationsHotWater
        {
            get { return IndicationshotWater; }
            set { IndicationshotWater = value; }
        }
        public double IndicationsColdWater
        {
            get { return IndicationscoldWater; }
            set { IndicationscoldWater = value; }
        }
        public Gun(double Square, double TariffElectricity, 
            double TariffHotWater, double TariffColdWater, double TariffMajorRepairs,
            double TariffHeating, double IndicationsElectricity, double IndicationsHotWater, double IndicationsColdWater
        )
        {
            this.Square = Square;
            this.TariffElectricity = TariffElectricity;
            this.TariffHotWater = TariffHotWater;
            this.TariffColdWater = TariffColdWater;
            this.TariffMajorRepairs = TariffMajorRepairs;
            this.TariffHeating = TariffHeating;
            this.IndicationsElectricity = IndicationsElectricity;
            this.IndicationsHotWater = IndicationsHotWater;
            this.IndicationsColdWater = IndicationsColdWater;
        }
        public string Print()
        {
            string ResultElectricity = $"Всего потрачено электричество: {IndicationsElectricity} кВт. И того к оплате {IndicationsElectricity * TariffElectricity} рублей.\r\n";
            string ResultHotWater = $"Объем потраченой горячий воды: {IndicationsHotWater} кубометров. И того к оплате {IndicationsHotWater * TariffHotWater} рублей.\r\n";
            string ResultColdWater = $"Объем потраченой холодной воды: {IndicationsColdWater} кубометров. И того к оплате {IndicationsColdWater * TariffColdWater} рублей.\r\n";
            string ResultMajorRepairs = $"Плата за капитальный ремонт: {Square * TariffMajorRepairs} рублей.\r\n";
            string ResultHeating = $"Плата за отопления: {Square * TariffHeating} рублей.\r\n";
            string Result = $"Итого: {(IndicationsElectricity * TariffElectricity) + (IndicationsHotWater * TariffHotWater) + (IndicationsColdWater * TariffColdWater) + (Square * TariffHeating)} рублей.";
            return ResultElectricity + ResultHotWater + ResultColdWater + ResultMajorRepairs + ResultHeating + Result;
        }
        }
    }

