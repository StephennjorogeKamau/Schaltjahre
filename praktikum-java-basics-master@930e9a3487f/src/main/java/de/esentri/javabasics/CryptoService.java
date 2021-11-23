package de.esentri.javabasics;

import org.springframework.stereotype.Service;

import java.util.Scanner;

@Service
public class CryptoService {
    public static void main(String[] args) {
        String a = null;

        // Create a Scanner object attached to the keyboard
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
        }

        /*
         * Diese Methode soll den Input-Parameter encrypten, also verschlüsseln.
         * Und zwar soll jeder Buchstabe um 5 Zeichen im Alphabet nach vorne gesetzt werden.
         * Beispiel: Für den Input "Praktikum" soll der Wert "Uwfpynpzr" zurückgegeben werden.
         */


        String message = userMessage;
        int key = userKey;
        char [] chars = message.toCharArray();
        for(char i : chars) {
            i += key;
            System.out.print(i);
        }

        /*
         * Diese Methode soll den Input-Parameter decrypten, also entschlüsseln.
         * Und zwar so, dass die aus der encrypt()-Methode verschlüsselten codes wieder lesbar werden.
         * * Beispiel: Für den Input "Uwfpynpzr" soll der Wert "Praktikum" zurückgegeben werden.
         */

        do {
            //user input
            System.out.println();
            System.out.println();
            System.out.println("would you like to decrypt your text?");
            System.out.println("Continue? y/n");
            a= in.next();

            // decryption processing
            String decrypt =String.valueOf(chars);
            for(char i : chars) {
                i -= key;
                System.out.print(chars);
            }
        }while (a.equals("y"));

    }
}
