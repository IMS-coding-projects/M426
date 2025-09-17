using System.Collections;

namespace M426
{
    public class TrafficCharges(List<TaxRange> taxRanges, int additionalTaxPer1000CcOverLimit)
    {
        private List<TaxRange> TaxRanges { get; set; } = taxRanges;
        private int AdditionalTaxPer1000CcOverLimit { get; set; } = additionalTaxPer1000CcOverLimit;

        // constructor

        public double EngineCubicCapacity(double cubicCapacity)
        {
            double tax = 0;
            double maxCubicCapacity = 0;
            double maxCubicCapacityTax = 0;
            
            foreach (var taxRange in TaxRanges)
            {
                maxCubicCapacity = taxRange.max;
                maxCubicCapacityTax = taxRange.tax;
                if (cubicCapacity <= taxRange.max && cubicCapacity >= taxRange.min)
                {
                    return taxRange.tax;
                }
            }
            
            if (cubicCapacity > maxCubicCapacity)
            {
                tax += maxCubicCapacityTax + (Math.Ceiling(cubicCapacity / 1000) - maxCubicCapacity / 1000) * additionalTaxPer1000CcOverLimit;
            }
            
            return tax;
        }
    }
}