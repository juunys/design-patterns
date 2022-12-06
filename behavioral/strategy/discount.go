package main

type DiscountStrategy interface {
	GetDiscount() float32
}
