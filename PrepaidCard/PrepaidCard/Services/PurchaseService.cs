using PrepaidCard.Entities;

namespace PrepaidCard.Services
{
    public class PurchaseService
    {
        static List<PurchaseEntity> purchases;
        //שליפת רשימת רכישות
        public List<PurchaseEntity> GetPurchases()
        {
            if (purchases == null)
                return null;
            return purchases;
        }
        //שליפת רכישה לפי מזהה רכישה
        public PurchaseEntity GetPurchaseById(int id)
        {
            if (purchases == null || (purchases.FindIndex(p => p.PurchaseId == id)) == -1)
                return null;
            return purchases.Find(purchase => purchase.PurchaseId == id);
        }
        #region פונקציות מיוחדות
        //שליפת רכישה לפי מזהה כרטיס
        public PurchaseEntity GetPurchaseByCard(int id)
        {
            if (purchases == null || (purchases.FindIndex(b => b.CardId == id)) == -1)
                return null;
            return purchases.Find(purchase => purchase.CardId == id);
        }
        //שליפת רכישה לפי מזהה מוקד
        public PurchaseEntity GetPurchaseByPurchaseCenter(int id)
        {
            if (purchases == null || (purchases.FindIndex(b => b.PurchaseCenterId == id)) == -1)
                return null;
            return purchases.Find(purchase => purchase.PurchaseCenterId == id);
        }
        #endregion

        //הוספת רכישה
        public bool PostPurchase(PurchaseEntity purchase)
        {
            if (purchases == null)
                purchases = new List<PurchaseEntity>();
            if (purchases.Find(p => p.PurchaseId == purchase.PurchaseId) != null) return false;

            purchases.Add(purchase);
            return true;
        }
        //עדכון רכישה
        public bool PutPurchase(int id, PurchaseEntity purchase)
        {
            if (purchases == null || (purchases.FindIndex(b => b.PurchaseId == id) == -1))
                return false;
            int index = purchases.FindIndex(purchase => purchase.PurchaseId == id);
            purchases[index].CardId = purchase.CardId;
            purchases[index].PurchaseId = purchase.PurchaseId;
            purchases[index].Sum= purchase.Sum;
            purchases[index].CustomerId = purchase.CustomerId;
            purchases[index].PurchaseCenterId = purchase.PurchaseCenterId;
            purchases[index].DateOfPurchase = purchase.DateOfPurchase;
            return true;
        }
        //מחיקת רכישה
        public bool DeletePurchase(int id)
        {
            if (purchases == null || (purchases.FindIndex(b => b.PurchaseId == id)) == -1)
                return false;
            purchases.Remove(purchases.Find(p => p.PurchaseId == id));
            return true;
        }
    }
}
