package de.esentri.javabasics;

import org.springframework.stereotype.Service;

import java.util.Scanner;

@Service
public class CryptoService {



    public String encrypt(String msg) {

      /*  // Create a Scanner object attached to the keyboard
        Scanner in = new Scanner(System.in);

        // Plain text message to be encrypted from user
        System.out.print("Please enter message to be encrypted: ");
        String userMessage = in.nextLine();

        // Integer encryption key from user.
        System.out.print("Ganzzahliger Wert zwischen 1 und 6 für den Verschlüsselungscode: ");
        int userKey = in.nextInt();

        // User error check for key
        while (userKey > 6) {
            System.out.print("ERROR! Bitte nur 1 - 6: ");
            userKey = in.nextInt();
        }*/

        /*
         * Diese Methode soll den Input-Parameter encrypten, also verschlüsseln.
         * Und zwar soll jeder Buchstabe um 5 Zeichen im Alphabet nach vorne gesetzt werden.
         * Beispiel: Für den Input "Praktikum" soll der Wert "Uwfpynpzr" zurückgegeben werden.
         */
        String message = "Nicolas";
        int key = 5;
        char[] chars = message.toCharArray();
        for (char i : chars) {
            i += key;
            System.out.print(i);
        }

        /*
         * Diese Methode soll den Input-Parameter decrypten, also entschlüsseln.
         * Und zwar so, dass die aus der encrypt()-Methode verschlüsselten codes wieder lesbar werden.
         * * Beispiel: Für den Input "Uwfpynpzr" soll der Wert "Praktikum" zurückgegeben werden.
         */


       // public String decrypt (String input){
            //return  null;
       // }
      return String.valueOf(chars);
    }
    //Decrypt message
    public String decrypt (String msg){

        //user input
        /*System.out.println();
        System.out.println();
        System.out.println("would you like to decrypt your text?");
        System.out.println("Continue? y/n");
        in = String.valueOf(in.chars());*/
        int key = 5;

        Scanner in = new Scanner(System.in);
        String decrypt = in.next();
        char[] chars = decrypt.toCharArray();
        for(char i : chars){
            i -= key;
            System.out.print(chars);
        }
        return String.valueOf(chars);
    }
}
