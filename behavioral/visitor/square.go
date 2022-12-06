package main

type Square struct {
	side int
}

func NewSquare(side int) *Square {
	return &Square{
		side: side,
	}
}

func (s *Square) accept(v Visitor) {
	v.visitForSquare(s)
}

func (s *Square) getType() string {
	return "Square"
}
