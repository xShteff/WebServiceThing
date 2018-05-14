package hello;

public class Car {
	private final String name;
	private final String model;
	
	public Car(String name, String model) {
		this.name = name;
		this.model = model;
	}

	public String getName() {
		return name;
	}

	public String getModel() {
		return model;
	}

	public String toString() {
		return "Car [name=" + name + ", model=" + model + "]";
	}
	
}
