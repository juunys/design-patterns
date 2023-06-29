# Visitor pattern

## Intention

*Visitor is a behavioral design pattern that lets you separate algorithms from the objects on which they operate.*

---

## Applicability

Use the Visitor when:
* you need to perform an operation on all elements of a complex object structure (for example, an object tree);
* to clean up the business logic of auxiliary behaviors.
* a behavior makes sense only in some classes of a class hierarchy, but not in others.

## Implementation - Theory

- Declare the visitor interface with a set of “visiting” methods, one per each concrete element class that exists in the program;
- Declare the element interface. If you’re working with an existing element class hierarchy, add the abstract “acceptance” method to the base class of the hierarchy. This method should accept a visitor object as an argument;
- Implement the acceptance methods in all concrete element classes. These methods must simply redirect the call to a visiting method on the incoming visitor object which matches the class of the current element;
- The element classes should only work with visitors via the visitor interface. Visitors, however, must be aware of all concrete element classes, referenced as parameter types of the visiting methods;
- For each behavior that can’t be implemented inside the element hierarchy, create a new concrete visitor class and implement all of the visiting methods;
- The client must create visitor objects and pass them into elements via “acceptance” methods.

## Execute

`go run .`