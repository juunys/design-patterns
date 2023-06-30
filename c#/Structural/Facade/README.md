# Facade
- Provides a unified interface to a set of interfaces in a subsystem

## When to Use
- When we want to simplify a sequence of complex operations
- When we want to simplify the user interface
- When we want to provide a single and uniform interface for the different functionalities of a subsystem
- When we want to create layered systems. A Facade provides the entry point for each subsystem de-layer.

## Facade
Knows which subsystem classes are responsible for a request and then delegates client requests to appropriate subsystem objects

## SubsSystems
Implements their respective functionalities assigned to them and these subsystems have no knowledge of the facade
