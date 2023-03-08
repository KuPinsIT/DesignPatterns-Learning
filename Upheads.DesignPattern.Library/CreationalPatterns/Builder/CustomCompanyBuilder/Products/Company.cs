using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upheads.DesignPattern.BuildingBlocks.Commons;
using Upheads.DesignPattern.Library.CreationalPatterns.Builder.CustomCompanyBuilder.Products.Enums;

namespace Upheads.DesignPattern.Library.CreationalPatterns.Builder.CustomCompanyBuilder.Products
{
    public class Company
    {
        public Company() {
            Name = "Unknown";
        }

        public Company(string name, string orgNumber, string phone, string email)
        {
            Name = name;
            OrgNumber = orgNumber;
            Phone = phone;
            Email = email;
        }

        public string Name { get; init; }
        public string OrgNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DiscountType DiscountType { get; private set; }
        public CompanyClass CompanyClass { get; private set; }
        public List<PaymentMethod> AvailablePaymentMethods { get; private set; } = new();

        public void SetDiscountType(DiscountType discountType) => DiscountType = discountType;

        public void SetCompanyClass(CompanyClass companyClass) => CompanyClass = companyClass;

        public void SetPaymentMethods(List<PaymentMethod> paymentMethods) => AvailablePaymentMethods = paymentMethods;

        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {Name}", Name);
            Console.WriteLine($"OrgNumber: {OrgNumber}", OrgNumber);
            Console.WriteLine($"Phone: {Phone}", Phone);
            Console.WriteLine($"Email: {Email}", Email);
            Console.WriteLine("----------------");

            Console.WriteLine($"Company on {CompanyClass} class");
            Console.WriteLine($"DiscountType: {DiscountType}", DiscountType);

            Console.WriteLine($"Payment Methods:");
            foreach (var method in AvailablePaymentMethods)
            {
                Console.WriteLine($"   {method}");
            }
        }
    }
}
