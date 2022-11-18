package factory

type SportsFactory interface {
	makeShoe() Shoe
	makeShirt() Shirt
}

func GetAdidasSportsFactory() SportsFactory {
	return &Adidas{}
}

func GetNikeSportsFactory() SportsFactory {
	return &Nike{}
}
