package main

import (
	c "github.com/juunys/structural/composite/component"
	"github.com/juunys/structural/composite/composite"
)

func main() {
	file1 := c.NewFile("File1")
	file2 := c.NewFile("File2")
	file3 := c.NewFile("File3")

	folder1 := composite.NewFolder("Folder1")

	folder1.Add(file1)

	folder2 := composite.NewFolder("Folder2")
	folder2.Add(file2)
	folder2.Add(file3)
	folder2.Add(folder1)

	folder2.Search("rose")
}
