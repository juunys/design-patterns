package main

import "fmt"

func main() {
	person1 := GetPerson()

	clonedPerson := person1.Clone()
	clonedPerson.Name = "Mary Jane"
	clonedPerson.Age = 24
	clonedPerson.HomeAddress.City = "Rio de Janeiro"

	fmt.Printf("*Source Person*\n %v", person1)
	fmt.Println()
	fmt.Printf("*Cloned Person*\n %v", clonedPerson)
}
