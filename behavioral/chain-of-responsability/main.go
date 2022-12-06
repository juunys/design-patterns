package main

import (
	"github.com/juunys/behavioral/chain-of-responsability/handler"
	m "github.com/juunys/behavioral/chain-of-responsability/model"
)

func main() {
	cashier := handler.NewCashier()

	medical := handler.NewMedical()
	medical.SetNext(cashier)

	doctor := handler.NewDoctor()
	doctor.SetNext(medical)

	reception := handler.NewReception()
	reception.SetNext(doctor)

	patient := m.NewPatient("abc")
	reception.Execute(patient)
}
