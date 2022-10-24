using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FacetedBuilder
{
    public class Person
    {
        //address
        public string StreetAddress, PostCode, City;

        //employment
        public string CompanyName, Position;
        public int AnnualIncome;

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(PostCode)}: {PostCode}, {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {nameof(Position)}, {nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }
}
