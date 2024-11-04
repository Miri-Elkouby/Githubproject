using PrepaidCard.Entities;

namespace PrepaidCard.Services
{
    public class StoreService
    {

        static List<StoreEntity> store;
        //שליפת רשימת חנויות
        public List<StoreEntity> GetStores()
        {
            if (store == null)
            {
                return null;
            }
            return store;
        }
        //שליפת חנות לפי מזהה חנות
        public StoreEntity GetStoreById(int id)
        {
            if (store == null || (store.Find(s => s.StoreId == id) == null))
                return null;
            return store.Find(store => store.StoreId == id);
        }
        #region פונקציות מיוחדות
        //שליפת חנות לפי שם חנות
        public StoreEntity GetStoreByName(string name)
        {
            if (store == null || (store.Find(s => s.StoreName == name) == null))
                return null;
            return store.Find(store => store.StoreName == name);
        }
        #endregion

        //הוספת חנות
        public bool PostStore(StoreEntity storee)
        {

            if (store == null)
                store = new List<StoreEntity>();
            if (store.Find(s => s.StoreId == storee.StoreId) != null) return false;

            store.Add(storee);
            return true;
        }
        //עדכון חנות
        public bool PutStore(int id, StoreEntity storee)
        {
            if (store == null || (store.Find(s => s.StoreId == id) == null))
                return false;
            int index = store.FindIndex(store => store.StoreId == id);
           
            store[index].StoreId = storee.StoreId;
            store[index].SiteStore=storee.SiteStore;
            store[index].City = storee.City;
            store[index].Email = storee.Email;
            store[index].Address= storee.Address;
            store[index].Manager = storee.Manager;
            store[index].StoreName = storee.StoreName;
            store[index].Phone = storee.Phone;
            return true;

        }
        //מחיקת חנות
        public bool DeleteStore(int id)
        {
            if (store == null || (store.Find(s => s.StoreId == id) == null))
                return false;
            store.Remove(store.Find(store => store.StoreId == id));
            return true;
        }
    }
}
