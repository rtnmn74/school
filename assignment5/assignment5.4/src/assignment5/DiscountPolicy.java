package assignment5;

// Abstract class for various discount methods
public abstract class DiscountPolicy {
	
	// Abstract method for calculating discount amount
	public abstract double calcDiscountAmount(int quantity, double itemUnitPrice);
	
	// Abstract method to set weekday
	public abstract void setWeekday(Weekday weekday);

}