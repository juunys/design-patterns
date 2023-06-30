# Strategy
- Defines a family of algorithms, encapsulates each one and makes them interchangeable
- Allows the algorithm to vary independently of the clients that use it

## When To Use
- Many related classes differ only in their behavior
- We need to use different variants of an algorithm
- An algorithm uses data that customers shouldn't know about
- A class defines many behaviors and they appear as several conditional statements in its operations

## Context
- Class where objects `ConcreteStrategy` will be instantiated
- Keeps a reference to `Strategy` object

## Strategy
- Defines a common interface to all classes that define the various behaviors expected
- The `Context` uses this interface to call the defined algorithm by a `ConcreteStrategy`

## ConcreteStrategy
Classes that implements the algorithms that suit every context

