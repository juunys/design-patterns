package main

import "fmt"

// acts as a client.
// It relies on gunFactory to create instances of various guns
func main() {
	ak47 := GetGunAK47()
	m4a1 := GetGunM4A1()

	fmt.Println(ak47)
	fmt.Println(m4a1)
}
