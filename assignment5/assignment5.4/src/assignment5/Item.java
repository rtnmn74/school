package assignment5;

public class Item {

	// Item variables
	private String title;
	private double unitPrice;
	private int quantity;
	private DiscountPolicy discount;
	
	// Constructor for Item
	public Item(String inputTitle, double inputUnitPrice, int inputQuantity) {
		this.title = inputTitle;
		this.unitPrice = inputUnitPrice;
		this.quantity = inputQuantity;

	}

	// set title
	public void setTitle(String title) {
		this.title = title;
	}

	// set unitPrice
	public void setUnitPrice(double unitPrice) {
		this.unitPrice = unitPrice;
	}

	// set quantity
	public void setQuantity(int quantity) {
		this.quantity = quantity;
	}

	// Get title
	public String getTitle() {
		return title;
	}

	// Get unitPrie
	public double getUnitPrice() {
		return unitPrice;
	}

	// Get quantity
	public int getQuantity() {
		return quantity;
	}
	
	// Get Discount Policy
	public DiscountPolicy getDiscount() {
		return discount;
	}

	// Get Discount Policy
	public void setDiscount(DiscountPolicy discount) {
		this.discount = discount;
	}
	
	
	// Get item total amount by multiplying quantity by the unit price
	public double getItemTotal() {

		return Math.round((this.unitPrice * this.quantity) * 100) / 100.00;

	}

	// Get item total discount amount
	public double getItemDiscount() {

		return discount.calcDiscountAmount(this.quantity, this.unitPrice);

	}
	
	// Get item total discount amount
	public double getItemDiscountTotal() {

		return (discount.calcDiscountAmount(this.quantity, this.unitPrice));

	}
	
}
