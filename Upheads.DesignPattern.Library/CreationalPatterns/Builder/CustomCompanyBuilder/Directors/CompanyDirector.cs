using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upheads.DesignPattern.Library.CreationalPatterns.Builder.CustomCompanyBuilder.Builders.Common;
using Upheads.DesignPattern.Library.CreationalPatterns.Builder.CustomCompanyBuilder.Products;

namespace Upheads.DesignPattern.Library.CreationalPatterns.Builder.CustomCompanyBuilder.Directors
{
    /// <summary>
    /// The Director class defines the order in which to call construction steps,
    /// so you can create and reuse specific configurations of products.
    /// </summary>
    public class CompanyDirector
    {
        private CompanyBuilder _builder;

        public CompanyDirector(CompanyBuilder builder)
        {
            _builder = builder;
        }


        public void ChangeBuilder(CompanyBuilder newBuilder) =>
            _builder = newBuilder;

        /// <summary>
        /// Create company with class, using configurations base on this class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="orgNumber"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        public void CreateCompany()
        {
            _builder.CreateNewCompany();
            _builder.PrepareClass();
            _builder.PrepareDiscount();
            _builder.ApplyPaymentMethods();
        }

        public Company GetCompany() =>
            _builder.GetCompany();
    }
}
