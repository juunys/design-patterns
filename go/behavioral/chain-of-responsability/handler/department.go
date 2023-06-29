package handler

import (
	m "github.com/juunys/behavioral/chain-of-responsability/model"
)

type Department interface {
	Execute(*m.Patient)
	SetNext(Department)
}
