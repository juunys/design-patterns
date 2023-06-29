package handler

import (
	"fmt"

	m "github.com/juunys/behavioral/chain-of-responsability/model"
)

type Cashier struct {
	next Department
}

func NewCashier() *Cashier {
	return &Cashier{}
}

func (c *Cashier) Execute(p *m.Patient) {
	if p.PaymentDone {
		fmt.Println("Payment Done")
	}
	fmt.Println("Cashier getting money from patient patient")
}

func (c *Cashier) SetNext(next Department) {
	c.next = next
}
