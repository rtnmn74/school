package assignment5;

import java.util.*;

public class Sale {

	// Add Vector list for Item
	Vector<Item> itemList = new Vector<Item>();

	// Add item element to Item
	public void addItem(Item item) {
		itemList.addElement(item);
	}

	// Get Discount Amount
	public double getTotalDiscount( ) {
		double subDiscountTotal = 0.0;
		Enumeration<Item> items = itemList.elements();
		while (items.hasMoreElements()) {
			Item theNextItem = (Item) items.nextElement();
			subDiscountTotal += theNextItem.getItemDiscountTotal();
		}
		return Math.round(subDiscountTotal * 100) / 100.00;
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
		return Math.round((getSubTotal() - getTotalDiscount()) *100) / 100.00;
	}

}