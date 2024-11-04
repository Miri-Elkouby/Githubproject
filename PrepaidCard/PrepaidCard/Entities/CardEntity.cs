namespace PrepaidCard.Entities
{
    public class CardEntity
    {
        public int CardId { get; set; }//מזהה כרטיס
        public DateTime DateOfPurchase { get; set; } //תאריך רכישה
        public DateTime CardValidity { get; set; } //תוקף כרטיס
        public string PurchaseCenter { get; set; } //מוקד רכישה
        public Double Sum { get; set; }// סכום
        public int CustomerId { get; set; }//מזהה לקוח
        public string ColorCard { get; set; }// צבע כרטיס

        public CardEntity()
        {

        }

        public CardEntity(int cardId, DateTime dateOfPurchase, DateTime cardValidity, string purchaseCenter, double sum, int customerId, string colorCard)
        {
            CardId = cardId;
            DateOfPurchase = dateOfPurchase;
            CardValidity = cardValidity;
            PurchaseCenter = purchaseCenter;
            Sum = sum;
            CustomerId = customerId;
            ColorCard = colorCard;
        }

    }
}
