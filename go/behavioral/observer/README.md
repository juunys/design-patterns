# Observer pattern

## Intention

*Observer is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.*

---

## Applicability

Use the Observer factory when:
* changes to the state of one object may require changing other objects, and the actual set of objects is unknown beforehand or changes dynamically;
* some objects in your app must observe others, but only for a limited time or in specific cases.

## Implementation - Theory

- Look over your business logic and try to break it down into two parts: the core functionality, independent from other code, will act as the publisher; the rest will turn into a set of subscriber classes;
- Declare the subscriber interface. At a bare minimum, it should declare a single update method;
- Declare the publisher interface and describe a pair of methods for adding a subscriber object to and removing it from the list. Remember that publishers must work with subscribers only via the subscriber interface;
- Decide where to put the actual subscription list and the implementation of subscription methods. Usually, this code looks the same for all types of publishers, so the obvious place to put it is in an abstract class derived directly from the publisher interface. Concrete publishers extend that class, inheriting the subscription behavior;
- Create concrete publisher classes. Each time something important happens inside a publisher, it must notify all its subscribers;
- Implement the update notification methods in concrete subscriber classes. Most subscribers would need some context data about the event. It can be passed as an argument of the notification method;
- The client must create all necessary subscribers and register them with proper publishers.

## Execute

`go run .`