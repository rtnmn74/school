package assignment5;

public class NoDiscount extends DiscountPolicy{
	// Return Zero for no discount
	@Override
	public double calcDiscountAmount(int quantity, double itemUnitPrice) {
		return 0.00;
	}
	
	// Set Weekday
	@Override
	public void setWeekday(Weekday weekday) {
		
	}

}
