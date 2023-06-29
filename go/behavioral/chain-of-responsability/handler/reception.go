package handler

import (
	"fmt"

	m "github.com/juunys/behavioral/chain-of-responsability/model"
)

type Reception struct {
	next Department
}

func NewReception() *Reception {
	return &Reception{}
}

func (r *Reception) Execute(p *m.Patient) {
	if p.RegistrationDone {
		fmt.Println("Patient registration already done")
		r.next.Execute(p)
		return
	}
	fmt.Println("Reception registering patient")
	p.RegistrationDone = true
	r.next.Execute(p)
}

func (r *Reception) SetNext(next Department) {
	r.next = next
}
