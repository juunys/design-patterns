package component

type VeggeMania struct {
}

func NewVeggieMania() *VeggeMania {
	return &VeggeMania{}
}

func (p *VeggeMania) GetPrice() int {
	return 15
}
