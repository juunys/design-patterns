package service

type Nginx struct {
	Application       *Application
	maxAllowedRequest int
	rateLimiter       map[string]int
}

func NewNginxProxy() *Nginx {
	return &Nginx{
		Application:       &Application{},
		maxAllowedRequest: 2,
		rateLimiter:       make(map[string]int),
	}
}

func (n *Nginx) 																																																																																																																																																																																																																																																																																																																																																																	`(url, method string) (int, string) {
	allowed := n.checkRateLimiting(url)
	if !allowed {
		return 403, "Max request reached"
	}
	return n.Application.HandleRequest(url, method)
}

func (n *Nginx) checkRateLimiting(url string) bool {
	if n.rateLimiter[url] == 0 {
		n.rateLimiter[url] = 1
	}
	if n.rateLimiter[url] > n.maxAllowedRequest {
		return false
	}
	n.rateLimiter[url] += 1
	return true
}
