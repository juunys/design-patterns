package main

type NewDiscount struct {
	cart ShoppingCart
}

func NewDiscountStrategy(cart ShoppingCart) *NewDiscount {
	return &NewDiscount{
		cart: cart,
	}
}

func (d NewDiscount) GetDiscount() float32 {
	total := d.cart.GetTotal()
	discount := float32(0)

	if total >= 150 {
		discount = 5
	}

	return total - total*(discount/100)
}
