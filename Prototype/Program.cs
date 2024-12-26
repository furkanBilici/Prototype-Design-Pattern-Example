using Prototype;

Customer customer = new Customer { Name = "Furkan", Id = 13 ,order="Cheese Burger"};
Customer customer2=(Customer) customer.Clone();
customer2.Name = "Furkan Bilici";//klon değiştiriliyor

Console.WriteLine(customer.Name);//nesnenin referansı değişmedi
Console.WriteLine(customer2.Name);//Klon nesne değiştirildi