package collection

import (
	i "github.com/juunys/behavioral/iterator/iterator"
	m "github.com/juunys/behavioral/iterator/model"
)

type UserCollection struct {
	Users []*m.User
}

func NewUserCollection(users []*m.User) *UserCollection {
	return &UserCollection{Users: users}
}

func (u *UserCollection) CreateIterator() i.Iterator {
	return &i.UserIterator{
		Users: u.Users,
	}
}
