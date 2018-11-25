package assignment5;

import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.*;

class SaleTest {

	@Test
	void testAddItem() {
		// Given
		// Construct 2 new Items
		Item itemTest = new Item("Toy", 1.10, 4);

		// Construct new Sale
		Sale saleTest = new Sale();
		// Add items
		saleTest.addItem(itemTest);

		// Assert
		String expected = "Toy";
		String result = itemTest.getTitle();
		assertEquals(result, expected);
	}

	@Test
	void testGetDiscountRate() {
		// Given
		// Construct new Sale
		Sale saleTest = new Sale();

		// Assert
		double expected = 0.00;
		double result = saleTest.getDiscountRate();
		assertEquals(result, expected);
	}


	@Test
	void testGetZeroDiscountRate() {
		// Given
		// Construct new Sale
		Sale saleTest = new Sale();

		// Assert
		double expected = 0.00;
		double result = saleTest.getDiscountRate();
		assertEquals(result, expected);
	}

	@Test
	void testGetStandardDiscountRate() {
		// Given
		// Construct new Sale
		Sale saleTest = new Sale();
		saleTest.setDiscount(Discount.STANDARD);
		saleTest.setWeekday(Weekday.TUESDAY);

		// Assert
		double expected = 0.05;
		double result = saleTest.getDiscountRate();
		assertEquals(result, expected);
	}

	@Test
	void testGetSeniorDiscountRate() {
		// Given
		// Construct new Sale
		Sale saleTest = new Sale();
		saleTest.setDiscount(Discount.SENIOR);
		saleTest.setWeekday(Weekday.TUESDAY);

		// Assert
		double expected = 0.07;
		double result = saleTest.getDiscountRate();
		assertEquals(result, expected);
	}
	
	@Test
	void testGetZeroSeniorDiscountRate() {
		// Given
		// Construct new Sale
		Sale saleTest = new Sale();
		saleTest.setDiscount(Discount.SENIOR);
		saleTest.setWeekday(Weekday.WEDNESDAY);

		// Assert
		double expected = 0.00;
		double result = saleTest.getDiscountRate();
		assertEquals(result, expected);
	}

	@Test
	void testGetPreferredDiscountRate() {
		// Given
		// Construct new Sale
		Sale saleTest = new Sale();
		saleTest.setDiscount(Discount.PREFERRED);
		saleTest.setWeekday(Weekday.TUESDAY);

		// Assert
		double expected = 0.09;
		double result = saleTest.getDiscountRate();
		assertEquals(result, expected);
	}

	@Test
	void testGetZeroDiscountAmount() {
		// Given
		// Construct 2 new Items
		Item itemTest1 = new Item("Toy", 1.10, 4);
		Item itemTest2 = new Item("Shirt", 10.99, 2);

		// Construct new Sale
		Sale saleTest = new Sale();
		// Add items
		saleTest.addItem(itemTest1);
		saleTest.addItem(itemTest2);

		// Assert
		double expected = 0.00;
		double result = saleTest.getDiscountAmount();
		assertEquals(result, expected);
	}

	@Test
	void testGetStandardDiscountAmount() {
		// Given
		// Construct 2 new Items
		Item itemTest1 = new Item("Toy", 1.10, 4);
		Item itemTest2 = new Item("Shirt", 10.99, 2);

		// Construct new Sale
		Sale saleTest = new Sale();
		// Add items
		saleTest.addItem(itemTest1);
		saleTest.addItem(itemTest2);
		// Set Standard Discount
		saleTest.setDiscount(Discount.STANDARD);
		saleTest.setWeekday(Weekday.WEDNESDAY);

		// Assert
		double expected = 1.32;
		double result = saleTest.getDiscountAmount();
		assertEquals(result, expected);
	}

	@Test
	void testGetSeniorDiscountAmount() {
		// Given
		// Construct 2 new Items
		Item itemTest1 = new Item("Toy", 1.10, 4);
		Item itemTest2 = new Item("Shirt", 10.99, 2);

		// Construct New Sale
		Sale saleTest = new Sale();
		// Add items
		saleTest.addItem(itemTest1);
		saleTest.addItem(itemTest2);
		// Set Senior Discount
		saleTest.setDiscount(Discount.SENIOR);
		saleTest.setWeekday(Weekday.TUESDAY);

		// Assert
		double expected = 1.85;
		double result = saleTest.getDiscountAmount();
		assertEquals(result, expected);
	}

	@Test
	void testGetPreferredDiscountAmount() {
		// Given
		// Construct 2 new Items
		Item itemTest1 = new Item("Toy", 1.10, 4);
		Item itemTest2 = new Item("Shirt", 10.99, 2);

		// Construct New Sale
		Sale saleTest = new Sale();
		// Add items
		saleTest.addItem(itemTest1);
		saleTest.addItem(itemTest2);
		// Set Preferred Discount
		saleTest.setDiscount(Discount.PREFERRED);
		saleTest.setWeekday(Weekday.WEDNESDAY);

		// Assert
		double expected = 2.37;
		double result = saleTest.getDiscountAmount();
		assertEquals(result, expected);
	}

	@Test
	void testGetSubTotal() {
		// Given
		// Construct 2 new Items
		Item itemTest1 = new Item("Toy", 1.10, 4);
		Item itemTest2 = new Item("Shirt", 10.99, 2);

		// Construct new Sale
		Sale saleTest = new Sale();
		// Add items
		saleTest.addItem(itemTest1);
		saleTest.addItem(itemTest2);

		// Assert
		double expected = 26.38;
		double result = saleTest.getSubTotal();
		assertEquals(result, expected);
	}

	@Test
	void testGetNoDiscountedSubTotal() {
		// Given
		// Construct 2 new Items
		Item itemTest1 = new Item("Toy", 1.10, 4);
		Item itemTest2 = new Item("Shirt", 10.99, 2);

		// Construct new Sale
		Sale saleTest = new Sale();
		// Add items
		saleTest.addItem(itemTest1);
		saleTest.addItem(itemTest2);

		// Assert
		double expected = 26.38;
		double result = saleTest.getDiscountedSubTotal();
		assertEquals(result, expected);
	}

	@Test
	void testGetStandardDiscountedSubTotal() {
		// Given
		// Construct 2 new items
		Item itemTest1 = new Item("Toy", 1.10, 4);
		Item itemTest2 = new Item("Shirt", 10.99, 2);

		// Construct new Sale
		Sale saleTest = new Sale();
		// Add items
		saleTest.addItem(itemTest1);
		saleTest.addItem(itemTest2);
		// Set Standard Discount Type 1
		saleTest.setDiscount(Discount.STANDARD);
		saleTest.setWeekday(Weekday.WEDNESDAY);

		// Assert
		double expected = 25.06;
		double result = saleTest.getDiscountedSubTotal();
		assertEquals(result, expected);
	}

	@Test
	void testGetSeniorDiscountedSubTotal() {
		// Given
		// Construct 2 new items
		Item itemTest1 = new Item("Toy", 1.10, 4);
		Item itemTest2 = new Item("Shirt", 10.99, 2);

		// Construct new Sale
		Sale saleTest = new Sale();
		// Add items
		saleTest.addItem(itemTest1);
		saleTest.addItem(itemTest2);
		// Set Senior Discount Type 2
		saleTest.setDiscount(Discount.SENIOR);
		saleTest.setWeekday(Weekday.TUESDAY);

		// Assert
		double expected = 24.53;
		double result = saleTest.getDiscountedSubTotal();
		assertEquals(result, expected);
	}

	@Test
	void testGetPreferredDiscountedSubTotal() {
		// Given
		// Construct 2 new items
		Item itemTest1 = new Item("Toy", 1.10, 4);
		Item itemTest2 = new Item("Shirt", 10.99, 2);

		// Construct new Sale
		Sale saleTest = new Sale();
		// Add items
		saleTest.addItem(itemTest1);
		saleTest.addItem(itemTest2);
		// Set Preferred Discount Type 3
		saleTest.setDiscount(Discount.PREFERRED);
		saleTest.setWeekday(Weekday.TUESDAY);

		// Assert
		double expected = 24.01;
		double result = saleTest.getDiscountedSubTotal();
		assertEquals(result, expected);
	}

}
