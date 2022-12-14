package factory

import (
	st "github.com/juunys/creational/abstract-factory/product/shirt"
	se "github.com/juunys/creational/abstract-factory/product/shoe"
)

// Concrete factory
type AdidasFactory struct {
}

func NewAdidasFactory() SportsFactory {
	return &AdidasFactory{}
}

func (a *AdidasFactory) MakeShoe(size int) se.ShoeProduct {
	return &se.AdidasShoe{
		Shoe: se.Shoe{
			Logo: "adidas",
			Size: size,
		},
	}
}

func (a *AdidasFactory) MakeShirt(size string) st.ShirtProduct {
	return &st.AdidasShirt{
		Shirt: st.Shirt{
			Logo: "adidas",
			Size: size,
		},
	}
}
