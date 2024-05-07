using Moq;
using SalesSystem.Business;
using SalesSystem.Entity;

namespace SalesSystem.Tests
{
    public class SalesBusinessTest
    {
        BusinessSales _businessSales;
        Mock<ISalesRepository> _salesRepositoryMock;

        public SalesBusinessTest()
        {
            var comeback = new List<Sales>
            {
                new Sales
                {
                    Date = new DateTime(2021, 04, 02),
                    Value = 500.00m
                },
                new Sales
                {
                    Date = new DateTime(2021, 04, 05),
                    Value = 50.00m
                },
                new Sales
                {
                    Date = new DateTime(2021, 04, 10),
                    Value = 353.10m
                }
            };

            _salesRepositoryMock = new Mock<ISalesRepository>();
            _salesRepositoryMock.Setup(x => x.SearchSales(It.IsAny<short>(), It.IsAny<short>()))
                .Returns(comeback);

            _businessSales = new BusinessSales(_salesRepositoryMock.Object);
        }

        [Fact(DisplayName = "Must successfully calculate monthly average")]
        public void MustCalculateSuccessfulMonthlyAverage()
        {
            var valueMonthly = _businessSales.CalculateMonthlyAverage(4, 2021);

            Assert.Equal(301.03m, valueMonthly);
        }
    }
}
