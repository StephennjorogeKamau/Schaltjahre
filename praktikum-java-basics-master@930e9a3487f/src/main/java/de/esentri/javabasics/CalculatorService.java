package de.esentri.javabasics;


import org.springframework.stereotype.Service;

import java.util.Random;
import java.util.Scanner;

@Service
public class CalculatorService {

  // Berechne die Summe zweier Zahlen!
  public int sumUp(int a, int b) {
    return a + b;
  }

  // Berechne das Ergebnis zweier Zahlen mit gegebenem Operator!
  // Beispiel: a = 5, b = 3, Operator "*", Lösung : 15
  // Beispiel: a = 4 b = 2, Operator "/", Lösung : 2
  // Operatoren: "+", "-", "*", "/"
  public double calculateByOperator(double a, double b, String operator) {
    //Use case
    switch (operator) {
      case "+" -> {
        System.out.println(a + " + " + b + " = " + (a+b));
        return a + b;
      }
      case "-" -> {
        System.out.println(a + " - " + b + " = " + (a-b));
        return a - b;
      }
      case "*" -> {
        System.out.println(a + " * " + b + " = " + (a*b));
        return a * b;
      }
      case "/" -> {
        System.out.println(a + " / " + b + " = " + (a/b));
        return a / b;
      }
      default -> System.out.println("Ungültiger Operator!");
    }
    return 0.0;
  }

  // Erstelle ein Mathe-Trainer Programm!
  // Die Aufgabe ist für die Schnellen unter euch, bitte erst zum Schluss erledigen.
  // Sie besteht daraus, zwei zufällige Zahlen zwischen 0 und 10 zu berechnen und
  // mit einem zufälligen Operator zu verrechnen. Die Aufgabe die aus den berechneten Zahlen
  // und dem zufälligen Operator resultiert, soll in die Konsole ausgegeben werden.
  // Dann muss der Nutzer die Lösung in die Konsole eingeben und es wird geprüft.
  // Bei richtiger Eingabe true zurückgeben, sonst false.
  // Operatoren: "+", "-", "*", "/"
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);

    String a;
    do {
      String operanden = null;
      int b = 0;
      int c = 0;

      Random number = new Random();
      int d = number.nextInt(10) + 1;
      int e = number.nextInt(10) + 1;


      Random operatorChoice = new Random();
      int operator = operatorChoice.nextInt(4);


      switch (operator) {

        case 0:
          operanden = "+";
          c = d + e;
          break;
        case 1:
          operanden = "-";
          c = d - e;
          break;
        case 2:
          operanden = "*";
          c = d * e;
          break;
        case 3:
          operanden = "/";
          c = d / e;
          break;
        default:
          operanden = "";
      }
      System.out.println("What is: " + d + operanden + e + "?");
      b = sc.nextInt();
      if(b!=c)
        System.out.println("Wrong answer! Right answer is: "+c);
      else{if(b==c)
        System.out.println("Right answer!"+c);
      }
      System.out.println("Continue? y/n");
      a = sc.next();

    } while (a.equals("y"));

  }

}


