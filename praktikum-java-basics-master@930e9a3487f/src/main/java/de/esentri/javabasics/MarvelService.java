package de.esentri.javabasics;

import org.springframework.stereotype.Service;

@Service
public class MarvelService {

  // Für eine gegebene pageId soll aus marvel-wikia-data.csv (src/main/resources/marvel-wikia-data.csv)
  // der entsprechende name des Heros zurückgegeben werden.
  // Beispiel: Für den input 8014 soll der Wert "Cyclops (Mythical) (Earth-616)" zurückgegben werden.
  public String findNameByPageId(int pageId) {
    return null;
  }

  // Für eine gegebene first Appearance soll in marvel-wikia-data.csv gezählt werden, wie viel Heroes dort ihre first appearance hatten.
  // Beispiel: Für den input "Aug-64" soll der Wert 15 zurückgegben werden.
  public int countAppearancesAt(String firstAppearanceIn) {
    return 0;
  }

  // Für eine gegebene pageId soll aus marvel-wikia-data.csv der entsprechende Hero als Objekt zurückgegeben werden.
  public MarvelHero buildMarvelHeroObjectForId(int pageId) {
    return null;
  }
}
