package com.example.steve_demo.student;

import org.springframework.stereotype.Service;

import java.time.LocalDate;
import java.util.List;

@Service
public class StudentService {
    public List<Student1> getStudents1() {
        return List.of(new Student1(
                1l,
                "Steve Kamau",
                "steve.me@yahoo.com",
                LocalDate.of(1987,01,10),
                34
        ));
    }
}
