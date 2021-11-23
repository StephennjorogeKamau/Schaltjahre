package de.esentri.javabasics;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class CryptoServiceTest {

  // SUT steht für "Software under test"
  CryptoService sut = new CryptoService();

  @Test
  public void encryptTest_Nicolas() {
    // When
    String encrypted = sut.encrypt("Nicolas");

    // Then
    Assertions.assertEquals("Snhtqfx", encrypted);
  }

  @Test
  public void encryptTest_T1ll() {
    // When
    String encrypted = sut.encrypt("T1ll");

    // Then
    Assertions.assertEquals("Y1qq", encrypted);
  }

  @Test
  public void encryptTest_zZzzZ() {
    // When
    String encrypted = sut.encrypt("zZzzZ");

    // Then
    Assertions.assertEquals("eEeeE", encrypted);
  }

  @Test
  public void encryptTest_Satz() {
    // When
    String encrypted = sut.encrypt("Ein ganzer Satz, wow!");

    // Then
    Assertions.assertEquals("Jns lfsejw Xfye, btb!", encrypted);
  }

  @Test
  public void decryptTest_Snhtqfx() {
    // When
    String decrypted = sut.decrypt("Snhtqfx");

    // Then
    Assertions.assertEquals("Nicolas", decrypted);
  }

  @Test
  public void decryptTest_Y1qq() {
    // When
    String decrypted = sut.decrypt("Y1qq");

    // Then
    Assertions.assertEquals("T1ll", decrypted);
  }

  @Test
  public void decryptTest_eEeeE() {
    // When
    String decrypted = sut.decrypt("eEeeE");

    // Then
    Assertions.assertEquals("zZzzZ", decrypted);
  }

  @Test
  public void decryptTest_Satz() {
    // When
    String decrypted = sut.decrypt("Jns lfsejw Xfye, btb!");

    // Then
    Assertions.assertEquals("Ein ganzer Satz, wow!", decrypted);
  }
}
