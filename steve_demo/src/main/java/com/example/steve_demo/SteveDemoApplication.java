package com.example.steve_demo;

import com.example.steve_demo.student.Student1;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

import java.time.LocalDate;
import java.util.List;

@SpringBootApplication
@RestController
public class SteveDemoApplication {

	public static void main(String[] args) {
		SpringApplication.run(SteveDemoApplication.class, args);
	}


}
