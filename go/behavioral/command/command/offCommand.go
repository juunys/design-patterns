package command

import (
	"github.com/juunys/behavioral/command/receiver"
)

type OffCommand struct {
	device receiver.Device
}

func NewOffCommand(device receiver.Device) *OffCommand {
	return &OffCommand{device: device}
}

func (c *OffCommand) Execute() {
	c.device.Off()
}
