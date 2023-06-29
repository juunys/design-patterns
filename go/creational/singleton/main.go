package main

import (
	"fmt"
	"sync"
	"time"
)

// Once object will perform an action exactly once and not more
var once sync.Once

type singleton struct {
	initializedInt int
}

var instance *singleton

func GetInstance(i int) *singleton {
	once.Do(func() {
		instance = &singleton{initializedInt: i}
	})

	return instance
}

func main() {
	go func() {
		time.Sleep(time.Millisecond * 100)
		fmt.Println(GetInstance(0))
	}()

	for i := 1; i < 100; i++ {
		go func(i int) {
			fmt.Printf("it[%v] = %v\n", i, GetInstance(i))
		}(i)
	}
}
