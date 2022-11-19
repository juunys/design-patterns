package main

import (
	"fmt"

	"github.com/juunys/creational/factory-method/factory"
)

// acts as a client.
// It relies on gunFactory to create instances of various guns
func main() {
	ak47 := factory.GetGunAK47()
	m4a1 := factory.GetGunM4A1()

	fmt.Println(ak47)
	fmt.Println(m4a1)
}
