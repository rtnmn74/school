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

	@Test
	void testGetItemStandardDiscountAmount() {
		// Given
		Item itemTest = new Item("Book", 2.20, 3);
		DiscountPolicy standard = new StandardDiscount();
		itemTest.setDiscount(standard);

		// Assert
		double expected = 0.33000000000000007;
		double result = itemTest.getItemDiscount();
		assertEquals(result, expected);
	}

	@Test
	void testGetItemSeniorDiscountAmount() {
		// Given
		Item itemTest = new Item("Book", 2.20, 3);
		DiscountPolicy senior = new SeniorDiscount();
		itemTest.setDiscount(senior);
		Weekday weekday = Weekday.TUESDAY;
		senior.setWeekday(weekday);

		// Assert
		double expected = 0.4620000000000001;
		double result = itemTest.getItemDiscount();
		assertEquals(result, expected);
	}

	@Test
	void testGetItemPreferredDiscountAmount() {
		// Given
		Item itemTest = new Item("Book", 2.20, 3);
		DiscountPolicy preferred = new PreferredDiscount();
		itemTest.setDiscount(preferred);
		Weekday weekday = Weekday.TUESDAY;
		preferred.setWeekday(weekday);

		// Assert
		double expected = 0.5940000000000001;
		double result = itemTest.getItemDiscount();
		assertEquals(result, expected);
	}

	@Test
	void testGetItemInvalidSeniorDiscountAmount() {
		// Given
		Item itemTest = new Item("Book", 2.20, 3);
		DiscountPolicy senior = new SeniorDiscount();
		itemTest.setDiscount(senior);
		Weekday weekday = Weekday.WEDNESDAY;
		senior.setWeekday(weekday);

		// Assert
		double expected = 0.00;
		double result = itemTest.getItemDiscount();
		assertEquals(result, expected);
	}

	@Test
	void testGetItemBOGODiscountAmount() {
		// Given
		Item itemTest = new Item("Book", 2.20, 3);
		DiscountPolicy bogo = new BOGODiscount();
		itemTest.setDiscount(bogo);
		Weekday weekday = Weekday.WEDNESDAY;
		bogo.setWeekday(weekday);

		// Assert
		double expected = 2.20;
		double result = itemTest.getItemDiscount();
		assertEquals(result, expected);
	}
	
	@Test
	void testGetItemInvalidBOGODiscountAmount() {
		// Given 
		Item itemTest = new Item("Book", 2.20, 1);
		DiscountPolicy bogo = new BOGODiscount();
		itemTest.setDiscount(bogo);
		Weekday weekday = Weekday.WEDNESDAY;
		bogo.setWeekday(weekday);

		// Assert
		double expected = 0.00;
		double result = itemTest.getItemDiscount();
		assertEquals(result, expected);
	}
}
