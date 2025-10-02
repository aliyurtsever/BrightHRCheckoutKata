# BrightHR Checkout Kata Application

### Description

This application developed by.Net 9.
This project simulates a simple Checkout system.
Items can be added to the basket using the Scan method.
Products are processed according to pricing rules.
Special offers and discounts can be applied.
The system logs errors and actions using ILogger.
This kata is designed for practicing TDD and SOLID principles.

### Features / Rules

**Products and Prices**

Each product has a unit price.
Special offers can be defined (OfferPrice + OfferQuantity).
A -> 50 each or 3 for 130  
B -> 30 each or 2 for 45  
C -> 20 each  
D -> 15 each  

**Basket Operations**

Add products using Scan(string item).
The basket tracks the quantity and prices of items.
Calculates the total of the basket by applying unit prices and any special pricing rules.

**Additional Discount**

Discounts can be applied as a percentage of the total price.
MyShopPriceRule added to make extra discount.

**Logging**

Operations and errors are logged via ILogger.
In tests, NullLogger ensures safe logging without exceptions.
