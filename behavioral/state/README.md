# State pattern

## Intention

*State is a behavioral design pattern that lets an object alter its behavior when its internal state changes. It appears as if the object changed its class.*

---

## Applicability

Use the State when:
* you have an object that behaves differently depending on its current state, the number of states is enormous, and the state-specific code changes frequently;
* you have a class polluted with massive conditionals that alter how the class behaves according to the current values of the class’s fields;
* you have a lot of duplicate code across similar states and transitions of a condition-based state machine.

## Implementation - Theory

- Decide what class will act as the context. It could be an existing class which already has the state-dependent code; or a new class, if the state-specific code is distributed across multiple classes;
- Declare the state interface. Although it may mirror all the methods declared in the context, aim only for those that may contain state-specific behavior;
- For every actual state, create a class that derives from the state interface. Then go over the methods of the context and extract all code related to that state into your newly created class;
- In the context class, add a reference field of the state interface type and a public setter that allows overriding the value of that field;
- Go over the method of the context again and replace empty state conditionals with calls to corresponding methods of the state object;
- To switch the state of the context, create an instance of one of the state classes and pass it to the context. You can do this within the context itself, or in various states, or in the client. Wherever this is done, the class becomes dependent on the concrete state class that it instantiates.

## Execute

`go run .`