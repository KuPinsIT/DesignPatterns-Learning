using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Upheads.DesignPattern.BuildingBlocks.Commons
{
    public class SalesOrder
    {
        public string OrderNumer { get; set; }
        public string Title { get; set; }
        public DiscountType DiscountType { get; private set; }
        public int Quantity { get; private set; }
        public decimal Amount { get; set; }
        public decimal AmountAfterDiscount { get; private set; }

        public SalesOrder(string orderNumber, string title, int quantity = 1)
        {
            OrderNumer = orderNumber;
            Title = title;
            Quantity = quantity;
        }

        public void SetDiscountType(DiscountType discountType) => DiscountType = discountType;
        public void SetQuantity(int quantity) => Quantity = quantity;
        public void SetAmountAfterDiscount(decimal value) => AmountAfterDiscount = Amount - value;

        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"OrderNumber: {OrderNumer}", OrderNumer);
            Console.WriteLine($"Title: {Title}", Title);
            Console.WriteLine("----------------");
            Console.WriteLine($"DiscountType: {DiscountType}", DiscountType);
            Console.WriteLine($"Quantity: {Quantity}", Quantity);
            Console.WriteLine($"Amount: {Amount}", Amount);
            Console.WriteLine($"AmountAfterDiscount: {AmountAfterDiscount}", AmountAfterDiscount);
        }
    }
}
