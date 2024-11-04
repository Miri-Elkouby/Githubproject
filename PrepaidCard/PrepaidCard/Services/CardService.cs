using PrepaidCard.Entities;

namespace PrepaidCard.Services
{
    public class CardService
    {
        static List<CardEntity> cards;
        //שליפת רשימת כרטיסים
        public  List<CardEntity> GetCards()
        {
            if (cards == null)
                return null;
            return cards;
        }
        //שליפת כרטיס לפי מזהה
        public CardEntity GetCardByID(int id)
        {
            if (cards == null || (cards.FindIndex(c => c.CardId == id) == -1))
                return null;
            return cards.Find(card => card.CardId == id);
        }
        #region פונקציות מיוחדות
        //שליפת כרטיס לפי מזהה לקוח
        public CardEntity GetCardByCustomer(int id)
        {
            if (cards == null || (cards.FindIndex(c => c.CustomerId == id) == -1))
                return null;
            return cards.Find(card => card.CustomerId == id);
        }
        #endregion

        //הוספת כרטיס
        public bool PostCard(CardEntity card)
        { 
            if (cards == null)
                cards = new List<CardEntity>();
            if(cards.Find(c => c.CardId == card.CardId)!=null) return false;
            cards.Add(card);
            return true;
        }


        //עדכון פרטי כרטיס
        public bool PutCard(int id, CardEntity card)
        {
            if (cards == null || (cards.FindIndex(c => c.CardId == id) == -1))
                return false;
            int index = cards.FindIndex(card => card.CardId == id);
            cards[index].CardId = card.CardId;
            cards[index].ColorCard = card.ColorCard;
            cards[index].CardValidity = card.CardValidity;
            cards[index].PurchaseCenter = card.PurchaseCenter;
            cards[index].Sum = card.Sum;
            cards[index].PurchaseCenter = card.PurchaseCenter;
            cards[index].DateOfPurchase = card.DateOfPurchase;

            return true;
        }

        //מחיקת כרטיס
        public bool DeleteCard(int id)
        {
            if (cards == null || (cards.FindIndex(c => c.CardId == id) == -1))
                return false;
            cards.Remove(cards.Find(card => card.CardId == id));
            return true;
        }

    }
}
