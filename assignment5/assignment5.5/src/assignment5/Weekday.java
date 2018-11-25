package assignment5;

//Enum for Weekdays
public enum Weekday {
	SUNDAY("Sunday"), MONDAY("Monday"), TUESDAY("Tuesday"), WEDNESDAY("Wednesday"), THURSDAY("Thursday"),
	FRIDAY("Friday"), SATURDAY("Saturday");
	// Variables
	private String name;

	//Get Weekday Name
	public String getName() {
		return name;
	}

	// Constructor for Weekday
	private Weekday(String name) {
		this.name = name;
	}
}
