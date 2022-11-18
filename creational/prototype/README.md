# Builder pattern

## Intention

*Specify the types of objects to be created using a prototype instance and create new objects by copying that prototype.*

---

The above intent means that you can create prototype objects that have a specific method (`clone`) to clone your data into a new object. This avoids recreating expensive or complex objects to create.

An existing (partially or fully completed) design is a prototype.

## Definitions
* Shallow copy
    -  It's a copy that shares the same references (point to the same underlying values) than those of the source object that the copy was made from
* Deep copy (used in prototype)
    -  It's a copy that doesn't share the same references (point to the same underlying values) than those of the source object that the copy was made from

## Applicability

Use Prototype when:
* Need your code not to depend on concrete classes for creating new objects
* Want to avoid subclass explosion for very similar objects
* Want to avoid recreating "expensive" or "complex" objects

## Execute

`go run .`