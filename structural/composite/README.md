# Facade pattern

## Intention

*Compose objects into tree structures to represent tops/whole. Composite allows clients to uniformly treat individual objects and compositions of objects.*

---

## Applicability

Use the Composite when:
* its object structure can be represented hierarchically, for example, tree-like structures;
* you want client code to treat compound objects and simple objects the same way.

## Implementation

* Make sure that the core model of your app can be represented as a tree structure. Try to break it down into simple elements and containers. Remember that containers must be able to contain both simple elements and other containers;
* Declare the component interface with a list of methods that make sense for both simple and complex components;
* Create a leaf class to represent simple elements. A program may have multiple different leaf classes;
* Create a container class to represent complex elements. In this class, provide an array field for storing references to sub-elements. The array must be able to store both leaves and containers, so make sure it’s declared with the component interface type;

While implementing the methods of the component interface, remember that a container is supposed to be delegating most of the work to sub-elements.
* Finally, define the methods for adding and removal of child elements in the container.

Keep in mind that these operations can be declared in the component interface. This would violate the Interface Segregation Principle because the methods will be empty in the leaf class. However, the client will be able to treat all the elements equally, even when composing the tree.

## Execute

`go run .`