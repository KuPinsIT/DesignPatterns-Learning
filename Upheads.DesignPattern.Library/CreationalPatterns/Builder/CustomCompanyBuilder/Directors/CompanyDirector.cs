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
        /// Build company with class, using configurations base on this class
        /// </summary>
        public Company BuildCompany()
        {
            return _builder.PrepareInformation()
                .PrepareClass()
                .AppyDiscount()
                .ApplyPaymentMethods()
                .Build();
        }
    }
}
