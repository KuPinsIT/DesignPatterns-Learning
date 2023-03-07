using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upheads.DesignPattern.BuildingBlocks;
using Upheads.DesignPattern.BuildingBlocks.Commons;
using Upheads.DesignPattern.Library.BehavioralPatterns.Strategy.DiscountStrategy;

namespace Upheads.DesignPattern.Library.BehavioralPatterns.Strategy
{
    public class StrategyExecutor : PatternExecutor
    {
        public override string Name => "Strategy - Behavioral Pattern";

        public override void Execute()
        {
            //From company, we get company discount type

            //Discount 20% --> get from configurations or database
            IDiscountStrategy discountStrategy = new PercentageDiscountStrategy(discountPercent: 20);
            ApplyDiscountAndDisplay(discountStrategy);

            //Discount 30 NOK --> get from configurations or database
            discountStrategy = new FixedAmountDiscountStrategy(discountAmount: 30);
            ApplyDiscountAndDisplay(discountStrategy);

            //Discount buy one get one
            discountStrategy = new BuyOneGetOneFreeDiscountStrategy();
            ApplyDiscountAndDisplay(discountStrategy);
        }

        private void ApplyDiscountAndDisplay(IDiscountStrategy discountStrategy)
        {
            SalesOrder salesOrder = new SalesOrder("0001", "Sales Order Apply Discount") { Amount = 100 };

            //Apply discount for order
            salesOrder = discountStrategy.ApplyDiscount(salesOrder);

            salesOrder.Display();
        }
    }
}
