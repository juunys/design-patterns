package product

// Concrete Product B2
type NikeShoe struct {
	Shoe
}

func (s *NikeShoe) SetLogo(logo string) {
	s.Logo = logo
}

func (s *NikeShoe) GetLogo() string {
	return s.Logo
}

func (s *NikeShoe) SetSize(size int) {
	s.Size = size
}

func (s *NikeShoe) GetSize() int {
	return s.Size
}
