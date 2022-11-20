package factory

import (
	st "github.com/juunys/creational/abstract-method/product/shirt"
	se "github.com/juunys/creational/abstract-method/product/shoe"
)

// Abstract factory
type SportsFactory interface {
	MakeShoe(size int) se.ShoeProduct
	MakeShirt(size string) st.ShirtProduct
}
