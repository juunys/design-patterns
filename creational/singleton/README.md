# Singleton pattern

## Intention
*Ensuring that a class has only one instance in the program and providing a global access point for it.*
---

Singleton is a design pattern that is intended to solve two problems in an application:
- **Ensure that a class has only one instance in the program** - This is very common for programs that access shared resources, such as databases, file systems, GUIs, program modules and more.
- **Provide a global access point for it** - this makes the singleton very similar to global variables, because we have a single object, with global access, being used by several parts of the application.

## Applicability
Use the singleton when:
* A class needs to have only one instance available throughout your program;
* Realize you are using global variables to hold important parts of the program, such as configuration variables that are used throughout the application.

## Implementation - Theory
- Declare  a private field in class to store the Singleton instance;
- Declare a public method (getter) to obtain the Singleton instance;
- In the public method call, add *lazy instantiation*, that is, check if a Singleton instance has already been created; if it was, return it, if not create a new instance and return it.
- Do not allow new instances of the class. You can easily achieve this goal by making the class constructor private.

## Execute
`go run main.go`