package de.esentri.javabasics;

public class MarvelHero {

  private int page_id;
  private String name;
  private Gender gender;
  private Alignment alignment;
  private String year;

  public MarvelHero(int page_id, String name, Gender gender, Alignment alignment, String year) {
    this.page_id = page_id;
    this.name = name;
    this.gender = gender;
    this.alignment = alignment;
    this.year = year;
  }

  public MarvelHero() {
  }

  public int getPage_id() {
    return page_id;
  }

  public void setPage_id(int page_id) {
    this.page_id = page_id;
  }

  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public Gender getGender() {
    return gender;
  }

  public void setGender(Gender gender) {
    this.gender = gender;
  }

  public Alignment getAlignment() {
    return alignment;
  }

  public void setAlignment(Alignment alignment) {
    this.alignment = alignment;
  }

  public String getYear() {
    return year;
  }

  public void setYear(String year) {
    this.year = year;
  }
}

enum Gender {

  MALE_CHARACTERS,
  FEALE_CHARACTERS,
  AGENDER_CHARACTERS
}

enum Alignment {
  BAD_CHARACTERS,
  GOOD_CHARACTERS,
  NEUTRAL_CHARACTERS
}

