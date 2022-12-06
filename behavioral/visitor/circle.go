package main

type Circle struct {
	radius int
}

func NewCircle(radius int) *Circle {
	return &Circle{
		radius: radius,
	}
}

func (c *Circle) accept(v Visitor) {
	v.visitForCircle(c)
}

func (c *Circle) getType() string {
	return "Circle"
}
