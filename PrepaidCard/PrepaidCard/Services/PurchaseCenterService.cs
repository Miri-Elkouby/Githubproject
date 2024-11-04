using PrepaidCard.Entities;

namespace PrepaidCard.Services
{
    public class PurchaseCenterService
    {

        static List<PurchaseCenterEntity> purchaseCenters;
        //שליפת רשימת מוקדים
        public List<PurchaseCenterEntity> GetPurchaseCenters()
        {
            if (purchaseCenters == null)
                return null;
            return purchaseCenters;
        }
        //שליפת מוקד לפי מזהה
        public PurchaseCenterEntity GetPurchaseCenterByID(int id)
        {
            if (purchaseCenters == null || (purchaseCenters.FindIndex(p => p.PurchaseCenterId == id) == -1))
                return null;
            return purchaseCenters.Find(p => p.PurchaseCenterId == id);
        }
        #region פונקציות מיוחדות
        //שליפת מוקד לפי עיר
        public PurchaseCenterEntity GetPurchaseCenterByCity(string city)
        {
            if (purchaseCenters == null || (purchaseCenters.FindIndex(p => p.City == city) == -1))
                return null;
            return purchaseCenters.Find(p => p.City == city);
        }
        #endregion

        //הוספת מוקד
        public bool PostPurchaseCenter(PurchaseCenterEntity purchaseCenter)
        {

            if (purchaseCenters == null)
                purchaseCenters = new List<PurchaseCenterEntity>();
            if (purchaseCenters.Find(p => p.PurchaseCenterId == purchaseCenter.PurchaseCenterId) != null) return false;

            purchaseCenters.Add(purchaseCenter);
            return true;
        }
        //עדכון מוקד
        public bool PutPurchaseCenter(int id, PurchaseCenterEntity purchaseCenter)
        {
            if (purchaseCenters == null || (purchaseCenters.FindIndex(p => p.PurchaseCenterId == id) == -1))
                return false;
            int index = purchaseCenters.FindIndex(p => p.PurchaseCenterId == id);
            purchaseCenters[index].City =purchaseCenter.City;
            purchaseCenters[index].Email = purchaseCenter.Email;
            purchaseCenters[index].Quantity = purchaseCenter.Quantity;
            purchaseCenters[index].PurchaseCenterId = purchaseCenter.PurchaseCenterId;
            purchaseCenters[index].Address = purchaseCenter.Address;
            purchaseCenters[index].Phone = purchaseCenter.Phone;
            purchaseCenters[index].NamePurchasePoint = purchaseCenter.NamePurchasePoint;
            return true;
        }
        //מחיקת מוקד
        public bool DeletePurchaseCenter(int id)
        {
            if (purchaseCenters == null || (purchaseCenters.FindIndex(p => p.PurchaseCenterId == id) == -1))
                return false;
            purchaseCenters.Remove(purchaseCenters.Find(p => p.PurchaseCenterId == id));
            return true;
        }
    }
}
