# Visitor
Represents an operation to be performed on the structure elements of an object

## When To Use
- When an object structure has many unrelated operations to perform
- When the structure of an object cannot be changed, but you need to perform new operations on it
- Operations need to be performed on concrete classes of an object structure

## Visitor
Declare a `Visit` operation for each `Concrete Element` class in the object structure

## ConcreteVisitor
Implement each operation declared by `Visitor`

## Element
Defines an operation `Accept` that takes a `Visitor` as argument

## ConcreteElement
Implements an operation `Accept` that takes a `Visitor` as argument

## ObjectStructure
- Can enumerate its elements
- Provides interface allowing visitor to visit its elements