package main

import (
	"fmt"

	"github.com/juunys/creational/factory-method/creator"
)

// acts as a client.
// It relies on gunFactory to create instances of various guns
func main() {
	ak47Factory := creator.NewAK47Factory()
	m4a1Factory := creator.NewM4A1Factory()
	ak47 := ak47Factory.FactoryMethod()
	m4a1 := m4a1Factory.FactoryMethod()

	fmt.Println(ak47)
	fmt.Println(m4a1)
}
