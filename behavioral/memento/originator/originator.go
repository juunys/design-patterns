package originator

import (
	"fmt"

	m "github.com/juunys/behavioral/memento/memento"
)

type Originator struct {
	state string
}

func NewOriginator(state string) *Originator {
	return &Originator{state: state}
}

func (o *Originator) SaveMemento() *m.ConcreteMemento {
	return &m.ConcreteMemento{State: o.state}
}

func (o *Originator) RestoreMemento(m *m.ConcreteMemento) {
	if m != nil {
		o.state = m.GetSavedState()
		fmt.Printf("Restored to State: %s\n", o.GetState())
	}
}

func (o *Originator) SetState(state string) {
	o.state = state
}

func (o *Originator) GetState() string {
	return o.state
}
