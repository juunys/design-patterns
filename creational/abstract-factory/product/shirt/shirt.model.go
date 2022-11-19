package product

import "fmt"

type Shirt struct {
	Logo string
	Size string
}

func (s Shirt) String() string {
	return fmt.Sprintf("Shirt:\nLogo: %s\nSize: %s\n",
		s.Logo,
		s.Size,
	)
}
