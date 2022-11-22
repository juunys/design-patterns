package main

import (
	"fmt"

	"github.com/juunys/structural/proxy/service"
)

func main() {
	nginxServer := service.NewNginxProxy()
	appStatusURL := "/app/status"
	createUserURL := "create/user"

	httpCode, body := nginxServer.HandleRequest(appStatusURL, "GET")
	fmt.Printf("\nUrl: %s\nHttpCode: %d\nBody: %s\n", appStatusURL, httpCode, body)

	httpCode, body = nginxServer.HandleRequest(appStatusURL, "GET")
	fmt.Printf("\nUrl: %s\nHttpCode: %d\nBody: %s\n", appStatusURL, httpCode, body)

	httpCode, body = nginxServer.HandleRequest(appStatusURL, "GET")
	fmt.Printf("\nUrl: %s\nHttpCode: %d\nBody: %s\n", appStatusURL, httpCode, body)

	httpCode, body = nginxServer.HandleRequest(createUserURL, "POST")
	fmt.Printf("\nUrl: %s\nHttpCode: %d\nBody: %s\n", appStatusURL, httpCode, body)

	httpCode, body = nginxServer.HandleRequest(createUserURL, "GET")
	fmt.Printf("\nUrl: %s\nHttpCode: %d\nBody: %s\n", appStatusURL, httpCode, body)
}
