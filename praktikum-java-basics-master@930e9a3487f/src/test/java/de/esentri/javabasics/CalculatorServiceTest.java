package de.esentri.javabasics;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class CalculatorServiceTest {

  // SUT steht für "Software under test"
  CalculatorService sut = new CalculatorService();

  @Test
  public void sumTest_positive() {
    // When
    int result = sut.sumUp(3, 5);

    // Then
    Assertions.assertEquals(8, result);
  }

  @Test
  public void sumTest_negative() {
    // When
    int result = sut.sumUp(-2, 9);

    // Then
    Assertions.assertEquals(7, result);
  }

  @Test
  public void calculateByOperator_plus() {
    // When
    double result = sut.calculateByOperator(2.0, 4.0, "+");

    // Then
    Assertions.assertEquals(6.0, result);
  }

  @Test
  public void calculateByOperator_minus() {
    // When
    double result = sut.calculateByOperator(4.0, 2.0, "-");

    // Then
    Assertions.assertEquals(2.0, result);
  }

  @Test
  public void calculateByOperator_times() {
    // When
    double result = sut.calculateByOperator(3.5, 2.0, "*");

    // Then
    Assertions.assertEquals(7.0, result);
  }

  @Test
  public void calculateByOperator_divide() {
    // When
    double result = sut.calculateByOperator(6.0, 3.0, "/");

    // Then
    Assertions.assertEquals(2.0, result);
  }
}
