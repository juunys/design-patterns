package factory

import (
	i "github.com/juunys/creational/factory-method/interface"
	c "github.com/juunys/creational/factory-method/product"
)

// serves as a factory, which creates guns of the desired type based on an incoming argumen
func GetGunAK47() i.GunProduct {
	return c.NewAK47()
}

func GetGunM4A1() i.GunProduct {
	return c.NewM4A1()
}
