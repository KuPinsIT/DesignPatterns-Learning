using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upheads.DesignPattern.BuildingBlocks.Commons;

namespace Upheads.DesignPattern.Library.BehavioralPatterns.Strategy.DiscountStrategy
{
    public class BuyOneGetOneFreeDiscountStrategy : IDiscountStrategy
    {
        public SalesOrder ApplyDiscount(SalesOrder salesOrder)
        {
            salesOrder.SetDiscountType(DiscountType.ByOneGetOne);
            salesOrder.SetQuantity(salesOrder.Quantity * 2);
            salesOrder.SetAmountAfterDiscount(0);
            return salesOrder;
        }
    }
}
