package handler

import (
	"fmt"

	m "github.com/juunys/behavioral/chain-of-responsability/model"
)

type Medical struct {
	next Department
}

func NewMedical() *Medical {
	return &Medical{}
}

func (m *Medical) Execute(p *m.Patient) {
	if p.MedicineDone {
		fmt.Println("Medicine already given to patient")
		m.next.Execute(p)
		return
	}
	fmt.Println("Medical giving medicine to patient")
	p.MedicineDone = true
	m.next.Execute(p)
}

func (m *Medical) SetNext(next Department) {
	m.next = next
}
