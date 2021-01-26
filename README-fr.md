# L'art du README

*Cet article peut également être lu en [Chinois](README-zh.md), 
[Portugais brésilien](README-pt-BR.md), [espagnol](README-es-ES.md) et
[Allemand](README-de-DE.md).*

## Etymologie

D'où vient le terme «README»?

La nomenclature remonte au moins aux années 1970 [et le
PDP-10] (http://pdp-10.trailing-edge.com/decuslib10-04/01/43,50322/read.me.html),
bien que cela puisse même remonter à l'époque des notes papier informatives placées au sommet
de piles de cartes perforées, avec "READ ME!" ("LISEZ-MOI!") griffonné sur eux, décrivant leur utilisation.

Un lecteur <sup>[1](#footnote-1)</sup> suggéra que le titre README puisse être un petit coup de pouce ludique 
en hommage au très fameux roman, de Lewis Carroll, intitulé Les Aventures d'Alice au pays des merveilles, 
comprennant une potion et un gâteau étiquetés "DRINK ME" (BUVEZ-MOI) et "EAT ME" (BUVEZ-MOI), respectivement.

Le modèle de README apparaissant en majuscules est un point récurrent tout au long de l'histoire. 
En plus du carractère visuellement frappant de l'utilisation des majuscules, les systèmes UNIX
trient les majuscules avant les minuscules, mettant commodément le README
avant le reste du contenu du répertoire <sup> [2](#footnote-2) </sup>.

L'intention est claire: *"Il s'agit d'informations importantes que l'utilisateur doit lire avant
de poursuivre."* Explorons ensemble ce qui constitue une "information importante" dans
ces temps modernes.

## Pour les créateurs, pour les consommateurs

Cet article traite des READMEs. Il présente ce qu'ils font, pourquoi ils sont
absolument nécessaires, et comment bien les construire.

Cet article concerne les créateurs de modules car en tant que constructeurs
de modules, leur travail consiste à créer des éléments durables.
C'est une motivation inhérente, même si le l'auteur n'a pas l'intention
de partager son travail. Une fois six mois passés, un module sans documentation
commence à paraître nouveau et peu familier.

Cet article est également pour les consommateurs de modules, puisque chaque
auteur de module en consomme également. Node.js a un degré d'interdépendance
très sain : personne n'est au bas de l'arborescence des dépendances.

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
intégrée de npm: une valeur par défaut sûre et le port d'entrée habituel pour 
les nouveaux développeurs.

Quelle que soit votre approche, peu importe si un spéléologue de module entre
dans le module souterrain sur [npmjs.org](https://npmjs.org),
[github.com](https://github.com) ou ailleurs, cet utilisateur
potentiel finira par regarder votre carré README en face. Étant donné que vos
utilisateurs se retrouveront inévitablement ici, que peut-on faire pour rendre
leurs premières impressions efficaces au maximum ?


## Spéléologues de module professionnel

### Le README: votre point d'entrée

Le README est le premier - et peut-être le seul - document qu'un consommateur de module examinera 
lors de la découverte de votre création. Le consommateur souhaite qu'un module réponde à son besoin, 
vous devez donc expliquer exactement ce que votre module permet et avec quelle efficacité il le fait.

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
- [Ken Williams](http://mathforum.org/ken/perl_modules.html#document)


### Key elements

Once a README is located, the brave module spelunker must scan it to discern if
it matches the developer's needs. This becomes essentially a series of pattern
matching problems for their brain to solve, where each step takes them deeper
into the module and its details.

Let's say, for example, my search for a 2D collision detection module leads me
to [`collide-2d-aabb-aabb`](https://github.com/noffle/collide-2d-aabb-aabb). I
begin to examine it from top to bottom:

1. *Name* -- self-explanatory names are best. `collide-2d-aabb-aabb` sounds
   promising, though it assumes I know what an "aabb" is. If the name sounds too
   vague or unrelated, it may be a signal to move on.

2. *One-liner* -- having a one-liner that describes the module is useful for
   getting an idea of what the module does in slightly greater detail.
   `collide-2d-aabb-aabb` says it

   > Determines whether a moving axis-aligned bounding box (AABB) collides with
   > other AABBs.

   Awesome: it defines what an AABB is, and what the module does. Now to gauge how
   well it'd fit into my code:

3. *Usage* -- rather than starting to delve into the API docs, it'd be great to
   see what the module looks like in action. I can quickly determine whether the
   example JS fits the desired style and problem. People have lots of opinions
   on things like promises/callbacks and ES6. If it does fit the bill, then I
   can proceed to greater detail.

4. *API* -- the name, description, and usage of this module all sound appealing
   to me. I'm very likely to use this module at this point. I just need to scan
   the API to make sure it does exactly what I need and that it will integrate
   easily into my codebase. The API section ought to detail the module's objects
   and functions, their signatures, return types, callbacks, and events in
   detail. Types should be included where they aren't obvious. Caveats should be
   made clear.

5. *Installation* -- if I've read this far down, then I'm sold on trying out the
   module. If there are nonstandard installation notes, here's where they'd go,
   but even if it's just a regular `npm install`, I'd like to see that mentioned,
   too. New users start using Node.js all the time, so having a link to npmjs.org
   and an install command provides them the resources to figure out how Node.js
   modules work.

6. *License* -- most modules put this at the very bottom, but this might
   actually be better to have higher up; you're likely to exclude a module VERY
   quickly if it has a license incompatible with your work. I generally stick to
   the MIT/BSD/X11/ISC flavours. If you have a non-permissive license, stick it
   at the very top of the module to prevent any confusion.


## Cognitive funneling

The ordering of the above was not chosen at random.

Module consumers use many modules, and need to look at many modules.

Once you've looked at hundreds of modules, you begin to notice that the mind
benefits from predictable patterns.

You also start to build out your own personal heuristic for what information you
want, and what red flags disqualify modules quickly.

Thus, it follows that in a README it is desirable to have:

1. a predictable format
2. certain key elements present

You don't need to use *this* format, but try to be consistent to save your users
precious cognitive cycles.

The ordering presented here is lovingly referred to as "cognitive funneling,"
and can be imagined as a funnel held upright, where the widest end contains the
broadest more pertinent details, and moving deeper down into the funnel presents
more specific details that are pertinent for only a reader who is interested
enough in your work to have reached that deeply in the document. Finally, the
bottom can be reserved for details only for those intrigued by the deeper
context of the work (background, credits, biblio, etc.).

Once again, the Perl monks have wisdom to share on the subject:

> The level of detail in Perl module documentation generally goes from
> less detailed to more detailed.  Your SYNOPSIS section should
> contain a minimal example of use (perhaps as little as one line of
> code; skip the unusual use cases or anything not needed by most
> users); the DESCRIPTION should describe your module in broad terms,
> generally in just a few paragraphs; more detail of the module's
> routines or methods, lengthy code examples, or other in-depth
> material should be given in subsequent sections.
>
> Ideally, someone who's slightly familiar with your module should be
> able to refresh their memory without hitting "page down".  As your
> reader continues through the document, they should receive a
> progressively greater amount of knowledge.
> -- from `perlmodstyle`


## Care about people's time

Awesome; the ordering of these key elements should be decided by how quickly
they let someone 'short circuit' and bail on your module.

This sounds bleak, doesn't it? But think about it: your job, when you're doing
it with optimal altruism in mind, isn't to "sell" people on your work. It's to
let them evaluate what your creation does as objectively as possible, and decide
whether it meets their needs or not -- not to, say, maximize your downloads or
userbase.

This mindset doesn't appeal to everyone; it requires checking your ego at the
door and letting the work speak for itself as much as possible. Your only job is
to describe its promise as succinctly as you can, so module spelunkers can
either use your work when it's a fit, or move on to something else that does.


## Appel aux armes!

Allez de l'avant, courageux spéléologue de module, et rendez votre travail découvrable et utilisable
grâce à une excellente documentation!


## Bonus: other good practices

Outside of the key points of the article, there are other practices you can
follow (or not follow) to raise your README's quality bar even further and
maximize its usefulness to others:

1. Consider including a **Background** section if your module depends on
   important but not widely known abstractions or other ecosystems. The function
   of [`bisecting-between`](https://github.com/noffle/bisecting-between) is not
   immediately obvious from its name, so it has a detailed *Background* section
   to define and link to the big concepts and abstractions one needs to
   understand to use and grok it. This is also a great place to explain the
   module's motivation if similar modules already exist on npm.

2. Aggressively linkify! If you talk about other modules, ideas, or people, make
   that reference text a link so that visitors can more easily grok your module
   and the ideas it builds on. Few modules exist in a vacuum: all work comes
   from other work, so it pays to help users follow your module's history and
   inspiration.

3. Include information on types of arguments and return parameters if it's not
   obvious. Prefer convention wherever possible (`cb` probably means callback
   function, `num` probably means a `Number`, etc.).

4. Include the example code in **Usage** as a file in your repo -- maybe as
   `example.js`. It's great to have README code that users can actually run if
   they clone the repository.

5. Be judicious in your use of badges. They're easy to
   [abuse](https://github.com/angular/angular). They can also be a breeding
   ground for bikeshedding and endless debate. They add visual noise to your
   README and generally only function if the user is reading your Markdown in a
   browser online, since the images are often hosted elsewhere on the
   internet. For each badge, consider: "what real value is this badge providing
   to the typical viewer of this README?" Do you have a CI badge to show build/test
   status? This signal would better reach important parties by emailing
   maintainers or automatically creating an issue. Always consider the
   audience of the data in your README and ask yourself if there's a flow for
   that data that can better reach its intended audience.

6. API formatting is highly bikesheddable. Use whatever format you think is
   clearest, but make sure your format expresses important subtleties:

   a. which parameters are optional, and their defaults

   b. type information, where it is not obvious from convention

   c. for `opts` object parameters, all keys and values that are accepted

   d. don't shy away from providing a tiny example of an API function's use if
      it is not obvious or fully covered in the **Usage** section.
      However, this can also be a strong signal that the function is too complex
      and needs to be refactored, broken into smaller functions, or removed
      altogether

   e. aggressively linkify specialized terminology! In markdown you can keep
      [footnotes](https://daringfireball.net/projects/markdown/syntax#link) at
      the bottom of your document, so referring to them several times throughout
      becomes cheap. Some of my personal preferences on API formatting can be
      found
      [here](https://github.com/noffle/common-readme/blob/master/api_formatting.md)

7. If your module is a small collection of stateless functions, having a
   **Usage** section as a [Node REPL
   session](https://github.com/noffle/bisecting-between#example) of function
   calls and results might communicate usage more clearly than a source code
   file to run.

8. If your module provides a CLI (command line interface) instead of (or in
    addition to) a programmatic API, show usage examples as command invocations
    and their output. If you create or modify a file, `cat` it to demonstrate
    the change before and after.

9. Don't forget to use `package.json`
    [keywords](https://docs.npmjs.com/files/package.json#keywords) to direct
    module spelunkers to your doorstep.

10. The more you change your API, the more work you need to exert updating
    documentation -- the implication here is that you should keep your APIs
    small and concretely defined early on. Requirements change over time, but
    instead of front-loading assumptions into the APIs of your modules, load
    them up one level of abstraction: the module set itself. If the requirements
    *do* change and 'do-one-concrete-thing' no longer makes sense, then simply
    write a new module that does the thing you need. The 'do-one-concrete-thing'
    module remains a valid and valuable model for the npm ecosystem, and your
    course correction cost you nothing but a simple substitution of one module for
    another.

11. Finally, please remember that your version control repository and its
    embedded README will outlive your [repository host](https://github.com) and
    any of the things you hyperlink to -- especially images -- so *inline* anything
    that is essential to future users grokking your work.


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


## Bonus: la liste de contrôle README

Une liste de contrôle utile pour évaluer la progression de votre README:

- [ ] Une seule ligne expliquant le but du module
- [ ] Contexte et liens nécessaires
- [ ] Des termes potentiellement inconnus renvoient à des sources d'information
- [ ] Exemple d'utilisation clair, *exécutable*
- [ ] Instructions d'installation
- [ ] Documentation complète de l'API
- [ ] Effectue [l'entonnoir cognitif](https://github.com/noffle/art-of-readme#cognitive-funneling)
- [ ] Mises en garde et limitations mentionnées à l'avance
- [ ] Ne se fie pas aux images pour fournir des informations capitales
- [ ] Licence


## The author

I'm [noffle](http://blog.eight45.net/about/). I'm known to
[blog](http://blog.eight45.net), [tweet](https://twitter.com/noffle), and
[hack](https://github.com/noffle).

This little project began back in May in Berlin at squatconf, where I was
digging into how Perl monks write their documentation and also lamenting the
state of READMEs in the Node.js ecosystem. It spurred me to create
[common-readme](https://github.com/noffle/common-readme). The "README Tips"
section overflowed with tips though, which I decided could be usefully collected
into an article about writing READMEs. Thus, Art of README was born!

You can reach me at `noffle@eight45.net` or on Freenode IRC in `#eight45`.


## Lectures complémentaires

- [README-Driven Development](http://tom.preston-werner.com/2010/08/23/readme-driven-development.html)
- [Documentation First](http://joeyh.name/blog/entry/documentation_first/)


## Notes de bas de page

1. <a name="footnote-1"> </a> Merci,
    [Sixes666](https://www.reddit.com/r/node/comments/55eto9/nodejs_the_art_of_readme/d8akpz6)!

1. <a name="footnote-2"> </a> Voir [The Jargon File](http://catb.org/~esr/jargon/html/R/README-file.html).
    Cependant, la plupart des systèmes actuels ne trieront pas les majuscules avant toutes les minuscules, 
    réduisant ainsi l'utilité de cette convention à son seul visuel frappant.


## Credits

A heartfelt thank you to [@mafintosh](https://github.com/mafintosh) and
[@feross](https://github.com/feross) for the encouragement I needed to get this
idea off the ground and start writing!

Thank you to the following awesome readers for noticing errors and sending me
PRs :heart: :

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

Thank you to [@qihaiyan](https://github.com/qihaiyan) for translating Art of
README to Chinese! The following users also made contributions:

- [@BrettDong](https://github.com/brettdong) for revising punctuation in Chinese version.
- [@Alex-fun](https://github.com/Alex-fun)
- [@HmyBmny](https://github.com/HmyBmny)
- [@vra](https://github.com/vra)

Thank you to [@lennonjesus](https://github.com/lennonjesus) for translating Art
of README to Brazilian Portuguese! The following users also made contributions:

- [@rectius](https://github.com/rectius)

Thank you to [@jabiinfante](https://github.com/jabiinfante) for translating Art
of README to Spanish!

Thank you to [@Ryuno-Ki](https://github.com/Ryuno-Ki) for translating Art of
README to German! The following users also made contributions:

- [@randomC0der](https://github.com/randomC0der)

Finally, thanks for all of the feedback! Please share your comments [as an
issue](https://github.com/noffle/art-of-readme/issues)!

## Les contributions sont bienvenues!

Vous avez repéré une erreur? Quelque chose n'a pas de sens? Envoyez-moi une [pull
request] (https://github.com/noffle/art-of-readme/pulls)!
Veuillez cependant éviter de faire des changements stylistiques s'il-vous-plait,
il est peu probable qu'ils soient acceptés. Merci!

## Licence

[Creative Commons Attribution License](http://creativecommons.org/licenses/by/2.0/)
