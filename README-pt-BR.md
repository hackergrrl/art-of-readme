# Art of README

*Este artigo foi traduzido do [Inglês](README.md) e traduzido para [Chinês](README-zh.md),
[Português](README-pt-BR.md), [Espanhol](README-es-ES.md), [Alemão](README-de-DE.md)
e [Francês](README-fr.md).*

## Etimologia

De onde vem o termo "README"?

A nomenclatura data de *pelo menos* 1970
[e do PDP-10](http://pdp-10.trailing-edge.com/decuslib10-04/01/43,50322/read.me.html),
embora possa ainda remeter de volta aos dias das notas de papel colocadas no topo
da pilha de cartões perfurados, com um "READ ME!" rabiscado sobre eles,
descrevendo a sua utilização.

Um leitor<sup>[1](#footnote-1)</sup> sugeriu que o título README possa ser uma
referência a Alice no País das Maravilhas, de Lewis Carroll, onde existe uma
poção e um bolo escrito *"DRINK ME"* (ME BEBA) e *"EATME"* (ME COMA)
respectivamente.

O padrão README aparecendo todo em maiúsculo é uma característica consistente
ao longo da história. Além do impacto visual de usar tudo em caps, sistemas
UNIX ordenam letras maiúsculas antes de minúsculas, colocando convenientemente
o README antes de todo o resto do conteúdo do diretório<sup>[2](#footnote-2)</sup>.

A intenção é clara: *"esta é uma informação importante para o usuário ler antes
de prosseguir"*. Vamos explorar juntos o que constitui uma "informação importante" na
era moderna.


## Para os criadores, para os consumidores

Este é um artigo sobre os READMEs. Sobre o que eles fazem, por que são absolutamente
necessários, e como escrevê-los direito.

É escrito para os criadores de módulos, pois, como um construtor de módulos,
seu trabalho é criar algo que vá durar. Esta é uma motivação inerente, mesmo se
o autor não tiver a intenção de compartilhar seu trabalho. Depois de passados 6
meses, um módulo sem documentação começa a virar algo novo e desconhecido.

Também é escrito para os consumidores de módulo, pois cada autor de módulo é
também um consumidor. Node tem um grau bastante saudável de interdependência:
ninguém vive na parte inferior da árvore de dependência.

Apesar de ser focado em Node, o autor afirma que as suas lições se aplicam
também a outros ecossistemas de programação.


## Muitos módulos: alguns bons, alguns ruins

O ecossistema Node é alimentado por seus módulos. [NPM](https://npmjs.org) é a
mágica que faz com que tudo *aconteça*. No decorrer de uma semana, programadores
Node avaliam dezenas de módulos para inclusão em seus projetos. Esta é uma grande
quantidade de energia agitada diariamente, madura para a colheita, tão rápida
quanto alguém possa escrever `npm install`.

Assim como qualquer ecossistema que é extremamente acessível, o grau de qualidade
varia. npm faz o seu melhor para organizar bem todos os módulos e entregá-los da
melhor forma possível. Entretanto, as ferramentas achadas lá variam bastante:
algumas são novas e brilhantes. Outras são velhas e enferrujadas. E algumas estão
ali no meio termo. Há também aquelas que sequer temos idéia do que fazem!

Para módulos, isto pode tomar a forma de nomes incorretos ou inúteis (alguém
adivinha o que o módulo `fudge` faz?), sem documentação, sem testes, nenhum
comentário de código-fonte, ou nomes de função incompreensíveis.

Muitos não têm um mantenedor ativo. Se um módulo tem nenhuma pessoa disponível
para responder às perguntas e explicar o que ele faz, combinado com nenhum ou
restos de documentação deixados para trás, torna-se um artefato alienígena
bizarro, inutilizável e incompreensível pelos hackers arqueólogos de amanhã.

Para aqueles módulos que não têm documentação, onde estariam seu espectro de
qualidade? Talvez eles sejam descritos com apenas uma linha: `"ordenar números
pelo valor hexadecimal"`. Talvez seja um trecho de código de exemplo. Estas são
duas melhorias sem valor, mas elas tendem a resultar no pior cenário para um
moderno caçador de tesouros: cavar o código-fonte para tentar entender como ele
realmente funciona. Escrever uma documentação excelente é sobre como manter os
usuários *fora* do código-fonte, fornecendo instruções suficientes para
aproveitar as abstrações maravilhosas que seu módulo traz.

Node tem um ecossistema "amplo": é em grande parte composto de uma lista muito
longa de módulos independentes do tipo faça-alguma-coisa-bem, sob nenhuma bandeira
que não a sua própria. Existem [exceções](https://github.com/lodash/lodash),
mas apesar destes poucos feudos, são os plebeus de uma única causa quem, devido
ao seu grande número, verdadeiramente governam o reino do Node.

Isso tem uma consequência natural: pode ser difícil encontrar módulos de qualidade
que façam exatamente o que você precisa.

**Tudo bem com isso**. De verdade. A falta de barreiras para entrar e um problema
para encontrar as coisas é infinitamente melhor do que um problema de cultura,
onde apenas uns poucos privilegiados podem participar.

Além disso, descoberta -- como se vê -- é mais fácil de tratar.


## Todos os caminhos levam ao README.txt

A comunidade Node tem respondido ao desafio da descoberta de diferentes formas.

Alguns desenvolvedores Node experientes se unem para criar
[listas revisadas](https://github.com/sindresorhus/awesome-nodejs) de módulos de
qualidade.
Os desenvolvedores unem o conhecimento de seus muitos anos examinando centenas de
módulos diferentes para compartilhar com os recém-chegados a *Crème de la Crème*:
os melhores módulos em cada categoria.
Isso também pode assumir a forma de feeds RSS e listas de discussão de novos
módulos considerados dignos e úteis por membros confiáveis da comunidade.

Sobre o Social Graph? Essa ideia estimulou a criação do
[node-modules.com](http://node-modules.com/), um substituto para a busca npm que
usa o lado social do seu Github para encontrar módulos que seus amigos gostam ou
criaram.

Claro que também existe a funcionalidade de [busca](https://npmjs.org) nativa do
npm: um padrão seguro e porta de entrada comum a novos desenvolvedores.

Não importa a sua abordagem, independentemente de o consumidor encontrar seu módulo
no [npmjs.org](https://npmjs.org), no [Github.com](https://github.com) ou em
algum outro lugar, eles vão estar olhando o seu README na frente. De forma que
seus usuários irão fatalmente acabar aqui, o que pode ser feito para fazer esta
breve impressão ser o mais eficaz possível?


## Caçador de tesouros profissional

### O README: Your one-stop shop

Um README é a entrada principal - e talvez a única - para um consumidor olhar
para o sua criação. O consumidor quer um módulo para atender sua necessidade,
então você deve explicar exatamente o que seu módulo faz, e como efetivamente
ele faz isso.

Seu trabalho é:

1. dizer o que isso é (dentro de um contexto)
2. mostrar como é em ação
3. mostrar como utilizar
4. mostrar outros detalhes relevantes

Este é *seu* trabalho. Cabe ao criador do módulo provar que seu trabalho é uma
pedra preciosa brilhando em meio a um mar de módulos. Considerando que muitos
desenvolvedores irão encontrar o caminho para o seu README antes de mais nada,
a qualidade aqui é a vitrine do seu trabalho voltado para o público.


### Brevidade

A falta de um README é uma bandeira vermelha poderosa, mas mesmo um README longo
não é necessariamente garantia de alta qualidade. O README ideal é tão curto
quanto é possível ser, sem ser curto demais. A documentação detalhada é boa -
faça páginas separadas para ela! - Mas mantenha o seu README breve.


### Aprenda com o passado

Diz-se que aqueles que não estudam a história estão condenados a cometer os mesmos
erros novamente. Os desenvolvedores têm escrito documentação por alguns anos.
Seria um desperdício não olhar um pouco para trás e ver o que as pessoas fizeram
antes do Node.

Perl, para todos as críticas que recebe, é de certa forma o avô espiritual do Node.
Ambas são linguagens de script de alto nível, adotam muitas expressões idiomáticas
do UNIX, combustível de grande parte da internet, e ambos apresentam um grande
ecossistema de módulos.

É por isso que os [monges](http://perlmonks.org) da comunidade Perl  tem grande
experiência em escrever
[READMEs de qualidade](http://search.cpan.org/~kane/Archive-Tar/lib/Archive/Tar.pm).
CPAN é um recurso maravilhoso que vale a pena a leitura afim de aprender mais
sobre uma comunidade que escreveu consistentemente documentação de alto calibre.


### Sem README? Sem abstração

A falta de um README significa que os desenvolvedores terão que mergulhar no seu
código para entendê-lo.

Os Monges do Perl tem uma sabedoria para compartilhar sobre isso:

> Sua documentação está completa quando alguém consegue utilizar seu módulo sem
> nunca precisar olhar o seu código. Isso é muito importante. Isso torna possível
> que você separe a interface documentada do seu módulo da implementação interna
> (entranhas). Isso é bom porque significa que você está livre para mudar as
> entranhas do seu módulo enquanto a interface continua a mesma.

Lembre-se: a documentação, não o código, define o que um módulo faz.
-- [Ken Williams](http://mathforum.org/ken/perl_modules.html#document)


### Elementos chave

Uma vez loacalizado um README, o bravo caçador de tesouros deve avaliar se o
módulo atende às necessidades do desenvolvimento. Isto se torna essencialmente
uma série de padrão de problemas de harmonização para o seu cérebro para resolver,
onde cada passo leva mais a fundo no módulo e seus detalhes.

Digamos, por exemplo, que minha busca por um sistema de detecção de colisões em
2D me leve ao
[`collide-2d-aabb-aabb`](https://github.com/noffle/collide-2d-aabb-aabb). Eu
começo a examina-lo de cima a baixo:

1. *Nome* -- Nomes autoexplicativos são os melhores. `collide-2d-aabb-aabb` soa
   promissor, embora assuma que eu saiba o que um "aabb" é. Se o nome soa muito
   vago ou sem relação com nada, pode ser um sinal para abandonar.

2. *Uma linha* -- Ter um linha descrevendo o módulo é útil para ter uma ideai do
   que o módulo faz em mais detalhes.
   `collide-2d-aabb-aabb` diz isso:

   > Determina se um axis-aligned-bounding-box (AABB) em movimento colide com
   > outros AABBs.

   Implessionante: isso define o que um AABB é e o que o módulo faz. Agora, para
   medir o quão bem ele irá se adequar em meu código:

3. *Utilização* -- ao invés de começar a mergulhar na documentação da API, seria
   ótimo ver o que o módulo faz em ação. Eu posso rapidamente determinar se um
   exemplo JS se encaixa no estilo desejado e resolve o problema. As pessoas têm
   muitas opiniões em coisas como promisses/callbacks e ES6. Se isso acontecer
   caber a conta, então eu posso proceder a uma maior detalhe. If it does fit the
   bill, then I can proceed to greater detail.

4. *API* -- o nome, descrição e utilização deste módulo chamam minha atenção.
   Estou muito propenso a usar este módulo neste momento. Eu só preciso varrer a
   API para me certificar de que ele faz exatamente o que eu preciso e que será
   fácil de integrar em minha base de código. A seção API deveria detalhar objetos
   e funções do módulo, suas assinaturas, tipos de retorno, callbacks e eventos
   em bom nível de detalhe. Tipos devem ser incluídos onde eles não são óbvios.
   Ressalvas devem ser claras.

5. *Instalação* -- se li até aqui embaixo, então eu estou decidido a experimentar
   o módulo. Se houver notas de instalação fora do padrão, aqui é onde eles vão,
   mas mesmo se for apenas um `inpm nstall` comum eu gostaria de saber isso também.
   Novos usuários começam a usar o Node todo o tempo, assim, ter um link para
   [npmjs.org](http://npmjs.org) e um comando de instalação lhes dá os recursos
   para descobrir como os módulos Node funcionam.

6. *Licença* -- a maioria dos módulos colocam isso na parte inferior, mas, na
   verdade, seria melhor ter mais acima. É provável que você decida muito
   rapidamente não usar um módulo se ele tiver uma licença incompatível com o seu
   trabalho. Eu geralmente uso os sabores MIT / BSD / X11 / ISC. Se você tiver
   uma licença não-permissiva, coloque-a no topo do módulo para evitar qualquer
   confusão.


## Afunilamento cognitivo

A ordenação acima não foi escolhida ao acaso.

Consumidores de módulos usam muitos módulos e precisam avaliar muitos módulos.

Uma vez que você olha centenas de módulos você começa a perceber que a mente se
beneficia de padrões previsíveis.

Você começa a desenvolver sua própria heurística sobre qual informação você quer
e quais as bandeiras vermelhas desqualificam um módulo rapidamente.

Assim, segue o que um bom README deve desejavelmente ter:

1. um formato previsível
2. a presença de alguns elementos-chave

Você não precisa usar *este* formato, mas tente ser consistente para poupar
tempo de processamento precioso do cérebro de seus usuários

A ordenação aqui apresentada é carinhosamente chamada de "afunilamento cognitivo",
e pode ser imaginada como um funil em posição vertical, em que a extremidade
mais larga contém os mais amplos detalhes pertinentes, e movendo-se mais
profundamente para dentro do funil, detalhes mais específicos que são pertinentes
apenas para um leitor que está suficientemente interessado em seu trabalho para
ter chegado tão a fundo no documento. Finalmente, a parte inferior pode ser
reservada para detalhes que somente aqueles intrigados com o mais profundo
contexto do trabalho (background, créditos, bibliografia, ...)

Mais uma vez, os monges Perl tem sabedoria para compartilhar sobre o assunto:

> O nível de detalhe de documentação de um módulo Perl geralmente vai de
> menos detalhada a mais detalhada. Sua seção SINOPSE deve conter um exemplo de
> utilização mínima (talvez tão pouco como uma única linha de código; ignorar os
> casos de uso incomuns ou qualquer coisa que não seja necessária para a maioria
> dos usuários); A descrição deve descrever o seu módulo em termos gerais,
> geralmente em apenas alguns parágrafos; mais detalhes do módulo de rotinas ou
> métodos, exemplos de códigos longos, ou outro material mais aprofundado deve ser
> dado nas secções subsequentes.
>
> O ideal é que alguém que é um pouco familiarizado com o seu módulo deve ser
> capaz de refrescar a sua memória sem chegar ao "fim da página". A medida que seu
> leitor continue a ler o documento, deve receber uma
> quantidade cada vez maior de conhecimento. -- de `perlmodstyle`


## Preocupe-se com o tempo das pessoas

Awesome; the ordering of these key elements should be decided by how quickly
they let someone 'short circuit' and bail on your module.

Isso soa sombrio, não é? Mas pense nisso: seu trabalho, quando você o está fazendo
com o altruísmo ideal em mente, não é "vender" as pessoas no seu trabalho. É
deixá-las avaliar o que sua criação faz o mais objetivamente possível, e decidir
se ela atende às suas necessidades ou não. Não para, digamos, maximizar seus
downloads ou base de usuários.

Essa mentalidade não é para todos; ela exige botar seu ego de lado e deixar o
trabalho falar por si, tanto quanto possível. Seu único trabalho é para descrever
sua promessa da forma mais sucinta possível, de modo caçadores de módulos podem
querer usar o seu trabalho quando lhes servir, ou buscar outro que sirva.


## Mãos à obra

Vá em frente, bravo desbravador de módulos, e faça o seu trabalho de descoberta
e utilização através de documentação de qualidade!


## Bônus: outras boas práticas

Fora dos pontos-chave do artigo, há outras práticas a seguir (ou não) para
aumentar o nível de qualidade do seu README ainda mais e maximizar a sua utilidade
para os outros.

1. Considere a inclusão de uma seção **Background** se o seu módulo depender de
   importantes mas não muito conhecidas abstrações ou outros ecosistemas. A
   função de [`bisecting-between`](https://github.com/noffle/bisecting-between)
   não é imediatamente óbvia a partir de seu nome, por isso tem uma detalhada
   seção *Background* para definir e referenciar os grandes conceitos e abstrações
   que é preciso entender para utiliza-lo. Este também é um ótimo lugar para
   explicar a motivação do módulo, se módulos semelhantes já existirem no NPM.

2. Referencie agressivamente! Se você falar sobre outros módulos, idéias ou
   pessoas, faça com que o texto referência um link para que os visitantes possam
   entender mais facilmente o seu módulo e as ideias em que ele se baseia. Existem
   alguns módulos em um vácuo: todo o trabalho vem de outros trabalhos, isso ajuda
   os usuários a seguir a história e inspiração do seu módulo.

3. Inclua a informação de tipos de argumentos e parâmetros de retorno se não
   forem óbvios. Prefira usar convenções sempre que possível. (`cb` provavelmente
   significa `callback function`, `num` provavelmente significa um `Número`).

4. Inclua o código de exemplo em **Utilização** como um arquio em seu repositório
   -- algo como `example.js`. É ótimo ter um código README que os usuários podem
   executar se clonarem seu repositório.

5. Seja criterioso no uso de badges. É fácil de [abusar](https://github.com/angular/angular). 
   Eles acrescentam ruído visual para o seu
   README, e geralmente só funcionam se o usuário estiver lendo seu markdown em
   um navegador on-line, uma vez que as imagens são geralmente hospedados em
   outros lugares na internet. Para cada badge, considere: "qual o real valor este
   badge está fornecendo para o leitor típico deste README"? Ter um badge CI para
   mostrar o status de build / testes? Este alerta seria melhor se enviado por
   e-mail para os mantenedores importantes do módulo ou criando uma issue
   automaticamente -- sempre considere o público dos dados no seu README e
   pergunte-se se há um fluxo de dados que pode atingir melhor o seu público-alvo.

6. API formatting is highly bikesheddable. Use whatever format you think is most
   clear, but make sure your format expresses important subtleties:

   a. quais parâmetros são opicionais, e quais seus valores default

   b. mencione tipos que não são óbivios por convenção

   c. para parâmetros de objetos `opts`, detalhe todas as chaves e valores aceitos

   d. não se acanhe de fornecer um pequeno exemplo do uso de uma função da API se
      seu uso não é óbvio ou totalmente coberto na seção **Utilização**.
      No entanto, isso também pode ser um sinal forte que a função é complexa demais
      e precisa ser reformulada, dividida em funções menores, ou removida
      completamente

   e. referencie agressivamente a terminologia! Em markdown você pode manter
      [footnotes](https://daringfireball.net/projects/markdown/syntax#link) no
      rodapéat do seu documento, por isso referencia-los várias vezes ao longo do
      documento torna-se barato. Algumas das minhas preferências pessoais na
      formatação de API podem ser encontradas
      [aqui](https://github.com/noffle/common-readme/blob/master/api_formatting.md)

7. Se seu módulo é uma pequena coleção de funções stateless, tenha uma seção
   **Utilização** como em [Node REPL session]
   (https://github.com/noffle/bisecting-between#example). Chamadas e resultados
   podem explicar a utilização de forma mais clara do que um arquivo de código-fonte
   para ser executado.

8. Se o seu módulo fornece uma CLI (command line interface) ao invés de (ou
   adicionalmente a) uma API, mostre exemplos de utilização como invocações de
   linha de comando e suas saídas. Se você criar ou modificar um arquivo, use
   `cat` para demonstrar o antes e o depois.

9.  Não se esqueça de usar
    [keywords](https://docs.npmjs.com/files/package.json#keywords) no `package.json`
    para direcionar os caçadores de módulos à sua porta.

10. Quanto mais você mudar a sua API, mais trabalho será necessário para mantê-la
    atualizada. Por isso você deve manter suas APIs pequenas e bem definidas desde
    o início. Requisitos mudam ao longo do tempo. Se os requisitos *mudam* e
    'fazer-uma-coisa-concreta' não faz mais sentido, simplesmente  escreva um novo
    módulo que faça o que você precisa. 'fazer-uma-coisa-concreta' continua um
    módulo válido e valoroso para o ecosistema npm. E o custo de uma correção é
    o de uma simples substituição de um módulo para outro.

11. Finally, please remember that your version control repository and its
    embedded README will outlive your [repository host](https://github.com) and
    any of the things you hyperlink to--especially images--so *inline* anything
    that is essential to future users grokking your work.


## Bônus: *common-readme*

Não por coincidência, este também é o formato utilizado por
[**common-readme**](https://github.com/noffle/common-readme), um conjunto de
README guidelines e geradores utilitários de linha-de-comando. Se você gostar do
que vir aqui, você talvez possa poupar algum tempo escrevendo READMEs com o
`common-readme`. Você encontrará módulos de verdade neste formato também.

Você também poderá gostar de
[standard-readme](https://github.com/richardlitt/standard-readme), que é mais
estruturado, lintable, em um formato comum de README.


## Bônus: Exemplos

A teroria é boa... Mas com o que READMEs excelentes se parecem? Aqui estão alguns
que eu acredito que aplicam bem os princípios deste artigo:

- https://github.com/noffle/ice-box
- https://github.com/substack/quote-stream
- https://github.com/feross/bittorrent-dht
- https://github.com/mikolalysenko/box-intersect
- https://github.com/freeman-lab/pixel-grid
- https://github.com/mafintosh/torrent-stream
- https://github.com/pull-stream/pull-stream
- https://github.com/substack/tape
- https://github.com/yoshuawuyts/vmd


Conhece outros bons exemplos? [Envie um pull request](https://github.com/noffle/art-of-readme/pulls)!


## Bonus: The README Checklist

Um prático checklist para você conferir como seu README está:

- [ ] Uma linha explicando o propósito do módulo
- [ ] Ligações e contextualizações necessárias
- [ ] Termos pontencialmente desconhecidos linkados a fontes de informações
- [ ] Exemplo de utilização claro e *executável*
- [ ] Instruções de instalação
- [ ] Documentação extensiva da API
- [ ] Realizar [afunilamento cognitivo](https://github.com/noffle/art-of-readme#cognitive-funneling)
- [ ] Advertências e limitações explícitas
- [ ] Não depender de imagens para transmitir informações importantes
- [ ] Licença


## O autor

Eu sou o [noffle](http://blog.eight45.net/about/). Sou conhecido por
[blog](http://blog.eight45.net), [tweet](https://twitter.com/noffle), e
[hack](https://github.com/noffle).

Este pequeno projeto começou em maio em Berlim na squatconf, onde eu estava
escavando a forma como os monges Perl escrevem sua documentação e também
lamentando o estado dos meus READMEs no ecosistema Node. Isso me estimulou a
criar o [common-readme](https://github.com/noffle/common-readme). A seção
"README Tips" transbordou de dicas e eu achei que poderia ser útil coletá-las
em um artigo sobre escrever READMEs. Assim, Art of README nasceu!


## Leitura adicional

- [README-Driven Development](http://tom.preston-werner.com/2010/08/23/readme-driven-development.html)
- [Documentation First](http://joeyh.name/blog/entry/documentation_first/)


## Notas de rodapé

1. <a name="footnote-1"></a>Obrigado,
   [Sixes666](https://www.reddit.com/r/node/comments/55eto9/nodejs_the_art_of_readme/d8akpz6)!

2. <a name="footnote-2"></a>Veja [The Jargon File](http://catb.org/~esr/jargon/html/R/README-file.html).
   Entretanto, a maioria dos sistemas de hoje em dia não organiza maiúsculas antes
   dos caracteres minúsculos, reduzindo a convenção a simplemente um apelo visual.


## Créditos

Um sincero agradecimento ao [@mafintosh](https://github.com/mafintosh) e
[@feross](https://github.com/feross) pelo incentivo que eu precisava para dar
vida a essa ideia e começar a escrever!

Obrigado aos incríveis leitores por reportar erros e enviar suas PRs :heart: :

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

Um agradecimento ao [@qihaiyan](https://github.com/qihaiyan) por traduzir o Art
of README para chinês! Os seguintes usuários também fizeram contribuições:

- [@BrettDong](https://github.com/brettdong) for revising punctuation in Chinese version.
- [@Alex-fun](https://github.com/Alex-fun)
- [@HmyBmny](https://github.com/HmyBmny)
- [@vra](https://github.com/vra)

Um agradecimento ao [@lennonjesus](https://github.com/lennonjesus) por traduzir
o Art of README para o Português Brasileiro! Os seguintes usuários também fizeram contribuições:

- [@rectius](https://github.com/rectius)

Um agradecimento ao [@jabiinfante](https://github.com/jabiinfante) por traduzir
o Art of README para o Espanhol!

Um agradecimento ao [@Ryuno-Ki](https://github.com/Ryuno-Ki) por traduzir
o Art of README para o Alemão! Os seguintes usuários também fizeram contribuições:

- [@randomC0der](https://github.com/randomC0der)

Um agradecimento ao [@Manfred Madelaine](https://github.com/Manfred-Madelaine-pro) e
[@Ruben Madelaine](https://github.com/Ruben-Madelaine)
por traduzir o Art of README para o Francês!

Finalmente, obrigado a todos pelo feedback! Por favor, compartilhe seus
comentários através de [issues](https://github.com/noffle/art-of-readme/issues)!


## Contribuições são bem vindas!

Encontrou um erro? Algo não faz sentido? Envie um [pull
request](https://github.com/noffle/art-of-readme/pulls)!

## Licença

[Creative Commons Attribution License](http://creativecommons.org/licenses/by/2.0/)
