package de.esentri.javabasics;

public class MarvelHero {

  private int page_id;
  private String name;
  private Gender gender;
  private Alignment alignment;
  private String year;

  //K0nstruktor
  public MarvelHero(int page_id, String name, Gender gender, Alignment alignment, String year) {
    this.page_id = page_id;
    this.name = name;
    this.gender = gender;
    this.alignment = alignment;
    this.year = year;
  }

  //Methode
  public MarvelHero() {

  }

  //Getter
  public int getPage_id() {

    return page_id;
  }

  //Setter
  public void setPage_id(int page_id) {

    this.page_id = page_id;
  }

  //Getter
  public String getName() {

    return name;
  }

  //Setter
  public void setName(String name) {

    this.name = name;
  }

  //Getter
  public Gender getGender() {

    return gender;
  }

  //Setter
  public void setGender(Gender gender) {

    this.gender = gender;
  }

  //Getter
  public Alignment getAlignment() {

    return alignment;
  }

  //Setter
  public void setAlignment(Alignment alignment) {

    this.alignment = alignment;
  }

  //Getter
  public String getYear() {

    return year;
  }

  //Setter
  public void setYear(String year) {
    this.year = year;
  }
}

//festgelegt Variablen.
enum Gender {

  MALE_CHARACTERS,
  FEALE_CHARACTERS,
  AGENDER_CHARACTERS
}

//festgelegt Variablen.
enum Alignment {
  BAD_CHARACTERS,
  GOOD_CHARACTERS,
  NEUTRAL_CHARACTERS
}

