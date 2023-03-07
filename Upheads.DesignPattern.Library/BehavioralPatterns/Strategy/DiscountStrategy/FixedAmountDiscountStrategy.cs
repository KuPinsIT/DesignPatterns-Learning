using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upheads.DesignPattern.BuildingBlocks.Commons;

namespace Upheads.DesignPattern.Library.BehavioralPatterns.Strategy.DiscountStrategy
{ 
    public class FixedAmountDiscountStrategy : IDiscountStrategy
    {
        public decimal DiscountAmount { get; set; }

        public FixedAmountDiscountStrategy(decimal discountAmount) => DiscountAmount = discountAmount;
        public SalesOrder ApplyDiscount(SalesOrder salesOrder)
        {
            salesOrder.SetDiscountType(DiscountType.FixedAmount);
            salesOrder.SetAmountAfterDiscount(DiscountAmount);
            return salesOrder;
        }
    }
}
