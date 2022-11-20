package main

import (
	"fmt"

	"github.com/juunys/creational/abstract-factory/factory"
)

func main() {
	adidasFactory := factory.NewAdidasFactory()
	nikeFactory := factory.NewNikeFactory()

	adidasShoe := adidasFactory.MakeShoe(39)
	adidasShirt := adidasFactory.MakeShirt("P")

	nikeShoe := nikeFactory.MakeShoe(40)
	nikeShirt := nikeFactory.MakeShirt("M")

	fmt.Println("* Adidas Factory *")
	fmt.Println(adidasShoe)
	fmt.Println(adidasShirt)

	fmt.Println("* Nike Factory *")
	fmt.Println(nikeShoe)
	fmt.Println(nikeShirt)

}
