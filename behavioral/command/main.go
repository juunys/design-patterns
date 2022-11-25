package main

import (
	"github.com/juunys/behavioral/command/command"
	"github.com/juunys/behavioral/command/invoker"
	"github.com/juunys/behavioral/command/receiver"
)

func main() {
	tv := &receiver.Tv{}

	onCommand := command.NewOnCommand(tv)
	offCommand := command.NewOffCommand(tv)

	button := invoker.NewInvokerButton(onCommand)
	button.Press()

	button.SetCommand(offCommand)
	button.Press()
}
