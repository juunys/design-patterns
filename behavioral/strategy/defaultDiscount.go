package main

type DefaultDiscount struct {
	cart ShoppingCart
}

func NewDefaultDiscountStrategy(cart ShoppingCart) *DefaultDiscount {
	return &DefaultDiscount{
		cart: cart,
	}
}

func (d DefaultDiscount) GetDiscount() float32 {
	total := d.cart.GetTotal()
	discount := float32(0.0)

	if total >= 100 && total < 200 {
		discount = 10
	} else if total >= 200 && total < 300 {
		discount = 20
	} else if total >= 300 {
		discount = 30
	}

	return total - total*(discount/100)
}
