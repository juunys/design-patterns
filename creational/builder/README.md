# Builder pattern

## Intention

*Separating the construction of a complex object from its representation so that the same construction process can create different representations.*

---

* The pattern suggests separating the code that creates and the code that uses the object.
* It deals with the creation of complex objects (really complex), such as:
    - Objects with complex constructors
    - Objects composed of several objects (composite)
    - Objects with complex creation algorithm

## Allows

* Object creation in steps
* Method chaining
* Final object vary in data and type

## Applicability

Use the builder when:
* Object creation becomes complex
* Want the code to be able to generate different representation of the same object

## Execute

`go run .`