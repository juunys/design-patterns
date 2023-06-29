package main

import (
	"fmt"

	c "github.com/juunys/behavioral/memento/caretaker"
	o "github.com/juunys/behavioral/memento/originator"
)

func main() {
	caretaker := c.NewCaretaker()
	originator := o.NewOriginator("A")

	fmt.Printf("Originator Current State: %s\n", originator.GetState())
	caretaker.BackupMemento(originator.SaveMemento())

	originator.SetState("B")
	fmt.Printf("Originator Current State: %s\n", originator.GetState())
	caretaker.BackupMemento(originator.SaveMemento())

	originator.SetState("C")
	fmt.Printf("Originator Current State: %s\n", originator.GetState())
	caretaker.BackupMemento(originator.SaveMemento())

	originator.RestoreMemento(caretaker.Undo())
	originator.RestoreMemento(caretaker.Undo())
	originator.RestoreMemento(caretaker.Undo())
	originator.RestoreMemento(caretaker.Undo())
	originator.RestoreMemento(caretaker.Undo())
}
