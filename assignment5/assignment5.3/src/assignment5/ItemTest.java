package assignment5;

import static org.junit.jupiter.api.Assertions.*;


import org.junit.jupiter.api.Test;

class ItemTest {

	@Test
	void testGetTitle() {
		// Given
		Item itemTest = new Item("Book", 2.20, 3);
		
		// Assert
		String expected = "Book";
		String result = itemTest.getTitle();
		assertEquals(result, expected);
	}

	@Test
	void testGetUnitPrice() {
		// Given
		Item itemTest = new Item("Book", 2.20, 3);
		
		// Assert
		double expected = 2.20;
		double result = itemTest.getUnitPrice();
		assertEquals(result, expected);
	}

	@Test
	void testGetQuantity() {
		// Given
		Item itemTest = new Item("Book", 2.20, 3);

		// Assert
		int expected = 3;
		int result = itemTest.getQuantity();
		assertEquals(result, expected);
	}
	
	@Test
	void testGetItemTotal() {
		// Given
		Item itemTest = new Item("Book", 2.20, 3);
		
		// Assert
		double expected = 6.60;
		double result = itemTest.getItemTotal();
		assertEquals(result, expected);
	}

}
