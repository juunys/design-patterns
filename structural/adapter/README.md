# Adapter pattern

## Intention

*Convert the interface of a class to another interface expected by clients. The Adapter allows certain classes to work together that would otherwise be impossible because of their incompatible interfaces.*

---

## Applicability

Use the Adapter when:
* you don't want your code to rely directly on third-party or legacy code;
* you want to use an existing class but its interface is incompatible with the interface your code or domain needs;
* you want to reuse multiple subclasses that lack certain functionality but it's impractical to extend the code of each just to add the functionality you want.

## Implementation - Theory

- Declare the Adapter's interface (Target in the diagram): This is the interface your client code uses and all concrete Adapters implement. It must have the methods that will be forwarded to the code being adapted (Adaptee in the diagram);
- Create concrete adaptors that implement the Adapter's interface (Adapter in the diagram): you can create as many adapter classes as you need for your code. This class should forward method calls to the code being adapted (Adaptee in the diagram);
- Forward Adapter method calls to Adaptee: now you only need to forward method calls from your concrete Adapter to the code being adapted (Adaptee in the diagram).

## Execute

`go run .`