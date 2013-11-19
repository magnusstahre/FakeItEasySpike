namespace FakeLab
{
    public class SweetTooth
    {
        public void BuyTastiestCandy(ICandyShop shop)
        {
            shop.BuyCandy(shop.GetTopSellingCandy());
        }
    }
}