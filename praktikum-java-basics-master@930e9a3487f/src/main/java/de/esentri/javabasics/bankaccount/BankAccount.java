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

    public BankAccount(String iban, int pin, double balance, Bank bank, Customer customer) {
        this.iban = iban;
        this.pin = pin;
        this.balance = balance;
        this.bank = bank;
        this.customer = customer;
    }

    public String getIban() {
        return iban;
    }

    public void setIban(String iban) {
        this.iban = iban;
    }

    public int getPin() {
        return pin;
    }

    public void setPin(int pin) {
        this.pin = pin;
    }

    public double getBalance() {
        return balance;
    }

    public void setBalance(double balance) {
        this.balance = balance;
    }

    public Bank getBank() {
        return bank;
    }

    public void setBank(Bank bank) {
        this.bank = bank;
    }

    public Customer getCustomer() {
        return customer;
    }

    public void setCustomer(Customer customer) {
        this.customer = customer;
    }
}
