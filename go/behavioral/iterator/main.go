package main

import (
	"fmt"

	c "github.com/juunys/behavioral/iterator/collection"
	m "github.com/juunys/behavioral/iterator/model"
)

func main() {

	user1 := m.NewUser("a", 30)
	user2 := m.NewUser("b", 20)

	userCollection := c.NewUserCollection([]*m.User{user1, user2})

	iterator := userCollection.CreateIterator()

	for iterator.HasNext() {
		user := iterator.GetNext()
		fmt.Printf("User is %+v\n", user)
	}
}
