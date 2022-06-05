# labb1_systemtestning

De tre affärskritiska delarna i projektet som jag har identifierat är:

1. Överföring  mellan egna konton
2. Internationell överföring mellan egna konton
3. Skapa ny användare baserat på konstruktorn

Då vi vid skapandet av projektet använde oss av grundläggande felhantering så har jag inte hittat några kritiska saker som kan gå fel vid exekvering av testerna, jag har provat att skicka olika datatyper samt positiva och negativa värden på variablerna men dessa felhanteras i ursprungs koden.

Jag kan dock se att oönskade effekter kan uppnås ifall man inte hade använt denna typen av felhantering. Hade datatypen för överföringar varit int istället för double så hade man inte kunnat skicka belopp innehållandes ören.
Vi har också tagit höjd för att man ej skall kunna skicka andra datatyper (exempelvis strängar) när man utför överföringar.

Då skapandet av ny användare görs via en konstruktor så kommer alltid variablerna i klassen att vara av korrekta datatyper och ett objekt kommer alltid att skapas, även här har jag svårt att se att något kan gå fel.
Detta testet hade kunnat utökas om programmet hade en annan kravställning, vill man t.ex inte använda tecken avsett för det svenska alfabetet (Å, Ä , Ö) så hade man fått sätta restriktioner för dessa tecken i koden som testet är baserat på.
Även här finns det felhantering inbyggt för otillåtna tecken och datatyper.
