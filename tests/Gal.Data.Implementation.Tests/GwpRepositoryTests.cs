using Gal.Data.Implementation.Repositories;
using System;
using Xunit;

namespace Gal.Data.Implementation.Tests
{
    public class GwpRepositoryTests
    {
        [Fact]
        public void GwpRepository_GetAverage_Throws()
        {
            var sut = new GwpRepository();
            Assert.ThrowsAsync<NotImplementedException>(() => sut.GetAverageForPeriodAsync("", "", 0, 0));
        }
    }
}
