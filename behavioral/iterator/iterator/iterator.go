package iterator

import (
	m "github.com/juunys/behavioral/iterator/model"
)

type Iterator interface {
	HasNext() bool
	GetNext() *m.User
}
