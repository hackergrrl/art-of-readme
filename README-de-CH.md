# Die Kunst des README

*Dieser Artikel wurde aus dem [Englischen](README.md) übersetzt.*

*Dieser Artikel kann auch auf [Chinesisch](README-zh.md), 
[Brasilianisches Portugiesisch](README-pt-BR.md),
[Spanisch](README-es-ES.md) und [Französisch](README-fr.md) gelesen werden.*

## Etymologie

Woher stammt der Begriff "README"?

Die Bezeichnung geht *mindestens* zurück auf die 70er Jahre
[und den PDP-10](http://pdp-10.trailing-edge.com/decuslib10-04/01/43,50322/read.me.html),
auch wenn es sogar noch weiter zurückliegen könnte, zu den Tagen, als
informative Papiernotizen auf einen Stapel Lochkarten gestapelt wurden
mit „LIES MICH!” bekritzelt, um ihren Zweck zu beschreiben.

Ein Leser<sup>[1](#footnote-1)</sup> schlug vor, dass der Title README eine
humorvolle Anspielung auf
*Alice im Wunderland* von Lewis Caroll seien könnte, in der es
einen Trank und einen Kuchen mit der Bezeichung *"DRINK ME"* beziehungsweise
*"EAT ME"* gibt.

Das Muster, das README komplett in Großbuchstaben erscheint, ist eine
konsistente Facette durch die Geschichte. Nicht nur dank der visuellen
Hervorhebung durch das Benutzen von Majuskeln, sondern auch dadurch, dass
UNIX-Systeme Großbuchstaben vor Kleinbuchstaben sortieren würden, was die
README bequemerweise vor den Rest des Ordnerinhalts
platzierte<sup>[2](#footnote-2)</sup>.

Die Absicht ist klar: *"Dies ist wichtige Information für den Nutzer, die
gelesen sollte, bevor weitergemacht wird."* Lasst uns zusammen erkunden,
was "wichtige Informationen" in der heutigen Moderne ausmacht.

## Für Ersteller, für Konsumierende

Dies ist ein Artikel über READMEs. Darüber, was sie tun, warum sie unbedingt
notwendig sind und wie sie gut erstellt werden können.

Dies ist für Ersteller von Modulen geschrieben, da es die Aufgabe eines solchen
ist, etwas zu schaffen, dass überdauert. Es ist eine inhärente Motivation,
selbst wenn der Autor keine Absicht hat, ihre Arbeit zu teilen. Nach sechs
Monaten wird ein Modul ohne Dokumentation wie neu und unbekannt aussehen.

Dies ist ebenso für Konsumierende von Modulen geschrieben, da jeder Autor auch
ein Nutzer von Modulen ist. Node.js hat einen sehr gesunden Grad von
Interdependenz: niemand lebt wirklich am Fuße des Abhängigkeitsbaums.

Auch wenn es sich auf Node.js fokussiert, behauptet der Autor, dass die
Lektionen sich genauso gut auf andere Programmierumgebungen anwenden lassen.

## Viele Module: einige gut, andere schlecht

Das Node.js-Ökosystem basiert auf seinen Modulen. [npm](https://npmjs.org) ist
die Magie dahinter, die es alles *vorantreibt*. Innerhalb einer Woche werten
Node.js-Entwickler Dutzende Module aus, ob sie sie für ihre Projekte nutzen
sollen. Damit wird täglich eine Menge Macht freigesetzt, die nur darauf wartet
genutzt zu werden, indem `npm install` geschrieben wird.

Wie andere sehr zugängliche Ökosysteme auch, schwankt die Qualität. npm
macht das Beste daraus, all diese Module nett zu verpacken und weit zu
verteilen. Die gefundenen Werkzeuge unterscheiden sich jedoch ziemlich:
einige sind brandneu, andere angestaubt oder kaputt und wieder andere irgendwo
dazwischen. Es gibt sogar welche, von denen wir gar nicht wissen, was sie tun!

Für einige Module kann das in Form ungenauer oder wenig hilfreicher Namen
annehmen (was wohl das `fudge` Modul tut?), andere haben keine Dokumentation,
Tests, Kommentare im Quellcode oder unverständliche Funktionsnamen.

Viele haben keinen aktiven Instandhalter. Falls ein Modul keinen Menschen mehr
hat, der Fragen beantwortet und erklärt, was ein Modul macht, kombiniert mit
fehlenden Überbleibseln von Dokumentation, dann wird das Modul ein bizarres
Artefakt eines Aliens, unbenutzbar und unverständlich für die
Archäologie-Hacker von morgen.

Wo landen die Module, die eine Dokumentation haben, auf dem Qualitätsspektrum?
Manchmal handelt es sich nur um einen Einzeiler: `"Sortiert Nummern nach ihren
Hex-Werten"`. Vielleicht ist es ein Beispielcode-Schnippsel. Beides sind
besser als gar nichts, aber sie tendieren dazu, in das Worst-Case Szenario
einer modernen Modul-Höhlenforschung zu resultieren: Den Quellcode
durchforsten, um zu versuchen und zu verstehen, wie es tatsächlich
funktioniert. Das Schreiben hervorragender Dokumentation zeichnet sich dadurch
aus, dass der Nutzer aus dem Quellcode ferngehalten wird, indem die Anleitungen
ausreichend genug sind, um die wundervollen Abstraktionen zu genießen, die das
Modul bereitstellt.

Node.js hat ein "großes" Ökosystem: Es besteht im Wesentlichen aus einer
sehr langen Liste von unabhängigen mach-eine-Sache-gut Modulen und nicht mehr.
Es gibt [Ausnahmen](https://github.com/lodash/lodash), aber von diesen
kleineren Lehnsgütern abgesehen sind es die Einzweck-Gutsherren, die aufgrund
ihrer schieren Anzahl das Node.js-Königreich beherrschen.

Diese Situation hat eine natürliche Konsequenz: Es kann schwer sein,
*hochwertige* Module zu finden, die genau das machen, was du willst.

**Das ist in Ordnung**. Wirklich. Eine niedrige Eintrittsbarriere und das
Auffindbarkeits-Problem sind unendlich besser als ein Kulturproblem, bei dem
nur die wenigen Privilegierten teilnehmen dürfen.

Darüberhinaus lässt sich Auffindbarkeit -- wie wir herausfinden werden --
einfacher adressieren.

## Alle Strassen führen zur README.md

Die Node.js Gemeinschaft hat auf die Herausforderung der Auffindbarkeit in
verschiedenen Weisen reagiert.

Einige erfahrene Node.js-Entwickler haben sich zusammengetan, um eine
[kuratierte Liste](https://github.com/sindresorhus/awesome-nodejs) hochwertiger
Module zu erstellen.
Entwickler nutzen ihre langjährige Erfahrung beim Untersuchen von Hunderten
verschiedener Module, um mit Neulingen die *crème de la crème* zu teilen:
die besten Module in jeder Kategorie.
Dies kann auch in Form von RSS-Feeds und Mailinglisten geschehen, die neue
Module vorstellen, die von vertrauenswürdigen Mitgliedern der Community als
nützlich betrachtet werden.

Was ist mit dem sozialen Graphen? Diese Idee regte die Erstellung von
[node-modules.com](http://node-modules.com/) an, einem Ersatz der npm-Suche,
die GitHubs sozialen Graphen verwendet, um Module zu finden, die deine Freunde
mögen oder erstellt haben.

Natürlich hat npm auch eine eingebaute [Suche](https://npmjs.org):
ein sicherer Standard und der übliche Einstiegspunkt für neue Entwickler.

Egal welcher Ansatz, unabhängig davon, ob ein Modul-Höhlenforscher die
Moduluntergründe von [npmjs.org](https://npmjs.org),
[github.com](https://github.com) oder anderswo betritt, der potentielle Nutzer
wird schließlich deine README zu sehen bekommen. Da sich deine Nutzer
unausweislich hier wiederfinden werden, stellt sich die Frage, was du machen
kannst, um ihren ersten Eindruck maximal effektiv zu mcahen?

## Professionelle Modul-Höhlenforschung

### Die README: Alles aus einer Hand

Die README ist der erste -- und vielleicht einzige -- Blick eines Modulnutzers
in dein Werk. Der Nutzer erwartet, dass ein Modul ihre Bedürfnisse erfüllt,
also must du genau erklären, was für ein Problem dein Modul löst und wie
effektiv es dabei ist.

Deine Aufgabe ist es,

1. zu erklären, was es ist (mit Kontext)
2. zu zeigen, wie es in Aktion aussieht
3. zu zeigen, wie es genutzt wird
4. alle weiteren relevante Details aufzuzählen

Dies ist *deine* Aufgabe. Es liegt an den Modulersteller zu beweisen, dass
ihre Arbeit ein glänzender Edelstein im Meer von schludrigen Modulen ist.
Da so viele Entwickleraugen zuerst die README finden werden, ist Qualität hier
dein öffentlichkeitswirksames Maß deiner Arbeit.

### Kürze

Das Fehlen einer README ist eine starke Warnsignal, aber auch eine lange
README ist kein Indikator von hoher Qualität. Die ideale README ist so kurz
wie es geht, aber nicht kürzer. Ausführliche Dokumentation ist gut -- erstelle
separate Seiten dafür! -- aber halte deine README prägnant.

### Aus der Vergangenheit lernen

Es heißt, dass jene, die nicht aus ihrer Vergangenheit lernen, dazu verdammt
sind, die Fehler zu wiederholen. Entwickler haben bereits seit einigen Jahren
Dokumentation geschrieben. Es wäre eine Verschwendung, nicht ein wenig darauf
zurückzublicken und nachzuschauen, was die Leute vor Node.js gemacht haben.

Perl, trotz aller Kritik, die es erfährt, ist in einigen Weisen der geistige
Großvater von Node.js. Beides sind High-Level Skriptsprache, übernehmen viele
UNIX-Idiome, befeuern große Teile des Internets und beide besitzen ein reiches
Modul-Ökosystem.

Es stellt sich heraus, dass die
[Mönche der Perl-Community](http://perlmonks.org) der tatsächlich viel
Erfahrung im Schreiben von
[hochqualitativen READMEs](http://search.cpan.org/~kane/Archive-Tar/lib/Archive/Tar.pm)
erworben haben. CPAN ist eine wundervolle Ressource, die es wert ist,
durchgelesen zu werden, um mehr von einer Gemeinschaft zu lernen, die durchweg
hochkalibrige Dokumentation geschrieben hat.

### Keine README? Keine Abstraktion

Ohne README werden Entwickler den Quellcode betrachten müssen, um ihn zu
verstehen.

Die Perl-Mönche haben hierzu eine Weisheit zu teilen:

> Deine Dokumentation ist dann vollständig, wenn jemand dein Modul nutzen kann,
> ohne jemals auf den Quellcode schauen zu müssen. Das ist sehr wichtig. Es
> ermöglicht es dir, die dokumentierte Schnittstelle deines Moduls von dessen
> Implementierung zu trennen (gut). Das ist gut, weil es bedeutet, dass du
> frei bist, die Interna deines Moduls zu ändern, solange die Schnittstelle
> die gleiche bleibt.
>
> Zur Erinnerung: Die Dokumentation, nicht der Quellcode, bestimmt darüber,
> was ein Modul macht.
-- [Ken Williams](http://mathforum.org/ken/perl_modules.html#document)

### Schlüsselelemente

Sowie eine README gefunden wurde, überfliegt der mutige Modul-Höhlenforscher es,
um festzustellen, ob es die Bedürfnisse des Entwicklers abdeckt. Im
Wesentlichen handelt es sich dabei um eine Reihe von Problemen des
Musterabgleichs, welches das Gehirn lösen muss, wobei jeder Schritt den
Entwickler tiefer in das Modul und dessen Details führt.

Sagen wir zum Beispiel, meine Suche für ein Modul zur 2D-Kollisionserkennung
führt mich zu
[`collide-2d-aabb-aabb`](https://github.com/noffle/collide-2d-aabb-aabb). Ich
beginne damit, es von oben nach unten zu durchforsten:

1. *Name* -- am besten selbsterklärend. `collide-2d-aabb-aabb` klingt
   vielversprechend, auch wenn es annimmt, dass ich weiß, was "aabb" ist. Wenn
   der Name zu vage oder unbezogen klingt, kann das ein Signal sein, woanders
   weiterzusuchen.

2. *Einzeiler* -- ein Einzeiler zur Beschreibung des Moduls kann nützlich sein,
   um eine Idee davon zu bekommen, was das Modul in etwa macht.
   `collide-2d-aabb-aabb` sagt, dass es

   > Bestimmt, ob eine sich bewegende Achsen-ausgerichtete Begrenzungs-Box
   > (AABB) mit anderen AABBs kollidiert.

   Fantastisch: es definiert AABB und was das Modul macht. Jetzt zum Abschätzen,
   wie gut es in meinen Code passen wird:

3. *Benutzung* -- anstatt sich direkt in die API-Dokumentation zu vertiefen,
   wäre es toll zu sehen, wie das Modul in Aktion aussieht. Ich kann schnell
   bestimmen, ob das Beispiel-JavaScript den gewünschtem Stil und Problem
   entspricht. Die Leute haben viele Meinungen dazu, wie Dinge wie
   Promises/Callbacks und ES6 aussehen sollten. Falls es den Vorstellungen
   entspricht, dann kann ich mit mehr Details fortfahren.

4. *API* -- der Name, die Beschreibung und die Benutzung des Moduls klingen
   allesamt vielversprechend für mich. Ich bin an dieser Stelle sehr dazu
   geneigt, das Modul zu benutzen. Ich muss nur noch das API überfliegen, um zu
   sehen, ob es genau das macht, was ich brauche und werde es dann leicht in
   meine Codebase integrieren. Der Abschnitt zum API muss daher die Objekte und
   Funktionen des Moduls, ihre Signaturen, Rückgabewerte, Callbacks und Events
   im Detail beschreiben. Typen sollten einbezogen werden, wenn sie nicht
   offensichtlich sind. Warnungen sollten klar gemacht werden.

5. *Installation* -- wenn ich bis hierhin gelesen habe, bin ich bereit, dass
   Modul zu installieren. Falls die Installationsbeschreibung vom Standard
   abweicht, sollte es hier stehen, selbst wenn es nur ein reguläres
   `npm install` ist, würde ich das gerne erwähnt sehen. Ständig fangen neue
   Nutzer mit Node.js an, so dass ein Link zur npmjs.org und ein
   Installationsbefehl ihnen die Ressourcen an die Hand gibt, um herauszufinden,
   wie Node.js-Module funktionieren.

6. *Lizenz* -- viele Module platzieren dies ganz am Ende, aber es könnte weiter
   oben besser aufgehoben sein; du wirst ein Modul wohl sehr schnell
   ausschließen, wenn die Lizenz mit deiner Arbeit unkompatibel ist. Generell
   tendiere ich zu MIT/BSD/X11/ISC-Varianten. Falls du eine non-permissive
   Lizenz hast, platziere sie ganz am Anfang, um Verwirrung zu vermeiden.

## Wahrnehmungstrichter

Die Reihenfolge oben wurde nicht zufällig gewählt.

Nutzer von Modulen benutzen viele, und sie müssen sich viele Module anschauen.

Nachdem du Hunderte von Modulen betrachtet hast, wirst du bemerken, dass der
Verstand von bestimmten Mustern profitiert.

Du wirst außerdem anfangen, eine eigene persönliche Heuristik zu entwickeln,
welche Informationen du brauchst und welche Warnsignale ein Modul sehr schnell
disqualifizieren.

Daher ist es für eine README vorteilhaft, folgendes zu besitzen:

1. ein vorhersehbares Format
2. das Vorhandensein bestimmter Schlüsselelemente

Du musst nicht *dieses* Format nutzen, aber versuche konsistent zu sein, um
deinen Nutzern wertvolle Runden der Erkenntnis zu ersparen.

Die hier gewählte Reihenfolge wird auch liebevoll als "Wahrnehmungstrichter"
bezeichnet und kann sich wie ein Trichter vorgestellt werden, der aufrecht
gehalten wird, wobei das breite Ende die gröbsten relevanten Details beinhaltet
und nach unten hin immer spezifischer wird für die Leser, die an deiner Arbeit
interessiert genug sind, um so weit unten im Dokument anzugelangen. Das Ende
kann dann für Details reserviert werden für diejenigen, die mehr an dem
tieferen Kontext der Arbeit interessiert sind (Hintergrund, Danksagungen,
Quellenangaben usw.).

Wieder einmal haben die Perlmönche eine Weisheit zu diesem Thema zu teilen:

> Der Detaillevel in Dokumentation von Perlmodulen reicht üblicherweise von
> weniger detailliert zu mehr detailliert. Der SYNOPSIS-Abschnitt sollte ein
> Minimal-Beispiel zur Benutzung beinhalten (vielleicht so klein wie eine Zeile
> Code; überspring die ungewöhnlichen Fälle oder alles, dass nicht von den
> meisten Nutzern gebraucht wird); die DESCRIPTION sollte dein Modul in groben
> Zügen beschreiben, normalerweise in wenigen Abschnitten; mehr Details zu den
> Routinen oder Methoden deines Moduls, längere Codebeispiele oder anderes
> tiefergehendes Material sollte in darauffolgenden Abschnitten kommen.
>
> Idealerweise sollte jemand, der nur wenig mit deinem Modul vertraut ist,
> seine Erinnerung auffrischen können, ohne auf "Bild ab" drücken zu müssen.
> Mit weiterem Voranschreiten durch das Dokumente, sollten deine Leser nach
> und nach tieferes Wissen erhalten.
> -- aus `perlmodstyle`

## Sorge dich um die Zeit der Leute

Fantastisch; die Reihenfolge dieser Schlüsselelemente sollte dadurch bestimmt
werden, wie schnell sie es jemanden erlaubt, vorzeitig dein Modul zu
verwerfen.

Das klingt rau, stimmt's? Aber denk drüber nach: es ist nicht deine Aufgabe,
sowie du sie mit einem optimalen Altruismus erfüllst, den Leuten deine Arbeit
zu "verkaufen". Sondern sie dein Werk so objektiv wie möglich auswerten zu
lassen, um zu entscheiden, ob es ihre Bedürfnisse erfüllt oder nicht -- und
nicht etwa, sagen wir, die Anzahl der Downloads oder Nutzer zu maximieren.

Diese Denkweise spricht nicht jeden an; sie verlangt das eigene Ego außen vor
zu lassen und die Arbeit soweit wie möglich für sich selbst sprechen zu lassen.
Dein einziger Auftrag ist es, sein Versprechen so genau wie möglich zu
beschreiben, so dass Modul-Höhlenforscher entweder deine Arbeit, sofern sie
passt, benutzen, oder sich nach etwas anderem umsehen können.

## Zu den Waffen!

Schreite voran, mutiger Modul-Höhlenforscher, und mach deine Arbeit auffindbar
und nutzbar durch exzellente Dokumentation!

## Bonus: andere gute Praktiken

Außer den Schlüsselpunkten dieses Artikels gibt es noch andere Praktiken, die
du anwenden (oder nicht anwenden) kannst, um die Qualitätsleiste deiner
README zu erhöhen und dessen Nützlichkeit für andere zu maximieren:

1. Überleg dir, ob du einen Abschnitt **Hintergrund** einfügen willst, falls
   dein Modul auf wichtigen, aber nicht sehr bekannten Abstraktionen oder
   anderen Ökosystemen beruht. Die Funktion von
   [`bisecting-between`](https://github.com/noffle/bisecting-between) ist nicht
   jedem sofort klar anhand des Namens, so das es einen ausführlichen Abschnitt
   *Hintergrund* hat, um die großen Konzepte zu definieren und zu verlinken,
   sowie die Abstraktionen zu erklären, die jemand verstehen muss, um es zu
   benutzen. Dies ist auch ein toller Platz, um die Motivation hinter dem
   Modul zu erklären, falls ähnliche Module bereits auf npm existieren.

2. Verlinke viel! Falls du über andere Module, Ideen oder Personen sprichst,
   verlinke die Referenz, so dass Besucher einfach dein Module und die Ideen
   dahinter verstehen können. Wenige Module existieren in einem Vakuum: die
   ganze Arbeit beruht auf anderen Werken, also zahlt es sich aus, dass Nutzer
   die Geschichte und Inspiration deines Moduls folgen können.

3. Schließe Informationen über Typen von Argumenten und Rückgabewerten ein,
   sofern diese nicht offensichtlich sind. Bevorzuge Konvention wo immer
   möglich. `cb` bedeutet wahrscheinlich callback-Funktion, `num` bezeichnet
   wohl ein `Number` usw.).

4. Führe Beispielcode aus dem Bereich **Benutzung** als Datei in deinem Repo
   -- vielleicht als `example.js`. Es ist klasse, README code zu haben, den
   Nutzer tatsächlich ausführen können, falls sie das Repository klonen.

5. Sei bedachtsam mit dem Nutzen von Abzeichen. Sie können leicht
   [missbraucht](https://github.com/angular/angular) werden. Sie können auch
   Grundlage für Nebensächlichkeiten (Bikeshedding) und endlosen Debatten
   werden. Sie fügen visuellen Störungen zu deiner README hinzu und
   funktionieren oft nur, wenn der Nutzer dein Markdown im Webbrowser liest, da
   die Bilder oft woanders im Internet gehostet werden.
   Für jedes Abzeichen überlege dir: "Was ist der tatsächliche Wert, den dieses
   Abzeichen dem üblichen Betrachter der README bringt?" Hast du ein
   CI-Abzeichen, um den Status des Builds / Tests anzuzeigen? Dieses Signal
   würde die relevanten Gruppen eher erreichen, indem den Instandhaltern eine
   E-Mail geschickt oder ein Issue erstellt wird. Bedenke immer das Publikum
   der Daten in deiner README und frage dich selber, ob es einen Fluss für
   diese Daten gibt, die das gewünschte Publikum besser erreicht.

6. API-Formatierung hat das Potential, sich in Nebensächlichkeiten zu
   verlieren. Benutze das Format, von dem du denkst, es ist am klarsten, aber
   stelle sicher, das dein Format folgende wichtige Feinheiten ausdrückt:

   a. welche Parameter sind optional, sowie ihre Standardwerte

   b. Typinformationen, sofern nicht aufgrund von Konventionen offensichtlich

   c. für `opts` Objekt-Parameter, alle akzeptierten Schlüssel-Wert-Paare

   d. schrecke nicht davor zurück, ein winziges Beispiel der Benutzung einer
      API-Funktion zu geben, sofern es nicht offensichtlich oder im Abschnitt
      **Benutzung** behandlet wurde.
      Dies kann aber auch ein starker Hinweis darauf sein, dass die Funktion zu
      komplex ist und refactort, in kleinere Funktionen aufgebrochen oder
      komplett entfernt werden muss

   e. verlinke spezielle Terminologie! In Markdown kannst du
      [Fußnoten](https://daringfireball.net/projects/markdown/syntax#link) am
      Ende deines Dokuments einfügen, so dass das erneute Verweisen von ihnen
      sehr billig ist. Einige meiner persönlichen Präferenzen hinsichtlich
      API-Formatierung lassen sich
      [hier](https://github.com/noffle/common-readme/blob/master/api_formatting.md)
      finden

7. Falls dein Modul sich aus einer Sammlung zustandsloser Funktionen
   zusammensetzt, kann der Abschnitt **Benutzung** als 
   [Node REPL session](https://github.com/noffle/bisecting-between#example) von
   Funktionsaufrufen und -ergebnissen vielleicht den Gebrauch klarer ausdrücken
   als das Ausführen einer Datei.

8. Falls dein Modul ein CLI (command line interface) bereitstellt anstelle
   (oder zusätzlich zu) einem programmatischen API, zeige Nutzungsbeispiele als
   Aufrufe von Befehlen und ihrer Ausgabe. Falls du eine Datei erstellst oder
   bearbeitest, `cat` sie, um den Unterschied davor und danach zu demonstrieren.

9. Vergiss nicht, [Keywords](https://docs.npmjs.com/files/package.json#keywords)
   in der `package.json` zu benutzen, um Modul-Höhlenforscher an deine Pfote zu
   leiten.

10. Je mehr du dein API veränderst, desto mehr Arbeit musst du darauf
    verwenden, deine Dokumentation zu aktualisieren -- die Implikation hier ist,
    dass du dein API klein halten und früh konkret definieren solltest.
    Anforderungen ändern sich über die Zeit, aber anstatt Annahmen von
    vornherein in das API deiner Module zu packen, hebe sie eine
    Abstraktionsebene höher: dem Modul selber. Sofern sich die Änderungen
    *tatsächlich* ändern und 'mach-eine-konkrete-Sache' nicht länger Sinn
    ergibt, erstelle ein neues Modul, dass die Aufgabe erledigt. Das
    'mach-eine-konkrete-Sache'-Modul bleibt weiterhin gültig und ein wertvolles
    Modell für das npm-Ökosystem, und deine Kurskorrektur kostet dich nichts
    außer einer einfachen Ersetzung eines Moduls mit einem anderen.

11. Schlussendlich, erinnere dich bitte, dass deine Versionskontroll-Repository
    und die README darin dein [repository host](https://github.com) überleben
    wird und ebenso alles, worauf du einen Link setzt -- insbesondere Bilder --
    so *inkludiere* alles, was wesentlich ist für künftige Nutzer, um deine
    Arbeit zu verstehen.

## Bonus: *common-readme*

Nicht zufälligerweise wird das vorgestellte Format auch von
[**common-readme**](https://github.com/noffle/common-readme) verwendet, einer
Sammlung von README-Richtlinien und handlichen Kommandozeilen-Generatoren.
Falls dir gefällt, was hier geschrieben steht, kannst du etwas Zeit beim
Schreiben von README mit `common-readme` sparen. Du wirst tatsächliche
Beispiele von Modulen in diesem Format dort finden.

Du magst vielleicht auch
[standard-readme](https://github.com/richardlitt/standard-readme), was ein
strukturierter, linearer Ansatz einer üblichen README-Formats darstellt.

## Bonus: Musterbeispiele

Theorie ist gut und schön, aber wie sehen hervorragende READMEs aus? Dies sind
einige Beispiele, von denen ich denke, die die Prinzipien diesen Artikels gut
verinnerlichen:

- https://github.com/noffle/ice-box
- https://github.com/substack/quote-stream
- https://github.com/feross/bittorrent-dht
- https://github.com/mikolalysenko/box-intersect
- https://github.com/freeman-lab/pixel-grid
- https://github.com/mafintosh/torrent-stream
- https://github.com/pull-stream/pull-stream
- https://github.com/substack/tape
- https://github.com/yoshuawuyts/vmd

## Bonus: Die README-Checkliste

Eine hilfreiche Checkliste, um abzuschätzen, wie gut deine README vorankommt:

- [ ] Einzeiler, der den Zweck deines Moduls ausdrückt
- [ ] Nützlicher Hintergrund-Kontext und Links
- [ ] Potenziell unbekannte Begriffe verlinken auf informative Quellen
- [ ] Klare, **lauffähige** Beispiele der Anwendung
- [ ] Installationsanleitung
- [ ] Ausführliche API-Dokumentation
- [ ] Ausführen des [Wahrnehmungstrichters](https://github.com/noffle/art-of-readme#cognitive-funneling)
- [ ] Warnmeldungen und Einschränkungen werden im Voraus erwähnt
- [ ] Verlässt sich nicht auf Bilder, um kritische Informationen zu vermitteln
- [ ] Lizenz

## Über den originalen Autor

Ich bin [noffle](http://blog.eight45.net/about/). Ich bin dafür bekannt zu
[bloggen](http://blog.eight45.net), [tweeten](https://twitter.com/noffle), und
zu [hacken](https://github.com/noffle).

Dieses kleine Projekt begann damals im Main in Berlin bei der squantconf, wo
ich mich damit beschäftigt habe, wie Perl-Mönche ihre Dokumentation schreiben
und mich ebenso über den Stand der READMEs im Node.js-Ökosystem beschwert habe.
Das hat mich dazu gebracht,
[common-readme](https://github.com/noffle/common-readme) zu erstellen.
Der Abschnitt zu "README Tipps" floss allerdings mit Tipps über, so dass ich
mich entschied, diese in einem Artikel zu sammeln, wie READMEs geschrieben
werden. So wurde die Kunst des README geboren!

Du kannst mich unter `noffle@eight45.net` oder im Freenode IRC in `#eight45`
erreichen.

## Zum Weiterlesen

- [README-Driven Development](http://tom.preston-werner.com/2010/08/23/readme-driven-development.html)
- [Documentation First](http://joeyh.name/blog/entry/documentation_first/)

## Fußnoten

1. <a name="footnote-1"></a>Danke,
   [Sixes666](https://www.reddit.com/r/node/comments/55eto9/nodejs_the_art_of_readme/d8akpz6)!

1. <a name="footnote-2"></a>Siehe [Jargon File](http://catb.org/~esr/jargon/html/R/README-file.html).
   Die meisten Systeme heutzutage werden jedoch nicht Großbuchstaben vor
   Kleinbuchstaben sortieren, so dass sich die Nützlichkeit der Konvention
   auf die visuelle Hervorhebung durch die Nutzung der Großbuchstaben
   beschränkt.

## Danksagung

Ein inniger Dank an dich, [@mafintosh](https://github.com/mafintosh) und
[@feross](https://github.com/feross) für die Ermunterung, die ich brauchte, um
diese Idee umzusetzen und anzufangen zu schreiben!

Danke auch an die folgenden großartigen Leser, die Fehler bemerkt und mir PRs
gesendet haben :heart: :

- [@ungoldman](https://github.com/ungoldman)
- [@boidolr](https://github.com/boidolr)
- [@imjoehaines](https://github.com/imjoehaines)
- [@radarhere](https://github.com/radarhere)
- [@joshmanders](https://github.com/joshmanders)
- [@ddbeck](https://github.com/ddbeck)
- [@RichardLitt](https://github.com/RichardLitt)
- [@StevenMaude](https://github.com/StevenMaude)
- [@KrishMunot](https://github.com/KrishMunot)
- [@chesterhow](https://github.com/chesterhow)
- [@sjsyrek](https://github.com/sjsyrek)
- [@thenickcox](https://github.com/thenickcox)

Dank an [@qihaiyan](https://github.com/qihaiyan) für das Übersetzen der Kunst
des README ins Chinesische! Die folgenden Nutzer haben auch Beiträge
eingebracht:

- [@BrettDong](https://github.com/brettdong) für das Revidieren der Punktierung
  in der chinesischen Version.
- [@Alex-fun](https://github.com/Alex-fun)
- [@HmyBmny](https://github.com/HmyBmny)
- [@vra](https://github.com/vra)

Dank an [@lennonjesus](https://github.com/lennonjesus) für das Übersetzen der
Kundes des README in Brasilianisches Portugiesisch! Die folgenden Nutzer haben
auch Beiträge eingebracht:

- [@rectius](https://github.com/rectius)

Dank an [@jabiinfante](https://github.com/jabiinfante) für das Übersetzen der
Kunst des README ins Spanisch!

Dank an [@Ryuno-Ki](https://github.com/Ryuno-Ki) für das Übersetzen der Kunst
des README ins Deutsche! Die folgenden Nutzer haben auch Beiträge eingebracht:

- [@randomC0der](https://github.com/randomC0der)

Dank an [@Manfred Madelaine](https://github.com/Manfred-Madelaine-pro) und
[@Ruben Madelaine](https://github.com/Ruben-Madelaine)
für das Übersetzen der Kunst des README ins Französisch! 

Abschließend dank an alle für ihr Feedback! Bitte teilt eure Kommentare
[als issue](https://github.com/noffle/art-of-readme/issues)!

## Pull requests willkommen!

Einen Fehler entdeckt? Irgendetwas ergibt keinen Sinn? Sende mir einen
[pull request](https://github.com/noffle/art-of-readme/pulls)! Bitte vermeide
stilistische Änderungen -- sie werden wahrscheinlich nicht angenommen. Danke!

## Lizenz

[Creative Commons Attribution License](http://creativecommons.org/licenses/by/2.0/)
