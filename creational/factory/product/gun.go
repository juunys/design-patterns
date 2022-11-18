package product

// product interface
// defines all methods a gun should have
type GunProduct interface {
	setName(name string)
	setPower(power int)
	getName() string
	getPower() int
}
