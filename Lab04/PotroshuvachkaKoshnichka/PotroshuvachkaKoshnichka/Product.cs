using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotroshuvachkaKoshnichka
{
    public class Product
    {
        public Product(string productName, string productCategory, double productPrice, int productQuantity)
        {
            this.productName = productName ?? throw new ArgumentNullException(nameof(productName));
            this.productCategory = productCategory ?? throw new ArgumentNullException(nameof(productCategory));
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
        }

        public String productName { get; set; }
        public String productCategory { get; set; }
        public double productPrice { get; set; }
        public int productQuantity { get; set; }

        public override bool Equals(object obj)
        {
            var product = obj as Product;
            return product != null &&
                   productName == product.productName &&
                   productCategory == product.productCategory &&
                   productPrice == product.productPrice;
        }

        public override string ToString()
        {
            return this.productName;
        }

        public override int GetHashCode()
        {
            var hashCode = -1107612236;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(productName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(productCategory);
            hashCode = hashCode * -1521134295 + productPrice.GetHashCode();
            return hashCode;
        }
    }
}
