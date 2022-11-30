package receiver

type Device interface {
	On()
	Off()
}

func NewTvDevice() Device {
	return newTv()
}
