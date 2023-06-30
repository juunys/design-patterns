# Memento
- It is intended to capture and externalize an object's internal state, without violating encapsulation, so that it can later be restored to this state.
- Allows saving and restoring the state of an object without breaking defined encapsulation rules

## When To Use
- Object state needs to be saved and restored lately
- Object state can't be exposed directly using a interface without expose the implementation

## Originator
- Object to be saved
- Create a `Memento` with a snapshot of current state
- Uses `Memento` to restore this internal state

## Memento
- Represents a stored state
- Stores the internal state of `Originator` object

## Caretaker
- Persists `Memento`
- Provides `Memento` back to `Originator` to restore the internal state