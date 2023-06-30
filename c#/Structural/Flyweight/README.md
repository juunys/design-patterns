# Flyweight
- Used to create many related small objects without invoking a lot of overhead work in doing so, thus improving performance and maintainability
- Allows programs to support large amounts of objects, keeping memory consumption low

## When To Use
- When many similar objects will be used and storage cost is high
- When we can share state between objects
- When a few shared objects would easily replace many unshared objects
- When we need to save used memory

## Flyweight
Interface that defines the objects members

## ConcreteFlyweight
Implements the interface and adds storage to the intrinsic state

## UnsharedConcreteFlyweight
Implements the interface and adds storage to the particular instance and is not shared

## FlyweightFactory
Creates and manages the flyweight objects

## Client
Keeps a reference to the flyweight and calculate or stores the extrinsic state of the flyweight objects

### State
- intrinsic state (in memory)
- extrinsic state (execution time)