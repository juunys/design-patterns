package facade

import (
	"fmt"

	c "github.com/juunys/structural/facade/complex"
)

type WalletFacade struct {
	Account      *c.Account
	Wallet       *c.Wallet
	SecurityCode *c.SecurityCode
	Notification *c.Notification
	Ledger       *c.Ledger
}

func NewWalletFacade(accountID string, code int) *WalletFacade {
	fmt.Println("Starting create account")
	walletFacacde := &WalletFacade{
		Account:      c.NewAccount(accountID),
		SecurityCode: c.NewSecurityCode(code),
		Wallet:       c.NewWallet(),
		Notification: &c.Notification{},
		Ledger:       &c.Ledger{},
	}
	fmt.Println("Account created")
	return walletFacacde
}

func (w *WalletFacade) AddMoneyToWallet(accountID string, securityCode, amount int) error {
	fmt.Println("Starting add money to wallet")
	err := w.Account.CheckAccount(accountID)
	if err != nil {
		return err
	}
	err = w.SecurityCode.CheckCode(securityCode)
	if err != nil {
		return err
	}
	w.Wallet.CreditBalance(amount)
	w.Notification.SendWalletCreditNotification()
	w.Ledger.MakeEntry(accountID, "credit", amount)
	return nil
}

func (w *WalletFacade) DeductMoneyFromWallet(accountID string, securityCode, amount int) error {
	fmt.Println("Starting debit money from wallet")
	err := w.Account.CheckAccount(accountID)
	if err != nil {
		return err
	}

	err = w.SecurityCode.CheckCode(securityCode)
	if err != nil {
		return err
	}
	err = w.Wallet.DebitBalance(amount)
	if err != nil {
		return err
	}
	w.Notification.SendWalletDebitNotification()
	w.Ledger.MakeEntry(accountID, "credit", amount)
	return nil
}
