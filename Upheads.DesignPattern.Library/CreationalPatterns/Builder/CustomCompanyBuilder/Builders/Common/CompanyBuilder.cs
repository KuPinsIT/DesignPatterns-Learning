﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upheads.DesignPattern.Library.CreationalPatterns.Builder.CustomCompanyBuilder.Products;

namespace Upheads.DesignPattern.Library.CreationalPatterns.Builder.CustomCompanyBuilder.Builders.Common
{
    /// <summary>
    /// The Builder interface or abstract class declares product 
    /// construction steps that are common to all types of builders.
    /// </summary>
    public abstract class CompanyBuilder
    {
        protected Company _company = new();

        /// <summary>
        /// Get prepared company.
        /// If concrete builders don't follow the same interface 
        /// this method must be moved to the concrete builder's class.
        /// </summary>
        /// <returns>Company.</returns>
        public Company GetCompany() => _company;

        public abstract void CreateNewCompany();
        public abstract void PrepareClass();
        public abstract void PrepareDiscount();
        public abstract void ApplyPaymentMethods();

    }
}
