package main

type Caretaker struct {
	mementoArray []*Memento
}

func NewCaretaker() *Caretaker {
	return &Caretaker{mementoArray: make([]*Memento, 0)}
}

func (c *Caretaker) AddMemento(m *Memento) {
	c.mementoArray = append(c.mementoArray, m)
}
func (c *Caretaker) GetMemento(index int) *Memento {
	return c.mementoArray[index]
}
