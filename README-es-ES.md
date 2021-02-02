# El arte del README

*Este artículo ha sido traducido desde el [inglés](README.md) y tambien lo
puedes encontrar en [chino](README-zh.md),
[portugués brasileño](README-pt-BR.md), [alemán](README-de-DE.md) 
o [Francés](README-fr.md).*

## Etimología

¿De dónde viene el término "README"?

La nomenclatura se remonta *por lo menos* a la década de los 70's, incluso
podría remontarse a los días de las notas de papel informativas situadas sobre
tarjetas perforadas donde encontramos "READ ME" (¡LEEME!) garabateado por
encima, describiendo así su uso.

Un lector<sup>[1](#footnote-1)</sup> ha sugerido que el título README puede ser
un guiño a *Las aventuras de Alicia en el país de las maravillas* de Lewis
Carroll, donde una poción y un pastel están etiquetados como *"BÉBEME"* y
*"CÓMEME"*, respectivamente.

El patrón README escrito por completo en mayúsculas ha sido constante a lo
largo de la historia. Además de la sorpresa visual de utilizar las mayúsculas,
los sistemas UNIX ordenan los caracteres en mayúsculas antes que en minúsculas,
acomodando convenientemente el archivo README antes que el resto del contenido
del directorio<sup>[2](#footnote-2)</sup>.

La intención es clara: *"ésta es información importante que el usuario debe
leer antes de continuar"*. Vamos a explorar juntos qué constituye la
"información importante" en estos tiempos modernos.

## Para creadores, para consumidores

Este es un artículo acerca de los archivos README. Sobre qué es lo que hacen,
por qué son absolutamente necesarios y cómo desarrollarlos correctamente.

Esto está escrito para creadores de módulos. Como constructores de módulos,
nuestro trabajo es crear algo que perdure en el tiempo. Esta es una motivación
inherente, incluso si el autor no tiene intención de compartir su trabajo. Una
vez que pasan 6 meses, un módulo sin documentación comienza a parecer nuevo y
desconocido.

Esto también está escrito para consumidores de módulos, ya que, todo autor de
módulos es también un consumidor de módulos. Node.js tiene un grado muy sano de
interdependencias: nadie está en lo más bajo del árbol de dependencias.

A pesar de estar centrado en Node.js, el autor sostiene que la lección puede
ser aplicada igual de bien a otros ecosistemas de programación.

## Muchos módulos: unos buenos, unos malos

El ecosistema de Node.js está sostenido gracias a sus módulos.
[npm](https://npmjs.org) es la magia
que hace que todo *funcione*. Durante una semana cualquiera, un desarrollador
de Node.js evalúa docenas de módulos para incluir en sus proyectos. Esto
significa utilizar muchísimo poder a diario, es tan rápido que basta con
ejecutar `npm install`.

Como cualquier ecosistema extremadamente accesible, la barra de calidad puede
variar. npm funciona empaquetando y distribuyendo estos módulos ampliamente.
Sin embargo, las herramientas que nos encontramos son muy variadas: algunas son
nuevas y relucientes, otras son viejas u oxidadas y
algunas otras están el medio. Incluso hay algunas de las que ¡no sabemos ni qué
es lo que hacen!

En lo relativo a módulos, esto puede llevar a nombres inexactos o inútiles
(¿alguien adivina qué hace el módulo `fudge`?), proyectos sin pruebas o
documentación, sin comentarios en el código fuente o funciones con nombres
incomprendibles.

Muchos módulos nisiquiera tienen mantenimiento constante. Si un módulo no tiene
una persona disponible respondiendo a preguntas y explicando qué hace el módulo
o, por lo menos, un rastro de documentación, éste módulo se vuelve un artefacto
alienígena bizarro, inusable e incomprensible para los *arqueolo-hackers* del
mañana.

Para aquellos módulos que si tienen documentación, ¿a qué nivel de calidad
podremos encontrarlos? Puede que sea una simple explicación de una línea:
`"ordena números por su valor en hexadecimal"`. Puede que sea un pedazo de
código fuente. Ambos casos son mejor que nada, pero suelen terminar (en el peor
de los casos) utiles sólo para los espeleólogos de módulos modernos: esos que
excavan el un código fuente para intentar entender cómo funciona realmente.
Escribir documentación excelente sirve para mantener a los usuarios *fuera* del
código fuente, proporcionando suficientes instrucciones para disfrutar de la
maravillosa abstracción que nos brinda el módulo.

Node.js tiene un "amplio" ecosistema: está compuesto por una larga lista de
módulos independientes que hacen una-cosa-bien y nada más. Existen
[excepciones](https://github.com/lodash/lodash), pero a pesar de estos feudos
menores, son los desarrolladores de módulos con un único propósito los que,
dada su superioridad numérica, verdaderamente mandan en el reino de Node.js.

Esta situación tiene una consecuencia natural: puede ser complicado encontrar
módulos de *calidad* que hagan exactamente lo que tú quieres que hagan.

**Esto está bien**. De verdad. Una exigencia de entrada menor y un problema
de detectabilidad son infinitamente mejor que un problema de cultura, donde
sólo unos pocos privilegiados puedan participar.

Además, la detectabilidad --como finalmente resulta-- va a ser más fácil de
solucionar.

## Todos los caminos llevan al README.md

La comunidad de Node.js ha respondido al reto de la detectabilidad de muchas
maneras diferentes.

Algunos desarrolladores con experiencia en Node.js se han asociado para crear
[listas curadas](https://github.com/sindresorhus/awesome-nodejs) de módulos de
calidad. Los desarrolladores aprovechan sus muchos años de examinar cientos
de módulos para compartir con los recién llegados la *crème de la crème*: los
mejores módulos de cada categoría. Además, esto podrá tomar forma de feeds RSS
o listas de correo de nuevos módulos que sean considerados útiles por miembros
confiables de la comunidad.

¿Qué hay de las redes sociales? Esta idea estimuló la creación de
[node-modules.com](http://node-modules.com/), un reemplazo de búsqueda para npm
que aprovecha tus conexiones sociales en GitHub para encontrar módulos que
gusten o hayan sido hechos por tus amigos.

Por supuesto también está la funcionalidad nativa de 
[búsqueda](https://npmjs.org) de
npm: una opción segura y habitual punto de entrada para nuevos desarrolladores.

No importa cuál sea tu opción, no importa si los espeleólogos de módulos entran
al subsuelo de nuestros módulos por [npmjs.org](https://npmjs.org),
[github.com](https://github.com) o por cualquier otro sitio, estos usuarios
potenciales se encontrarán mirando fijamente a tu fichero README. Ya
que tus usuarios terminarán inevitablemente aquí, ¿qué podemos hacer para
potenciar al máximo su primera impresión?

## Espeleología de módulos profesional

### README: Tu única ventanilla

Un README es la primera -- y puede que única -- mirada que dedica un consumidor
de módulos a tu creación. El consumidor quiere que el módulo satisfaga su
necesidad, por lo tanto, debemos explicar exactamente qué necesidad satisface
el módulo y qué tan efectivo es.

Tu trabajo consiste en

1. decirles qué es (con contexto)
2. mostrarles cómo funciona
3. mostrarles cómo usarlo
4. decirles cualquier otro detalle relevante

Este es *tu* trabajo. Depende del creador del módulo probar que su trabajo es
una joya brillante en un mundo de módulos chapuceros. Ya que tu README será lo
primero que vean los ojos de muchos desarrolladores, la calidad de éste será
como se mida públicamente la calidad de tu trabajo.

### Sé breve

La falta de un README supone una bandera roja, aunque un README muy largo no es
indicativo de mucha calidad. El README ideal es tan corto como sea posible. La
documentación detallada es buena -- ¡haz páginas separadas para esto!
-- pero mantén tu README sucinto.

### Aprender del pasado

Suele decirse que, quién no aprende historia, está condenado a cometer los
mismos errores una y otra vez. Los desarrolladores han estado escribiendo
documentación desde hace bastantes años. Sería un desperdicio no mirar atrás
y fijarnos en lo que la gente ha estado haciendo bien antes de Node.js.

Perl, por todas las críticas que recibe, es en muchas maneras el abuelo
espiritual de Node. Ambos son lenguajes de alto nivel que adoptan muchas
expresiones de UNIX, son el combustible de gran parte de Internet y ambos
poseen un amplio ecosistema de módulos.

Al parecer, los denominados [monjes](http://perlmonks.org) de la comunidad
Perl tienen muchísima experiencia escribiendo
[REAMEs de calidad](http://search.cpan.org/~kane/Archive-Tar/lib/Archive/Tar.pm).
CPAN es un recurso excelente al que vale la pena echar un ojo para aprender más
de una comunidad que escribe de manera consistente documentación de gran
calibre.

### ¿No hay README? No hay abstracción

No tener un README implica que los desarrolladores tengan que ahondar en tu
código para poder llegar a entenderlo.

Los Perl monks comparten cierta sabiduría acerca de este tema:

> Tu documentación estará completa cuando alguien sea capaz de usar tu módulo
sin tener que mirar el código fuente. Esto es muy importante. Esto hace posible
que puedas separar la interfaz documentada de la implementación interna (tripas)
de tu módulo. Esto es bueno, significa que eres libre de cambiar el código de
tu módulo mientras mantengas intacta la interfaz.
>
> Recuerda: la documentación y no el código define lo que hace un módulo.
-- [Ken Williams](http://mathforum.org/ken/perl_modules.html#document)

### Elementos clave

Una vez localizado el README, el valiente espeleólogo de módulos debe
escanearlo para discernir si se ajusta a las necesidades del desarrollo. Esencialmente,
esto se convierte en una serie de coincidencia de patrones que sus cerebros
deben resolver, donde cada paso les mete más dentro del módulo y sus detalles.

Digamos, por ejemplo, que mi búsqueda de un módulo de detección de colisiones
2D me lleva hasta
`collide-2d-aabb-aabb`](https://github.com/noffle/collide-2d-aabb-aabb) y
comenzamos a examinarlo de arriba a abajo:

1. *Nombre* -- los nombres auto-explicativos son los mejores.
`collide-2d-aabb-aabb` suena prometedor, aunque asumimos que se entiende lo que
significa "aabb". Si el nombre suena demasiado vago o sin relevancia, podría
ser una señal para evitar el módulo.

2. *Línea-única* -- tener una única línea que describa el módulo, resulta muy
útil para ofrecer una idea de lo que hace el módulo en algo más de detalle.
`collide-2d-aabb-aabb` dice esto:

   > Determina si el movimiento de una caja delimitada alienada en un eje
   (CDAE) colisiona
   > con otras CDAE. (CDAE = AABB = axis-aligned bounding box)

   Increíble. Define lo qué significa AABB y qué hace el módulo. Ahora queda
   calibrar cómo de bien encajaría en mi código.

3. *Uso* -- En lugar de empezar a ahondar en la documentación de la API,
estaría genial si podemos ver el módulo en acción. Así podemos determinar
rápidamente si el código de ejemplo encaja con el estilo buscado y soluciona
el problema. La gente tiene muy diversas opiniones con cosas como las
promesas/callbacks y ES6. Si encaja a primera vista, entonces podemos
avanzar más y profundidad.

4. *API* -- el nombre, la descripción y el uso de este módulo son cosas muy
atractivas para mi. Muy probablemente estoy en un punto en el que voy a usar
este módulo. Sólo necesito revisar la API para asegurarme de que hace
exactamente lo que necesito y de que tendrá una integración sencilla con mi
código fuente. La sección de API debe detallar los objetos y funciones del
módulo, sus firmas, tipados de vuelta, callbacks y eventos. Debemos incluir el
tipado allá donde no sea obvio. Cualquier advertencia debe ser expuesta
muy claramente.

5. *Instalación* -- si he leído hasta aquí abajo, entonces estoy condenado a
instalar el módulo. Si existen notas no estándar de instalación, deberían ir
aquí, al igual que si es un simple `npm install`, también me gustaría verlo
mencionado aquí. Existen nuevos usuarios comenzando a usar Node.js todo el
tiempo, así que, enlazar a [npmjs.org](npmjs.org) con el comando de instalación
les facilita los recursos para descubrir cómo funciona el sistema de módulos de
Node.

6. *Licencia* -- la mayoría de los módulos ponen esto muy abajo, pero podría
ser mejor ponerlo más arriba; Es posible que excluyas rápidamente un módulo si
tiene una licencia incompatible con tu trabajo. Yo generalmente me mantengo en
licencias tipo MIT/BSD/X11/ISC. Si tienes una licencia no permisiva, colócala
muy arriba del módulo para prevenir cualquier tipo de confusión.

## Canalización cognitiva

El orden de lo expuesto anteriormente no ha sido escogido al azar.

Los consumidores de módulos usan muchos módulos y necesitan vontinuar
descubriendo muchos otros.

Cuando has visto cientos de módulox comienzas a descubrir que la mente se
beneficia de patrones predecibles.

También comienzas a construir tu propio sistema heurístico para aquella
información
que quieres y para esas banderas rojas que descalifican rápidamente algunos
módulos.

De esta forma, podemos deducir que un README deseable debe tener:

1. un formato predecible
2. ciertos elementos clave presentes

No necesitas usar *este* formato, pero intenta ser consistente para ahorrar a
tus usuarios valiosos ciclos cognitivos.

El orden presentado aquí se denomina cariñosamente "canalización cognitiva"
y podemos imaginarlo como un embudo en posición vertical, donde la zona más
ancha contiene los detalles pertinentes más generales y al movernos hacia abajo
en el embudo se presentan detalles más específicos, pertinentes únicamente para
un lector lo suficientemente interesado en nuestro trabajo como para para haber
llegado hasta las profundidades del documento.

Finalmente, el fondo podrá reservarse para detalles que incluyan un contexto
más profundo del trabajo (antecedentes, créditos, bibliografía, etc).

De nuevo, los monjes de Perl tienen sabiduría que comparten sobre esta materia:

> El nivel de detalle en la documentación de un módulo Perl generalmente va de
menos a más detalle. Tu sección de SIPNOSIS deberá contener un ejemplo de uso
mínimo (quizás algo tan simple como una única línea de código; evitar los casos
de uso poco comunes o cualquier cosa innecesaria para la mayoría de usuarios);
> la DESCRIPCIÓN debe describir tu módulo en términos más amplios, generalmente
con unos pocos párrafos; Se podrán dar más detalles de rutinas o métodos,
ejemplos de código más largos y otros materiales más a profundidad en secciones
posteriores.
>
> Idealmente, alguien ligeramente familiar con tu módulo debería ser capaz de
refrescar su memoria sin pulsar "avance página". A medida que el lector avance
por el documento, irá recibiendo progresivamente más cantidad de información.
>
> *-Tomado de `perlmodstyle`*

## Preocupación por el tiempo de los demás

Es Increíble, el orden de estos puntos clave debería decidirse por la rapidez
con la que alguien 'corto circuite' apuesta por tu módulo.

¿Suena poco prometedor? Piensa en esto: tu trabajo, cuando estás en ello con
un alto nivel de altruismo en mente, no se trata de "vender" a la gente tu
trabajo, se trata de permitir que evalúen qué hace tu creación lo más
objetivamente posible, que decidan si satisface sus necesidades o no -- además
de maximizar tu número de descargas y tu base de usuarios, por su puesto.

Este modo de pensar no se ajusta a todo el mundo; requiere dejar tu ego en la
puerta y dejar que el trabajo hable por si solo tanto como sea posible. Tu
único trabajo es describir lo que prometes tan sucintamente como te sea
posible, de manera que los espeleólogos de módulos puedan usar tu trabajo
cuando les encaje, o bien, encontrar otra opción que les encaje mejor.

## ¡Llamada a las armas!

¡Sal allí fuera, valiente constructor de módulos! ¡Haz que tu trabajo sea
visible y utilizable gracias a una documentación excelente!

## Bonus: otras buenas prácticas

Más allá de las claves de este artículo, existen otras técnicas que puedes
seguir (o evitar) para subir aún más la barra de calidad de tus README y
maximizar su usabilidad para el resto:

1. Considera incluir una sección de **Antecedentes** si tu módulo depende de
una importante pero no muy conocida abstracción o de otros ecosistemas. La
función de [`bisecting-between`](https://github.com/noffle/bisecting-between)
no es demasiado obvia si partimos de su nombre, por lo tanto, encontramos una
sección muy detallada de *Antecedentes* para definir y enlazar hacia grandes
conceptos y abstracciones que nadie tiene porqué entender para pilotar el
módulo. Este suele ser un buen lugar para explicar la motivación del módulo si
es que ya existen módulos similares en npm.

2. ¡Utiliza Links todo el tiempo! Si hablas de otros módulos, ideas o gente,
haz que ese texto de referencia se convierta en un enlace, de manera que los
visitante puedan comprender fácilmente tu módulo y las ideas en las que se
basa. Pocos módulos existen desde el vacío: todo el trabajo proviene de otro
trabajo, esto puede ayudar a tus usuarios a conocer la historia e inspiración
de tu módulo.

3. Incluye información acerca del tipado de los argumentos y de los parámetros
de salida (si éstos no son obvios). Priorizar las convenciones cuando sea
posible (`cb` probablemente se refiere a una función de callback, `num`
probablemente representa un `Number`, etc).

4. Incluye el código de ejemplo de la sección de **Uso** como un fichero más
del repositorio (algo como `example.js`). Está bastante bien tener código en
el README que los usuarios pueden ejecutar tras clonar el repositorio.

5. Utiliza los badges con cabeza. Es fácil
[abusar](https://github.com/angular/angular) de ellos. Pueden ser grande
fuentes de polémicas y debates interminables. Añaden ruido visual a tu README y
solo funcionan si el usuario está leyendo el README en un navegador conectado,
ya que, la mayoría de las imágenes están albergadas en un servidor de internet.

    Para cada badget, es importante preguntarse: "¿Qué valor real aporta al
    típico lector de este README?" ¿Tienes un badge de CI que muestre el
    estado del build/test?

   Estas señales deberían llegar a las partes interesadas mediante un email a
   los mantenedores, o bien, creando automáticamente una incidencia -- siempre
   hay que considerar qué audiencia quiere esta información en el README,
   habría que preguntarse si existe algún flujo para que esta información
   pueda llegar mejor hasta la audiencia deseada.

6. Formatear una API es altamente opinable. Utiliza el formato que tú
consideres más claro, pero asegúrate de que este formato  contempla algunas
sutilezas:

   a. Qué parámetros son opcionales y su valor por defecto

   b. Información del tipado, allí donde no exista una convención obvia

   c. Para los parámetros `opts` de un objeto, todas las claves y valores
   aceptados

   d. No húyas de proporcionar un pequeño ejemplo de uso de alguna función de
   la API cuyo funcionamiento no sea obvio o no esté completamente cubierto en
   la sección de *Uso*. Sin embargo, esto puede como una señal de complejidad
   de la función, tal vez pudiera necesitar ser refactorizada, dividida en
   funciones más pequeñas o eliminada en su conjunto.

   e. ¡Utiliza links para los terminos especiales! En markdown se pueden
   escribir
   [notas al pie](https://daringfireball.net/projects/markdown/syntax#link) en
   la parte de abajo del documento, hacer varias referencias al pie de página
   resulta barato. Algunas de mis preferencias personales al formatear una API
   pueden encontrarse
   [aquí](https://github.com/noffle/common-readme/blob/master/api_formatting.md).

7. Si tu módulo está compuesto por una pequeña colección de funciones sin
estado, tener una sección de **Uso** similar a la de
[Node REPL session](https://github.com/noffle/bisecting-between#example) con
invocaciones a funciones y sus resultados puede comunicar el uso de manera más
clara que un fichero de código fuente en ejecución.

8. Si tu módulo proporciona un CLI (interfaz de comando) en lugar (o además) de
una API de programación, muestra invocaciones de comandos con ejemplos de uso,
así como la salida de éstos. Si creas o modificas un fichero, `cat` podrá
demostrar que ha cambiado antes y después.

9. No olvides utilizar las
[palabras clave](https://docs.npmjs.com/files/package.json#keywords) en tu
`package.json` para dirigir a los espeleólogos de módulos hasta el peldaño de
tu puerta.

10. Cuanto más cambies tu API, más trabajo necesitas hacer actualizando la
documentación -- esto implica que deberías mantener tus APIS pequeñas y
definidas con concreción desde las primeras fases.

    Los requerimientos cambian a lo largo del tiempo, en lugar de cargar
    supuestos directamente en la API de tus módulos, cárgalos en un nivel de
    abstracción: el set del módulo mismo. Si los requerimientos *sí* cambian
    y hacer-una-sola-cosa deja de tener sentido, entonces escribe un nuevo
    módulo que haga aquello que necesitas ahora.

    El módulo que 'hace-una-cosa-concreta' permanece como un modelo válido y
    valioso en el ecosistema de npm, tu corrección en caliente implicará
    únicamente la sustitución de un módulo por otro.

11. Finalmente, recuerda por favor que tu sistema de control de versiones y su
fichero README integrado sobrevivirán a tu
[servicio del repositorio](https://github.com) y a cualquiera de las cosas a
las que enlaces -- especialmente a imágenes -- así que -- incluye -- todo lo
esencial para que futuros usuarios puedan usar tu trabajo.

## Bonus: *common-readme*

No es una coincidencia que este formato sea utilizado por
[**common-readme**](https://github.com/noffle/common-readme), un conjunto de
guías para READMEs además de un práctico generador en línea de comandos. Si te
gusta lo que está escrito aquí, ahorrarás algo de tiempo escribiendo READMEs
con `common-readme`. También encontrarás ejemplos reales de módulos con este
formato.

También puede interesarte
[standard-readme](https://github.com/richardlitt/standard-readme), una versión
más estructurada y formateada para un escribir los READMEs.

## Bonus: Ejemplares

La teoría está muy bien, pero, ¿cómo es un fichero excelente de README? Aquí
tenemos algunos que encarnan muy bien los principios de este artículo:

- [https://github.com/noffle/ice-box](https://github.com/noffle/ice-box)
- [https://github.com/substack/quote-stream](https://github.com/substack/quote-stream)
- [https://github.com/feross/bittorrent-dht](https://github.com/feross/bittorrent-dht)
- [https://github.com/mikolalysenko/box-intersect](https://github.com/mikolalysenko/box-intersect)
- [https://github.com/freeman-lab/pixel-grid](https://github.com/freeman-lab/pixel-grid)
- [https://github.com/mafintosh/torrent-stream](https://github.com/mafintosh/torrent-stream)
- [https://github.com/pull-stream/pull-stream](https://github.com/pull-stream/pull-stream)
- [https://github.com/substack/tape](https://github.com/substack/tape)
- [https://github.com/yoshuawuyts/vmd](https://github.com/yoshuawuyts/vmd)

¿Conoces alguno otro buen ejemplo? [Envía un pull request](https://github.com/noffle/art-of-readme/pulls)!

## Bonus: Lista de verificación para un LÉEME

A continuación, una lista de comprobación para medir la calidad de tu fichero
README:

- [ ] Una línea explicando el propósito del módulo
- [ ] Contexto de fondo necesario y enlaces
- [ ] Enlaces a fuentes informativas de términos potencialmente desconocidos
- [ ] Ejemplo de uso *ejecutable* y claro
- [ ] Instrucciones de instalación
- [ ] Documentación extensa de la API
- [ ] Realización de [tunelización cognitiva](https://github.com/noffle/art-of-readme#cognitive-funneling)
- [ ] Mencionar excepciones y limitaciones por adelantado
- [ ] No usar imágenes para mostrar información crítica
- [ ] Licencia

## Autor

Soy [noffle](http://blog.eight45.net/about/). Se me conoce por mi
[blog](http://blog.eight45.net), [tweet](https://twitter.com/noffle) y
[hack](https://github.com/noffle).

Este pequeño proyecto comenzó en mayo en la conferencia squatconf de Berlín,
mientras investigaba cómo los _Perl monks_ hacían documentación y lamentaba el
estado actual de los README en el ecosistema de Node. Esto me sirvió como
estimulante para crear
[common-readme](https://github.com/noffle/common-readme). La sección "README
Tips" está repleta de consejos, por lo que decidí recogerlos todos en un
artículo sobre escribir READMEs. ¡Así nació Art of README!

## Otras lecturas

- [README-Driven Development](http://tom.preston-werner.com/2010/08/23/readme-driven-development.html)
- [Documentation First](http://joeyh.name/blog/entry/documentation_first/)
 
## Notas al pie

1. <a name="footnote-1"></a>Gracias,
   [Sixes666](https://www.reddit.com/r/node/comments/55eto9/nodejs_the_art_of_readme/d8akpz6)!

1. <a name="footnote-2"></a>Consultar [The Jargon File](http://catb.org/~esr/jargon/html/R/README-file.html). Sin embargo la mayoría
de sistemas actuales, no ordenan las mayúsculas antes que los caracteres en
minúsculas reduciendo así la utilidad de la convención de usar todo mayúsculas
a una simple representación llamativa.

## Créditos

Un sentido agradecimiento a [@mafintosh](https://github.com/mafintosh) y a
[@feross](https://github.com/feross) por el ánimo recibido que necesité para
despegar esta idea y empezar a escribir.

Gracias a los lectores increíbles que aparecen a continuación por encontrar
errores y enviarme sus PRs :heart::

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

¡Gracias a [@qihaiyan](https://github.com/qihaiyan) por traducir Art of
README a chino! Los siguientes usuarios también contribuyeron:

- [@BrettDong](https://github.com/brettdong) (por revisar la puntuación en la
versión china)
- [@Alex-fun](https://github.com/Alex-fun)
- [@HmyBmny](https://github.com/HmyBmny)
- [@vra](https://github.com/vra)

¡Gracias a [@lennonjesus](https://github.com/lennonjesus) por traducir Art of
README a portugués brasileño! Los siguientes usuarios también contribuyeron a
este artículo:

- [@rectius](https://github.com/rectius)

¡Gracias a [@jabiinfante](https://github.com/jabiinfante) por traducir Art of
README a español!

¡Gracias a [@Ryuno-Ki](https://github.com/Ryuno-Ki) por traducir Art of
README a alemán! Los siguientes usuarios también contribuyeron a este artículo:

- [@randomC0der](https://github.com/randomC0der)

¡Gracias a [@Manfred Madelaine](https://github.com/Manfred-Madelaine-pro) y
[@Ruben Madelaine](https://github.com/Ruben-Madelaine)
por traducir Art of README a Francés!

Para terminar, ¡gracias por todo el feedback! Por favor hacer vuestros
comentarios [como una _issue_](https://github.com/noffle/art-of-readme/issues)!

## ¡Pull requests bienvenidas!

¿Has encontrado un error? ¿Algo no tiene sentido? ¡Enviar un [pull
request](https://github.com/noffle/art-of-readme/pulls)! Por favor evitar
enviar cambios de estilo --
Seguramente no serán aceptados. ¡Gracias!

## Licencia

[Creative Commons Attribution License](http://creativecommons.org/licenses/by/2.0/).
