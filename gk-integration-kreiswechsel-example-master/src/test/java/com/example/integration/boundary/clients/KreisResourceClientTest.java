package com.example.integration.boundary.clients;

import static org.assertj.core.api.Assertions.assertThat;
import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertTrue;

import com.example.integration.model.Kreis;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.extension.ExtendWith;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.test.context.junit.jupiter.SpringExtension;

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
}
