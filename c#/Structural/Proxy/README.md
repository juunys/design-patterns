# Proxy
Provides an object that acts as a replacement for an actual service object used by a client to control access to it

## Whe To Use
- When we need to create objects on demand when their operations are requested
- When we have a class with sensitive data (which should be restricted access) and it is necessary to provide access control for the original object
- When we have to use classes where the creation of objects takes a long time and consumes a lot of resources
- When should we allow access to a remote object using a local object (referencing the remote object)

## Subject
Defines the common interface for `RealSubject` and `Proxy` so that a `Proxy` can be used anywhere a `RealSubject` is expected

## Proxy
Maintains a reference that allows the proxy to access `RealSubject`. Proxy can refer to a `Subject` if the `RealSubject` and `Subject` interfaces are the same

## RealSubject
Defines the real object that proxy represents