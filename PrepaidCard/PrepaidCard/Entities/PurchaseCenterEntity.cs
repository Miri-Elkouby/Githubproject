namespace PrepaidCard.Entities
{
    public class PurchaseCenterEntity
    {
        public int PurchaseCenterId { get; set; }//מזהה מוקד רכישה
        public string NamePurchasePoint { get; set; }//שם מוקד רכישה
        public string Address { get; set; }//כתובת
        public string City { get; set; }//עיר
        public string Phone { get; set; }//טלפון
        public string Email { get; set; }//מייל
        public int Quantity { get; set; }//כמות המלאי
        public PurchaseCenterEntity() { }

        public PurchaseCenterEntity(int purchaseCenterId, string namePurchasePoint, string address, string city, string phone, string email, int quantity)
        {
            PurchaseCenterId = purchaseCenterId;
            NamePurchasePoint = namePurchasePoint;
            Address = address;
            City = city;
            Phone = phone;
            Email = email;
            Quantity = quantity;
        }
    }
}
