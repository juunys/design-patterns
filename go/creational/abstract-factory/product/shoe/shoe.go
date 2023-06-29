package product

// Abstract Product B
type ShoeProduct interface {
	SetLogo(logo string)
	SetSize(size int)
	GetLogo() string
	GetSize() int
}
