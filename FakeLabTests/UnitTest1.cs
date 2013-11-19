using FakeItEasy;
using FakeLab;
using NUnit.Framework;

namespace FakeLabTests
{
    public class UnitTest1
    {
        [Test]
        public void FakeIt()
        {
            var lollipop = A.Fake<ICandy>();
            var shop = A.Fake<ICandyShop>();
            A.CallTo(() => shop.GetTopSellingCandy()).Returns(lollipop);
            var developer = new SweetTooth();
            developer.BuyTastiestCandy(shop);
            A.CallTo(() => shop.BuyCandy(lollipop)).MustHaveHappened();
        }
    }
}
