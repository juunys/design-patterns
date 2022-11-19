package pInterface

import (
	m "github.com/juunys/creational/prototype/model"
)

// Prototype interface
type PersonPrototype interface {
	Clone() *m.Person
}

func GetPerson() PersonPrototype {
	return m.NewPerson()
}
