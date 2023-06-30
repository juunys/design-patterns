# Chain of Responsability
- Avoids coupling the sender of a request to its receiver, giving more than one object a chance to handle the request
- Snap the receiving objects and pass the request along the chain until an object handles it

## When to Use
- When we have more than one handler for a request
- When we have reasons why a manager should pass a request to another in the chain
- When we have a set of handlers that vary dynamically
- When we want to maintain flexibility in assigning requests to handlers

## Handler
Defines an interface to handle requests

## Concrete Handler
Processes the request under his responsibility or sends it to his successor

## Client
Start the request to a `ConcreteHandler` object in the chain of responsability