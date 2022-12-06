package visitor

type BrazilTaxVisitor struct{}

func NewBrazilTaxVisitor() *BrazilTaxVisitor {
	return &BrazilTaxVisitor{}
}

func (b BrazilTaxVisitor) CalculateTaxesForFood(food Food) float32 {
	return food.GetPrice() * float32(5)
}

func (b BrazilTaxVisitor) CalculateTaxesForCigarette(cigarette Cigarette) float32 {
	return cigarette.GetPrice() * float32(2)
}

func (b BrazilTaxVisitor) CalculateTaxesForAlcoholicDrink(alcoholicDrink AlcoholicDrink) float32 {
	return alcoholicDrink.GetPrice() * float32(1)
}
