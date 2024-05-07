using SalesSystem.Business;

namespace SalesSystem.Tests
{
    public class BusinessFreightTest
    {
        [Theory(DisplayName = "Should successfully calculate freight up to 5km away")]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void MustCalculateFreightFor5KmWithSuccess(int distanceKm)
        {
            var valueFreight = new BusinessFreight().CalculateShipping(distanceKm);

            Assert.Equal(0.00m, valueFreight);
        }

        [Theory(DisplayName = "Must successfully calculate freight with a distance greater than 5km and less than 15km")]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(14)]
        public void MustCalculateFreightBetween5kmAnd15kmSuccessfully(int distanceKm)
        {
            var valueFreight = new BusinessFreight().CalculateShipping(distanceKm);

            Assert.Equal(10.00m, valueFreight);
        }

        [Theory(DisplayName = "Must successfully calculate freight with a distance of more than 15km")]
        [InlineData(16)]
        [InlineData(20)]
        [InlineData(50)]
        [InlineData(400)]
        public void MustCalculateFreightOver15kmWithSuccess(int distanceKm)
        {
            var valueFreight = new BusinessFreight().CalculateShipping(distanceKm);

            Assert.Equal(30.00m, valueFreight);
        }
    }
}