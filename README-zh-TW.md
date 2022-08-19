# README 的藝術

*此文章也有 [簡體中文](README-zh.md)、[日文](README-ja-JP.md)、[巴西葡萄牙文](README-pt-BR.md)、[西班牙文](README-es-ES.md)、[德文](README-de-DE.md) 以及 [法文](README-fr.md)。*

## 詞源

「README」這個詞是從何而來？

命名的日期**至少**可以追溯到 1970 年以及 [PDP-10](http://pdp-10.trailing-edge.com/decuslib10-04/01/43,50322/read.me.html)，不過也有可能來自更早之前放在打孔卡片上資訊豐富的紙質筆記，上面潦草地寫著「READ ME!」。

有位讀者<sup>[1](#footnote-1)</sup> 則認為 README 可能來自於 Lewis
Carroll 的《愛麗絲夢遊仙境》，其中一個藥水及蛋糕分別被貼上 *"DRINK ME"* 及 *"EAT ME"*。

README 從出現開始都是全大寫的形式，除了全大寫形式的視覺衝擊力外，UNIX 系統大寫字母會排在小寫字母前面，因此 README 能顯示在其他內容之前<sup>[[2]](#footnote-2)</sup>。

這樣做的用途很明顯： *「這是給用戶在進行下一步之前閱讀的重要訊息」*。讓我們來看一下現在的 *「重要訊息」* 是怎麼構成的。 

## 給創作者及使用者

這是一篇關於 READMEs 的文章。關於它們的作用、為什麼它們絕對必要、以及如何精心製作它們。

這是為模組的創作者而寫，因為對於一個模組的創作者，你的工作是創作一些持久的東西，這是一種內在的動機，即使創作者無意分享他們的作品。一旦六個月過去，一個沒有文件的模組，作者也將開始覺得陌生。

這也是為了模組的使用者而寫，因為每個模組的作者也同時是一個模組的使用者。Node 有許多健康的相互依賴關係：沒有人會處在依賴樹的底部。

儘管內容主要是跟 Node 相關，作者認為也同樣適用於其他語言的生態系，

## 眾多模組，有好有壞
Node 的生態系源於他的模組們，[npm](https://npmjs.org) 是讓這一切 *開始* 的魔法。Node 開發者們每週都會評估專案中數十個模組。只要會寫 `npm install` 就能在日常生活中使用各種成熟的模組。

像其他容易使用的生態系，品質標準也各不相同。npm 盡最大努力打包所有模塊並分發到各處。然而，這些工具發現的種類繁多，有些閃亮又新，有些破損又生鏽。還有一些我們完全不知道他們在做什麼！

有些模組採用不準確或是無用的名字(猜猜看 `fudge` 這個模組是在做什麼？)、沒有文件、沒有測試、來源程式碼沒有註解或是難以理解的函式名稱。

許多模組沒有活躍的維護者。如果模組沒有人能夠回答問題以及解釋模組在做什麼，再加上沒有文件，模組將變成一個奇異的外星製品，無法使用且難以理解。

為什麼有些有文件的模組品質不好？有可能他們只有一行敘述：「按照十六進制對數字排序」。也有可能只有一段示範程式碼。這些都是毫無意義的改動，但卻使得模組使用者只能透過深入研究原始碼來了解其運作方式。撰寫出色的文件能讓使用者遠離原始碼，並透過抽象的方式了解模組的精彩之處。

Node 有「廣大」的生態系，它主要由一長串「只做好一件事」的模組組成。當然也有些 [例外](https://github.com/lodash/lodash)，儘管有些小領地，但 Node 王國主要還是由這些單一目的的平民統治著。

這有個後果：很難找到完全符合你需求的 *高品質* 模組。

**這也沒關係**。真的，低門檻及可發現性問題比只有少數特權人士可以參與的文化問題好。

此外，可發現性問題通常是容易解決的。

## 條條大路通 README.md
Node 社群已經用不同方式來解決可發現性的問題。

一些有經驗的 Node 開發者聯手創建有品質的模組[列表](https://github.com/sindresorhus/awesome-nodejs)。開發者利用多年研究數百的不同的模組，並分享每個類別裡最好的模組給新進者。也可能透過 RSS 訂閱以及被信任的社群成員視為有用的新模組郵件名單形式。

那社群圖譜呢？這個想法催生了 [node-modules.com](http://node-modules.com/)，一個替代 npm 搜尋的替代工具，利用 GitHub 的社群圖譜來找到你朋友喜歡或創建的模組。

當然還有 npm 內建的 [搜尋](https://npmjs.org) 功能：一個安全的預設功能，也是新開發者的常用入口。

無論用戶是透過 [npmjs.org](https://npmjs.org) 或 [github.com](https://github.com) 或其他地方找到模組，他們最終都會先看到你的 README，我們如何做到讓他們第一眼就印象深刻呢？

## 專業模組探討

## README：你的一站式服務

README 是模組使用者第一次(或許是唯一一次)查看你的創作。使用者想要模組滿組他們的需求，所以你必須準確地解釋模組滿足什麼需求，以及它如何有效地做到。

你的工作是：

1. 告訴他們這是什麼(利用場景)
2. 告訴他們實際使用上會是什麼樣子
3. 告訴他們要怎麼使用它
4. 告訴他們其他相關細節

這是*你的*工作。模組創作者有責任證明他們的作品是不嚴謹模組海洋中一顆閃亮的寶石。由於許多開發者會先看到你的 README，因此這會是公眾評量你作品的衡量標準。

## 簡潔

缺少 README 會是一個嚴重警訊，但即使有冗長的 README 也不代表高品質。理想的 README 盡可能簡短，但也不會太短。為詳細的文件單獨建立分頁，但請保持你的 README 簡潔。

## 向過去學習
有人說不研究歷史的人，注定重蹈覆徹。多年來，開發者一直撰寫文件，如果不回頭看看人們在 Node 之前是怎麼正確的撰寫文件，那就太浪費了。

Perl 儘管受到許多批評，某些方面上算是 Node 非實質的祖父母。兩者都是高階腳本語言，採用許多 UNIX 理念，為網路提供許多動力，並且都具有廣大的模組生態系。

事實證明 Perl 社群有許多[傳教士](http://perlmonks.org)在寫出[高品質 README](http://search.cpan.org/~kane/Archive-Tar/lib/Archive/Tar.pm) 有豐富的經驗。CPAN 是一個值得一讀的優秀資源，可以了解一個社群如何編寫一致的高品質文件。

### 沒有 README 就沒有抽象

沒有 README 就代表開發者將需要深入你的程式碼才能理解。

Perl 的傳教士曾分享此智慧：

> 當有人使用你的模組但不需要閱讀原始碼，你的文件就完成了。
> 這非常重要，因為這讓你分離模組文件介面與內部實作。
> 這是一件好事，因為這意味著只要介面保持不變，你可以自由更改模組的內部結構。
-- [Ken Williams](http://mathforum.org/ken/perl_modules.html#document)

### 關鍵要素

一旦有了 README，勇敢的模組探索者將閱讀它來確認是否符合開發者的需求。這基本上變成一系列思維模式，每一步都讓他們更深入了解模組及其細節。

例如，我搜尋 2D 碰撞檢測模組引導我找到 [`collide-2d-aabb-aabb`](https://github.com/hackergrrl/collide-2d-aabb-aabb)。我開始從頭到尾檢查：

1. *名稱*：不言自明的名稱是最好的。`collide-2d-aabb-aabb`聽起來很不錯，儘管它假設我知道什麼是 「aabb」。如果名稱聽起來太模糊或不相關，這可能會是我繼續查找其他模組的警訊。

2. *一行敘述*：透過一行敘述說明模組，有助於更詳細地了解模組的作用。如 `collide-2d-aabb-aabb` 這樣描述：

> 確認移動的軸對齊邊界框 (AABB) 是否與其他 AABB 碰撞。

太棒了，這行敘述定義了 AABB 是什麼，以及模組的作用。現在可以來衡量模組是否適合我的程式碼。

3. *用法*：與其開始深入研究 API 文件，不如先看模組在實際運用會是什麼樣子。我可以快速確認範例 JS 是否適合所需的程式碼樣式及想要解決的問題。許多人對於像是 promises/callbacks 和 ES6 有許多意見。如果確實符合需求，那麼我可以進一步深入研究細節。

4. *API*：如果這個模組的名稱、描述以及使用方式都很吸引我。在這點上，我非常有可能使用這個模組。我只需要再檢視 API 以確保模組完全符合我的需求，並且可以輕鬆整合到我的程式碼中。API 區塊應該詳細說明模組的物件及函式、它們的簽名、回傳型別、callbacks 以及事件。當型別包含在不明顯的地方時，注意事項要描述清楚。

5. *安裝*：如果我已經閱讀到這，代表我要開始試用這個模組了。如果不是通用的安裝說明，那就需要在這個區塊描述。即使只是一個常規的 `npm install`，我也希望看到它被提及。對於新使用 Node 的用戶，放一個指向 npmjs.org 的連結及安裝指令，可以讓用戶更快理解 Node 模組怎麼運作。

6. *授權*：大多數的模組會放在最後敘述，但最好還是往前放一些。如果某個模組的授權協議與你的工作不相符，你可以很快將其排除在外。我通常堅持使用 MIT/BSD/X11/ISC。如果你不想授權，最好將其放到最前面來避免造成混淆。

## 認知漏斗

上面提及的順序不是隨機選擇的。

使用者使用很多模組，需要查看很多模組。

一旦你看過數百個模組，你就會注意到使用可預測模式的好處。

你還會開始建立自己的策略來決定什麼資訊是你想要的，以及哪些危險訊號會讓你快速略過這些模組。

因此，README 應該包含以下資訊：

1. 可預測的格式
2. 存在某些關鍵要素

你不需要使用*這種*格式，但盡量保持一致以節省用戶寶貴的認知週期。

這裡提到的呈現順序被稱為「認知漏斗」，可以想像成一個直立的漏斗，其中最寬的一端包含最廣泛的相關細節，而深入漏斗則呈現出更具體的細節，只有對你的作品有足夠興趣的讀者才能深入了解這部分的細節。最後，底部只能保留給那些對你的作品更深層背景(背景、致謝、參考書目......等)有興趣的使用者。

再一次，Perl 傳教士分享在這個問題上的智慧：
> Perl 模組文件對於細節的詳細程度通常從少至多
> 你的 SYNOPSIS 部分應該包含一個最小的使用範例
> (可能只有一行程式碼；省略掉不常用的例子或多數用戶不需要的內容)
> 敘述文字應該廣泛地描述你的模組，通常只需要幾個段落就好；
> 後續的段落要給出更多模組 routines 或函式、較長的程式碼範例或其他底層要素細節
> 理想情況下，稍微熟悉你模組的人應該能夠在不點擊「下一頁」的情況下大致了解你的模組
> 隨著繼續閱讀，他們應該會獲得越來越多的知識。
> -- `perlmodstyle`

## 在意使用者的時間
很棒；這些關鍵要素的排序應取決於它們讓使用者「短路」並放棄使用你的模組的速度。

這是不是聽起來很淒涼？但應該這麼想：當你懷著最佳的利他主義做這件事時，你的工作不是推銷作品給別人，而是讓他們盡可能客觀的評估你的創作。並覺得它是否滿足他們的需求，而不是為了最大化你的下載量或使用數。

並不是每個人都有這種心態，這需要有自我約束和實事求是的態度。你唯一要做的是簡潔描述它的承諾，這樣模組探險者們就可以在合適的時候選擇使用你的作品或另尋其他模組。

## 號召戰鬥

勇往直前，勇敢的模組探險者，透過優秀的文件來讓你的作品被看見及使用。

## 額外補充：其他好做法

除了本文的重點外，你也可以遵循(或不遵循)其他做法，以進一步提高 README 的品質標準並最大限度地提高對其他人的實用性：

1. 如果你的模組依賴於重要但不廣為人知的抽象或其他生態系，請考慮加上**背景**區塊。[`bisecting-between`](https://github.com/hackergrrl/bisecting-between) 的功能並不能從它的名字就可以立即看出來，所以需要有詳細**背景**區塊來定義及連結到大概念及抽象，讓使用者能夠使用及理解。如果 npm 上已經有相似的模組，這也是一個解釋建立此模組動機的好地方。

2. 積極建立連結！如果你談論到其他模組、想法或其他人時，在參考文字上加上連結，可以讓造訪者更容易的了解你的模組背後的想法。很少模組是憑空誕生的，所有的作品都源自於其他作品，因此幫助使用者了解模組的歷史和靈感是值得的。

3. 當參數及返回值的型別不明顯時，請加上相對應的資訊。盡可能符合常用約定(`cb` 可能表示 callback、`num` 可能表示 `Number`)。

4. 在**用法**中示範的程式碼，要以文件的形式放在 repo 中，例如：`example.js`。這樣當用戶 clone 專案後，就可以直接執行 README 提及的程式碼。

5. 謹慎使用徽章，它們很容易被[濫用](https://github.com/angular/angular)。他們也可能是瑣碎事物及無止盡爭吵的溫床。它們會在你的 README 上增加視覺干擾，並且只有在用戶用連網瀏覽器閱讀你的 Markdown 時才能看到徽章，因為圖片是存放在網路空間。對於發放每個徽章，需要考慮：這個徽章對閱讀 README 的標準讀者有什麼真正的價值？你有 CI 徽章來顯示 build/test 狀態嗎？透過發送電子郵件給維護者或自動創建 issue，讓此訊號能更好的被接收到。永遠要考慮 README 數據中的受眾，並問自己是否有一個流程讓數據更容易觸及到目標受眾。

6. API 格式是可高度循環的。使用你認為最清晰的任何格式，但要確保你的格式表達了重要的細節：

    a. 哪些參數是可選的，以及他們的預設值
    b. 如果型別不像約定呈現，需包含型別資訊
    c. 對於 `opts` 物件參數，描述它所有可以接受的鍵與值
    d. 如果在**用法**區塊不明顯或沒有完全涵蓋，不要迴避提供使用 API 函數的小範例。但這也是一個警訊，表示該函數過於複雜，需要重構、分解為更小的函數或完全刪除
    e. 積極為專業術語加上連結！在 Markdown 中，你可以在文件底部加上[註腳](https://daringfireball.net/projects/markdown/syntax#link)，可以很方便的多次引用它們，我個人對於 API 格式的偏好可以查看[這裡](https://github.com/hackergrrl/common-readme/blob/master/api_formatting.md)   

7. 如果你的模組是一個小的無狀態函數集合，將**用法**區塊以 [Node REPL session](https://github.com/hackergrrl/bisecting-between#example)格式提供函數的呼叫及結果會比執行原始碼文件更清楚傳達使用方式。

8. 如果你的模組提供 CLI(指令介面)而不是 API，請提供使用範例程式如何呼叫指令和輸出。如果你創建或修改一個文件，`cat` 它示範前後的變化。

9. 別忘記使用 `package.json` 的關鍵字來引導模組探索者找到你的模組。

10. 你更改的 API 越多，更新文件所需的工作就越多。代表你應該在早期就保持 API 精簡且定義明確。需求隨著時間變化，但不是預先設計到 API 中，而是要將它們設計到抽象類別：模組集合自身。當需求確實**變化**時並且「只做一個具體的事」不再符合需求，那麼只需要寫一個新模組來完成需求。「只做一個具體的事」模組仍然是 npm 生態系中一個有效且有價值的模型，而你的改進過程只是簡單用一個模組替換另一個模組。

11. 最後請記住，你的版本控制專案及內嵌入的 README 存在時間將比你的[專案託管](https://github.com)或任何你連結的事物，特別是圖片都要長久。因此*內連*任何對未來使用者了解你的作品至關重要的內容。

## 額外補充：*常見 README*
並非巧合，這也是 [**common-readme**](https://github.com/hackergrrl/common-readme) 使用的格式，一套 README 指南及方便的指令產生器。如果你喜歡這篇文章，你也可以透過 `common-readme` 來節省撰寫 README 的時間。你也可以找到使用這種格式的真實模組範例。

你也可以在 [standard-readme](https://github.com/richardlitt/standard-readme) 享受更架構化的通用 README 格式。

## 額外補充：範例
理論總是很好，但優秀的 README 長什麼樣子？以下是我認為很好體現本文原則的範例：

- https://github.com/hackergrrl/ice-box
- https://github.com/substack/quote-stream
- https://github.com/feross/bittorrent-dht
- https://github.com/mikolalysenko/box-intersect
- https://github.com/freeman-lab/pixel-grid
- https://github.com/mafintosh/torrent-stream
- https://github.com/pull-stream/pull-stream
- https://github.com/substack/tape
- https://github.com/yoshuawuyts/vmd

## 額外補充：README 檢查表

一個實用的檢查表來衡量你的 README：

- [ ] 用一行解釋模組的用途
- [ ] 必要的背景資料與連結
- [ ] 將可能不熟悉的術語連結到資訊來源
- [ ] 清楚、*可運行*的使用範例
- [ ] 安裝說明
- [ ] 詳細的 API 文件
- [ ] 執行[認知漏斗](#認知漏斗)
- [ ] 預先提及注意事項和限制
- [ ] 不依賴圖像傳遞重要訊息
- [ ] 授權

## 作者

你好，我是 [Kira](http://kira.solar)。

這個小專案從五月在柏林的 squatconf 開始，我在那裡深入研究 Perl 傳教士如何撰寫他們的文件，同時也感嘆 Node 生態系中 README 的狀態。這促使我建立 [common-readme](https://github.com/hackergrrl/common-readme)。雖然 "README Tips" 區塊充滿了提示，我仍然決定撰寫一篇關於撰寫 README 的文章。於是，Art of README 誕生了！

## 延伸閱讀

- [README-Driven Development](http://tom.preston-werner.com/2010/08/23/readme-driven-development.html)
- [Documentation First](http://joeyh.name/blog/entry/documentation_first/)

## 註腳

1. <a name="footnote-1"></a>感謝 [Sixes666](https://www.reddit.com/r/node/comments/55eto9/nodejs_the_art_of_readme/d8akpz6)！

2. <a name="footnote-2"></a>查看 [The Jargon File](http://catb.org/~esr/jargon/html/R/README-file.html)。但是，現今大多數系統不會將大寫符號排在小寫符號之前，降低了這個約定的作用，全部大寫只能造成視覺衝擊性。

## 致謝

衷心感謝 [@mafintosh](https://github.com/mafintosh) 及 [@feross](https://github.com/feross) 鼓勵我構思這個想法及開始寫作！

感謝以下出色的讀者注意到錯誤並向我發出 PR :heart: :

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

感謝 [@qihaiyan](https://github.com/qihaiyan) 將 Art of README 翻譯成簡體中文！以下用戶也做出貢獻：

- [@BrettDong](https://github.com/brettdong) 修改中文版本的標點符號。
- [@Alex-fun](https://github.com/Alex-fun)
- [@HmyBmny](https://github.com/HmyBmny)
- [@vra](https://github.com/vra)

感謝 [@lennonjesus](https://github.com/lennonjesus) 將 Art of README 翻譯成巴西葡萄牙文！ 以下用戶也做出了貢獻：

- [@rectius](https://github.com/rectius)

感謝 [@jabiinfante](https://github.com/jabiinfante) 將 Art of README 翻譯成西班牙文！

感謝 [@Ryuno-Ki](https://github.com/Ryuno-Ki) 將 Art of README 翻譯成德文！ 以下用戶也做出了貢獻：

- [@randomC0der](https://github.com/randomC0der)

感謝 [@Manfred Madelaine](https://github.com/Manfred-Madelaine-pro) 和 [@Ruben Madelaine](https://github.com/Ruben-Madelaine) 將 Art of README 翻譯成法文！

## 其他資源
一些讀者為 README 組件推薦了其他有用的資源：
- [Software Release Practice](https://tldp.org/HOWTO/Software-Release-Practice-HOWTO/distpractice.html#readme)
- [GNU Releases](https://www.gnu.org/prep/standards/html_node/Releases.html#index-README-file)

## 授權

[Creative Commons Attribution License](http://creativecommons.org/licenses/by/2.0/)
