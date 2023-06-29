package iterator

import (
	m "github.com/juunys/behavioral/iterator/model"
)

type UserIterator struct {
	index int
	Users []*m.User
}

func (u *UserIterator) HasNext() bool {
	return u.index < len(u.Users)
}
func (u *UserIterator) GetNext() *m.User {
	if u.HasNext() {
		user := u.Users[u.index]
		u.index++
		return user
	}
	return nil
}
