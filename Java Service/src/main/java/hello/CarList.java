package hello;

import java.util.ArrayList;

public class CarList {
	public ArrayList<Car> list;
	
	public CarList() {
		this.list = new ArrayList<Car>();
		this.addCar(new Car("Volkswagen", "Golf"));
		this.addCar(new Car("Seat", "Ibiza"));
	}
	
	public void addCar(Car car) {
		this.list.add(car);
	}
	
	public void removeCar(int index) {
		this.list.remove(index);
	}
	
	public void removeCar(Car car) {
		this.list.remove(car);
	}
	
	public Car getCar(int id) {
		return list.get(id);
	}
	
	public Car getCar(String name) {
		for(int i = 0; i < list.size(); i++)
			if(list.get(i).getName().toLowerCase().equals(name.toLowerCase()))
				return list.get(i);
		
		return new Car("Null", "Null");
	}
}
