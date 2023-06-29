package adapter

import (
	"fmt"

	"github.com/juunys/structural/adapter/service"
)

type WindowsAdapter struct {
	windowMachine *service.Windows
}

func NewWindowsAdapter(windowsMachine service.Windows) *WindowsAdapter {
	return &WindowsAdapter{
		windowMachine: &windowsMachine,
	}
}

func (w *WindowsAdapter) InsertIntoLightningPort() {
	fmt.Println("Adapter converts Lightning signal to USB.")
	w.windowMachine.InsertIntoUSBPort()
}
