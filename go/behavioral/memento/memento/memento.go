package memento

type Memento interface {
	GetSavedState() string
}
