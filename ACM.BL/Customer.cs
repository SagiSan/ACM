using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        private string _lastName;
        public string LastName
        {
            get
            { return _lastName; }
            set { _lastName = value; }
        }
        public string FirstName { get; set; }
        public string EmailAdress { get; set; }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;
            return isValid;
        }
    }
}
