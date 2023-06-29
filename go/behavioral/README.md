# Behavioral Patterns

- **Chain of responsibility**: prevents coupling the sender of a request to its receiver, giving more than one object a chance to handle the request. Chains the receiving objects and passes the request along the chain until an object handles it;
- **Command**: Encapsulates a request as an object, thereby allowing you to parameterize clients with different requests, queue or log requests, and support undoable operations;
- **Iterator**: provides a way to sequentially access the elements of an aggregate object without exposing its underlying representation
- **Mediator**: defines an object that encapsulates how a set of objects interact. The mediator promotes loose coupling by preventing objects from explicitly referring to each other, allowing you to vary their interactions independently;
- **Memento**: without violating encapsulation, it captures and externalizes an object's internal state, so that it can later be restored to that state;
- **Observer**: defines a one-to-many dependency between objects, so that when an object changes state, all its dependents are automatically notified and updated;
- **State**: allows an object to change its behavior when its internal state changes. The object will appear to have changed its class.
- **Strategy**: Define a family of algorithms, encapsulate each one of them and make them interchangeable. The strategy allows the algorithm to vary independently of the clients that use it;
- **Template method**: defines the skeleton of an algorithm in one operation, deferring the definition of some steps to subclasses. The template method allows subclasses to redefine certain steps of an algorithm without changing its structure;
- **Visitor**: represents an operation to be performed on the structure elements of an object. The visitor allows you to define a new operation without changing the classes of the elements it operates on.