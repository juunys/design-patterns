package main

type Train interface {
	Arrive()
	Depart()
	PermitArrival()
}
