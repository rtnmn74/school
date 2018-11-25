package assignment5;

import java.util.*;

public class Sale {
	/*
	 * // Constant variables for Discount Rates private static double
	 * STANDARD_DISCOUNT_RATE = 0.05; private static double SENIOR_DISCOUNT_RATE =
	 * 0.07; private static double PREFERRED_DISCOUNT_RATE = 0.09;
	 */
	// Enum for Discount
	private Discount discount;
	private Weekday weekday;

	// Add Vector list for Item
	Vector<Item> itemList = new Vector<Item>();

	// Add item element to Item
	public void addItem(Item item) {
		itemList.addElement(item);
	}

	public Discount getDiscount() {
		return discount;
	}

	public void setDiscount(Discount discount) {
		this.discount = discount;
	}

	// Get Week Day
	public Weekday getWeekday() {
		return weekday;
	}

// Set Week Day
	public void setWeekday(Weekday weekday) {
		this.weekday = weekday;
	}

	// Get Discount Rate based on Discount Type
	public double getDiscountRate() {
		// Switch statement to return the discount rate
		// Standard Rate is 0.05, Senior Rate is 0.07, Preferred Rate is 0.09
		if (discount == null) {
			return 0.00;
		} else {
			switch (discount) {

			case STANDARD:
				return 0.05;

			case SENIOR:
				if (getWeekday() != Weekday.TUESDAY)
					return 0.00;
				else
					return 0.07;

			case PREFERRED:
				return 0.09;

			default:
				return 0.00;
			}
		}
	}

	// Get Discount Amount
	public double getDiscountAmount() {
		return Math.round((getSubTotal() * getDiscountRate()) * 100) / 100.00;
	}

	// Get Sub-total Amount of all items
	public double getSubTotal() {
		double subTotal = 0.0;
		Enumeration<Item> items = itemList.elements();
		while (items.hasMoreElements()) {
			Item theNextItem = (Item) items.nextElement();
			subTotal += theNextItem.getItemTotal();
		}
		return Math.round(subTotal * 100) / 100.00;
	}

	// Get Discounted Sub-total
	public double getDiscountedSubTotal() {
		return Math.round((getSubTotal() - getDiscountAmount()) * 100) / 100.00;
	}
}