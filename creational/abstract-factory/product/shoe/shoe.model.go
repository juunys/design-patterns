package product

import "fmt"

type Shoe struct {
	Logo string
	Size int
}

func (s Shoe) String() string {
	return fmt.Sprintf("Shoe:\nLogo: %s\nSize: %d\n",
		s.Logo,
		s.Size,
	)
}
