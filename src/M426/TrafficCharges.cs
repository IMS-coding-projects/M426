namespace M426
{
    public static class TrafficCharges
    {
        public static double EngineCubicCapacity(double cubicCapacity)
        {
            double tax = 0;

            // Calculate additional tax based on cubic capacity over thousands of cc
            //tax += ((int)(cubicCapacity / 1000) - 11) * 0.3;

            // Use switch with range patterns
            tax += cubicCapacity switch
            {
                <= 1200 => 69,
                <= 1400 => 88,
                <= 1600 => 108,
                <= 1800 => 128,
                <= 2000 => 148,
                <= 2500 => 208,
                <= 3000 => 358,
                <= 3500 => 508,
                <= 4000 => 658,
                <= 4500 => 808,
                <= 5000 => 958,
                <= 5500 => 1108,
                <= 6000 => 1258,
                <= 7000 => 1558,
                <= 8000 => 1858,
                <= 9000 => 2158,
                <= 10000 => 2458,
                <= 11000 => 2758,
                _ => 0
            };
            
            if (cubicCapacity > 11000)
            {
                tax += 2758 + (Math.Ceiling(cubicCapacity / 1000) - 11) * 300;
            }

            return tax;
        }
    }
}