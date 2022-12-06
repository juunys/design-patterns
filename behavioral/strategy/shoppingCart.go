package main

type ShoppingCart struct {
	Products         []*Product
	discountStrategy DiscountStrategy
}

func NewShoppingCart() *ShoppingCart {
	return &ShoppingCart{}
}

func (s *ShoppingCart) AddProduct(products []*Product) {
	s.Products = append(s.Products, products...)
}

func (s ShoppingCart) GetProducts() []*Product {
	return s.Products
}

func (s ShoppingCart) GetTotal() float32 {
	total := float32(0.0)
	for _, product := range s.Products {
		total += product.price
	}

	return total
}

func (s ShoppingCart) GetTotalWithDiscount() float32 {
	return s.discountStrategy.GetDiscount()
}

func (s *ShoppingCart) SetDiscount(discount DiscountStrategy) {
	s.discountStrategy = discount
}
