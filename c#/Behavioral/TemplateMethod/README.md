# TemplateMethod
Defines the skeleton of an algorithm in an operation in the base class, deferring some steps to subclasses

## When To Use
- When we have a group of algorithms consisting of the same steps
- When we have algorithms that differ only in the implementation of specific steps
- When we want to transparently change algorithms without having to change the client code

## AbstractClass
Implements a `TemplateMethod` that defines a skeleton of an algorithm

## ConcreteClass
Implements the primitive operations to realize specific phases of an algorithm subclasse