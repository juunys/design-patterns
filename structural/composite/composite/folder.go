package composite

import (
	"fmt"

	c "github.com/juunys/structural/composite/component"
)

type Folder struct {
	components []c.Component
	Name       string
}

func NewFolder(name string) *Folder {
	return &Folder{
		Name: name,
	}
}

func (f *Folder) Search(keyword string) {
	fmt.Printf("Serching recursively for keyword %s in folder %s\n", keyword, f.Name)
	for _, component := range f.components {
		component.Search(keyword)
	}
}

func (f *Folder) Add(c c.Component) {
	f.components = append(f.components, c)
}
