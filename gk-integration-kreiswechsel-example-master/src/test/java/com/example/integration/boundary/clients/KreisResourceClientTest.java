package com.example.integration.boundary.clients;

import com.example.integration.model.Kreis;
import com.example.integration.model.Mitglied;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.test.context.junit.jupiter.SpringExtension;

import static org.assertj.core.api.Assertions.assertThat;
import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertTrue;

@SpringBootTest
@ExtendWith(SpringExtension.class)
public class KreisResourceClientTest {

  @Autowired private KreisResourceClient client;

  @Test
  public void contextLoads() throws Exception {
    assertThat(client).isNotNull();
  }

  @Test
  public void testReceiveAllKreis() {
    // given
    // when
    ResponseEntity<Kreis[]> response = client.getAllKreise();
    Kreis[] kreise = response.getBody();
    // then
    assertEquals(HttpStatus.OK, response.getStatusCode());
    assertEquals(MediaType.APPLICATION_JSON, response.getHeaders().getContentType());
    assertTrue(kreise.length == 2);
  }

  @Test
  public void testReceiveAllMitgliederByKreisId() {
    // given
    int kreisId = 1;
    // when
    ResponseEntity<Mitglied[]> response = client.getAllMitgliederByKreis(kreisId);
    Mitglied[] mitglieder = response.getBody();
    // then
    assertEquals(HttpStatus.OK, response.getStatusCode());
    assertEquals(MediaType.APPLICATION_JSON, response.getHeaders().getContentType());
    assertTrue(mitglieder.length == 2);
  }

  @Test
  public void testUpdateMitgliederByMitgliedId() {
    // given
    int currentId = 420;

    Mitglied testMitglied = new Mitglied();
    testMitglied.setId(7);
    testMitglied.setEmail("matthias.schnell@esentri.com");
    testMitglied.setName("matthias schnell");
    // when
    ResponseEntity<Void> response = client.updateMitgliedById(currentId, testMitglied);
    // then
    assertEquals(HttpStatus.ACCEPTED, response.getStatusCode());
  }
}
