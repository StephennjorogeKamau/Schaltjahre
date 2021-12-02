package com.example.integration.model;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@AllArgsConstructor
@NoArgsConstructor
@Data
@JsonIgnoreProperties(ignoreUnknown = true)
public class Mitglied {
  private long id;
  private String username;
  private String Firstname;
  private String Lastname;
  private String email;
  private String phone;

  public void setName(String matthias_schnell) {
  }
}
