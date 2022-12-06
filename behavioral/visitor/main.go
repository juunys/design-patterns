package main

import "fmt"

func main() {
	square := NewSquare(2)
	circle := NewCircle(3)
	rectangle := NewRectangle(2, 3)

	areaCalculator := NewAreaCalculator()

	square.accept(areaCalculator)
	circle.accept(areaCalculator)
	rectangle.accept(areaCalculator)

	fmt.Println()
	middleCoordinates := NewMiddlewareCoordinates()
	square.accept(middleCoordinates)
	circle.accept(middleCoordinates)
	rectangle.accept(middleCoordinates)
}
