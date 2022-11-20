package abstraction

import (
	imp "github.com/juunys/structural/bridge/implementation"
)

type Computer interface {
	Print()
	SetPrinter(imp.Printer)
}
