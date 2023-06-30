# Command
- Encapsulate a request as an object, allowing clients to parameterize different requests, queues or log requests, with support for reversing operations
- Converts requests or simple operations into objects

## When To Use
- Parameterize objects by an action when executed
- Specify, queue and execute requests at different times
- Support undo operations
- Structure a system around high-level operations
- Reduce coupling between client requests and the objects that execute them
- Facilitate the implementation of new operations and simplify the maintenance of operations

## Command
Declares a interface to execute an operation

## ConcreteCommand
Defines a link between a `Receiver` object and an `Action`

## Invoker
Solicit `Command` to execute the request

## Receiver
Knows how to execute the associated operations with the command execution

## Client
Create a object `ConcreteCommand` and defines your `Receiver`