package product

// Concrete Product A2
type NikeShirt struct {
	Shirt
}

func (s *NikeShirt) SetLogo(logo string) {
	s.Logo = logo
}

func (s *NikeShirt) GetLogo() string {
	return s.Logo
}

func (s *NikeShirt) SetSize(size string) {
	s.Size = size
}

func (s *NikeShirt) GetSize() string {
	return s.Size
}
