using EntityDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class ProductsViewModel
    {
        public string productName { get; set; }
        public string categoryName { get; set; }
        public decimal? unitPrice { get; set; }

        public ProductsViewModel()
        {
        }
        public ProductsViewModel(OrderDetail entry)
        {
            productName = entry.Product.ProductName;
            categoryName = entry.Product.Category.CategoryName;
            unitPrice = entry.Product.UnitPrice;
        }
    }

    public class OrdersViewModel
    {
        public int orderId { get; set; }
        public List<ProductsViewModel> product { get; set; }
        public DateTime? orderDate { get; set; }
        public DateTime? requiredDate { get; set; }
        public OrdersViewModel()
        {
        }
        public OrdersViewModel(Order entry)
        {
            orderId = entry.OrderId;
            product = new List<ProductsViewModel>();
            foreach (var item in entry.OrderDetails)
            {
                product.Add(new ProductsViewModel(item));
            }
            orderDate = entry.OrderDate;
            requiredDate = entry.RequiredDate;
        }
    }
}
