package client

import (
	"fmt"

	i "github.com/juunys/structural/adapter/interface"
)

type Client struct{}

func NewClient() *Client {
	return &Client{}
}

func (c *Client) InsertLightningConnectorIntoComputer(com i.Computer) {
	fmt.Println("Client inserts Lightning connector into computer.")
	com.InsertIntoLightningPort()
}
