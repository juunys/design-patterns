package visitor

type Cigarette struct {
	product Product
	price   float32
}

func NewCigarette(price float32) *Cigarette {
	return &Cigarette{
		price: price,
	}
}

func (c Cigarette) GetPrice() float32 {
	return c.price
}

func (c Cigarette) GetPriceWithTaxes(visitor TaxVisitor) float32 {
	return visitor.CalculateTaxesForCigarette(c)
}
