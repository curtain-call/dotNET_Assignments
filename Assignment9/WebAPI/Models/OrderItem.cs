
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    [Serializable]
    public class OrderItem
    {
        [Key]
        public string Id { get; set; }

        public int Index { get; set; } 

        public Product Product { get; set; }
        //public string ProductID { get; set; }
        public int Quantity { get; set; }
        public double ItemPrice { get; set; }

        //[ForeignKey("OrderId")]
        //public int OrderId { set; get; }

        public OrderItem() {
            Id = Guid.NewGuid().ToString();
            Product = new Product("苹果", 5);
        }

        public OrderItem(string id,Product product,int quantity)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
            ItemPrice = Quantity * Product.Price;
        }

        public override bool Equals(object obj)
        {
            var orderItem = obj as OrderItem;
            return orderItem != null && Product.ProductID== orderItem.Product.ProductID;
        }

        public override string ToString()
        {

            return "[Item]"+Id + '\t' + Product + '\t' + Quantity + '\t' + ItemPrice + '\t';
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}


