package memento

type ConcreteMemento struct {
	State string
}

func (m *ConcreteMemento) GetSavedState() string {
	return m.State
}
