package de.esentri.javabasics;

import org.springframework.stereotype.Service;

@Service
public class CryptoService {

  /*
   * Diese Methode soll den Input-Parameter encrypten, also verschlüsseln.
   * Und zwar soll jeder Buchstabe um 5 Zeichen im Alphabet nach vorne gesetzt werden.
   * Beispiel: Für den Input "Praktikum" soll der Wert "Uwfpynpzr" zurückgegeben werden.
   */
  public String encrypt(String input) {
    return input;
  }

  /*
   * Diese Methode soll den Input-Parameter decrypten, also entschlüsseln.
   * Und zwar so, dass die aus der encrypt()-Methode verschlüsselten codes wieder lesbar werden.
   * * Beispiel: Für den Input "Uwfpynpzr" soll der Wert "Praktikum" zurückgegeben werden.
   */
  public String decrypt(String input) {
    return input;
  }
}
