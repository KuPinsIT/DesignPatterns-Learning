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
    public class StandardCompanyBuilder : CompanyBuilder
    {
        public override CompanyBuilder PrepareInformation()
        {
            _company = new Company("Standard", "STANDARD12345", "0123456789", "standard@standard.no");
            return this;
        }

        public override CompanyBuilder PrepareClass()
        {
            _company.SetCompanyClass(CompanyClass.Standard);
            return this;
        }

        public override CompanyBuilder AppyDiscount()
        {
            _company.SetDiscountType(DiscountType.Percentage);
            return this;
        }

        public override CompanyBuilder ApplyPaymentMethods()
        {
            _company.SetPaymentMethods(new List<PaymentMethod> { PaymentMethod.Cash, PaymentMethod.Debit });
            return this;
        }
    }
}
