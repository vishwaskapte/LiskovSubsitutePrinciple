// See https://aka.ms/new-console-template for more information

using LiskovSubsitutePrinciple;

Product laptop = new ElectronicsProduct(80000.00, 12);

// Liskov Substitution Principle in action
double discountedLaptopPrice = laptop.CalculateDiscount();
Console.WriteLine("Discount for laptop: Rs. " + discountedLaptopPrice);

Product wardrobe = new FurnitureProduct(37000.00, 12);

// Liskov Substitution Principle in action
double discountedWardrobePrice = wardrobe.CalculateDiscount();
Console.WriteLine("Discount for wardrobe: Rs. " + discountedWardrobePrice);
