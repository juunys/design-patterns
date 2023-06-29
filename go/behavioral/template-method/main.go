package main

import "fmt"

func main() {
	smsOTP := NewSms()
	o := Otp{
		iOtp: smsOTP,
	}
	o.genAndSendOTP(4)

	fmt.Println("")
	emailOTP := NewEmail()
	o = Otp{
		iOtp: emailOTP,
	}
	o.genAndSendOTP(4)

}
