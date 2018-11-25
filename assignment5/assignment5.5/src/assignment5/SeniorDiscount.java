package assignment5;

public class SeniorDiscount extends DiscountPolicy {
	// Variable for weekday
	private Weekday weekday;
	// Variable for rate set to 0.07
	private double rate = 0.07;
	
	//Constructor for Senior Discount
	public SeniorDiscount() {
	}
	
	//Override calculate discount to only calculate senior rate on Tuesdays 
	@Override
	public double calcDiscountAmount(int quantity, double itemUnitPrice) {
		if (weekday.getName() == null || weekday.getName() != "Tuesday") {
			return 0.00;
		} else {
			return (this.rate * itemUnitPrice) * quantity;
		}

	}
	
	// Override set weekday  
	@Override
	public void setWeekday(Weekday weekday) {
		this.weekday = weekday;
		
	}
	
	// Method to get weekday 
	public Weekday getWeekday() {
		return weekday;
	}

}
