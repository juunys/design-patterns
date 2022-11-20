package abstraction

import (
	"fmt"

	imp "github.com/juunys/structural/bridge/implementation"
)

type Windows struct {
	printer imp.Printer
}

func NewWindows() *Windows {
	return &Windows{}
}

func (w *Windows) Print() {
	fmt.Println("Print request for windows")
	w.printer.PrintFile()
}

func (w *Windows) SetPrinter(p imp.Printer) {
	w.printer = p
}
