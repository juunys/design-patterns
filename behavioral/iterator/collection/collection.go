package collection

import (
	i "github.com/juunys/behavioral/iterator/iterator"
)

type Collection interface {
	createIterator() i.Iterator
}
