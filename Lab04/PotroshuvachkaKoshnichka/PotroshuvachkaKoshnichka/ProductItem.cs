using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotroshuvachkaKoshnichka
{
    class ProductItem
    {
        public Product product { get; set; }
        public int quantity { get; set; }

        public override string ToString()
        {
            return product.productName + " " + quantity + " x " + product.productPrice + " = " + quantity * product.productPrice;
        }

        public override bool Equals(object obj)
        {
            var item = obj as ProductItem;
            return item != null &&
                   EqualityComparer<Product>.Default.Equals(product, item.product) &&
                   quantity == item.quantity;
        }

        public override int GetHashCode()
        {
            var hashCode = 21273572;
            hashCode = hashCode * -1521134295 + EqualityComparer<Product>.Default.GetHashCode(product);
            hashCode = hashCode * -1521134295 + quantity.GetHashCode();
            return hashCode;
        }
    }
}
