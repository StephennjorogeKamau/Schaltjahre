package de.esentri.javabasics.bankaccount;

import de.esentri.javabasics.bankaccount.exceptions.CustomerNotAnAdultException;

import java.util.List;

// Bei der Erstellung eines Bankkontos muss geprüft werden,
// ob der Kunde volljährig ist und das erstellte Bankkonto der angegebenen Bank
// hinzugefügt werden
public class BankAccount {
    private String iban;
    private int pin;
    private double balance;
    private Bank bank;
    private Customer customer;
}
