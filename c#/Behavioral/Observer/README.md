# Observer
Defines a one-to-many (1-N) dependency between objects so that when an object changes state, all its dependents are automatically notified and updated

## When To Use
- When a change in the state of an object implies changes in other objects
- When an object must be able to notify other objects but no assumptions about the objects to be notified
- When an abstraction has two aspects and one depends on the other
- When we do not want a strong coupling with the objects that need to know these modifications

## Subject
Publishers object. When any changes occurs in a `Subject` state, notify all of your subscribers

## Observers
Are subscribers. They receive notifications about subjects state changes