package visitor

type TaxVisitor interface {
	CalculateTaxesForFood(food Food) float32
	CalculateTaxesForCigarette(cigarette Cigarette) float32
	CalculateTaxesForAlcoholicDrink(alcoholicDrink AlcoholicDrink) float32
}
