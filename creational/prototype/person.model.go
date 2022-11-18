package main

import (
	"bytes"
	"encoding/gob"
	"fmt"
)

type Person struct {
	Name        string
	Age         int
	HomeAddress *HomeAddress
}

type HomeAddress struct {
	HouseNumber, City, Country string
}

func NewPerson() *Person {
	return &Person{
		Name: "Junedune",
		Age:  26,
		HomeAddress: &HomeAddress{
			HouseNumber: "721",
			City:        "Sao Paulo",
			Country:     "BR",
		},
	}
}

func (p *Person) String() string {
	return fmt.Sprintf("Name: %s\n Age: %d\n HomeAddress: %v\n",
		p.Name,
		p.Age,
		p.HomeAddress,
	)
}

// Prototype concrete with deep copy through serialization
func (p *Person) Clone() *Person {
	pe := &Person{}
	buf := bytes.Buffer{}
	enc := gob.NewEncoder(&buf)
	enc.Encode(p)
	dec := gob.NewDecoder(&buf)
	dec.Decode(pe)
	return pe
}
