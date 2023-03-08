using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upheads.DesignPattern.BuildingBlocks.Commons;

namespace Upheads.DesignPattern.Library.BehavioralPatterns.Strategy.DiscountStrategy
{
    public class PercentageDiscountStrategy : IDiscountStrategy
    {
        public decimal DiscountPercent { get; set; }

        public PercentageDiscountStrategy(decimal discountPercent) => DiscountPercent = discountPercent;

        public SalesOrder ApplyDiscount(SalesOrder salesOrder)
        {
            salesOrder.SetDiscountType(DiscountType.Percentage);
            salesOrder.SetAmountAfterDiscount(salesOrder.Amount * DiscountPercent / 100);
            return salesOrder;
        }
    }
}
