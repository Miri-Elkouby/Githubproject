namespace PrepaidCard.Entities
{
    [Flags]
    public enum TypesOfPaymentMethods { CASH, CREDITCARD, CHECK }
    public class PurchaseEntity
    {
        public int PurchaseId { get; set; }//מזהה רכישה
        public int CustomerId { get; set; }//מזהה לקוח
        public int CardId { get; set; }//מזהה כרטיס
        public int PurchaseCenterId { get; set; }//מזהה מוקד רכישה
        public DateTime DateOfPurchase { get; set; }//תאריך
        public Double Sum { get; set; }//סכום
        public TypesOfPaymentMethods PaymentMethod { get; set; }//אופן התשלום

        public PurchaseEntity()
        {
        }

        public PurchaseEntity(int purchaseId, int customerId, int cardId, int purchaseCenterId, DateTime date, double sum, TypesOfPaymentMethods paymentMethod)
        {
            PurchaseId = purchaseId;
            CustomerId = customerId;
            CardId = cardId;
            PurchaseCenterId = purchaseCenterId;
            DateOfPurchase = date;
            Sum = sum;
            PaymentMethod = paymentMethod;
        }
    }
}
