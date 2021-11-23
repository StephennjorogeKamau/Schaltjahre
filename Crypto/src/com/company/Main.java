package com.company;

import java.util.Scanner;

class Crypto {
// Import Java libraries

    public static void main(String[] args) {

        String a = null;

        // Create a Scanner object attached to the keyboard
        Scanner in = new Scanner (System.in);

        // Plain text message to be encrypted from user
        System.out.print("Please enter something to be encrypted or the encrypted message: ");
        String userMessage = in.nextLine();

        // Integer encryption key from user.

        System.out.print("Please enter an integer value between 1 and 6 for encryption key: ");
        int userKey = in.nextInt();

        // User error check for key
        while (userKey > 6) {
            System.out.print("Your key must be between 1 and 6.\nPlease enter an integer value between 1 and 6: ");
            userKey = in.nextInt();
        }

        // Encryption  processing
        String message = userMessage;
        int key = userKey;
        char [] chars = message.toCharArray();
        for(char i : chars) {
            i += key;
            System.out.print(i);
        }
        do {
            //user input
            System.out.println();
            System.out.println();
            System.out.println("would you like to decrypt your text?");
            System.out.println("Continue? y/n");
            a= in.next();


            String decrypt =String.valueOf(chars);
            for(char i : chars) {
                i -= key;
                System.out.print(chars);
            }

            // decryption processing
                /*String decrypt = String.valueOf(chars);
                String chars2 = decrypt;
                for(char i : chars) {
                    i -= key;
                    System.out.print(chars2);
                }*/
        }while (a.equals("y"));


    }
}

