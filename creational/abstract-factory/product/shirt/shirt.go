package product

// Abstract Product A
type ShirtProduct interface {
	SetLogo(logo string)
	SetSize(size string)
	GetLogo() string
	GetSize() string
}
