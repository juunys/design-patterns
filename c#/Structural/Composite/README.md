# Composite
- Compose objects into tree-like structures to represent part-whole hierarchies
- Allows clients to treat individual objects and object compositions uniformly (as a single object)

## Component
Interface or abstract class that describes normal operations to simple elements or complex of the tree

## Leaf
Unique object, doesn't has sub elements. Implements standard behaviours according to the Component interface

## Composite
Has others composite objects and implements the Component's methods.