# L'art du README

*Cet article a été traduit à partir de la version [Anglaise](README.md) 
et est également disponible en [Chinois](README-zh.md),
[Portugais](README-pt-BR.md), [Espagnole](README-es-ES.md) et [Allemand](README-de-DE.md).*

## Etymologie

D'où vient le terme «README»?

La nomenclature remonte au moins aux années 1970 [et le
PDP-10](http://pdp-10.trailing-edge.com/decuslib10-04/01/43,50322/read.me.html),
bien que cela puisse même remonter à l'époque des notes informatives en papier placées au sommet
de piles de cartes perforées, avec "READ ME!" ("LISEZ-MOI!") griffonné sur eux, décrivant leur utilisation.

Un lecteur<sup>[1](#footnote-1)</sup> suggéra que le titre README puisse être un petit coup de pouce ludique 
en hommage au très fameux roman, de Lewis Carroll, intitulé Les *Aventures d'Alice au pays des merveilles*, 
comprennant une potion et un gâteau étiquetés respectivement avec "DRINK ME" (BUVEZ-MOI) et "EAT ME" (MANGEZ-MOI).

Le modèle de README apparaissant en majuscules est un point récurrent tout au long de l'histoire. 
En plus du carractère visuellement frappant de l'utilisation des majuscules, les systèmes UNIX
triaient les majuscules avant les minuscules, mettant commodément le README
avant le reste du contenu du répertoire<sup>[2](#footnote-2)</sup>.

L'intention est claire: *"Il s'agit d'informations importantes que l'utilisateur doit lire avant
de poursuivre".* Explorons ensemble ce qui constitue une information "importante" dans
ces temps modernes.

## Pour les créateurs, pour les consommateurs

Cet article traite des READMEs. Il présente ce qu'ils font, pourquoi ils sont
absolument nécessaires, et comment bien les construire.

Cet article peut intéresser les créateurs de modules car, en tant que constructeurs
de modules, leur travail consiste à créer des éléments durables et compréhensibles.
C'est une motivation inhérente, même si l'auteur n'a pas l'intention
de partager son travail.
En effet, même si développé pour une utilisation privée, 
une fois six mois passés, un module sans documentation
devient inconnu même aux yeux de son créateur.

Cet article est également pour les consommateurs de modules, puisque chaque
auteur de module en consomme également. Node.js a un degré d'interdépendance
très sain : personne n'est aux pieds de l'arborescence des dépendances.

Bien qu'il se concentre sur Node.js, l'auteur soutient que ses leçons s'appliquent
aussi bien à d’autres écosystèmes de programmation.

## De nombreux modules: certains bons, d'autres mauvais

L'écosystème Node.js est alimenté par ses modules. [npm](https://npmjs.org) est
la magie qui fait tout cela *tourner*. Au cours d'une semaine, les développeurs Node évaluent
des dizaines de modules à intégrer dans leurs projets. C'est beaucoup de puissance
que de pouvoir tirr quotidiennement, autant de modules, aussi vite que l'on puisse
écrire `npm install`.

Comme tout écosystème extrêmement accessible, la barre de qualité varie. npm
fait de son mieux pour bien empaqueter tous ces modules et les expédier ici et
là en fonction du besoin. Cependant, les modules récupérés sont très variés: 
certains sont neufs et brillants, d'autres sont cassés et rouillés,
et d'autres encore sont situés quelque part entre les deux. 
Il y en a même certains dont nous ne savons tout simplement pas ce qu'ils font!

Pour les modules, cela peut prendre la forme de noms inexacts ou inutiles 
(une idée sur ce que fait le module `fudge`?), pas de documentation, pas de tests, 
pas de commentaires dans le code source ou des noms de fonctions incompréhensibles.

Beaucoup n'ont pas de mainteneur actif. Si un module n'a aucune personne disponible pour
répondre aux questions et expliquer ce que fait un module, combiné à une absence de documentation 
laissé en héritage, un module devient un artefact extraterrestre bizarre, inutilisable
et incompréhensible par les archéologues-hackers de demain.

Pour les modules ayant de la documentation, où se situent-ils en terme de qualité?
C'est peut-être juste une description à une seule ligne: `"trie les nombres par leur valeure hexadécimal"`,
ou il s'agirait d'un exemple extrait du code. C'est déjà mieux que rien, mais ils ont 
tendance à finir, dans le pire des cas, comme module pour les spéléologues des temps modernes: 
fouillant dans le code source pour essayer de comprendre comment il fonctionne réellement. 
Ecrire une excellente documentation, c'est garder les utilisateurs
*hors* du code source en fournissant des instructions suffisantes pour profiter des
merveilleuses abstractions que votre module apporte.

Node.js a un écosystème "large": il est en grande partie constitué d'une très longue liste de
modules indépendants, adeptes du faire-une-chose-mais-le-faire-bien. Il y a des
[exceptions](https://github.com/lodash/lodash), mais malgré ces fiefs mineurs,
ce sont les modules à "but unique" qui, étant donné leur plus grand nombre, gouvernent réellement le
Royaume de Node.js.

Cette situation a une conséquence naturelle: il peut être difficile de trouver des modules *de qualité*
qui font exactement ce que vous voulez.

**C'est ok**. Vraiment. Une barre basse à l'entrée et un problème de découvrabilité est
infiniment mieux qu'un problème de culture, où seuls quelques privilégiés peuvent participer.

De plus, la découvrabilité - en fait - est plus facile à gérer.

## Tous les chemins mènent au README.md
La communauté de Node.js a répondu au défi de la découverte de
différentes manières.

Certains développeurs expérimentés de Node.js se sont associés pour créer
des [listes organisées](https://github.com/sindresorhus/awesome-nodejs)
de modules de qualité. Les développeurs tirent parti de leurs nombreuses
années à examiner des centaines de modules différents en partageant avec
les nouveaux arrivants la crème de la crème :
les meilleurs modules de chaque catégorie. Cela peut également prendre la
forme de flux RSS et de listes de diffusion de nouveaux modules jugés utiles
par les membres de confiance de la communauté.

Qu'en est-il du graphe social ? Cette idée a stimulé la création de
[node-modules.com](http://node-modules.com/), un remplacement de recherche 
npm qui exploite votre graphe social GitHub pour trouver des modules que
vos amis aiment ou ont créés.

Bien sûr, il existe également la fonctionnalité de [recherche](https://npmjs.org) 
intégrée de npm: une valeur sûre par défaut et le point d'entrée habituel pour tous 
les nouveaux développeurs.

Quelle que soit votre approche, peu importe si un spéléologue de module entre
dans les profonds souterrains de  modules sur [npmjs.org](https://npmjs.org),
[github.com](https://github.com) ou ailleurs, cet utilisateur
potentiel finira par regarder votre README en face. Étant donné que vos
utilisateurs se retrouveront inévitablement ici, que peut-on faire pour rendre
leurs premières impressions efficaces au maximum ?


## Spéléologues de module professionnel

### Le README: votre point d'entrée

Le README est le premier - et peut-être le seul - document qu'un consommateur de module examinera 
lors de la découverte de votre création. Le consommateur souhaite qu'un module réponde à son besoin, 
vous devez donc expliquer exactement ce que votre module permet de faire et avec quelle efficacité il le fait.

Votre travail consiste à:

1. leur dire ce que c'est (avec un contexte)
2. leur montrer à quoi il ressemble en action
3. leur montrer comment l'utiliser
4. leur indiquer tout autre détail pertinent

C'est *votre* travail. C'est au créateur du module de prouver que son travail est un
joyau brillant dans la mer des modules abandonnés. Puisque tant de développeurs
trouverons leur chemin vers votre README avant d'intier toute autre action, la qualité 
du README sera comme une mesure de votre travail face au public.


### Brièveté

L'absence d'un README est un puissant drapeau rouge, mais un long README n'est pas
non plus gage de qualité. Le README idéal est aussi court que possible, 
sans l'être trop. La documentation détaillée est bonne - séparez
les pages pour cela! - mais gardez votre README succinct.


### Apprendre du passé

On dit que ceux qui n'étudient pas leur histoire sont condamnés à refaire les mêmes 
erreurs à nouveau. Les développeurs écrivent de la documentation depuis un certain nombre
d'années. Ce serait un gaspillage de ne pas regarder un peu en arrière et voir ce que les gens
faisaient juste avant Node.js.

Perl, malgré toutes les critiques qu'il reçoit, est à certains égards le grand-père spirituel
de Node.js. Les deux sont des langages de script de haut niveau, adoptent de nombreux idiomes UNIX,
sont utilisés dans une grande partie d'Internet, et disposent d'un vaste écosystème de modules.

Il s'avère que les [moines](http://perlmonks.org) de la communauté Perl ont en effet une grande expérience 
en rédaction de [README de qualité](http://search.cpan.org/~kane/Archive-Tar/lib/Archive/Tar.pm). CPAN est une
merveilleuse ressource qui vaut la peine d'être lue pour en savoir plus sur une communauté
qui a rédigé des documentations de bonne facture.


### Pas de README? Pas d'abstraction

Pas de README signifie que les développeurs devront fouiller dans votre code pour
le comprendre.

Les moines Perl ont une sagesse à partager à ce sujet:

> Votre documentation est complète lorsque quelqu'un peut utiliser votre module sans jamais
> avoir à regarder son code. C'est très important. Cela vous permet de séparer l'interface 
> documentée de votre module de son implémentation interne (tripes). C'est bien car cela 
> signifie que vous êtes libre de modifier les composants internes du module autant que 
> que vous le voulez, pour peu que l'interface l'interface reste la même.
>
> N'oubliez pas: la documentation, pas le code, définit ce que fait un module.
> -- [Ken Williams](http://mathforum.org/ken/perl_modules.html#document)


### Éléments clé

Une fois qu'un README est identifié, le chercheur de module doit le scanner afin de confirmer si
celui-ci répond bien à ses besoins de développement. Cela devient essentiellement une série de validation
de critères d'acceptation que leur cerveau doit résoudre, où chaque étape les plonge de plus en plus
dans le module et ses détails.

Disons, par exemple, que ma recherche d'un module de détection de collision 2D m'amène
à [`collide-2d-aabb-aabb`](https://github.com/noffle/collide-2d-aabb-aabb). je
commence à l'examiner de haut en bas:

1. *Nom* - les noms explicites sont les meilleurs. Le nom `collide-2d-aabb-aabb`
   semble prometteur, bien que cela suppose que je sache ce qu'est un "aabb". 
   Si le nom semble trop vague ou sans rapport, cela peut être un signal pour passer à autre chose.

2. *One-liner* - avoir un one-liner qui décrit le module est utile pour
   avoir une idée de ce que fait le module avec un peu plus de détails.
   `collide-2d-aabb-aabb` l'exprime très bien

   > Détermine si un cadre de délimitation aligné sur l'axe mobile (AABB) entre en collision avec
   > un autres AABB.

   Génial: il définit ce qu'est un AABB et ce que fait le module. Maintenant pour évaluer comment
   cela s'intégrerait dans mon code:

3. *Utilisation* - plutôt que de commencer à fouiller dans la documentation de l'API, ce serait génial de
   voir à quoi ressemble le module en action. Je peux rapidement déterminer si l'exemple 
   correspond au style et au problème souhaités. Les gens ont beaucoup d'opinions
   sur des choses comme les promesses/callbacks et ES6. Si cela correspond à la demande, alors je
   peut continuer vers plus de détails sur le fonctionnement.

4. *API* - le nom, la description et l'utilisation de ce module semblent tous attrayants pour moi.
   Je suis très susceptible d'utiliser ce module à ce stade. J'ai juste besoin de scanner
   l'API pour m'assurer qu'elle fait exactement ce dont j'ai besoin et qu'elle s'intègre
   facilement dans ma base de code. La section API doit détailler les objets du module
   et fonctions, leurs signatures, types de retour, rappels et événements dans le détail.
   Les types doivent être inclus là où ils ne sont pas évidents. Les mises en garde devraient être
   clairement explicités.

5. *Installation* - si j'ai lu jusque-là, je suis convaincu d'au moins essayer le
   module. S'il y a des notes d'installation non standard, voici où elles iraient,
   mais même si c'est juste une simple commande d'`installation npm`, j'aimerais voir cela mentionné,
   aussi. De nouveaux utilisateurs commencent à utiliser Node.js tout le temps, donc avoir un lien vers npmjs.org
   et la commande d'installation associée, leur fournit toutes les ressources nécessaires pour 
   comprendre comment les modules Node.js fonctionnent.

6. *Licence* - la plupart des modules placent cela tout en bas, mais cela pourrait
   en fait être placé plus haut; vous êtes susceptible d'exclure un module TRÈS
   rapidement s'il possède une licence incompatible avec votre travail. Je m'en tiens généralement aux
   dérivés des licences MIT / BSD / X11 / ISC. Si vous avez une licence non permissive, placez-la
   tout en haut du module pour éviter toute confusion.


## Progressivité cognitive

L'ordre des éléments ci-dessus n'a pas été choisi au hasard.

Les consommateurs de modules utilisent et analysent de nombreux modules.

Une fois que vous avez regardé des centaines de modules, vous commencez à remarquer que l'esprit
bénéficie de modèles prévisibles.

Vous commencez également à élaborer votre propre heuristique personnelle pour les informations que vous
veulez, et quels drapeaux rouges disqualifient rapidement les modules.

Ainsi, il s'ensuit que dans un README, il est souhaitable d'avoir:

1. un format prévisible
2. certains éléments clés présents

Vous n'avez pas besoin d'utiliser *ce* format, mais essayez d'être cohérent pour éviter la perte de
précieux cycles cognitifs à vos utilisateurs.

La recommandation présentée ici est appelée «progressivité cognitive»,
et peut être imagée en un entonnoir, tenu debout, où l'extrémité la plus large contient 
les détails les plus généraux et les plus pertinents, et la descente progressive dans l'entonnoir présente
des détails de plus en plus spécifiques, n'étant pertinents que pour un lecteur suffisamment intéressé
par le module pour avoir atteint ce niveau de profondeur. 
Finalement, la fin peut être réservée pour les détails  sur le contexte 
de la crétaion (background, crédits, biblio, etc.).

Une fois de plus, les moines Perl ont une sagesse à partager sur le sujet:

> Le niveau de détail dans la documentation du module Perl va généralement du
> moins détaillé au plus détaillé. Votre section SYNOPSIS devrait
> contenir un exemple minimal d'utilisation (peut-être aussi court qu'une simple ligne de
> code; sautez les cas d'utilisation inhabituels et tout ce qui n'est pas nécessaire pour 
> la plupart des utilisateurs); la DESCRIPTION doit décrire votre module en termes généraux,
> généralement en quelques paragraphes; le rests des détails sur le module, 
> ses méthodes, ses longs exemples ou autres doivent être donné dans les sections suivantes.
>
> Idéalement, quelqu'un qui connaît un peu votre module devrait être
> capables de se rafraîchir la mémoire sans pour autant devoir pacourir  l'entièreté de votre 
> docuement. Au cours de sa lecture, votre lecteur devrait recevoir, graduellement, 
> des connaissances de plus en plus poussées.
> -- de `perlmodstyle`


## Se soucier du temps des gens

Impressionnant; l'ordre de ces éléments clés doit être décidé en fonction de la rapidité
avec laquelle ils permettent à quelqu'un de «court-circuiter» et abandonner votre module.

Cela semble sombre, n'est-ce pas? Mais pensez-y: votre travail, quand vous le faites
avec un altruisme optimal à l'esprit, ce n'est pas pour «vendre» votre travail à des gens. 
C'est de les laisser évaluer ce que votre création fait, aussi objectivement que possible, et 
de décider si celui-ci réponde ou non à leurs besoins - ne pas, par exemple, maximiser vos 
téléchargements ou votre base d'utilisateur.

Cet état d'esprit ne plaît pas à tout le monde; Cela implique qu'il faille laisser son ego à
l'netrée et laisser l'œuvre parler d'elle-même autant que possible. Votre seul travail est
de décrire sa promesse aussi succinctement que possible, afin que les spéléologues de modules puissent
soit utilisez votre travail quand c'est un ajustement, soit passez à autre chose.


## Appel aux armes!

Allez de l'avant, courageux dénicheurs de module, et rendez votre travail compréhensible et utilisable
par tous, grâce à une excellente documentation!


## Bonus: autres bonnes pratiques

En dehors des points clés de l'article, il existe d'autres pratiques que vous pouvez
suivre (ou ne pas suivre) pour élever encore plus la barre de qualité de votre README et
maximiser son utilité pour les autres:

1. Pensez à inclure une section **Contexte** si votre module dépend 
   d'autres abstractions importantes mais peu connues ou d'autres écosystèmes. La fonction
   de [`bissecting-between`](https://github.com/noffle/bisecting-between) n'est pas
   immédiatement évident à partir de son nom, il a donc une section détaillée *Contexte*
   pour définir et établir un lien avec les grands concepts et abstractions dont on a besoin
   pour comprendre et utiliser votre module. C'est aussi un excellent endroit pour expliquer
   la motivation du module si des modules similaires existent déjà sur npm.

2. Référencez agressivement! Si vous parlez d'autres modules, idées ou personnes, utilisez 
   une référence afin que les visiteurs puissent plus facilement analyser votre module
   et les idées sur lesquelles il s'appuie. Peu de modules existent à partir de rien: tout le travail vient
   d'autres travaux, il est donc avantageux d'aider les utilisateurs à suivre l'historique de votre module et
   ses inspirations.

3. Incluez des informations sur les types d'arguments et renvoyez les paramètres si ce n'est pas le cas
   évident. Préférez la convention dans la mesure du possible (`cb` signifie probablement un rappel
   fonction, `num` signifie probablement un `nombre`, etc.).

4. Incluez l'exemple de code dans **Usage** en tant que fichier dans votre dépôt - peut-être comme
   `exemple.js`. C'est formidable d'avoir un code README que les utilisateurs peuvent exécuter si
   ils clonent le référentiel.

5. Soyez judicieux dans votre utilisation des badges. Ils sont faciles à
   [abuser](https://github.com/angular/angular). Ils ajoutent du bruit visuel à votre
   README et ne fonctionne généralement que si l'utilisateur lit votre Markdown dans un
   navigateur web, car les images sont souvent hébergées ailleurs sur Internet. 
   Pour chaque badge, considérez: "quelle valeur réelle apporte ce badge
   au lecteur type de ce README?" Avez-vous un badge CI pour afficher la version / le test
   statut? Ce signal permettrait de mieux atteindre les parties importantes en envoyant un email 
   aux mainteneurs ou en créant automatiquement une github issue. Considérez toujours les
   destinataires des données présentes dans votre README et demandez-vous s'il existe un flux dédié 
   pour ces données qui pourrait mieux atteindre le public ciblé.
   
6. Le formatage de l'API est hautement adaptable. Utilisez le format que vous pensez
   le plus clair, mais assurez-vous que votre format exprime des subtilités importantes:

   a. quels paramètres sont facultatifs et leurs valeurs par défaut

   b. informations de typage, là où elles ne ressortent pas de la convention

   c. pour les paramètres d'objet `opts`, toutes les clés et valeurs acceptées

   d. n'hésitez pas à fournir un petit exemple d'utilisation d'une fonction API si
      ce n'est pas évident ou entièrement couvert dans la section **Utilisation**.
      Cependant, cela peut également être un signal fort que la fonction est trop complexe
      et doit être remaniée, divisée en fonctions plus petites ou supprimée
      tout simplement

   e. liez agressivement la terminologie spécialisée! En Markdown, vous pouvez garder des
      [notes de bas de page](https://daringfireball.net/projects/markdown/syntax#link) en
      bas de votre document, donc y mettre les détails des points annexes devient tout simplement
      bon marché. Certaines de mes préférences personnelles sur le formatage de l'API peuvent être
      trouvé [ici](https://github.com/noffle/common-readme/blob/master/api_formatting.md)

7. Si votre module est une petite collection de fonctions sans état, ayant un
   **Section d'utilisation** en tant que [Node REPL
   session](https://github.com/noffle/bisecting-between#example) de la fonction
   les appels et les résultats peuvent communiquer l'utilisation plus clairement qu'un code source
   fichier à exécuter.

8. Si votre module fournit une CLI (interface de ligne de commande) au lieu de (ou
    plus) une API programmatique, afficher des exemples d'utilisation sous forme d'appels de commandes
    et leur sortie. Si vous créez ou modifiez un fichier, «cat» pour le démontrer
    le changement avant et après.

9. N'oubliez pas d'utiliser `package.json`
    [mots-clés](https://docs.npmjs.com/files/package.json#keywords) pour diriger
    les chercheurs de module jusqu'à votre porte.

10. Plus vous modifiez votre API, plus vous devez effectuer de mise à jour
    de la documentation - l'implication ici est que vous devez conserver vos API
    petite et concrètement définie dès le début. Les exigences changent avec le temps, mais
    au lieu d'hypothèses de chargement frontal dans les API de vos modules, chargez
    les remonter d'un niveau d'abstraction: le module s'est posé. Si les exigences
    *faire* changer et 'faire-une-chose-concrète' n'a plus de sens, alors tout simplement
    écrivez un nouveau module qui fait ce dont vous avez besoin. Le 'faire-une-chose-concrète'
    module reste un modèle valide et précieux pour l'écosystème npm, et votre
    la correction de cap ne vous coûte rien d'autre qu'une simple substitution d'un module pour
    un autre.

11. Enfin, n'oubliez pas que votre référentiel de contrôle de version et ses
    Le fichier README intégré survivra à votre [hôte du référentiel](https://github.com) et
    tout élément vers lequel vous créez un lien hypertexte - en particulier les images - donc *en ligne* n'importe quoi
    c'est essentiel pour les futurs utilisateurs qui gambadent votre travail.


## Bonus: *common-readme*

Ce n'est pas par hasard, c'est aussi le format utilisé par
[**common-readme**](https://github.com/noffle/common-readme), un ensemble de README
directives et générateur de ligne de commande pratique. Si vous aimez ce qui est écrit ici,
vous pouvez gagner du temps en écrivant des README avec `common-readme`. Vous trouverez
de vrais exemples de modules avec ce format également.

Vous pouvez également profiter du 
[standard-readme](https://github.com/richardlitt/standard-readme), qui est une
version plus structurée et formatable du format README commun.


## Bonus: exemplaires

La théorie est bonne, mais à quoi ressemblent les excellents README? En voilà quelques-uns 
qui, je pense, incarnent bien les principes de cet article:

- https://github.com/noffle/ice-box
- https://github.com/substack/quote-stream
- https://github.com/feross/bittorrent-dht
- https://github.com/mikolalysenko/box-intersect
- https://github.com/freeman-lab/pixel-grid
- https://github.com/mafintosh/torrent-stream
- https://github.com/pull-stream/pull-stream
- https://github.com/substack/tape
- https://github.com/yoshuawuyts/vmd


## Bonus: la liste de validation d'un README

Une liste de contrôle utile pour évaluer la progression de votre README:

- [ ] Une seule ligne expliquant le but du module
- [ ] Contexte et liens nécessaires
- [ ] Des termes potentiellement inconnus renvoient à des sources d'information
- [ ] Exemple d'utilisation clair, *exécutable*
- [ ] Instructions d'installation
- [ ] Documentation complète de l'API
- [ ] Applique la [progressivité cognitive](https://github.com/noffle/art-of-readme#cognitive-funneling)
- [ ] Mises en garde et limitations mentionnées à l'avance
- [ ] Ne se fie pas aux images pour fournir des informations capitales
- [ ] Licence


## L'auteur

Je suis [noffle](http://blog.eight45.net/about/). Je suis connu pour mes divers
[blogs](http://blog.eight45.net), [tweets](https://twitter.com/noffle) et
[hacks](https://github.com/noffle).

Ce petit projet a commencé en mai à Berlin chez squatconf, où je creusais
la façon dont les moines Perl écrivaient leur documentation, tout en déplorant
l'état des READMEs dans l'écosystème Node.js. Cela m'a alorsincité à créer
[common-readme](https://github.com/noffle/common-readme). Cependant, la section 
pour les "Conseils README" débordant de conseils, je me suis alors dit que
cela pourrait être utilement de les collecter dans un article dédié à la rédaction de README.
Ainsi, n'aissait l'Art of README!

Vous pouvez me joindre à `noffle@eight45.net` ou sur Freenode IRC dans `#eight45`.


## Lectures complémentaires

- [README-Driven Development](http://tom.preston-werner.com/2010/08/23/readme-driven-development.html)
- [Documentation First](http://joeyh.name/blog/entry/documentation_first/)


## Notes de bas de page

1. <a name="footnote-1"> </a> Merci,
    [Sixes666](https://www.reddit.com/r/node/comments/55eto9/nodejs_the_art_of_readme/d8akpz6)!

1. <a name="footnote-2"> </a> Voir [The Jargon File](http://catb.org/~esr/jargon/html/R/README-file.html).
    Cependant, la plupart des systèmes actuels ne trieront pas les majuscules avant toutes les minuscules, 
    réduisant ainsi l'utilité de cette convention à son seul visuel frappant.


## Crédits

Un grand merci à [@mafintosh](https://github.com/mafintosh) et
[@feross](https://github.com/feross) pour les encouragements dont j'avais bien besoin afin 
de faire décoller cette idée et commencer à écrire!

Merci aux super lecteurs suivants d'avoir remarqué des erreurs et de m'avoir envoyé
des PRs :coeur: :

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

Merci à [@qihaiyan](https://github.com/qihaiyan) d'avoir traduit l'Art of
README en chinois! Les utilisateurs suivants ont également fait des contributions:

- [@BrettDong](https://github.com/brettdong) pour la révision de la ponctuation en version chinoise.
- [@Alex-fun](https://github.com/Alex-fun)
- [@HmyBmny](https://github.com/HmyBmny)
- [@vra](https://github.com/vra)

Merci à [@lennonjesus](https://github.com/lennonjesus) d'avoir traduit l'Art
of README en portugais brésilien! Les utilisateurs suivants ont également fait des contributions:

- [@rectius](https://github.com/rectius)

Merci à [@jabiinfante](https://github.com/jabiinfante) pour la traduction de l'Art
of README en espagnol!

Merci à [@Ryuno-Ki](https://github.com/Ryuno-Ki) pour avoir traduit l'Art of
README en allemand! Les utilisateurs suivants ont également fait des contributions:

- [@randomC0der](https://github.com/randomC0der)

Merci à [@Manfred Madelaine](https://github.com/Manfred-Madelaine-pro) et
[@Ruben Madelaine](https://github.com/Ruben-Madelaine)
pour la traduction de l'Art of README en français!

Enfin, merci pour tous les commentaires! Veuillez partager vos commentaires [en tant qu'issue](https://github.com/noffle/art-of-readme/issues)!

## Les contributions sont les bienvenues!

Vous avez repéré une erreur? Quelque chose n'a pas de sens? Envoyez-moi une [pull
request](https://github.com/noffle/art-of-readme/pulls)!
Veuillez cependant éviter de faire des changements stylistiques s'il-vous-plait,
il est peu probable qu'ils soient acceptés. Merci!

## Licence

[Creative Commons Attribution License](http://creativecommons.org/licenses/by/2.0/)
