package de.esentri.javabasics.bankaccount;

import de.esentri.javabasics.bankaccount.exceptions.NoAccountWithIbanException;
import de.esentri.javabasics.bankaccount.exceptions.NotCredibleException;
import de.esentri.javabasics.bankaccount.exceptions.WrongPinException;
import org.springframework.stereotype.Service;

import java.math.BigDecimal;
import java.math.RoundingMode;
import java.text.DecimalFormat;
import java.text.DecimalFormatSymbols;
import java.text.NumberFormat;
import java.util.Locale;

@Service
public class BankAccountService {

    // Diese Provision behält sich die Bank bei jeder Überweisung ein, sofern die Ziel-Bank eine andere ist als die vom Geld-Sender.
    // Der Geld-Sender muss für diese Provision aufkommen.
    private static double bankProvision = 0.05;


    // Gebe das Bankkonto zurück welches der übergebenen Bank zugeordnet ist und die übergebene IBAN besitzt
    public BankAccount findByBankAndIban(Bank bank, String iban) throws NoAccountWithIbanException {
        for (bank.getBankAccounts())
    }

    // Geld überweisen
    // Der Betrag amount wird von originBankAccount zum Konto mit der IBAN iban bei der destinationBank überwiesen.
    // Der Sender muss die richtige PIN eingeben und kreditwürdig sein.
    // Beachtet die bankProvision!
    public void sendMoney(BankAccount originBankAccount, Bank destinationBank, String iban, double amount, int pin) throws Exception {

    }

    // Geld abheben
    // Das angegebene Bank-Konto bankAccount wird um den angegebenen Betrag amount belastet.
    // Die PIN muss richtig eingegeben werden.
    // Das Konto muss kreditwürdig sein.
    public void withdrawMoney(BankAccount bankAccount, double amount, int pin) throws NotCredibleException, WrongPinException {

    }

    // Geld einzahlen
    // Es müssen mindestens 5 Einheiten abgehoben werden.
    // Der Kontostand vom angegebenen Bank-Konto bankAccount wird um den angegebenen Betrag amount erhöht.
    // Die PIN muss richtig eingegeben werden.
    // Das Konto muss kreditwürdig sein.
    public void depositMoney(BankAccount bankAccount, double amount, int pin) throws WrongPinException {

    }
}
