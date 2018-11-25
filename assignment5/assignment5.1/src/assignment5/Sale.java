package assignment5;

import java.util.*;

public class Sale {
	// Constant variable for Discount Rate 
	private static double DISCOUNT_RATE = 0.05;
	
	// Add Vector list for Item
	Vector<Item> itemList = new Vector<Item>();

	// Add item element to Item
	public void addItem(Item item) {
		itemList.addElement(item);
	}

	// Get Discount Rate
	public double getDiscountRate() {
		return DISCOUNT_RATE;
	}
	
	// Get Discount Amount
	public double getDiscount() {
		return Math.round((getSubTotal() * getDiscountRate())*100) / 100.00;
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
		return Math.round((getSubTotal() - getDiscount()) * 100) / 100.00;
	}
}