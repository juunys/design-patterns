package handler

import (
	"fmt"

	m "github.com/juunys/behavioral/chain-of-responsability/model"
)

type Doctor struct {
	next Department
}

func NewDoctor() *Doctor {
	return &Doctor{}
}

func (d *Doctor) Execute(p *m.Patient) {
	if p.DoctorCheckUpDone {
		fmt.Println("Doctor checkup already done")
		d.next.Execute(p)
		return
	}
	fmt.Println("Doctor checking patient")
	p.DoctorCheckUpDone = true
	d.next.Execute(p)
}

func (d *Doctor) SetNext(next Department) {
	d.next = next
}
