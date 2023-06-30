# Mediator
- Defines an object that encapsulates how a set of objects interact
- Allows a group of objects to communicate with each other without coupling them through a mediator object

## When To Use
- Changes in the state of one object affect many other objects
- The large number of interconnections between objects makes the system cumbersome and difficult to change
- You want to be able to change parts of a system independently of each other

## Mediator
Defines a commnunication interface with `Colleague` objects

## ConcreteMediator
Keeps reference to `Colleague` objects. Implements communication and message transfer between `Colleague` classes

## Colleague
Keeps a reference to `Mediator` object and communicates with `Mediator` as needed.

## ConcreteColleague
Communicate with each other through the mediator