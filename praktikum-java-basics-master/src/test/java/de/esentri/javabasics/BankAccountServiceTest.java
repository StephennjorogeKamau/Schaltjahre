/*package de.esentri.javabasics;

import de.esentri.javabasics.bankaccount.Bank;
import de.esentri.javabasics.bankaccount.BankAccount;
import de.esentri.javabasics.bankaccount.BankAccountService;
import de.esentri.javabasics.bankaccount.Customer;
import de.esentri.javabasics.bankaccount.exceptions.CustomerNotAnAdultException;
import de.esentri.javabasics.bankaccount.exceptions.NoAccountWithIbanException;
import de.esentri.javabasics.bankaccount.exceptions.NotCredibleException;
import de.esentri.javabasics.bankaccount.exceptions.WrongPinException;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*/;

/*class BankAccountServiceTest {

    BankAccountService sut = new BankAccountService();

    @Test
    void findByBankAndIban_Correct() throws Exception {
        // Given
        Bank bank = new Bank("hidd03284020fhief", "Sparkasse");
        BankAccount bankAccount = new BankAccount("DE39285748204284R1S481S3", 1234, 50000.00, bank, new Customer("Max", "Mustermann", 54));

        // When
        BankAccount foundBankAccount = sut.findByBankAndIban(bank, "DE39285748204284R1S481S3");

        // Then
        Assertions.assertEquals(bankAccount, foundBankAccount);
    }

    @Test
    void findByBankAndIban_NotFound() throws Exception {
        // Given
        Bank bank = new Bank("hidd03284020fhief", "Sparkasse");
        BankAccount bankAccount = new BankAccount("DE39285748204284R1S481S3", 1234, 50000.00, bank, new Customer("Max", "Mustermann", 54));

        // Then
        Assertions.assertThrows(NoAccountWithIbanException.class, () -> sut.findByBankAndIban(bank, "DE39285748204284R1S481S4"));
    }

    @Test
    void sendMoney_sameBank() throws Exception {
        // Given
        Bank bank = new Bank("hidd03284020fhief", "Sparkasse");
        BankAccount originBankAccount = new BankAccount("DE39285748204284R1S481S3", 1234, 50000.00, bank, new Customer("Max", "Mustermann", 54));
        BankAccount destinationBankAccount = new BankAccount("DE8370213PJPIEV48120", 5678, 20000.00, bank, new Customer("Anna", "Mustermann", 34));

        // When
        sut.sendMoney(originBankAccount, bank, "DE8370213PJPIEV48120", 58.79, 1234);

        // Then
        Assertions.assertEquals(originBankAccount.getBalance(), 49941.21);
        Assertions.assertEquals(destinationBankAccount.getBalance(), 20058.79);
    }

    @Test
    void sendMoney_differentBank() throws Exception {
        // Given
        Bank sparkasse = new Bank("hidd03284020fhief", "Sparkasse");
        Bank volksbank = new Bank("obwqovbqwd8494183", "Volksbank");
        BankAccount originBankAccount = new BankAccount("DE39285748204284R1S481S3", 1234, 50000.00, sparkasse, new Customer("Max", "Mustermann", 54));
        BankAccount destinationBankAccount = new BankAccount("DE8370213PJPIEV48120", 5678, 20000.00, volksbank, new Customer("Anna", "Mustermann", 34));

        // When
        sut.sendMoney(originBankAccount, volksbank, "DE8370213PJPIEV48120", 7874.98, 1234);

        // Then
        Assertions.assertEquals(originBankAccount.getBalance(), 41731.28);
        Assertions.assertEquals(destinationBankAccount.getBalance(), 27874.98);
    }

    @Test
    void sendMoney_Not_creditable() throws Exception {
        // Given
        Bank sparkasse = new Bank("hidd03284020fhief", "Sparkasse");
        Bank volksbank = new Bank("obwqovbqwd8494183", "Volksbank");
        BankAccount originBankAccount = new BankAccount("DE39285748204284R1S481S3", 1234, 300.00, sparkasse, new Customer("Max", "Mustermann", 54));
        BankAccount destinationBankAccount = new BankAccount("DE8370213PJPIEV48120", 5678, 20000.00, volksbank, new Customer("Anna", "Mustermann", 34));

        // Then
        Assertions.assertThrows(NotCredibleException.class, () -> sut.sendMoney(originBankAccount, volksbank, "DE8370213PJPIEV48120", 7874.98, 1234));
    }

    @Test
    void sendMoney_wrong_pin() throws Exception {
        // Given
        Bank sparkasse = new Bank("hidd03284020fhief", "Sparkasse");
        Bank volksbank = new Bank("obwqovbqwd8494183", "Volksbank");
        BankAccount originBankAccount = new BankAccount("DE39285748204284R1S481S3", 1236, 300.00, sparkasse, new Customer("Max", "Mustermann", 54));
        BankAccount destinationBankAccount = new BankAccount("DE8370213PJPIEV48120", 5678, 20000.00, volksbank, new Customer("Anna", "Mustermann", 34));

        // Then
        Assertions.assertThrows(WrongPinException.class, () -> sut.sendMoney(originBankAccount, volksbank, "DE8370213PJPIEV48120", 7874.98, 1234));
    }

    @Test
    void withdrawMoney() throws NotCredibleException, WrongPinException, CustomerNotAnAdultException {
        // Given
        Bank sparkasse = new Bank("hidd03284020fhief", "Sparkasse");
        BankAccount originBankAccount = new BankAccount("DE39285748204284R1S481S3", 1234, 50000.00, sparkasse, new Customer("Max", "Mustermann", 54));

        // When
        sut.withdrawMoney(originBankAccount, 3184.98, 1234);

        // Then
        Assertions.assertEquals(originBankAccount.getBalance(), 46815.02);
    }

    @Test
    void withdrawMoney_not_creditable() throws CustomerNotAnAdultException {
        // Given
        Bank sparkasse = new Bank("hidd03284020fhief", "Sparkasse");
        BankAccount originBankAccount = new BankAccount("DE39285748204284R1S481S3", 1234, 50000.00, sparkasse, new Customer("Max", "Mustermann", 54));

        // Then
        Assertions.assertThrows(NotCredibleException.class, () -> sut.withdrawMoney(originBankAccount, 51184.98, 1234));
    }

    @Test
    void withdrawMoney_wrong_pin() throws CustomerNotAnAdultException {
        // Given
        Bank sparkasse = new Bank("hidd03284020fhief", "Sparkasse");
        BankAccount originBankAccount = new BankAccount("DE39285748204284R1S481S3", 2234, 50000.00, sparkasse, new Customer("Max", "Mustermann", 54));

        // Then
        Assertions.assertThrows(WrongPinException.class, () -> sut.withdrawMoney(originBankAccount, 51184.98, 1234));
    }

    @Test
    void depositMoney() throws WrongPinException, CustomerNotAnAdultException {
        // Given
        Bank sparkasse = new Bank("hidd03284020fhief", "Sparkasse");
        BankAccount originBankAccount = new BankAccount("DE39285748204284R1S481S3", 1234, 50000.00, sparkasse, new Customer("Max", "Mustermann", 54));

        // When
        sut.depositMoney(originBankAccount, 500, 1234);

        // Then
        Assertions.assertEquals(originBankAccount.getBalance(), 50500.00);
    }

    @Test
    void depositMoney_amount_under_5() throws CustomerNotAnAdultException {
        // Given
        Bank sparkasse = new Bank("hidd03284020fhief", "Sparkasse");
        BankAccount originBankAccount = new BankAccount("DE39285748204284R1S481S3", 1234, 50000.00, sparkasse, new Customer("Max", "Mustermann", 54));

        // Then
        Assertions.assertThrows(IllegalArgumentException.class, () -> sut.depositMoney(originBankAccount, 4.98, 1234));
    }

    @Test
    void depositMoney_wrong_pin() throws CustomerNotAnAdultException {
        // Given
        Bank sparkasse = new Bank("hidd03284020fhief", "Sparkasse");
        BankAccount originBankAccount = new BankAccount("DE39285748204284R1S481S3", 2234, 50000.00, sparkasse, new Customer("Max", "Mustermann", 54));

        // Then
        Assertions.assertThrows(WrongPinException.class, () -> sut.depositMoney(originBankAccount, 2000, 2943));
    }
}*/
