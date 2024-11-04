using PrepaidCard.Entities;

namespace PrepaidCard.Services
{
    public class CustomerService
    {

        static List<CustomerEntity> customers;
        //שליפת רשימת לקוחות
        public List<CustomerEntity> GetCustomers()
        {
            if (customers == null)
                return null;
            return customers;
        }
        //שליפת לקוח לפי מזהה
        public CustomerEntity GetCustomerById(int id)
        {
            if (customers == null || (customers.FindIndex(c => c.CustomerId == id) == -1))
                return null;
            return customers.Find(c => c.CustomerId == id);
        }
        #region פונקציות מיוחדות

        //פונקציה זו עדין אינה טובה צריך לטפל בה

        ////שליפת לקוחות לפי תאריך הצטרפות
        //public CustomerEntity GetCustomersByDateOfJoin(DateTime DateOfJoin)
        //{
        //    if (customers == null || (customers.FindIndex(c => c.CustomerId == id) == -1))
        //        return null;
        //    return customers.Find(c => c.CustomerId == id);
        //}
        #endregion

        //הוספת לקוח
        public bool PostCustomer(CustomerEntity customer)
        {
            if (customers == null)
                customers = new List<CustomerEntity>();
            if (customers.Find(c => c.CustomerId == customer.CustomerId) != null) return false;

            customers.Add(customer);
            return true;
        }
        //עדכון לקוח
        public bool PutCustomer(int id, CustomerEntity customer)
        {
            if (customers == null || (customers.Find(c => c.CustomerId == id) == null))
                return false;
            int index = customers.FindIndex(c => c.CustomerId == id);
            customers[index].Adress=customer.Adress;
            customers[index].FirstName=customer.FirstName;
            customers[index].DateOfBirth=customer.DateOfBirth;
            customers[index].CustomerId=customer.CustomerId;
            customers[index].DateOfJoin=customer.DateOfJoin;
            customers[index].Email=customer.Email;
            customers[index].Phone=customer.Phone;
            customers[index].LastName=customer.LastName;
            return true;
        }
        //מחיקת לקוח
        public bool DeleteCustomer(int id)
        {
            if (customers == null || (customers.Find(c => c.CustomerId == id) == null))
                return false;
            customers.Remove(customers.Find(c => c.CustomerId == id));
            return true;
        }
    }
}
