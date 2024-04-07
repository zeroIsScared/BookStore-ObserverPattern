// See https://aka.ms/new-console-template for more information
using BookStore;

Customer customer1 = new Customer();
Customer customer2 = new Customer();
Order order1 = new Order();
Order order2 = new Order();
StaffMember staff1= new StaffMember();
EmailNotificationService emailNotificationService1 = new EmailNotificationService();
SMSNotificationService smsNotificationService2 = new SMSNotificationService();


customer1.Id = 1;
customer2.Id = 2;
order1.Id = 1;
order2.Id = 2;

order1.EventManager.Subscribe(customer1);
order1.EventManager.Subscribe(staff1);

order1.PlaceOrder(emailNotificationService1);
order1.PlaceOrder(smsNotificationService2);
order1.GetOrderReadyForShipping(smsNotificationService2);
order1.GetOrderReadyForShipping(emailNotificationService1);