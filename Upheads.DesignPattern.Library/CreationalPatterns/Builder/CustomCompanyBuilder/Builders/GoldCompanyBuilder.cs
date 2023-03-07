using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upheads.DesignPattern.BuildingBlocks.Commons;
using Upheads.DesignPattern.Library.CreationalPatterns.Builder.CustomCompanyBuilder.Builders.Common;
using Upheads.DesignPattern.Library.CreationalPatterns.Builder.CustomCompanyBuilder.Products;
using Upheads.DesignPattern.Library.CreationalPatterns.Builder.CustomCompanyBuilder.Products.Enums;

namespace Upheads.DesignPattern.Library.CreationalPatterns.Builder.CustomCompanyBuilder.Builders
{
    /// <summary>
    /// Concrete Builders provide different implementations of the construction steps.
    /// Note that concrete builders may produce products that don't follow the common interface.
    /// </summary>
    public class GoldCompanyBuilder : CompanyBuilder
    {
        public override void CreateNewCompany()
        {
            _company = new Company("Gold", "GOLD12345", "0123456789", "gold@gold.no");
        }

        public override void PrepareClass()
        {
            _company.CompanyClass = CompanyClass.Gold;
        }

        public override void PrepareDiscount()
        {
            _company.DiscountType = DiscountType.Gold;
        }

        public override void ApplyPaymentMethods()
        {
            _company.AvailablePaymentMethods = new List<PaymentMethod> { PaymentMethod.Cash, PaymentMethod.Debit, PaymentMethod.Credit };
        }

    }
}
