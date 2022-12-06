package main

import "fmt"

func main() {
	shoppingCart := NewShoppingCart()
	shoppingCart.AddProduct([]*Product{
		{name: "Product 1", price: 50},
		{name: "Product 2", price: 50},
		{name: "Product 3", price: 50},
	})
	fmt.Println(shoppingCart.GetTotal())

	defaultDiscount := NewDefaultDiscountStrategy(*shoppingCart)
	newDiscount := NewDiscountStrategy(*shoppingCart)

	shoppingCart.SetDiscount(defaultDiscount)
	fmt.Println(shoppingCart.GetTotalWithDiscount())

	shoppingCart.SetDiscount(newDiscount)
	fmt.Println(shoppingCart.GetTotalWithDiscount())
}
