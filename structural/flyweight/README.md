# Flyweight pattern

## Intention

*Flyweight is a structural design pattern that is intended to use sharing to efficiently support large numbers of objects in a granular way.*

---

Flyweight aims to divide an object into two states: the intrinsic state and the extrinsic state.

* Intrinsic State: Dress in the intrinsic state as it can be shared across multiple Terrorist and Counter-Terrorist objects.
* Extrinsic State: Player location and the player weapon are an extrinsic state as they are different for every object.

## Applicability

Only Use the Flyweight when ALL of the following conditions are true:
* an application uses a large number of objects;
* storage costs are high because of the large number of objects;
* most object states can become extrinsic;
* many objects can be replaced by few shared objects;
* the application does not depend on the identity of objects.

## Implementation

* Divide fields of a class that will become a flyweight into two parts:
    - the intrinsic state: the fields that contain unchanging data duplicated across many objects
    - the extrinsic state: the fields that contain contextual data unique to each object
* Leave the fields that represent the intrinsic state in the class, but make sure they’re immutable. They should take their initial values only inside the constructor.
* Go over methods that use fields of the extrinsic state. For each field used in the method, introduce a new parameter and use it instead of the field.
* Optionally, create a factory class to manage the pool of flyweights. It should check for an existing flyweight before creating a new one. Once the factory is in place, clients must only request flyweights through it. They should describe the desired flyweight by passing its intrinsic state to the factory.
* The client must store or calculate values of the extrinsic state (context) to be able to call methods of flyweight objects. For the sake of convenience, the extrinsic state along with the flyweight-referencing field may be moved to a separate context class.

## Execute

`go run .`