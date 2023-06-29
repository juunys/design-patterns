package product

// Concrete Product A1
type AdidasShirt struct {
	Shirt
}

func (s *AdidasShirt) SetLogo(logo string) {
	s.Logo = logo
}

func (s *AdidasShirt) GetLogo() string {
	return s.Logo
}

func (s *AdidasShirt) SetSize(size string) {
	s.Size = size
}

func (s *AdidasShirt) GetSize() string {
	return s.Size
}
