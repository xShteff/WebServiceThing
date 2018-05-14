package hello;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class CarController {
	public CarList cars = new CarList();
	
	@RequestMapping("/getCars")
    public CarList getCars() {
		return cars;
	}
	
	@RequestMapping("/getCar")
    public Car getCar(@RequestParam(value="id", defaultValue="nan") int id) {
		return cars.getCar(id);
	}
}
