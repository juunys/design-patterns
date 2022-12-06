# Chain of Responsibility pattern

## Intention

*Chain of Responsibility is a behavioral design pattern that lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.*

---

## Applicability

Use the Memento factory when:
* your program is expected to process different kinds of requests in various ways, but the exact types of requests and their sequences are unknown beforehand;
* it’s essential to execute several handlers in a particular order;
* the set of handlers and their order are supposed to change at runtime.

## Implementation - Theory

- Declare the handler interface and describe the signature of a method for handling requests;
- To eliminate duplicate boilerplate code in concrete handlers, it might be worth creating an abstract base handler class, derived from the handler interface;
- One by one create concrete handler subclasses and implement their handling methods. Each handler should make two decisions when receiving a request;
    - Whether it’ll process the request.
    - Whether it’ll pass the request along the chain.
- The client may either assemble chains on its own or receive pre-built chains from other objects. In the latter case, you must implement some factory classes to build chains according to the configuration or environment settings;
- The client may trigger any handler in the chain, not just the first one. The request will be passed along the chain until some handler refuses to pass it further or until it reaches the end of the chain;
- Due to the dynamic nature of the chain, the client should be ready to handle the following scenarios:
    - The chain may consist of a single link.
    - Some requests may not reach the end of the chain.
    - Others may reach the end of the chain unhandled.

## Execute

`go run .`