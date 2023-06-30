# State
Allows an object to change its behavior when its internal state changes

## When To Use
- When you have an object that behaves differently depending on its current state, the number of states is huge and the state specific code changes frequently
- When the state of an object cannot be exposed directly using an interface without exposing the implementation

## Context
- Defines the interface of interest to customers
- Maintains an instance of the `ConcreteState` subclass that defines the current `State`

## State
- Defines the interface to encapsulate the behavior associated with a given `Context` state
- Interface used by the `Context` object to access mutable functionality

## ConcreteState
- Classes that implement the `State` interface and provide the actual functionality that will be used by the `Context` object
- Each class implements a behavior associated with a single state of the `Context` object