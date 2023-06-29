package main

import (
	"fmt"

	c "github.com/juunys/structural/decorator/component"
	d "github.com/juunys/structural/decorator/decorator"
)

func main() {

	pizza := c.NewVeggieMania()

	//Add cheese topping
	pizzaWithCheese := d.NewCheeseTopping(pizza)

	//Add tomato topping
	pizzaWithCheeseAndTomato := d.NewTomatoTopping(pizzaWithCheese)

	fmt.Printf("Price of veggeMania with tomato and cheese topping is %d\n", pizzaWithCheeseAndTomato.GetPrice())
}
