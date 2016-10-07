# Art of README

## 名词解释

"README"这个词从何而来？

正式命名的日期可以追溯到 *至少* 1970年 [参见
PDP-10](http://pdp-10.trailing-edge.com/decuslib10-04/01/43,50322/read.me.html),
更早的年代可能是在那些放在打孔卡片上的便签纸，上面潦草的写着“READ ME !”。

有的读者开了个玩笑，认为“README”应该是来自于“爱丽丝漫游仙境”，一瓶药水和一个月饼上分别贴着 *"DRINK ME"* 和 *"EAT ME"* 的标签。 

README这个词从出现开始就一直是大写的。除了大写单词更醒目之外，UNIX类系统中大写字母会排在小写字母的前面，这样README就会显示在其它内容的前面
<sup>[2](#footnote-2)</sup>。

这样做的目的显而易见：*“这是进行下一步之前的重要信息”*。让我们来看一下在现代“重要信息”是怎么构成的。


## 针对创建者和使用者

这是一篇关于README的文章，介绍了做什么，为什么要做，怎么才能做好。

这是写给模块创建者的，模块创建者的工作是创建一些能持续的东西，这是一种内在的动机，尽管作者可能并没想分享他的工作。一个没有文档的模块，往往时隔6个月后，就连作者自己都会觉得陌生。

这也是写给模块使用者的，每个模块的作者同时也是该模块的使用者。
Node有一个非常健康的依赖关联度：没人会处在依赖树的底部。

尽管内容主要是根Node相关，也同样适用于其它语言的生态系统。


## 很多模块，有好有坏

Node的生态系统源于它的模块，[npm](https://npmjs.org)起着 *关键* 作用。Node开发人员每周都会评估包含在他们的项目中的几十个模块。只要会写`npm install`，就能在日常工作中使用各种成熟的模块。

npm可以非常方便的对模块进行打包和分发，但是质量却是良莠不齐：有新的，有旧的，甚至有些连用途都不知道。

什么是坏的模块，就是名字不清晰，没有文档，没有测试，没有注释，函数名字不易于理解。 

很多模块没有活跃的维护者。如果一个模块没人回答问题或者说明模块的用途，再加上没有文档，就会变成一个火星上的东西，不可用并难以理解。

那些有文档的模块质量不好的原因又是什么？有的是因为文档里只有一行描述: `"sorts numbers by their hex
value"`。有的是因为文档里只是一些代码片段。这使得模块使用者只能通过阅读源码来理解模块是怎么工作的。编写优秀的文档可以使用户不用阅读源码就能理解你模块的精妙之处。

Node的生态环境非常广泛：由大量的“只做一件事”的模块构成。当然也有[例外](https://github.com/lodash/lodash)，像lodash这样的全家桶。

这就有一个易于发现的问题：找到你想要的 *高质量* 模块很困难。

**This is okay.** 低入门槛的生态和易于发现的问题总比封闭的生态要好的多。

并且，事实证明易于发现的问题总是容易解决的。


## 条条大路通向 README.txt

Node 社区已经用不同的方法来着手解决可发现性的问题。

一些有经验的Node开发者合力创建了高质量模块的列表[curated
lists](https://github.com/sindresorhus/awesome-nodejs)，筛选出了每个类别里的最好的模块。

受到社交图谱的启发，一个替代`npm search`的查找工具[node-modules.com](http://node-modules.com/)利用Github的社交图谱来查找你的朋友喜欢或创建的模块。

当然新的开发者还是可以用npm自带的 [search](https://npmjs.org) 功能。

用户无论是在[npmjs.org](https://npmjs.org) 或者
[github.com](https://github.com) 或在其它途径发现了你的模块，首先映入他们眼帘的是README。如何在这惊鸿一瞥中给他们留下深刻的印象？

## 职业的模块勘探

### The README: 你的一站式服务

README 是使用者首先（或唯一）审视你作品的入口。用户希望模块能满足他们的需要，所以你要清楚的说明你的模块的主要作用和优势。

你要做的是

1. 告诉他们这是什么 (使用场景)
2. 告诉他们在实际使用中是什么样子
3. 告诉他们使用的方法
4. 告诉他们其它相关的细节

这是 *你* 的工作。模块作者要证明他的作品在众多模块中是廖落星辰里的璀璨明珠。既然很多开发者第一眼看到的是你的README，README的编写质量决定了是否能给人留下好的第一印象。


### 简洁

README必须要有，但是README内容的长度和质量没什么关系。理想的README应该尽可能的短。详细的文档可以在单独的页面里描述。保持README的简洁。


### 以史为鉴

古人云：以史为鉴，可以知兴替。开发者编写文档已经有多年的历史了。值得我们花时间去看看在Node之前人们是怎么正确写文档的。

在某些方面，Node跟Perl非常类似。都是高级脚本语言，采用了很多UNIX的理念，推动了互联网的发展，都有广泛的模块生态系统。

结果表明[monks](http://perlmonks.org) Perl 社区在编写
[高质量
READMEs](http://search.cpan.org/~kane/Archive-Tar/lib/Archive/Tar.pm)方面很有经验。CPAN 是值得仔细阅读的优秀资源， 可以学到一个社区如何能够始终如一的编写出高质量的文档。


### 没有 README 就没有抽象

没有README意味着开发者需要阅读源码才能理解你的模块。

Perl圣僧们所分享的智慧：

> 只要你的文档时完备的，
> 用户就可以直接使用你的模块而无需去阅读源码。这是非常重要的。
> 通过文档可以在很大程度上将你的模块的外部接口和内部实现进行分离。
> 这样就可以在保持接口不变的情况下，灵活的修改内部实现。
>
> 记住: 对模块进行定义的是文档而不是代码。
-- [Ken Williams](http://mathforum.org/ken/perl_modules.html#document)


### 关键要素

有了README之后，勇敢的模块探险家会阅读它来判断模块是否满足开发者的需要。这是他们的思维模式，一步一步的去了解模块的细节。

比如说，当我想要一个2D碰撞检测模块时我找到了[`collide-2d-aabb-aabb`](https://github.com/noffle/collide-2d-aabb-aabb)。
我开始从头开始检查这个模块：

1. *Name* -- 名字含义非常清楚 `collide-2d-aabb-aabb`， 尽管它假设我知道"aabb"是什么意思。如果名字含义非常模糊或与我要找的没什么关系，我就会继续查找其它的模块了。

2. *One-liner* -- 通过一句话简明扼要的说明了这个模块是做什么的。
   `collide-2d-aabb-aabb` 的描述是：

   > Determines whether a moving axis-aligned bounding box (AABB) collides with
   > other AABBs.

   太棒了：描述了 AABB 的定义是什么，并且说明了这个模块是做什么的。现在开始评测它是否适合我的代码:

3. *Usage* -- 在开始探究API文档之前，最好看看这个模块在实际应用中是什么样子。我可以快速决定用JS写的示例程序是否符合我的代码样式和我要解决的问题。人们会在很多问题上意见相左，比如 promises/callbacks 和 ES6。如果符合我的要求，我会进一步去研究细节。

4. *API* -- 模块的名字，描述和使用方法都符合我的胃口。在这一点上我很乐意使用这个模块。我需要浏览API来确定这就是我需要的，并且很容易整合到我的代码中。API 部分应该详述模块的对象和函数，以及它们的签名，返回值，回调和事件。当类型不是特别明显的时候，也无需进行描述。注意事项要描述清楚。

5. *Installation* -- 当我读到这儿的时候我就要开始试用这个模块了。 如果不是通用的安装说明，就需要在这儿进行描述。即使是一句简单的`npm install`也好。 对于使用Node的新用户来说，放一个指向npmjs.org的链接和安装命令，可以让用户快速上手使用模块。

6. *License* -- 大多数模块把这个放在最末尾，但是最好还是往前放一些；非常有可能在把这个模块整合完后才发现License不合适。我通常使用MIT/BSD/X11/ISC。如果你的License不是很宽容，最好是放到最前面。

## 认知漏斗

上面的顺序不是随意选择的。

模块使用者需要用到很多模块，需要查看很多模块。

当你查看了上百个模块之后，就可以体会到使用可以预测的模式的好处。

你也开始建立你自己的策略来快速的决定哪些是你需要的，哪些是不需要的。

因此，README应该包涵一下信息:

1. 一个可以预测的格式
2. 某些关键元素

你不必非要用 *这个* 格式，但要保持统一以符合你的用户的认知习惯。

这儿介绍的顺序被简称为“认知漏斗”，
可以想象成是一个直立的漏斗，最宽的部分相关细节最宽泛，越往下移动细节越具体，只有对你的作品足够感兴趣的人才会关注这部分内容。最后，底部可以放一些作品背景的细节 (background，credits，biblio，...)

再一次，Perl圣僧们在这个主题上分享了他们的智慧：

> Perl模块的文档对于细节的描述是从少到多的。 
> 你的简介部分应该包涵一个小的例子程序
> （或许只有一行代码，省略掉不常用的用例或大多数用户用不到的功能）
> 描述部分应该从总体上描述你的模块，
> 通常只需要几个段落；在随后的章节中再详细描述模块的例程或方法，长的代码示例，或其它的资料。
> 理想情况下，在点“下一页”之前就能让人大体上了解你的模块。
> 随着用户继续阅读文档，他们能够渐进的获得更多的知识。
>  -- from `perlmodstyle`


## 珍惜时间

很棒；这些关键要素的排序应该让人尽快“短路”并放弃你的模块。

这听起来有点凄凉，不是吗？但是要这样想：你的工作，当你用利他主义思想来做的时候，不是为了销售给别人，而是为了让人们尽可能客观公正的评估你的作品，并判断是否满足他们的需要。而不是让你的下载量和用户数最大化。（老外的思想境界真是高）

并不是每个人都有这样的心态；这需要有自我约束和实事求是的态度。你唯一要做的是简洁的描述它的承诺，这样模块探险者们就可以或者使用你的作品或者别求他寻。

## 奖励: 其它好的实践

在文章的重点之外，有其它的实践你可以遵循(或不遵循)来提高你的README的质量，最大限度地发挥其作用。

1. 考虑包涵一个 **Background** 部分，如果你的模块依赖于重要但是不为人所熟知的抽象或生态系统。[`bisecting-between`](https://github.com/noffle/bisecting-between)的函数从它的名字上看不是特别明显，所以在 *Background* 部分会描述定义，并且给出具体概念和抽象的链接，以便需要的人去使用和获取。如果已经有相似的模块在npm上存在了，这儿也是一个非常适合描述建立模块的动机的地方。

2. 积极建立连接！如果你谈及其它的模块，想法，或者其他人的时候，在相关的引用内容上加上链接，这样访客就可以很容易的得到你的模块背后的想法。极少有模块是凭空诞生的：所有的作品来源于其它作品，因此很有必要让用户追溯你的模块的历史和灵感。

3. 包涵参数和返回值的类型的信息，当这些信息不明确的时候。 尽可能的符合约定(`cb` 代表回调函数，`num` 代表 `Number`)。

4. 在 **Usage** 部分包含的示例代码，要在repo中以文件的形式体现 -- 例如`example.js`。这样当用户clone项目后，就可以直接运行README中提及的代码。

5. 使用徽章要慎重。经常会被
   [滥用](https://github.com/angular/angular)。它们会容易引起争论。它们在你的README中加入了视觉噪声，并且只有当用户在联网的浏览器里阅读你的markdown时才能看到徽章，因为图片是存放在互联网上的其它地方。对于每一个徽章，需要考虑：README中的徽章提供给典型读者的真实含义是什么？用一个CI徽章来显示build/test状态？这个信号更应该发邮件给维护者，或者自动创建一个issue -- 永远要考虑你的README中的数据的受众并且自问一下是否有一个流程能够让数据更好的送达到目标受众。

6. API 文档格式没有局限。使用任何你认为是清晰的格式，但是要包含重要的细节：

   a. 参数是否可选，以及默认值

   b. 包含类型信息，如果类型不能清楚的根据约定进行体现

   c. 对于 `opts` 对象参数，描述它所接受的所有的 keys 和 values

   d. 为每个API提供一个小的调用示例，如果它们的用法不明显或是在 **Usage** 部分没有体现。
      不过，也有可能是函数太复杂了，需要进行重构，划分成更细粒度的函数，或者整体删除。

   e. 为特殊术语建立链接! 在markdown中你可以把
      [footnotes](https://daringfireball.net/projects/markdown/syntax#link) 放在文档的末尾，可以很方便的多次引用它们。[这儿](https://github.com/noffle/common-readme/blob/master/api_formatting.md)有一些我的API文档格式的个人偏好。

7. 如果你的模块是无状态函数的一个小的集合，在
   **Usage** 部分以 [Node REPL
   session](https://github.com/noffle/bisecting-between#example) 格式放一些调用和返回值的示例比运行一个示例文件更清晰。

8. 如果你的模块提供了 CLI (command line interface)而不是 API，用命令调用的方式展示调用示例和输出。如果你创建了或更改了一个文件， `cat` 它来展示更改前后的变化。

9. 不要忘记使用 `package.json`
    [keywords](https://docs.npmjs.com/files/package.json#keywords) 来盛情邀请模块探险者们。

10. API改的越多，越要努力的去更新文档 -- 言外之意是让你的API
    精简并及早给出具体定义。需求一直在变化，但是我们要做的是建立一个抽象层: 模块集合本身，而不是在API中做提前的假设。当需求
    *变更* 时，并且'只做一件事'不能满足要求的时候，只需写一个新的模块。 '只做一件事'对npm生态系统来说能够使一个模块是有效的和有价值的，并且你的改进过程只是简单的用一个模块来替换另一个模块。

11. 最后，请记住你的版本控制仓库和其中的README存在的时间要比你的 [repository host](https://github.com) 和你链接到的其它任何东西--特别是图片--的时间都要长久。所以 *inline* 任何对将来要获取你的作品的用户来说是重要的东西。

## 奖励：*common-readme*

不是巧合， 这也是
[**common-readme**](https://github.com/noffle/common-readme)用的文档格式，一个README写作指南和方便的command-line生成器。如果你喜欢这儿的内容，
通过`common-readme`你可以节省编写README的时间。你也可以找到使用这个格式的真实的模块的例子。

## 战斗的召唤！

前进，勇敢的模块探险家，通过出色的文档，让你的作品能够被发现和使用！

## 作者

我是 [noffle](http://blog.eight45.net/about/)。联系方式：
[blog](http://blog.eight45.net)，[tweet](https://twitter.com/noffle)，和
[hack](https://github.com/noffle).

这个小项目于5月份诞生在柏林的squatconf，在那儿我钻研Perl的圣僧们怎么编写他们的文档，同时叹息在Node生态系统中的我写的README。它促使我创建了
[common-readme](https://github.com/noffle/common-readme)。尽管"README Tips"部分满是tips，我仍然决定集中写一篇关于如果编写README的文章。于是，Art of README诞生了!


## Footnotes

1. <a name="footnote-1"></a>Thanks,
   [Sixes666](https://www.reddit.com/r/node/comments/55eto9/nodejs_the_art_of_readme/d8akpz6)!

1. <a name="footnote-2"></a>See [The Jargon File](http://catb.org/~esr/jargon/html/R/README-file.html).
   然而，现在的多数系统不会将大些字母排在小写字母前面，弱化了这个约定的作用，全部大写只能是在视觉上更显著。

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
- [@StevenMaude](https://github.com/StevenMaude)
- [@hejx](https://github.com/Alex-fun)

And thanks to my readers for their overall feedback:

- [entiat_blues](https://www.reddit.com/r/node/comments/55eto9/nodejs_the_art_of_readme/d8am9w5)


## Pull requests welcome!

Spotted an error? Something doesn't make sense? Send me a [pull
request](https://github.com/noffle/art-of-readme/pulls)!
