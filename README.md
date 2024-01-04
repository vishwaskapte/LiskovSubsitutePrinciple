
# Liskov Substitution Principle (LSP)

The Liskov Substitution Principle (LSP) is one of the SOLID principles of object-oriented programming and design. It states that objects of a superclass should be able to be replaced with objects of a subclass without affecting the correctness of the program. In other words, a derived class should extend the base class without changing its behavior.

Let's use an example related to product discounts to illustrate the Liskov Substitution Principle:

# Scenario:

Consider a retail system where products have discounts. Initially, there's a Product class with a method for calculating the discount.




## Initial Product Class:

```javascript
public class Product {
    protected double price;

    public Product(double price) {
        this.price = price;
    }

    public double calculateDiscount() {
        // Default discount calculation logic
        return 0.0;
    }

    public double getPrice() {
        return price;
    }
}

```

Now, let's create a derived class for a specific type of product, say, ElectronicProduct.

## ElectronicProduct Class:

```javascript
public class ElectronicProduct extends Product {
    private int warrantyMonths;

    public ElectronicProduct(double price, int warrantyMonths) {
        super(price);
        this.warrantyMonths = warrantyMonths;
    }

    @Override
    public double calculateDiscount() {
        // Custom discount calculation logic for electronic products
        return 0.1 * getPrice(); // 10% discount for electronics
    }

    public int getWarrantyMonths() {
        return warrantyMonths;
    }
}

```
With this setup, the ElectronicProduct class extends Product and overrides the calculateDiscount method to provide a specific discount logic for electronic products.

## Usage in Client Code:

```javascript
public class ShoppingCart {
    public static void main(String[] args) {
        Product laptop = new ElectronicProduct(1000.0, 12);
        
        // Liskov Substitution Principle in action
        double discountedPrice = laptop.calculateDiscount();
        System.out.println("Discounted price: $" + discountedPrice);
    }
}

```
In this example, the ElectronicProduct is used in place of a Product object. According to the Liskov Substitution Principle, the client code can treat ElectronicProduct as a Product, and calling calculateDiscount() on it works seamlessly, providing the specific discount logic for electronic products.

This adherence to the Liskov Substitution Principle ensures that substituting a base class object with a derived class object does not alter the correctness of the program, and it allows for easy extensibility and flexibility in your codebase.



## 🚀 About Me
I'm a full stack developer...


## 🛠 Skills
Project Built on ASP.Net Core


## 🔗 Links
[![portfolio](https://img.shields.io/badge/my_portfolio-000?style=for-the-badge&logo=ko-fi&logoColor=white)](https://vishwaskapte.netlify.app/)

[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/vishwas-kapte-47535621/)

[![twitter](https://img.shields.io/badge/github-1DA1F2?style=for-the-badge&logo=github&logoColor=white)](https://github.com/vishwaskapte/SingleResposibilityPrinciple/)

