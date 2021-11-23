package de.esentri.javabasics;

import org.springframework.stereotype.Service;

@Service
public class CryptoService {
  Scanner in = new Scanner (System.in);
   System.out.print("Praktikum");

  String userMessage = in.nextLine();
  System.out.print("Ganzzahliger Wert zwischen 1 und 6 für den Verschlüsselungscode: ");
  int userKey = in.nextInt();

  while (userKey > 6) {
    System.out.print("ERROR! Bitte nur 1 - 6: ");
    userKey = in.nextInt();

}

  /*
   * Diese Methode soll den Input-Parameter encrypten, also verschlüsseln.
   * Und zwar soll jeder Buchstabe um 5 Zeichen im Alphabet nach vorne gesetzt werden.
   * Beispiel: Für den Input "Praktikum" soll der Wert "Uwfpynpzr" zurückgegeben werden.
   */
  public String encrypt(String input) {
    String input = userMessage;
    int key = userKey;
    char [] chars = input.toCharArray();
    for(char i : chars) {
      i += key;
      System.out.print(i);
    return input;
  }

  /*
   * Diese Methode soll den Input-Parameter decrypten, also entschlüsseln.
   * Und zwar so, dass die aus der encrypt()-Methode verschlüsselten codes wieder lesbar werden.
   * * Beispiel: Für den Input "Uwfpynpzr" soll der Wert "Praktikum" zurückgegeben werden.
   */
  public String decrypt(String input) {
      String input = userMessage;
      int key = userKey;
      char [] chars = input.toCharArray();
      for(char i : chars) {
        i -= key;
        System.out.print(i);
    return input;
  }
}
