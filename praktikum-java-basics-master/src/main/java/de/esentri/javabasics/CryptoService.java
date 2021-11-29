package de.esentri.javabasics;

import org.springframework.stereotype.Service;

@Service
public class CryptoService {

  /*
   * Diese Methode soll den Input-Parameter encrypten, also verschlüsseln.
   * Und zwar soll jeder Buchstabe um 5 Zeichen im Alphabet nach vorne gesetzt werden.
   * Beispiel: Für den Input "Praktikum" soll der Wert "Uwfpynpzr" zurückgegeben werden.
   */
  int key;
  public String encrypt(String input) {
    input = "";
    int key = 5;
    char [] chars = input.toCharArray();
    for(char i : chars) {
      i += key;
      System.out.print(i);
    }
    return input;
  }

  /*
   * Diese Methode soll den Input-Parameter decrypten, also entschlüsseln.
   * Und zwar so, dass die aus der encrypt()-Methode verschlüsselten codes wieder lesbar werden.
   * * Beispiel: Für den Input "Uwfpynpzr" soll der Wert "Praktikum" zurückgegeben werden.
   */
  public String decrypt(String input) {

      //user input
   // Scanner in = new Scanner (System.in);
    //int userKey = 0;
    //  userKey = in.nextInt();
      //String inp =String.valueOf(chars);
   // String message = "";
    //char [] chars = message.toCharArray();
     // for(char i : chars) {
     //   i -= key;
      //  System.out.print(chars);
      //}

      // decryption processing
                /*String decrypt = String.valueOf(chars);
                String chars2 = decrypt;
                for(char i : chars) {
                    i -= key;
                    System.out.print(chars2);
                }*/

  return input;
  }
}
