package product

// product interface
// defines all methods a gun should have
type GunProduct interface {
	SetName(name string)
	SetPower(power int)
	GetName() string
	GetPower() int
}
