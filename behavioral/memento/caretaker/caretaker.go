package caretaker

import (
	"fmt"

	m "github.com/juunys/behavioral/memento/memento"
)

type Caretaker struct {
	mementoArray []*m.ConcreteMemento
}

func NewCaretaker() *Caretaker {
	return &Caretaker{mementoArray: make([]*m.ConcreteMemento, 0)}
}

func (c *Caretaker) BackupMemento(m *m.ConcreteMemento) {
	c.mementoArray = append(c.mementoArray, m)
	fmt.Printf("Saving memento backup: %s\n", m.State)
}

func (c *Caretaker) Undo() *m.ConcreteMemento {
	if len(c.mementoArray) <= 0 {
		fmt.Println("No memento!")
		return nil
	}

	concreteMemento := c.mementoArray[len(c.mementoArray)-1]
	c.mementoArray = c.mementoArray[:len(c.mementoArray)-1]

	fmt.Printf("Restoring memento to: %s\n", concreteMemento.State)

	return concreteMemento
}
