# Bridge
- Decouples an abstraction from its implementation so that the two can vary independently
- Separate the object interface from it's implementation

## Abstraction
Abstract class that contains members that define an abstract business object and its functionality

## RefinedAbstraction
Class that inherits from class Abstraction

## Implementor
Interface that acts as a bridge between the abstraction class and the implementer classes and also makes the functionality of the implementer class independent of the abstraction class

## ConcreteImplementor
Classes that implement Implementor and also provide implementation details for associated abstraction class