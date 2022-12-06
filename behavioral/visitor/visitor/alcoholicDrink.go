package visitor

type AlcoholicDrink struct {
	product Product
	price   float32
}

func NewAlcoholicDrink(price float32) *AlcoholicDrink {
	return &AlcoholicDrink{
		price: price,
	}
}

func (a AlcoholicDrink) GetPrice() float32 {
	return a.price
}

func (a AlcoholicDrink) GetPriceWithTaxes(visitor TaxVisitor) float32 {
	return visitor.CalculateTaxesForAlcoholicDrink(a)
}
