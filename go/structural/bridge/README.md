# Bridge pattern

## Intention

*Bridge is a structural design pattern that lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.*

---

## Applicability

Use the Bridge when:
* you don't want your code to rely directly on third-party or legacy code;
* you want to use an existing class but its interface is incompatible with the interface your code or domain needs;
* you want to reuse multiple subclasses that lack certain functionality but it's impractical to extend the code of each just to add the functionality you want.

## Implementation - Theory

- Declare the Adapter's interface: This is the interface your client code uses and all concrete Adapters implement. It must have the methods that will be forwarded to the code being adapted;
- Create concrete adaptors that implement the Adapter's interface: you can create as many adapter classes as you need for your code. This class should forward method calls to the code being adapted;
- Forward Adapter method calls to Adaptee: now you only need to forward method calls from your concrete Adapter to the code being adapted.

## Execute

`go run .`