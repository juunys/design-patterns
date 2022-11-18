package main

// Prototype interface
type PersonPrototype interface {
	Clone() *Person
}

func GetPerson() PersonPrototype {
	return NewPerson()
}
