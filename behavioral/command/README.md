# Command pattern

## Intention

*Command is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.*

---

## Applicability

Use the Memento factory when:
* you want to parametrize objects with operations.;
* you want to queue operations, schedule their execution, or execute them remotely;
* you want to implement reversible operations.

## Implementation - Theory

- Declare the command interface with a single execution method;
- Start extracting requests into concrete command classes that implement the command interface. Each class must have a set of fields for storing the request arguments along with a reference to the actual receiver object. All these values must be initialized via the command’s constructor;
- Identify classes that will act as senders. Add the fields for storing commands into these classes. Senders should communicate with their commands only via the command interface. Senders usually don’t create command objects on their own, but rather get them from the client code;
- Change the senders so they execute the command instead of sending a request to the receiver directly;
- The client should initialize objects in the following order:
    - Create receivers;
    - Create commands, and associate them with receivers if needed;
    - Create senders, and associate them with specific commands.

## Execute

`go run .`