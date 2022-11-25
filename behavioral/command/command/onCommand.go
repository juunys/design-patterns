package command

import (
	"github.com/juunys/behavioral/command/receiver"
)

type OnCommand struct {
	device receiver.Device
}

func NewOnCommand(device receiver.Device) *OnCommand {
	return &OnCommand{device: device}
}

func (c *OnCommand) Execute() {
	c.device.On()
}
