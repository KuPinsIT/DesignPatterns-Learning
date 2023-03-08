using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upheads.DesignPattern.BuildingBlocks.Commons;
using Upheads.DesignPattern.Library.BehavioralPatterns.State;

namespace Upheads.DesignPattern.Library.BehavioralPatterns.Strategy.DiscountStrategy
{
    public interface IDiscountStrategy
    {
        SalesOrder ApplyDiscount(SalesOrder salesOrder);
    }
}
