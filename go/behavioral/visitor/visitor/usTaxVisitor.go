package visitor

type USTaxVisitor struct{}

func NewUSTaxVisitor() *USTaxVisitor {
	return &USTaxVisitor{}
}

func (u USTaxVisitor) CalculateTaxesForFood(food Food) float32 {
	return food.GetPrice() * float32(0.05)
}

func (u USTaxVisitor) CalculateTaxesForCigarette(cigarette Cigarette) float32 {
	return cigarette.GetPrice() * float32(1.5)
}

func (u USTaxVisitor) CalculateTaxesForAlcoholicDrink(alcoholicDrink AlcoholicDrink) float32 {
	return alcoholicDrink.GetPrice() * float32(0.5)
}
