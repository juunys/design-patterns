# Abstract pattern

## Intention

*Provide an interface for creating families of related or dependent objects without specifying their concrete classes.*

---

## Applicability

Use the Abstract factory when:
* a system must be independent of how its products are created, composed or represented
* a system must be configured as a multi-product family product
* a family of objects is designed to be used together and you need to enforce this constraint
* you want to provide a library of product classes and you only want to reveal their interfaces, not their implementations

## Implementation - Theory

- Create a common interface for all concrete factories;
- Create concrete factories;
- Create corresponding interfaces for each product family;
- Create the concrete products;

## Execute

`go run .`