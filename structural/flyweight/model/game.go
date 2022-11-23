package model

type Game struct {
	Terrorists        []*Player
	CounterTerrorists []*Player
}

func NewGame() *Game {
	return &Game{
		Terrorists:        make([]*Player, 1),
		CounterTerrorists: make([]*Player, 1),
	}
}

func (c *Game) AddTerrorist() {
	player := NewPlayerTerrorist()
	c.Terrorists = append(c.Terrorists, player)
	return
}

func (c *Game) AddCounterTerrorist() {
	player := NewPlayerCounterTerrorist()
	c.CounterTerrorists = append(c.CounterTerrorists, player)
	return
}
