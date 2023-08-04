using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Produtos_one.Entities
{
    class ImportedProduct : Product
    {

        public double CustomFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name,double price,double customFee)
        :base(name,price)
        { 
        
            CustomFee = customFee; 
        }
        public double TotalPrice() {
            return Price + CustomFee;
        }
        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}" +
                $"(Customs fee : $ {CustomFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
