package visitor

type Product interface {
	GetPriceWithTaxes(visitor TaxVisitor) float32
}
