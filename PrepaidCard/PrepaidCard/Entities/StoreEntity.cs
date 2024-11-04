namespace PrepaidCard.Entities
{
    public class StoreEntity
    {
        public int StoreId { get; set; }//מזהה חנות
        public string StoreName { get; set; }//שם
        public string Address { get; set; }//כתובת
        public string City { get; set; }//עיר
        public string Phone { get; set; }//טלפון
        public string Email { get; set; }//מייל
        public string Manager { get; set; }//מנהל
        public string SiteStore { get; set; }//אתר חנות
        public StoreEntity() { }

        public StoreEntity(int storeId, string name, string address, string city, string phone, string email, string manager,string siteStore)
        {
            StoreId = storeId;
            StoreName = name;
            Address = address;
            City = city;
            Phone = phone;
            Email = email;
            Manager = manager;
            SiteStore = siteStore;
        }
    }
}
