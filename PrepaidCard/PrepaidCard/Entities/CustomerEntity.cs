namespace PrepaidCard.Entities
{
    public class CustomerEntity
    {
        public int CustomerId { get; set; }//קוד לקוח
        public string FirstName { get; set; }//שם פרטי
        public string LastName { get; set; }//שם משפחה
        public string Phone { get; set; }//טלפון
        public string Adress { get; set; }//כתובת
        public string Email { get; set; }//מייל
        public DateTime DateOfBirth { get; set; } //תאריך לידה
        public DateTime DateOfJoin { get; set; }//תאריך הצטרפות
        public CustomerEntity() { }

        public CustomerEntity(int customerId, string firstName, string lastName, string phone,string adress, string email, DateTime dateOfBirth, DateTime dateOfJoin)
        {
            this.CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Adress= adress;
            Email = email;
            DateOfBirth = dateOfBirth;
            DateOfJoin = dateOfJoin;
        }
    }
}
