package factory

import (
	st "github.com/juunys/creational/abstract-method/product/shirt"
	se "github.com/juunys/creational/abstract-method/product/shoe"
)

// Concrete factory
type NikeFactory struct {
}

func (n *NikeFactory) MakeShoe(size int) se.ShoeProduct {
	return &se.NikeShoe{
		Shoe: se.Shoe{
			Logo: "nike",
			Size: size,
		},
	}
}

func (n *NikeFactory) MakeShirt(size string) st.ShirtProduct {
	return &st.NikeShirt{
		Shirt: st.Shirt{
			Logo: "nike",
			Size: size,
		},
	}
}
