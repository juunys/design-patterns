package abstraction

import (
	"fmt"

	imp "github.com/juunys/structural/bridge/implementation"
)

type Mac struct {
	printer imp.Printer
}

func NewMac() *Mac {
	return &Mac{}
}

func (m *Mac) Print() {
	fmt.Println("Print request for mac")
	m.printer.PrintFile()
}

func (m *Mac) SetPrinter(p imp.Printer) {
	m.printer = p
}
