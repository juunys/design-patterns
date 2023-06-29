package main

import (
	"fmt"

	v "github.com/juunys/behavioral/visitor/visitor"
)

func main() {
	food := v.NewFood(10)
	cigarette := v.NewCigarette(5)
	alcoholicDrink := v.NewAlcoholicDrink(50)

	brazilTaxVisitor := v.NewBrazilTaxVisitor()
	usTaxVisitor := v.NewUSTaxVisitor()

	var cart []v.Product
	cart = append(cart, food)
	cart = append(cart, cigarette)
	cart = append(cart, alcoholicDrink)
	totalBR := float32(0)
	for _, item := range cart {
		totalBR += item.GetPriceWithTaxes(brazilTaxVisitor)
	}

	totalUS := float32(0)
	for _, item := range cart {
		totalUS += item.GetPriceWithTaxes(usTaxVisitor)
	}

	fmt.Println("Total taxes BR: ", totalBR)
	fmt.Println("Total taxes US:", totalUS)
}
