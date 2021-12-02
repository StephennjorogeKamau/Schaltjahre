package com.example.integration.boundary.clients;

import com.example.integration.model.Kreis;
import lombok.extern.slf4j.Slf4j;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;
import org.springframework.web.client.RestTemplate;

@Slf4j
@Service
public class KreisResourceClient {

  public KreisResourceClient() {}

  private static final String LOCAL_URL = "http://0.0.0.0:9091/v1/mockService";
  private static final String REST_RESOURCE_KREIS = "/kreis";


  @Autowired private RestTemplate restTemplate;

  public ResponseEntity<Kreis[]> getAllKreise() {
    log.info("Calling Rest Service: {}{}", LOCAL_URL, REST_RESOURCE_KREIS);

    return restTemplate.getForEntity(LOCAL_URL + REST_RESOURCE_KREIS, Kreis[].class);
  }
}
