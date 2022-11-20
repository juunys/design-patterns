package decorator

import (
	c "github.com/juunys/structural/decorator/component"
)

type TomatoTopping struct {
	pizza c.PizzaComponent
}

func NewTomatoTopping(pizza c.PizzaComponent) *TomatoTopping {
	return &TomatoTopping{
		pizza: pizza,
	}
}

func (c *TomatoTopping) GetPrice() int {
	pizzaPrice := c.pizza.GetPrice()
	return pizzaPrice + 7
}
