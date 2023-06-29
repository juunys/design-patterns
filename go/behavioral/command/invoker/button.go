package invoker

import (
	c "github.com/juunys/behavioral/command/command"
)

type Button struct {
	command c.Command
}

func NewInvokerButton(command c.Command) *Button {
	return &Button{command: command}
}

func (b *Button) SetCommand(command c.Command) {
	b.command = command
}

func (b *Button) Press() {
	b.command.Execute()
}
