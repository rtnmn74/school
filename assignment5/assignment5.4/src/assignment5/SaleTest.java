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
		DiscountPolicy standard = new StandardDiscount();
		itemTest1.setDiscount(standard);
		itemTest2.setDiscount(standard);

		// Assert
		double expected = 1.32;
		double result = saleTest.getTotalDiscount();
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
		DiscountPolicy senior = new SeniorDiscount();
		itemTest1.setDiscount(senior);
		itemTest2.setDiscount(senior);
		// Set Weekday
		Weekday weekday = Weekday.TUESDAY;
		senior.setWeekday(weekday);
		

		// Assert
		double expected = 1.85;
		double result = saleTest.getTotalDiscount();
		assertEquals(result, expected);
	}
	
	@Test
	void testGetInvalidSeniorDiscountAmount() {
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
		DiscountPolicy senior = new SeniorDiscount();
		itemTest1.setDiscount(senior);
		itemTest2.setDiscount(senior);
		// Set Weekday
		Weekday weekday = Weekday.WEDNESDAY;
		senior.setWeekday(weekday);
		

		// Assert
		double expected = 0.00;
		double result = saleTest.getTotalDiscount();
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
		DiscountPolicy preferred = new PreferredDiscount();
		itemTest1.setDiscount(preferred);
		itemTest2.setDiscount(preferred);

		// Assert
		double expected = 2.37;
		double result = saleTest.getTotalDiscount();
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
		
		// Set NO Discount
		DiscountPolicy noDiscount = new NoDiscount();
		itemTest1.setDiscount(noDiscount);
		itemTest2.setDiscount(noDiscount);

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
		
		// Set Standard Discount
		DiscountPolicy standard = new StandardDiscount();
		itemTest1.setDiscount(standard);
		itemTest2.setDiscount(standard);

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
		
		// Set Senior Discount
		DiscountPolicy senior = new SeniorDiscount();
		itemTest1.setDiscount(senior);
		itemTest2.setDiscount(senior);
		
		// Set Weekday
		Weekday weekday = Weekday.TUESDAY;
		senior.setWeekday(weekday);

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
		
		// Set Preferred Discount
		DiscountPolicy preferred = new PreferredDiscount();
		itemTest1.setDiscount(preferred);
		itemTest2.setDiscount(preferred);

		// Assert
		double expected = 24.01;
		double result = saleTest.getDiscountedSubTotal();
		assertEquals(result, expected);
	}

}
