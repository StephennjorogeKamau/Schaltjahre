# Webservices

- REST: Representatonal State Transfer
+ Statusfreie (stateless) HTTP Verbindung
- Arbitary Web Service 
+ Statusbehaftete Verbindung (TCP)
+ Beispiel: WCF (Windows Communication Foundation), Websocket

## REST
+ HTTP Operationen/Anfragen werden auf CRUD 
(Create, Read, Update, Delete) gemappt

+ Aufbau:
    - HTTP-Methode bestimmen
    - URL-Definieren
    - Bispiel: Abruf eines Kunden mit der Kd.Nr 5
    - http://servername/Methodenname/parameter
    - http://localhost:8888/Kundenname?id=XY
    - http://localhost:8888/Kunden?id=5
    - Liste aller Kunden
    - http://localhost:8888/Kunden