package de.esentri.javabasics.bankaccount;

import java.util.ArrayList;
import java.util.List;

public class Bank {
    private String bic;
    private String name;
    private List<BankAccount> bankAccounts;

    public Bank(String bic, String name, List<BankAccount> bankAccounts) {
        this.bic = bic;
        this.name = name;
        this.bankAccounts = bankAccounts;
    }

    public String getBic() {
        return bic;
    }

    public void setBic(String bic) {
        this.bic = bic;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public List<BankAccount> getBankAccounts() {
        return bankAccounts;
    }

    public void setBankAccounts(List<BankAccount> bankAccounts) {
        this.bankAccounts = bankAccounts;
    }
}
