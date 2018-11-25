package assignment5;

public class StandardDiscount extends DiscountPolicy {
    
	// Variable for rate set to 0.05
	private double rate = 0.05;

	// Constructor for standard rate
	public StandardDiscount() {
	}

	// Override calculate discount to multiply rate by the unit price 
	@Override
	public double calcDiscountAmount(int quantity, double itemUnitPrice) {
		// Return calculated discount amount
			return (this.rate * itemUnitPrice) * quantity;
	}

	// Override the set weekday method
	@Override
	public void setWeekday(Weekday weekday) {
		// TODO Auto-generated method stub
		
	}


}
