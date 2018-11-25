package assignment5;

import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.Test;

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
		double expected = 0.05;
		double result = saleTest.getDiscountRate();
		assertEquals(result, expected);
	}

	@Test
	void testGetDiscount() {
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
		double expected = 1.32;
		double result = saleTest.getDiscount();
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
	void testGetDiscountedSubTotal() {
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
		double expected = 25.06;
		double result = saleTest.getDiscountedSubTotal();
		assertEquals(result, expected);
	}

}
