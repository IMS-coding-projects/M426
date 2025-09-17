using M426;

namespace M426_Test
{
    [TestClass]
    public sealed class TrafficChargesTest
    {
        private readonly TrafficCharges _trafficCharges;

        public TrafficChargesTest()
        {
            var list = new List<TaxRange>
            {
                new TaxRange(int.MinValue, 1200, 69),
                new TaxRange(1201, 1400, 88),
                new TaxRange(1401, 1600, 108),
                new TaxRange(1601, 1800, 128),
                new TaxRange(1801, 2000, 148),
                new TaxRange(2001, 2500, 208),
                new TaxRange(2501, 3000, 358),
                new TaxRange(3001, 3500, 508),
                new TaxRange(3501, 4000, 658),
                new TaxRange(4001, 4500, 808),
                new TaxRange(4501, 5000, 958),
                new TaxRange(5001, 5500, 1108),
                new TaxRange(5501, 6000, 1258),
                new TaxRange(6001, 7000, 1558),
                new TaxRange(7001, 8000, 1858),
                new TaxRange(8001, 9000, 2158),
                new TaxRange(9001, 10000, 2458),
                new TaxRange(10001, 11000, 2758),
            };
            
            _trafficCharges = new TrafficCharges(list, 300);
        }
        
        [TestMethod]
        public void CubicCapacity0_EngineCubicCapacity_ResultTax_69()
        {
            // Arrange
            const double cubicCapacity = 0;
            const double expectedTax = 69;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }
        
        [TestMethod]
        public void CubicCapacity1000_EngineCubicCapacity_ResultTax_69()
        {
            // Arrange
            const double cubicCapacity = 1000;
            const double expectedTax = 69;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }
        
        [TestMethod]
        public void CubicCapacity1200_EngineCubicCapacity_ResultTax_69()
        {
            // Arrange
            const double cubicCapacity = 1200;
            const double expectedTax = 69;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity1201_EngineCubicCapacity_ResultTax_88()
        {
            // Arrange
            const double cubicCapacity = 1201;
            const double expectedTax = 88;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity1400_EngineCubicCapacity_ResultTax_88()
        {
            // Arrange
            const double cubicCapacity = 1400;
            const double expectedTax = 88;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity1401_EngineCubicCapacity_ResultTax_108()
        {
            // Arrange
            const double cubicCapacity = 1401;
            const double expectedTax = 108;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity1600_EngineCubicCapacity_ResultTax_108()
        {
            // Arrange
            const double cubicCapacity = 1600;
            const double expectedTax = 108;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity1601_EngineCubicCapacity_ResultTax_128()
        {
            // Arrange
            const double cubicCapacity = 1601;
            const double expectedTax = 128;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity1800_EngineCubicCapacity_ResultTax_128()
        {
            // Arrange
            const double cubicCapacity = 1800;
            const double expectedTax = 128;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity1801_EngineCubicCapacity_ResultTax_148()
        {
            // Arrange
            const double cubicCapacity = 1801;
            const double expectedTax = 148;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity2000_EngineCubicCapacity_ResultTax_148()
        {
            // Arrange
            const double cubicCapacity = 2000;
            const double expectedTax = 148;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity2001_EngineCubicCapacity_ResultTax_208()
        {
            // Arrange
            const double cubicCapacity = 2001;
            const double expectedTax = 208;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity2500_EngineCubicCapacity_ResultTax_208()
        {
            // Arrange
            const double cubicCapacity = 2500;
            const double expectedTax = 208;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity2501_EngineCubicCapacity_ResultTax_358()
        {
            // Arrange
            const double cubicCapacity = 2501;
            const double expectedTax = 358;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity3000_EngineCubicCapacity_ResultTax_358()
        {
            // Arrange
            const double cubicCapacity = 3000;
            const double expectedTax = 358;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity3001_EngineCubicCapacity_ResultTax_508()
        {
            // Arrange
            const double cubicCapacity = 3001;
            const double expectedTax = 508;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity3500_EngineCubicCapacity_ResultTax_508()
        {
            // Arrange
            const double cubicCapacity = 3500;
            const double expectedTax = 508;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity3501_EngineCubicCapacity_ResultTax_658()
        {
            // Arrange
            const double cubicCapacity = 3501;
            const double expectedTax = 658;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity4000_EngineCubicCapacity_ResultTax_658()
        {
            // Arrange
            const double cubicCapacity = 4000;
            const double expectedTax = 658;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity4001_EngineCubicCapacity_ResultTax_808()
        {
            // Arrange
            const double cubicCapacity = 4001;
            const double expectedTax = 808;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity4500_EngineCubicCapacity_ResultTax_808()
        {
            // Arrange
            const double cubicCapacity = 4500;
            const double expectedTax = 808;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity4501_EngineCubicCapacity_ResultTax_958()
        {
            // Arrange
            const double cubicCapacity = 4501;
            const double expectedTax = 958;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity5000_EngineCubicCapacity_ResultTax_958()
        {
            // Arrange
            const double cubicCapacity = 5000;
            const double expectedTax = 958;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity5001_EngineCubicCapacity_ResultTax_1108()
        {
            // Arrange
            const double cubicCapacity = 5001;
            const double expectedTax = 1108;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity5500_EngineCubicCapacity_ResultTax_1108()
        {
            // Arrange
            const double cubicCapacity = 5500;
            const double expectedTax = 1108;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity5501_EngineCubicCapacity_ResultTax_1258()
        {
            // Arrange
            const double cubicCapacity = 5501;
            const double expectedTax = 1258;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity6000_EngineCubicCapacity_ResultTax_1258()
        {
            // Arrange
            const double cubicCapacity = 6000;
            const double expectedTax = 1258;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity6001_EngineCubicCapacity_ResultTax_1558()
        {
            // Arrange
            const double cubicCapacity = 6001;
            const double expectedTax = 1558;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity7000_EngineCubicCapacity_ResultTax_1558()
        {
            // Arrange
            const double cubicCapacity = 7000;
            const double expectedTax = 1558;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity7001_EngineCubicCapacity_ResultTax_1858()
        {
            // Arrange
            const double cubicCapacity = 7001;
            const double expectedTax = 1858;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity8000_EngineCubicCapacity_ResultTax_1858()
        {
            // Arrange
            const double cubicCapacity = 8000;
            const double expectedTax = 1858;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity8001_EngineCubicCapacity_ResultTax_2158()
        {
            // Arrange
            const double cubicCapacity = 8001;
            const double expectedTax = 2158;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity9000_EngineCubicCapacity_ResultTax_2158()
        {
            // Arrange
            const double cubicCapacity = 9000;
            const double expectedTax = 2158;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity9001_EngineCubicCapacity_ResultTax_2458()
        {
            // Arrange
            const double cubicCapacity = 9001;
            const double expectedTax = 2458;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity10000_EngineCubicCapacity_ResultTax_2458()
        {
            // Arrange
            const double cubicCapacity = 10000;
            const double expectedTax = 2458;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity10001_EngineCubicCapacity_ResultTax_2758()
        {
            // Arrange
            const double cubicCapacity = 10001;
            const double expectedTax = 2758;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacity11000_EngineCubicCapacity_ResultTax_2758()
        {
            // Arrange
            const double cubicCapacity = 11000;
            const double expectedTax = 2758;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        // Edge cases
        [TestMethod]
        public void CubicCapacityNegativeOutOfBound_EngineCubicCapacity_ResultTax_69()
        {
            // Arrange
            const double cubicCapacity = -1;
            const double expectedTax = 69;
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }

        [TestMethod]
        public void CubicCapacityPositiveOutOfBound_EngineCubicCapacity_ResultTax_2758()
        {
            // Arrange
            const double cubicCapacity = 20000;
            const double expectedTax = 2758+(9*300); // 2758 + (20-11)*300 = 5458
            
            // Act
            var actual = _trafficCharges.EngineCubicCapacity(cubicCapacity);
            
            // Assert
            Assert.AreEqual(expectedTax, actual);
        }
    }
}
