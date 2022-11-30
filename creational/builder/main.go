package main

import (
	"fmt"

	b "github.com/juunys/creational/builder/builder"
	d "github.com/juunys/creational/builder/director"
)

func main() {
	normalBuilder := b.GetNormalBuilder()
	vipBuilder := b.GetVipBuilder()

	director := d.NewDirector(normalBuilder)
	normalHouse := director.BuildHouse()

	println(normalHouse)

	fmt.Println()
	director.SetBuilder(vipBuilder)
	vipHouse := director.BuildHouse()

	println(vipHouse)
}
