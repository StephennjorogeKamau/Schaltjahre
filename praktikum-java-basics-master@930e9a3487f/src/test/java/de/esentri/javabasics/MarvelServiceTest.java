package de.esentri.javabasics;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class MarvelServiceTest {

  // SUT steht für "Software under test"
  MarvelService sut = new MarvelService();

  @Test
  public void findNameByIdTest_jay() {
    // Given
    int pageId = 754677;

    // When
    String foundName = sut.findNameByPageId(pageId);

    // Then
    Assertions.assertEquals("Jay Kelsey (Earth-616)", foundName);
  }


  @Test
  public void findNameByIdTest_leslie() {
    // Given
    int pageId = 237494;

    // When
    String foundName = sut.findNameByPageId(pageId);

    // Then
    Assertions.assertEquals("Leslie Lenrow (Earth-616)", foundName);
  }

  @Test
  public void findNameByIdTest_ironman() {
    // Given
    int pageId = 1868;

    // When
    String foundName = sut.findNameByPageId(pageId);

    // Then
    Assertions.assertEquals("\"Iron Man (Anthony \\\"\"Tony\\\"\" Stark)\"", foundName);
  }

  @Test
  public void countAppearancesTest_sep71() {
    // Given
    String firstAppearanceIn = "Sep-71";

    // When
    int counted = sut.countAppearancesAt(firstAppearanceIn);

    // Then
    Assertions.assertEquals(6, counted);
  }

  @Test
  public void countAppearancesTest_Aug64() {
    // Given
    String firstAppearanceIn = "Aug-64";

    // When
    int counted = sut.countAppearancesAt(firstAppearanceIn);

    // Then
    Assertions.assertEquals(15, counted);
  }

  @Test
  public void countAppearancesTest_May21() {
    // Given
    String firstAppearanceIn = "May-21";

    // When
    int counted = sut.countAppearancesAt(firstAppearanceIn);

    // Then
    Assertions.assertEquals(0, counted);
  }

  @Test
  public void buildMarvelHeroObjectForIdTest_spiderMan() {
    // Given
    int pageId = 1678;

    // When
    MarvelHero buildHero = sut.buildMarvelHeroObjectForId(pageId);

    // Then
    Assertions.assertEquals(1678, buildHero.getPage_id());
    Assertions.assertEquals("Spider-Man (Peter Parker)", buildHero.getName());
    Assertions.assertEquals("1962", buildHero.getYear());
    Assertions.assertEquals(Gender.MALE_CHARACTERS, buildHero.getGender());
    Assertions.assertEquals(Alignment.GOOD_CHARACTERS, buildHero.getAlignment());
  }

  @Test
  public void buildMarvelHeroObjectForIdTest_hulk() {
    // Given
    int pageId = 1833;

    // When
    MarvelHero buildHero = sut.buildMarvelHeroObjectForId(pageId);

    // Then
    Assertions.assertEquals(1833, buildHero.getPage_id());
    Assertions.assertEquals("Hulk (Robert Bruce Banner)", buildHero.getName());
    Assertions.assertEquals("1962", buildHero.getYear());
    Assertions.assertEquals(Gender.MALE_CHARACTERS, buildHero.getGender());
    Assertions.assertEquals(Alignment.GOOD_CHARACTERS, buildHero.getAlignment());
  }

  @Test
  public void buildMarvelHeroObjectForIdTest_hitman() {
    // Given
    int pageId = 701584;

    // When
    MarvelHero buildHero = sut.buildMarvelHeroObjectForId(pageId);

    // Then
    Assertions.assertEquals(701584, buildHero.getPage_id());
    Assertions.assertEquals("Hitman (Hobgoblin) (Earth-616)", buildHero.getName());
    Assertions.assertEquals("2013", buildHero.getYear());
    Assertions.assertEquals(Gender.MALE_CHARACTERS, buildHero.getGender());
    Assertions.assertEquals(Alignment.BAD_CHARACTERS, buildHero.getAlignment());
  }

}
