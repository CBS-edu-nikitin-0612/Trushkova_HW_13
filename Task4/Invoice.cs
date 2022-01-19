using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Invoice
    {
        readonly int _account;
        readonly string _customer;
        readonly string _provider;
        string _article;
        int _quantity;
        double _totalPrice;
        double _totalPriceWithoutNDS;
        const double PRICE = 1000;
        const int NDS_PROCENT = 20;

        public Invoice(int account, string customer, string provider)
        {
            this._account = account;
            this._customer = customer;
            this._provider = provider;
        }

        public int Account { get { return _account; } }

        public string Customer 
        { 
            get 
            {
                if (_customer != null)
                    return _customer;
                else return "Имя покупателя не задано";
            } 
        }

        public string Provider 
        { 
            get 
            {
                if (_provider != null)
                    return _provider;
                else return "Имя продавца не задано";
            } 
        }

        public string Article 
        { 
            get
            {
                if (_article != null)
                    return _article;
                else return "Имя продавца не задано";
            }
            set
            {
                _article = value;
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public double TotalPrice { get => _totalPrice; }
        public double TotalPriceWithoutNDS { get => _totalPriceWithoutNDS; }

        public void CalculateTotalPrice()
        {
            _totalPrice = _quantity * PRICE;
            _totalPriceWithoutNDS = _totalPrice * (100 - NDS_PROCENT) / 100;
        }
    }
}
