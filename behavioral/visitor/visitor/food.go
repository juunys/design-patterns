package visitor

type Food struct {
	product Product
	price   float32
}

func NewFood(price float32) *Food {
	return &Food{
		price: price,
	}
}

func (f Food) GetPrice() float32 {
	return f.price
}

func (f Food) GetPriceWithTaxes(visitor TaxVisitor) float32 {
	return visitor.CalculateTaxesForFood(f)
}
