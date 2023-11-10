namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IndiviualCustomer customer1 = new IndiviualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Enes";
            customer1.Surname = "Samancioglu";
            customer1.TcNo = "12345678910";


            
            CorporateCustomer coorporate2 = new CorporateCustomer();
            coorporate2.Id = 2;
            coorporate2.CustomerNumber = "54321";
            coorporate2.CompanyName = "Kodlama.io";
            coorporate2.TaxNumber = "1234567890";
            

            Customer customer3 = new IndiviualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Add(customer4);


        }
    }
}