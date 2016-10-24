# El arte del LÉEME

*Este artículo ha sido traducido desde el [inglés](README.md) y puede encontrarse en [chino](README-zh.md), en 
[brasileño portugués](README-pt-BR.md) y en [español](README-es-ES.md).*

## Etimología

¿De dónde viene el término "LÉEME"?

La nomenclatura está fechada desde *por lo menos* el artículo de los 70 [and the
PDP-10](http://pdp-10.trailing-edge.com/decuslib10-04/01/43,50322/read.me.html),
aunque puede ser más remontarse a los días de notas de papel informativas situadas sobre
pilas de tarjetas perforadas, con un "LÉEME!" garabateado encima, describiendo su uso.

Un lector<sup>[1](#footnote-1)</sup> ha sugerido que el título LÉEME puede ser un guiño a 
*Las aventuras de Alicia en el país de las maravillas* de Lewis Carroll, donde una poción y un pastel
están etiquetados con *"BÉBEME"* y *"CÓMEME"*, respectivamente.

El patrón de README escrito entero en mayúsculas es algo que ha sido constante a lo largo
de la historia. Además de la sorpresa visual de usar mayúsculas, los sistemas UNIX ordenan
los caracteres en mayúsculas antes que en minúsculas, poniendo convenientemente el fichero
README antes que el resto del contenido del directorio<sup>[2](#footnote-2)</sup>.

La intención es clara: *"ésta es información importante que el usuario debe leer antes de continuar"*.
Vamos a explorar juntos que constituye "información importante" en estos tiempos modernos.


## Para creadores, para consumidores

Este es un artículo acerca de los ficheros README. Sobre que es lo que hacen, por qué son absolutamente
necesarios, y cómo confeccionarlos correctamente.

Esto está escrito para creadores de módulos, como constructores de módulos, vuestro trabajo es
crear algo que dure en el tiempo. Esto dese ser una motivación inherente, incluso aunque el autor no tenga
intención de compartir su trabajo. Trasncurridos 6 meses, un módulo sin documentación comienza a
parecer nuevo y desconocido.

Esto también se ha escrito para consumidores de módulos, ya que todo autor de módulos es también
un consumidor de módulos. Node tiene un grado muy sano de interdependencias: nadie está en lo más
bajo del árbol de dependencias.

A pesar de estar centrado en Node, el autor sostiene que la lección puede ser aplicada igual de bien
a otros ecosistemas de programación


## Muchos módulos: unos buenos, unos malos

El ecosistema de Node está sostenido en sus módulos. [npm](https://npmjs.org) es la magia
que hace que todo *funcione*. Durante una semana cualquiera, un desarrollador de Node evalúa docenas
de módulos para ser incluidos en su proyecto. Eso es utilizar muchísimo poder a diario, utilizando
simplemente un `npm install`.

Como cualquier ecosistemas extremadamente accesible, la barra de calidad puede variar. npm
funciona empaquetando y distribuyendo estos módulos ampliamente. Sin embargo, las herramientas que
nos encontramos son muy variadas: algunas eston nuevas y relucientes, otras están viejas y oxidadas,
mientras otras están el medio. Incluso hay algunas de las que ¡no sabemos ni qué es lo que hacen!

En lo relativo a módulos, esto puede llevarse a una forma de nombres inexactos o inútiles (¿alguien
adivina qué hace el módulo `fudge`?), sin documentación o pruebas, sin código fuente comentado, o
con nombres de función incomprensibles.

Muchos ni tiene un mantenedor activo. Si un módulo no tiene ni una persona disponible respondiendo a
preguntas y explicando qué hace el módulo, ni rastro de documentación, éste se vuelve un artefacto
alienígena bizarro, inusable e incomprensible para los *arqueolo-hackers* del mañana.

Para aquellos módulos que si tienen documentación, ¿a qué nivel de calidad podremos encontrarlos?
Puede que sea una simple explicación de una línea: `"ordena números por
su valor en hexadecimal"`. Puede que se un pedazo de código fuente. Ambos casos son
mejor que nada, pero suelen terminar en el peor de los casos para un
espeleólogo de módulos moderno: excavando en un código fuente para intentar entender
cómo funciona realmente. Escribir documentación excelente sirve para mantener a los
usuarios *fuera* del código fuente proporcionando suficientes intrucciones para 
disfrutar de la maravillosa abstracción que nos brinda el módulo.

Node tiene un "amplio" ecosistema: está ampliamente compuesto por una larga lista de
módulos independientes que hacen una-cosa-bien y únicamente eso. Existen 
[excepciones](https://github.com/lodash/lodash), pero a pesar de estos feudos menores,
es la gente de un único propósito la que, dada us superioridad numérica, verdaderamente mandan
en el reino de Node.

Esta situación tiene un consecuencia natural: puede ser complicado encontrar módulos de *calidad*
que hagan exactamente lo que tu quieres que hagan.

**Esto está bien**. De verdad. Una exigencia de entrada menor y un problema de detectabilidad, es
infinitamente mejor que un problema de cultura, donde sólo unos pocos privilegiados puedan participar.

Además, la detectabilidad --como finalmente resulta-- va a ser más fácil de solucionar.


## Todos los caminos llevan a README.md

La comunidad de Node ha respondido al reto de la detectabilidad de muchas maneras diferentes.

Algunos desarrolladores con experiencia de Node se han asociado para crear [listas
curadas](https://github.com/sindresorhus/awesome-nodejs) de módulos de calidad.
Los desarrolladores aprovechan sus muchos años examinando cientos de módulos para
compartir con los recién llegados la *crème de la crème*: los mejores módulos de cada
categoría. Esto podrá tomar forma de feeds RSS o listas de correo de nuevos módulos que
sean considerados útiles por miembros confiables de la comunidad.

¿Qué hay de la redes sociales? Esta idea estimuló la creación de 
[node-modules.com](http://node-modules.com/), un reemplazo de búsqueda para npm que aprovecha
tus conexiones sociales en GitHub para encontrar módulos que gusten o hayan sido hechos por
tus amigos.

Por supuesto también está la funcionalidad nativa de [búsqueda](https://npmjs.org) de
npm: una opción segura, y habitual punto de entrada para nuevos desarrolladores.

No importa cuál sea tu opción, no importa si el espeleológo de módulos entra al
subsuelo del módulo por [npmjs.org](https://npmjs.org),
[github.com](https://github.com), o por cualquier otro sitio, este usuario potencial se 
encontrará mirando fijamente a tu fichero README. Ya que tus usuario terminarán 
inevitablemente aquí, ¿qué podemos hacer para potenciar al máximo su primera impresión?


## Espeleología de módulos profesional

### README: Tu ventanilla única

Un README es la primera -- y puede que única -- mirada que dedica un consumidor de módulos 
a tu creación. El consumidor quiere que el módulo satisfaga su necesidad, así que debes
explicar exactamente que necesidad satisface tu módulo y cómo de efectivo es.

Tu trabajo consiste en

1. decirles qué es (con contexto)
2. mostrarles cómo funciona
3. mostrarles como usarlo
4. decirles cualquier otro detalle relevante

Este es *tu* trabajo. Depende del creador del módulo probar que su trabajo es una
joya brillante en un mundo de módulos chapuceros. Ya que tu README será lo primero que
vean los ojos de muchos desarrolladores, la calidad de éste, será como se mida 
públicamente la calidad de tu trabajo.


### Brevedad

La falta de un README supone una bandera roja, aunque un README muy largo no es
indicativo de mucha calidad. El README ideal es tan corto como sea posible. La documentación
detallada es buena -- ¡haz páginas separadas para esto! -- pero mantén tu README sucinto.


### Aprender del pasado

Suele decirse que quién no aprende historia, está condenado a comenter los mismos
errores otra vez. Los desarrolladores han estado escribiendo documentación desde hace
bastantes años. Sería un desperdicio no mirar atrás y fijarnos en lo que la gente
ha estado haciendo bien antes de Node.

Perl, por todo el fuego antiaéreo que recibe, es en muchas maneras el abuelo 
espiritual de Node. Ambos son lenguajes de alto nivel, que adoptan muchas expresiones
de UNIX, son el combustible de gran parte de Internet, y ambos poseen un amplio ecosistema de 
módulos.

Al parecer los denominados [monjes](http://perlmonks.org) de la comunidad Perl tienen
muchísima experiencia escribiendo
[REAME de calidad](http://search.cpan.org/~kane/Archive-Tar/lib/Archive/Tar.pm). CPAN es un
recurso excelente al que merece la pena echar un ojo para aprender más de una comunidad
que escribe de manera consistente documentación de gran calibre.


### ¿No hay README? No hay abstracción

No tener README implica que desarrolladores tengan que ahondar en tu código
para poder llegar a entenderlo.

Los Perl monks comparten cierta sabiduría acerca de este tema:

> Tu documentación estará completa cuando alguien sea capaz de usar tu módulo
> sin tener que mirar el código fuente. Esto es muy importante. Esto hace posible que
> puedas separar la interfaz documentada de tu módulo de su implementación
> interna (tripas). Esto es bueno, ya que significa que eres libre de cambiar el
> código de tu módulo mientras mantengas intacta la interfaz.
>
> Recuerda: la documentación, y no el ćodigo, define lo que hace un módulo.
-- [Ken Williams](http://mathforum.org/ken/perl_modules.html#document)


### Elementos clave

Una vez localizado el README, el valiente espeleólogo de módulos debe escanearlo
para discernir si se ajusta a las necesidades del desarrollo. Esencialmente, 
esto se convierte en una serie de coincidencia de patrones que sus cerebros deben
resolver, donde cada paso les mete más dentro del módulo y sus detalles.

Digamos ,por ejemplo, que mi búsquesa de un módulo de detección de colisiones 2D
me lleva hasta `collide-2d-aabb-aabb`](https://github.com/noffle/collide-2d-aabb-aabb). I
Comienzo a examinarlo de arriba hacia abajo:

1. *Nombre* -- los nombres auto-explicativos son los mejores. `collide-2d-aabb-aabb` suena
   prometedor, aunque asume que sé que significa "aabb". Si el nombre suena demasiado
   vago o sin relevancia, podría ser una señal para evitar el módulo.

2. *Línea-única* -- tener una única línea que describa el módulo, resulta muy útil
   para ofrecer una idea de lo que hace el módulo en algo más de detalle.
   `collide-2d-aabb-aabb` dice esto

   > Determina si el movimiento de una caja delimitada alienada en un eje (CDAE) colisiona
   > con otras CDAE. (CDAE = AABB = axis-aligned bounding box)

   Increible: define lo qué significa AABB, y lo que hace el módulo. Ahora queda calibrar cómo
   de bien encajaría en mi código. 

3. *Uso* -- En lugar de empezar a ahondar en la documentación de la API, estaría genial
   poder ver el módulo en acción. Así puedo rápidamente determinar si el JS de ejemplo
   encaja en el estilo buscado y soluciona el problema. La gente tiene muy diversas 
   opiniones en cosas como promesas/callbacks y ES6. Si encaja a primera vista, entonces
   se puede proceder más en profundidad.

4. *API* -- el nombre, la descripción y el uso de este módulo son cosas muy atractivas
   para mi. Muy probablemente estoy en un punto en el que voy a usar este módulo. Sólo
   necesito revisar la API para asegurarme de que hace exactamente lo que necesito y
   de que tendrá una muy fácil integración con mi código fuente. La sección API, deberá
   detallar los objetos y funciones del módulo, sus firmas, tipados de vuelta, callbacks, y
   eventos. Se deberá incluir el tipado allá donde no sea obvio. Cualquier advertencia deberá
   ser expuestsa claramente.

5. *Instalación* -- si he leído hasta aquí abajo, entonces estoy condenado a instalar el
   módulo. Si existen notas no estándar de instalación, deberían ir aquí, al igual que si es 
   un simple `npm install`, también me gustaría verlo mencionado aquí. Existen nuevos usuarios
   comenzando a usar Node todo el tiempo, así que enlazar a npmjs.org y el comando de instalación
   les facilita los recursos para descubrir como funciona el sistema de módulos de Node.

6. *Licencia* -- la mayoría de los módulos ponen esto muy abajo, pero podría ser mejor ponerlo
   más arriba; Es posible que excluyas rápidamente un módulo si tiene una licencia incompatible
   con tu trabajo. Yo generalemente me mantengo en licencias tipo MIT/BSD/X11/ISC. Si tienes
   una licencia no permisiva, colócala muy arriba del módulo para prevenir cualquier tipo
   de confusión.


## Canalización cognitiva

El orden de lo expusto anteriormente no ha sido escogido al azar.

Los consumidores de módulos usan muchos módulos, y necesitan ver muchos módulos.

Cuando has visto cientos de módulo, comienzas a descubrir que la mente de 
beneficia de patrones predecibles.

También comienzas a construir tu propio sistema heurístico para aquella información
que quieres, y para esas banderas rojas que descalifican rápidamente algunos modulos.

Así, se deduce que un README deseable debe tener:

1. un formato predecible
2. ciertos elementos clave presentes

No necesitas usar *este* formato, pero intenta ser consistente para ahorrar a tus usuarios
valiosos ciclos cognitivos.

El orden presentado aquí, se denomina cariñosamente "canalización cognitiva"
y puede imaginarse como un embudo en posición vertical, donde la zona más ancha
contiene los detalles pertinentes más generales, y al movernos hacía abajo en el embudo
se presentan detalles más específicos, pertinentes únicamente para un lectos lo suficientemente
interesado en tu trabajo como para para haber llegado hasta las profundidades del documento. 
Finalmente, el fondo podrá reservarse para detalles que incluyan un contexto más
profundo del trabajo (antecedentes, creditos, bibliografía, etc.).

De nuevo, los monjes de Perl tiene sabiduría que comparten sobre esta materia:

> El nivel de detalle en la documentación de un módulo Perl generalmente va
> de menos a más detalle. Tu sección de SIPNOSIS deberá contener un 
> ejemplo de uso mínimo (quizás algo tan simple como una única línea de 
> codigo; evitar los casos de uso poco comunes o cualquier cosa innecesaria para
> la mayoría de usuarios); la DESCRIPCIÓN deberá describir tu módulo en terminos más
> amplios, generalmente con unos pocos párrafos; Se podrá dar más detalle de
> rutinas o métodos, ejemplos de código más largos y otro material más en
> profundidad en secciones posteriores.
>
> Idealmente, alguien ligeramente familiar con tu módulo, debería ser capaz
> de refrescar su memoria sin pulsar "avance página". A medida que el lector
> avance por el documento, irán recibiendo progresivamente más cantidad de información.
> -- de `perlmodstyle`


## Preocupación por el tiempo de la gente

Increible; el orden de estos puntos clave, debería decidirse por la rapidez con la que 
alquien 'corto circuite' y apueste por tu módulo.

Suena poco prometedor, ¿verdad? Pero pensar en ello: tu trabajo, cuando estás en ello con
un alto nivel de altruismo en mente, no se trata de "vender" a la gente tu trabajo.
Se trata de dejar que evaluen qué hace tu creación lo más objetivamente posible,
y que decidan si satisface sus necesidades o no -- además de maximizar tu número de
descargas Y tu base de usuarios.

Este modo de pensar no se ajusta a todo el mundo; requiere dejar tu ego en la puerta
y dejar que el trabajo hable por si solo tanto como sea posible. Tu único trabajo
es describir lo que promete tan sucitamente como te sea posible, de manera que los
espeleólogos de módulos puedan usar tu trabajo cuando les encaje, o bien encontrar
otra opción que les encaje mejor.


## ¡Llamada a las armas!

¡Sal ahí fuera, valiente construtor de módulos, y haz que tu trabajo sea visible y
utilizable gracias a una documentación excelente!

## Bonus: otras buenas prácticas

Más allá de las claves de este artículo, existen otras técnicas qe puedes seguir
(o evitar) para subir aún más la barra de calidad de tus README y maximizar su
usabilidad para el resto:

1. Considera incluir un sección **Antecedentes** si tu módulo depende de una
   importante pero no muy conocida abstracción o de otros ecosistemas. La función 
   de [`bisecting-between`](https://github.com/noffle/bisecting-between) no es 
   demasiado obvia si partimos de su nombre, así que tiene una sección muy detallada 
   de *Antecedentes* para definir y enlazar hacia grandes conceptos y abstracciones
   que nadie tiene porqué entender para pilotar el módulo. Este suele ser un buen
   lugar en el que explicar la motivación del módulo si ya existen módulos similares
   en npm.

2. ¡Linka agresivamente! Si hablas de otros módulos, ideas o gente, haz que ese texto
   que referencia se convierta en un enlace, de manera que los visitante puedan 
   comprender fácilmente tu módulo y las ideas en las que se basa. Pocos módulos existen
   desde el vacío: todo el trabajo proviene de otro trabajo, así que esto ayuda a 
   tus usuarios a conocer la historia e inspiración de tu módulo.

3. Incluye información acerca del tipado de los argumentos y de los parámetros
   de salida si éstos no son obvios. Priorizar las convenciones cuando sea posible
   (`cb` probablemente se refiere a una función de callback, `num` probablemente
   representa un `Number`, etc.).

4. Incluye el código de ejemplo de la sección **Uso** como un fichero más del
   repositorio -- quizás como `example.js`. Está bastante bien tener código
   en el README que los usuarios pueden ejecutar tras clonar el repositorio.

5. Utiliza los badges con cabeza. Es fácil [abusar](https://github.com/angular/angular)
   de ellos. Pueden ser grande fuentes de polémicas y debates interminables. 
   Añaden ruido visual a tu README, y únicamente funcionan si el usuario está leyendo 
   el README en un navegador conectado, ya que la mayoría de las imágenes están 
   albergadas en un servidor de internet. Para cada badget, es importante preguntarse:
   "¿Qué valor real aporta al típico lector de este README?" ¿Tienes un
   badge de CI que muestre el estado del build/test? Esta señal debería llegar a
   las partes interesadas bien mediante un email a los mantenedores, o bien creando
   automáticamente una incidencia -- siempre hay que considerar que audiencia quiere 
   la información en el README y habría que preguntarse si existe algún flujo para esa
   información que pueda llegar mejor hasta la audiencia deseada.

6. Formatear una API es altamente opinable. Utiliza el formato que tu consideres
   más claro, pero asegurate de que este formato contempla algunas sutilezas:

   a. qué parámetros son opcionales, y su valor por defecto

   b. información del tipado, allí donde no exista un convención obvia

   c. para los parámetros `opts` de un objeto, todas las claves y valores aceptados

   d. no rehuyas de proporcionar un pequeño ejemplo de uso de alguna función de la API
      cuyo funcionamiento no sea obvio o no esté completamente cuvierto en la sección 
      *Uso*. Sin embargo, esto puede considerarse como una señal de complejidad de la 
      función, que pudiera necesitar ser refactorizada, dividida en funciones más 
      pequeñas o elimiada en s conjunto.

   e. ¡linka agresivamente terminología especializada! En markdown se puede escribir
      [notas al pie](https://daringfireball.net/projects/markdown/syntax#link) en la 
      parte de abajo del documento, así que hacer varias referencias a pie de página 
      resulta barato. Algunas de mis preferencias personales al formatear una API pueden
      encontrarse [aquí](https://github.com/noffle/common-readme/blob/master/api_formatting.md)

7. Si tu módulo está compuesto por una pequeña colección de funciones sin estado,
   tener una sección **Uso** smilar a la de [Node REPL
   session](https://github.com/noffle/bisecting-between#example) de invocaciones
   a funciones y sus resultados, pueden comunicar el uso de manera más claro que
   un fichero de código fuente en ejecución.

8. Si tu módulo proporciona un CLI (interfaz de comando) en lugar (o además) de una
    API de programación, muestra invocaciones de comandos como ejemplos de uso, así
    como la salida de éstos. Si creas o modificas un fichero, `cat` podrá demostrar
    que ha cambiado antes y después.

9. No olvides utilizar las 
    [palabras clave](https://docs.npmjs.com/files/package.json#keywords) en tu 
    `package.json` para dirigir a los espeleólogos de módulos hasta el peldaño
    de tu puerta.

10. Cuanto más cambies tu API, más trabajo necesitas hacer actualizando la
    documentación -- esto implica que deberías mantener tus APIS pequeñas
    y definidas con concreción desde las primeras fases. Los requerimientos
    cambian a lo largo del tiempo, pero en lugar de cargar supuestos en directamente
    en la API de tus módulos, cargalos en un nivel de abstracción: el set del módulo
    mismo. Si los requerimientos *sí* cambian, y hacer-una-sola-cosa deja de tener
    sentido, entonces escribe un nuevo módulo que haga aquello que necesitas ahora.
    El módulo que 'hace-una-cosa-concreta' permanece como un modelo válido 
    y valioso en el ecosistema de npm, y tu corrección en caliente implicará únicamente
    la sustitución de un módulo por otro.

11. Finalmente, recordar por favor que tu sistema de control de versiones y su fichero
    README integrado sobrevivirán a tu [servicio del repositorio](https://github.com) y
    a cualquiera de las cosas a las que enlaces -- especialmente a imágenes -- así que
    -- incluye -- todo lo esencial para que futuros usurios puedan usar tu trabajo.


## Bonus: *common-readme*

No es una coincidencia que este formato sea usado por 
[**common-readme**](https://github.com/noffle/common-readme), un conjunto de guías para README además
de un práctico generador de línea de comando. Si te gusta lo que está escrito aquí,
ahorrarás algo de tiempo escribiendo READMEs con `common-readme`. También encontrarás ejemplos reales 
de módulos con este formato.

También puede interesarte 
[standard-readme](https://github.com/richardlitt/standard-readme), que es una versión más
estructurada y formateada de un formato común de README.


## Bonus: Ejemplares

La teoría está muy bien, pero ¿cómo es un fichero excelente de README? Aquí tenemos algunos que encarnan muy bien
los principios de este artículo:

- https://github.com/noffle/ice-box
- https://github.com/substack/quote-stream
- https://github.com/feross/bittorrent-dht
- https://github.com/mikolalysenko/box-intersect
- https://github.com/freeman-lab/pixel-grid
- https://github.com/mafintosh/torrent-stream
- https://github.com/pull-stream/pull-stream
- https://github.com/substack/tape
- https://github.com/yoshuawuyts/vmd
- https://github.com/defstream/nl3


¿Conoces alguno otro que sea un buen ejemplo? [Envíame un pull
request](https://github.com/noffle/art-of-readme/pulls)!


## Bonus: Lista de verificacion para un LÉEME

A continuación una lista de comprobación para medir la calidad de tu fichero README:

- [ ] Una línea explicando el propósito del módulo
- [ ] Contexto de fondo necesario y enlaces
- [ ] Enlaces a fuentes informativas de términos potencialmente desconocidos
- [ ] Ejemplo de uso *ejecutable* y claro
- [ ] Intrucciones de instalación
- [ ] Documentación extensa de la API
- [ ] Realización de [tunelización cognitiva](https://github.com/noffle/art-of-readme#cognitive-funneling)
- [ ] Mencionar excepciones y limitaciones por adelantado
- [ ] No usar imágenes para mostrar información crítica
- [ ] Licencia


## Autor

Soy [noffle](http://blog.eight45.net/about/). Se me conoce por mi
[blog](http://blog.eight45.net), [tweet](https://twitter.com/noffle), y
[hack](https://github.com/noffle).

Este pequeño proyecto comenzó en mayo en la conferencia squatconf de Berlín, mientras investigaba como
los _Perl monks_ hacían documentación y lamentaba el estado actual de los README en el ecosistema de Node.
Esto me sirvió como estimulante para crear [common-readme](https://github.com/noffle/common-readme).
La sección "README Tips" está repleta de consejos, por lo que decidí recogerlos todos  en un artículo
sobre escribir READMEs. Así, ¡nació El arte de LÉEME!


## Notas al pie 

1. <a name="footnote-1"></a>Gracias,
   [Sixes666](https://www.reddit.com/r/node/comments/55eto9/nodejs_the_art_of_readme/d8akpz6)!

1. <a name="footnote-2"></a>Consultar [The Jargon File](http://catb.org/~esr/jargon/html/R/README-file.html).
   Sin embargo la mayoría de sistemas actuales, no ordenan las mayúsculas antes que los caracteres en minúsculas 
   reduciendo así la utilidad de la convención de usar todo mayúsculas a una simple representación llamativa.


## Créditos

Un sentido agradecimiento a [@mafintosh](https://github.com/mafintosh) y a 
[@feross](https://github.com/feross) por el ánimo recibido que necesité para despegar esta idea y empezar a escribir.

Gracias a los lectores increibles que aparecen a continuación, por encontrar errores y enviarme sus PR :heart: :

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

¡Gracias a [@qihaiyan](https://github.com/qihaiyan) por traducir Art of
README a chino! Los siguientes usuarios también contribuyeron:

- [@BrettDong](https://github.com/brettdong) por revisar la puntuación en la versión china.
- [@Alex-fun](https://github.com/Alex-fun)
- [@HmyBmny](https://github.com/HmyBmny)
- [@vra](https://github.com/vra)

¡Gracias a [@lennonjesus](https://github.com/lennonjesus) por traducir Art
of README a Portugués Brasileño!

¡Gracias a [@jabiinfante](https://github.com/jabiinfante) por traducir Art
of README a Español!


Para terminar, ¡gracias por todo el feedback! Por favor hacer vuestros comentarios [como una
_issue_](https://github.com/noffle/art-of-readme/issues)!


## ¡Pull requests bienvenidas!

¿Has encontrado un error? ¿Algo no tiene sentido? ¡Enviar un [pull
request](https://github.com/noffle/art-of-readme/pulls)! Por favor evitar enviar cambios de estilo -- 
Seguramente no serán aceptados. Gracias!

## Licencia

[Creative Commons Attribution License](http://creativecommons.org/licenses/by/2.0/)
