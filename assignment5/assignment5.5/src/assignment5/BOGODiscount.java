package assignment5;

public class BOGODiscount extends DiscountPolicy {
	// Variable for rate set to 0.5 half off
	private double rate = 0.5;

	// Override to apply discount to quantities over 1
	@Override
	public double calcDiscountAmount(int quantity, double itemUnitPrice) {
		if (quantity <= 1) {
			return 0;
		} else
			return (this.rate * itemUnitPrice) * (quantity - 1);
	}

	@Override
	public void setWeekday(Weekday weekday) {
		// TODO Auto-generated method stub

	}

}
