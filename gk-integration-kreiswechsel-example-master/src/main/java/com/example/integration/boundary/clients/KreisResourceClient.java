package com.example.integration.boundary.clients;

import com.example.integration.model.Kreis;
import com.example.integration.model.Mitglied;
import lombok.extern.slf4j.Slf4j;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpEntity;
import org.springframework.http.HttpMethod;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;
import org.springframework.web.client.RestTemplate;

import java.util.HashMap;
import java.util.Map;

@Slf4j
@Service
public class KreisResourceClient {

  public KreisResourceClient() {}

  private static final String LOCAL_URL = "http://0.0.0.0:9091/v1/mockService";
  private static final String REST_RESOURCE_KREIS = "/kreis";
  private static final String REST_RESOURCE_MITGLIED = "/mitglied";
  private static final String REST_URI_PARAM_MITGLIED_ID = "mitgliedId";

  @Autowired private RestTemplate restTemplate;

  public ResponseEntity<Kreis[]> getAllKreise() {
    log.info("Calling Rest Service: {}{}", LOCAL_URL, REST_RESOURCE_KREIS);

    return restTemplate.getForEntity(LOCAL_URL + REST_RESOURCE_KREIS, Kreis[].class);
  }

  public ResponseEntity<Mitglied[]> getAllMitgliederByKreis(int kreisId) {
    log.info("Calling Rest Service: {}{}", LOCAL_URL, REST_RESOURCE_KREIS);

    return restTemplate.getForEntity(
            LOCAL_URL + REST_RESOURCE_KREIS + "/" + kreisId + "/" + REST_RESOURCE_MITGLIED,
            Mitglied[].class);
  }

  public ResponseEntity<Void> updateMitgliedById(int currentMitgliedId, Mitglied mitglied) {
    log.info("Calling Rest Service: {}{}", LOCAL_URL, REST_RESOURCE_KREIS);
    try {
      Map<String, Object> uriParams = new HashMap<String, Object>();
      uriParams.put(REST_URI_PARAM_MITGLIED_ID, currentMitgliedId);
      HttpEntity<Mitglied> mitgliedEntity = new HttpEntity<Mitglied>(mitglied);
      mitgliedEntity.getHeaders().setContentType(MediaType.APPLICATION_JSON);

      return restTemplate.exchange(
              LOCAL_URL + REST_RESOURCE_MITGLIED + "/" + REST_URI_PARAM_MITGLIED_ID,
              HttpMethod.PUT,
              mitgliedEntity,
              Void.class,
              uriParams);
    } catch (Exception e) {
      log.error("Some went wrong...", e);
      throw e;
    }
  }
}
