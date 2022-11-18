# Factory pattern

## Intention

*Define an interface to create an object, but let subclasses decide which class to instantiate. The Factory Method lets you defer instantiation to subclasses.*

---

## Applicability

Use the factory when:
* You're not sure what types of objects your code will need.

Use the factory to:
* Decouple the code you create from the code that uses the classes (Single Responsibility Principle);
* Give a hook to subclasses to let them decide the object creation logic;
* Eliminate code duplication when creating objects.

## Implementation - Theory

- Create a common interface to all products (e.g. Product);
- Create classes that implement the products interface (e.g. ConcreteProduct1, ConcreteProduct2...)
- Create a class (Creator) that implements or contains the factory method. This class can contain data and other methods. There are rare cases where the Creator class is simply an interface with the factory method. The factory method is responsible for creating products that implement the "Product" interface.
- Create concrete classes that extend the Creator class and implement the factory method. ConcreteCreator classes can return different products, as long as those products implement the Product interface.

## Execute

`go run .`