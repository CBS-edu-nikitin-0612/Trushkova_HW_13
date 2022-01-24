namespace Trushkova_HW_13
{
    internal class Converter
    {
        double _usdToGrivna;
        double _eurToGrivna;
        double _rubToGrivna;
        
        public Converter(double usd, double eur, double rub)
        {
            this._usdToGrivna = usd;
            this._eurToGrivna = eur;
            this._rubToGrivna = rub;
        }

        public double UsdToGrivna(double usd)
            => usd * _usdToGrivna;

        public double EurToGrivna(double eur)
            => eur * _eurToGrivna;

        public double RubToGrivna(double rub)
            => rub * _rubToGrivna;


        public double GrivnaToUsd(double grivna)
        {
            if (_usdToGrivna != 0)
            {
                return grivna / _usdToGrivna;
            }
            else
            {
                return 0;
            }
        }

        public double GrivnaToEur(double grivna)
        {
            if (_eurToGrivna != 0)
            {
                return grivna / _eurToGrivna;
            }
            else
            {
                return 0;
            }
        }

        public double GrivnaToRub(double grivna)
        {
            if (_rubToGrivna != 0)
            {
                return grivna / _rubToGrivna;
            }
            else
            {
                return 0;
            }
        }
    }
}
