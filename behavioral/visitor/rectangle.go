package main

type Rectangle struct {
	l int
	b int
}

func NewRectangle(l, b int) *Rectangle {
	return &Rectangle{
		l: l,
		b: b,
	}
}

func (t *Rectangle) accept(v Visitor) {
	v.visitForrectangle(t)
}

func (t *Rectangle) getType() string {
	return "rectangle"
}
