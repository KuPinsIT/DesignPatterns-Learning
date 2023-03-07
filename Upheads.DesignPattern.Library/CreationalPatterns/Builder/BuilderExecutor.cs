using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upheads.DesignPattern.BuildingBlocks;
using Upheads.DesignPattern.Library.CreationalPatterns.Builder.CustomCompanyBuilder.Builders;
using Upheads.DesignPattern.Library.CreationalPatterns.Builder.CustomCompanyBuilder.Builders.Common;
using Upheads.DesignPattern.Library.CreationalPatterns.Builder.CustomCompanyBuilder.Directors;

namespace Upheads.DesignPattern.Library.CreationalPatterns.Builder
{
    public class BuilderExecutor : PatternExecutor
    {
        public override string Name => "Builder - Creational Pattern";

        public override void Execute()
        {
            CompanyBuilder standard = new StandardCompanyBuilder();
            CompanyBuilder gold = new GoldCompanyBuilder();
            CompanyBuilder platinum = new PlatinumCompanyBuilder();

            //Create standard company and display
            var director = new CompanyDirector(standard);
            CreateAndDisplayCompany(director);

            //Create gold company and display
            director = new CompanyDirector(gold);
            CreateAndDisplayCompany(director);

            //This is not common to see, but it is possible to change builder if necessary.
            director.ChangeBuilder(platinum);
            CreateAndDisplayCompany(director);
        }

        private static void CreateAndDisplayCompany(CompanyDirector director)
        {
            var company = director.BuildCompany();
            company.Display();
        }
    }
}
