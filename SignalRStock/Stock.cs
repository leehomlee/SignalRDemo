using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRStock
{
    public class Stock
    {
        /// <summary>
        /// 价格
        /// </summary>
        private decimal _price;
        /// <summary>
        /// 股票代码
        /// </summary>
        public string Symbol { get; set; }
        /// <summary>
        /// 首次设置的价格
        /// </summary>
        public decimal DayOpen { get; private set; }
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price == value)
                {
                    return;
                }

                _price = value;

                if (DayOpen == 0)
                {
                    DayOpen = _price;
                }
            }
        }
        public decimal Change
        {
            get
            {
                return Price - DayOpen;
            }
        }
        public double PercentChange
        {
            get
            {
                return (double)Math.Round(Change / Price, 4);
            }
        }
    }
}