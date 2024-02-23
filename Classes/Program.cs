using Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.Id = 1;
customer.FirstName = "Kaan";
customer.LastName = "İNAÇ";
customer.City = "Ankara";

Customer customer2 = new Customer
{
    Id = 2,
    FirstName = "Berkay",
    LastName = "İNAÇ",
    City = "Ankara"
};

Console.WriteLine(customer2.FirstName);

Console.ReadLine();