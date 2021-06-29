using Kang.Matthew.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRCAGApp
{
    class CarWashPackage
    {
        private string fragrance;
        private string carpets;
        private string upholstery;
        private string coat;
        private string handWash;
        private string handWax;
        private string wheelPolish;
        private string detailEngine;
        private string packageChoice;
        private string pstCharged;
        private decimal subtotal;
        private decimal gstCharged;
        private decimal taxes;
        private decimal total;
        private decimal packagePrice;
        private decimal fragrancePrice;

        /// <summary>
        /// Initializes an instance of the car wash package with the package chosen.
        /// </summary>
        /// <param name="package">The package type chosen by the customer.</param>
        public CarWashPackage (string package)
        {
            this.packageChoice = package;
            this.fragrance = "Fragrance - Pine";
            PackageChosen(package);
            CostCalculation(this.packagePrice, 0);

        }

        /// <summary>
        /// Initializes an instance of the car wash package with the package and fragrance chosen.
        /// </summary>
        /// <param name="package">The package type chosen by the customer.</param>
        /// <param name="fragrance">The fragrance type chosen by the customer.</param>
        public CarWashPackage (string package, string fragrance, decimal fragrancePrice)
        {
            this.packageChoice = package;
            this.fragrancePrice = fragrancePrice;
            this.fragrance = "Fragrance - " + fragrance;
            PackageChosen(package);
            CostCalculation(this.packagePrice, fragrancePrice);
            
        }
        public string PackageChoice
        {
            get
            {
                return this.packageChoice;
            }
        }
        public string Fragrance
        {
            get
            {
                return this.fragrance;
            }

        }

        public string Carpets
        {
            get
            {
                return this.carpets;
            }
        }

        public string Upholstery
        {
            get
            {
                return this.upholstery;
            }
        }

        public string Coat
        {
            get
            {
                return this.coat;
            }
        }

        public string HandWash
        {
            get
            {
                return this.handWash;
            }
        }

        public string HandWax
        {
            get
            {
                return this.handWax;
            }
        }

        public string WheelPolish
        {
            get
            {
                return this.wheelPolish;
            }
        }

        public string DetailEngine
        {
            get
            {
                return this.detailEngine;
            }
        }

        
        public decimal Subtotal
        {
            get
            {
                return this.subtotal;
            }
            
        }

        public string PstCharged
        {
            get
            {
                return this.pstCharged;
            }
            
        }

        public decimal GstCharged
        {
            get
            {
                return this.gstCharged;
            }
            
        }

        public decimal Total
        {
            get
            {
                return this.total;
            }
            
        }

        public decimal PackagePrice
        {
            get
            {
                return this.packagePrice;
            }
        }

        public decimal FragrancePrice
        {
            get
            {
                return this.fragrancePrice;
            }
        }

        public decimal Taxes
        {
            get
            {
                return this.taxes;
            }
        }

        /// <summary>
        /// Sets the package and fragrance types.
        /// </summary>
        /// <param name="package"></param>
        private void PackageChosen(string package)
        {

            this.carpets = 
            this.upholstery = 
            this.coat =
            this.handWax = 
            this.wheelPolish = 
            this.detailEngine = String.Empty;
            this.handWash = "Hand Wash";
            this.packagePrice = 7.50M;

            switch (package)
            {
                case "Deluxe":
                    this.carpets = "Shampoo Carpets";
                    this.handWax = "Hand Wax";
                    this.packagePrice = 15.00M;
                    break;
                case "Executive":
                    this.carpets = "Shampoo Carpets";
                    this.upholstery = "Shampoo Upholstery";
                    this.handWax = "Hand Wax";
                    this.wheelPolish = "Wheel Polish";
                    this.packagePrice = 35.00M;
                    break;
                case "Luxury":
                    this.carpets = "Shampoo Carpets";
                    this.upholstery = "Shampoo Upholstery";
                    this.coat = "Interior Protection Coat";
                    this.handWax = "Hand Wax";
                    this.wheelPolish = "Wheel Polish";
                    this.detailEngine = "Detail Engine Compartment";
                    this.packagePrice = 55.00M;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Calculates the cost of the car wash.
        /// </summary>
        /// <param name="package">The package type chosen.</param>
        /// <param name="fragrance">The fragrance type chosen.</param>
        public void CostCalculation(decimal packageCost,  decimal fragranceCost)
        {

            CarWashInvoice invoice = new CarWashInvoice(0.07M, 0.05M, packageCost, fragranceCost);

            this.subtotal = invoice.SubTotal;
            this.pstCharged = String.Format("{0:0.00}", invoice.ProvincialSalesTaxCharged);
            this.gstCharged = invoice.GoodsAndServicesTaxCharged;
            this.taxes = Math.Round(invoice.GoodsAndServicesTaxCharged + invoice.ProvincialSalesTaxCharged, 2);
            this.total = Math.Round(invoice.Total, 2);

        }
    }
}
