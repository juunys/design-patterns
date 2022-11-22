# Facade pattern

## Intention

*Proxy is a design pattern that is intended to provide a surrogate or location marker for another object to control access to that object.*

---

The Façade is the simplest pattern of all. It is intended to make life easier for client code by creating a facade object for a more complex system.

## Applicability

Use the Facade when:
* you have an expensive object to be created and you don't want to allow direct access to that object (virtual proxy);
* you want to restrict access to parts of your application (protection proxy);
* you want a link between your system and a remote system. The proxy can pretend to be the remote object's interface and handle all the complexity of connection and data transmission (remote proxy)
* you want to cache calls already made (smart proxy or caching proxy)

## Implementation

* If there’s no pre-existing service interface, create one to make proxy and service objects interchangeable. Extracting the interface from the service class isn’t always possible, because you’d need to change all of the service’s clients to use that interface. Plan B is to make the proxy a subclass of the service class, and this way it’ll inherit the interface of the service.
* Create the proxy class. It should have a field for storing a reference to the service. Usually, proxies create and manage the whole life cycle of their services. On rare occasions, a service is passed to the proxy via a constructor by the client.
* Implement the proxy methods according to their purposes. In most cases, after doing some work, the proxy should delegate the work to the service object.
* Consider introducing a creation method that decides whether the client gets a proxy or a real service. This can be a simple static method in the proxy class or a full-blown factory method.
* Consider implementing lazy initialization for the service object.

## Execute

`go run .`