using System;
using Xunit;

namespace democlasslib.tests
{
    public class MoneyChanger_Should
    {
        [Fact]
        public void ChangeMoney_Amnt_330_Pay_500_ChangeCorrectly()
        {
            var changer = new MoneyChanger();
            var result = changer.ChangeMoney(330, 500);

            Assert.Equal(100, result[0, 0]);
            Assert.Equal(1, result[0, 1]);

            Assert.Equal(50, result[1, 0]);
            Assert.Equal(1, result[1, 1]);

            Assert.Equal(20, result[2, 0]);
            Assert.Equal(1, result[2, 1]);
        }

        [Theory]
        [InlineData(330, 500, 170)]
        [InlineData(320, 1000, 680)]
        [InlineData(170, 500, 330)]
        public void CalculateMoneyToChange_Amnt_Pay_Change_Correctly(
            int amount, int pay, int shouldChange
        )
        {
            var changer = new MoneyChanger();
            var result = changer.CalcMoneyToChange(amount, pay);
            Assert.Equal(shouldChange, result);
        }
    }
}
