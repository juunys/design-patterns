package decorator

import (
	c "github.com/juunys/structural/decorator/component"
)

type CheeseTopping struct {
	pizza c.PizzaComponent
}

func NewCheeseTopping(pizza c.PizzaComponent) *CheeseTopping {
	return &CheeseTopping{
		pizza: pizza,
	}
}

func (c *CheeseTopping) GetPrice() int {
	pizzaPrice := c.pizza.GetPrice()
	return pizzaPrice + 10
}
