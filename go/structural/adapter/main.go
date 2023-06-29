package main

import (
	"github.com/juunys/structural/adapter/adapter"
	"github.com/juunys/structural/adapter/client"
	"github.com/juunys/structural/adapter/service"
)

func main() {
	client := client.NewClient()
	mac := service.NewMac()

	client.InsertLightningConnectorIntoComputer(mac)

	windowsMachine := service.NewWindows()
	windowsMachineAdapter := adapter.NewWindowsAdapter(*windowsMachine)

	client.InsertLightningConnectorIntoComputer(windowsMachineAdapter)
}
