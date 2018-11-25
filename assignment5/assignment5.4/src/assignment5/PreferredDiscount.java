package assignment5;

// Preferred Discount amount 
public class PreferredDiscount extends DiscountPolicy{

	// Discount rate set to 0.09
	private double rate = 0.09;
	
	// Constructor for Preferred Discount
	public PreferredDiscount() {
	}

	// Override Discount calculation method to multiply rate by the unitPrice 
	@Override
	public double calcDiscountAmount(int quantity, double itemUnitPrice) {
		// Return calculated discount amount
			return (this.rate * itemUnitPrice) * quantity;
	}

	// Override set weekday method
	@Override
	public void setWeekday(Weekday weekday) {
		
	}
}
