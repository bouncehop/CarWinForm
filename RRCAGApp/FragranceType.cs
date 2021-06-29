using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRCAGApp
{
    class FragranceType
    {
        private string fragrance;
        private decimal fragrancePrice;

        public FragranceType(string fragrance, decimal fragrancePrice)
        {
            this.fragrance = fragrance;
            this.fragrancePrice = fragrancePrice;
        }

        public string Fragrance
        {
            get
            {
                return this.fragrance;
            }
        }
        public decimal FragrancePrice
        {
            get
            {
                return this.fragrancePrice;
            }
        }
    }
}
