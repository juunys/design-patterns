# Decorator
- Attribute additional responsability to an object dinamically without affect the behaviour of others objects with the same class
- Provides an alternative to inheritance to extends a funcionality

## When to use
- When there is a need to attach or remove behavior for only certain instances of a class instead of all instances of the class
- When the extension through inheritance is impractical
- When we have a class that cannot be inherited because we are inheriting from any other class
- We want to dynamically and transparently add responsibilities to individual objects without affecting other objects
- When we can't use inheritance

## Component
Defines the interface for objects that can have responsibilities added to them dynamically

## ConcreteComponent
Implements Component and your instance can be decorated by behaviour inclusion

## Decorator
Keeps a reference to Component and defines an compatible interface with Component

## ConcreteDecorator
Extends Decorator and can include ou override a funcionality

