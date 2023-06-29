package main

import (
	"fmt"

	abs "github.com/juunys/structural/bridge/abstraction"
	imp "github.com/juunys/structural/bridge/implementation"
)

func main() {

	hpPrinter := imp.NewHp()
	epsonPrinter := imp.NewEpson()

	macComputer := abs.NewMac()

	macComputer.SetPrinter(hpPrinter)
	macComputer.Print()
	fmt.Println()

	macComputer.SetPrinter(epsonPrinter)
	macComputer.Print()
	fmt.Println()

	winComputer := abs.NewWindows()

	winComputer.SetPrinter(hpPrinter)
	winComputer.Print()
	fmt.Println()

	winComputer.SetPrinter(epsonPrinter)
	winComputer.Print()
	fmt.Println()
}
