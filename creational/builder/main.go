package main

import (
	"fmt"

	d "github.com/juunys/creational/builder/director"
	i "github.com/juunys/creational/builder/interface"
)

func main() {
	normalBuilder := i.GetNormalBuilder()
	vipBuilder := i.GetVipBuilder()

	director := d.NewDirector(normalBuilder)
	normalHouse := director.BuildHouse()

	println(normalHouse)

	fmt.Println()
	director.SetBuilder(vipBuilder)
	vipHouse := director.BuildHouse()

	println(vipHouse)
}
