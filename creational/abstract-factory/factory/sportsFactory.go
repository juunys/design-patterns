package factory

import (
	st "github.com/juunys/creational/abstract-factory/product/shirt"
	se "github.com/juunys/creational/abstract-factory/product/shoe"
)

// Abstract factory
type SportsFactory interface {
	MakeShoe(size int) se.ShoeProduct
	MakeShirt(size string) st.ShirtProduct
}
