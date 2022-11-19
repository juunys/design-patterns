package product

// Concrete Product B1
type AdidasShoe struct {
	Shoe
}

func (s *AdidasShoe) SetLogo(logo string) {
	s.Logo = logo
}

func (s *AdidasShoe) GetLogo() string {
	return s.Logo
}

func (s *AdidasShoe) SetSize(size int) {
	s.Size = size
}

func (s *AdidasShoe) GetSize() int {
	return s.Size
}
