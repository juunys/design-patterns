package composite

import (
	"fmt"

	c "github.com/juunys/structural/composite/component"
)

type Folder struct {
	Components []c.Component
	Name       string
}

func NewFolder(name string) *Folder {
	return &Folder{
		Name: name,
	}
}

func (f *Folder) Search(keyword string) {
	fmt.Printf("Serching recursively for keyword %s in folder %s\n", keyword, f.Name)
	for _, composite := range f.Components {
		composite.Search(keyword)
	}
}

func (f *Folder) Add(c c.Component) {
	f.Components = append(f.Components, c)
}
