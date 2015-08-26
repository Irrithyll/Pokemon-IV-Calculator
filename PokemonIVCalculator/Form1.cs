using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PokemonIVCalculator
{
    public partial class Form1 : Form

    {
        /*
        hardy,2,2
        bold,2,3
        modest,2,4
        calm,2,5
        timid,2,6
        lonely,3,2
         * 
        docile,3,3
        mild,3,4
        gentle,3,5
        hasty,3,6
        adamant,4,2
        impish,4,3
        bashful,4,4
        careful,4,5
        rash,5,4
        jolly,4,6
        naughty,5,2
        lax,5,3
        quirky,5,5
        naive,5,6
        brave,6,2
        relaxed,6,3
        quiet,6,4
        sassy,6,5
        serious,6,6
        */
        /*
        public readonly static IDictionary<string, string> Natures = new Dictionary<string, string>{
            {"Hardy", "22"},
            {"Bold", "23"},
            {"Modest", "24"},
            {"Calm","25"},
            {"Timid", "26"},
            {"Lonely", "32"},
            {"Docile", "33"},
            {"Mild", "34"},
            {"Gentle", "35"},
            {"Hasty", "36"},
            {"Adamant", "42"},
            {"Impish", "43"},
            {"Bashful", "44"},
            {"Careful", "45"},
            {"Rash", "54"},
            {"Jolly", "46"},
            {"Naughty", "52"},
            {"Lax", "53"},
            {"Quirky","55"},
            {"Naive", "56"},
            {"Brave", "62"},
            {"Relaxed", "63"},
            {"Quiet", "64"},
            {"Sassy", "65"},
            {"Serious", "66"}   
        };
        */

        string[] natures = new string[]{
        "Hardy","Bold","Modest","Calm","Timid","Lonely","Docile","Mild","Gentle","Hasty","Adamant","Impish",
        "Bashful","Careful","Rash","Jolly","Naughty","Lax","Quirky","Naive","Brave","Relaxed","Quiet","Sassy","Serious"
        };

        public readonly static IDictionary<string, int> Ids = new Dictionary<string, int>
        {
            { "bulbasaur", 001 },
            { "ivysaur", 002 },
            { "venusaur", 003 },
            { "charmander", 004 },
            { "charmeleon", 005 },
            { "charizard", 006 },
            { "squirtle", 007 },
            { "wartortle", 008 },
            { "blastoise", 009 },
            { "caterpie", 010 },
            { "metapod", 011 },
            { "butterfree", 012 },
            { "weedle", 013 },
            { "kakuna", 014 },
            { "beedrill", 015 },
            { "pidgey", 016 },
            { "pidgeotto", 017 },
            { "pidgeot", 018 },
            { "rattata", 019 },
            { "raticate", 020 },
            { "spearow", 021 },
            { "fearow", 022 },
            { "ekans", 023 },
            { "arbok", 024 },
            { "pikachu", 025 },
            { "raichu", 026 },
            { "sandshrew", 027 },
            { "sandslash", 028 },
            { "nidoran f", 029 },
            { "nidoran-f", 029 },
            { "nidorina", 030 },
            { "nidoqueen", 031 },
            { "nidoran m", 032 },
            { "nidoran-m", 032 },
            { "nidorino", 033 },
            { "nidoking", 034 },
            { "clefairy", 035 },
            { "clefable", 036 },
            { "vulpix", 037 },
            { "ninetales", 038 },
            { "jigglypuff", 039 },
            { "wigglytuff", 040 },
            { "zubat", 041 },
            { "golbat", 042 },
            { "oddish", 043 },
            { "gloom", 044 },
            { "vileplume", 045 },
            { "paras", 046 },
            { "parasect", 047 },
            { "venonat", 048 },
            { "venomoth", 049 },
            { "diglett", 050 },
            { "dugtrio", 051 },
            { "meowth", 052 },
            { "persian", 053 },
            { "psyduck", 054 },
            { "golduck", 055 },
            { "mankey", 056 },
            { "primeape", 057 },
            { "growlithe", 058 },
            { "arcanine", 059 },
            { "poliwag", 060 },
            { "poliwhirl", 061 },
            { "poliwrath", 062 },
            { "abra", 063 },
            { "kadabra", 064 },
            { "alakazam", 065 },
            { "machop", 066 },
            { "machoke", 067 },
            { "machamp", 068 },
            { "bellsprout", 069 },
            { "weepinbell", 070 },
            { "victreebel", 071 },
            { "tentacool", 072 },
            { "tentacruel", 073 },
            { "geodude", 074 },
            { "graveler", 075 },
            { "golem", 076 },
            { "ponyta", 077 },
            { "rapidash", 078 },
            { "slowpoke", 079 },
            { "slowbro", 080 },
            { "magnemite", 081 },
            { "magneton", 082 },
            { "farfetchd", 083 },
            { "doduo", 084 },
            { "dodrio", 085 },
            { "seel", 086 },
            { "dewgong", 087 },
            { "grimer", 088 },
            { "muk", 089 },
            { "shellder", 090 },
            { "cloyster", 091 },
            { "gastly", 092 },
            { "haunter", 093 },
            { "gengar", 094 },
            { "onix", 095 },
            { "drowzee", 096 },
            { "hypno", 097 },
            { "krabby", 098 },
            { "kingler", 099 },
            { "voltorb", 100 },
            { "electrode", 101 },
            { "exeggcute", 102 },
            { "exeggutor", 103 },
            { "cubone", 104 },
            { "marowak", 105 },
            { "hitmonlee", 106 },
            { "hitmonchan", 107 },
            { "lickitung", 108 },
            { "koffing", 109 },
            { "weezing", 110 },
            { "rhyhorn", 111 },
            { "rhydon", 112 },
            { "chansey", 113 },
            { "tangela", 114 },
            { "kangaskhan", 115 },
            { "horsea", 116 },
            { "seadra", 117 },
            { "goldeen", 118 },
            { "seaking", 119 },
            { "staryu", 120 },
            { "starmie", 121 },
            { "mr mime", 122 },
            { "mr-mime", 122 },
            { "scyther", 123 },
            { "jynx", 124 },
            { "electabuzz", 125 },
            { "magmar", 126 },
            { "pinsir", 127 },
            { "tauros", 128 },
            { "magikarp", 129 },
            { "gyarados", 130 },
            { "lapras", 131 },
            { "ditto", 132 },
            { "eevee", 133 },
            { "vaporeon", 134 },
            { "jolteon", 135 },
            { "flareon", 136 },
            { "porygon", 137 },
            { "omanyte", 138 },
            { "omastar", 139 },
            { "kabuto", 140 },
            { "kabutops", 141 },
            { "aerodactyl", 142 },
            { "snorlax", 143 },
            { "articuno", 144 },
            { "zapdos", 145 },
            { "moltres", 146 },
            { "dratini", 147 },
            { "dragonair", 148 },
            { "dragonite", 149 },
            { "mewtwo", 150 },
            { "mew", 151 },
            { "chikorita", 152 },
            { "bayleef", 153 },
            { "meganium", 154 },
            { "cyndaquil", 155 },
            { "quilava", 156 },
            { "typhlosion", 157 },
            { "totodile", 158 },
            { "croconaw", 159 },
            { "feraligatr", 160 },
            { "sentret", 161 },
            { "furret", 162 },
            { "hoothoot", 163 },
            { "noctowl", 164 },
            { "ledyba", 165 },
            { "ledian", 166 },
            { "spinarak", 167 },
            { "ariados", 168 },
            { "crobat", 169 },
            { "chinchou", 170 },
            { "lanturn", 171 },
            { "pichu", 172 },
            { "cleffa", 173 },
            { "igglybuff", 174 },
            { "togepi", 175 },
            { "togetic", 176 },
            { "natu", 177 },
            { "xatu", 178 },
            { "mareep", 179 },
            { "flaaffy", 180 },
            { "ampharos", 181 },
            { "bellossom", 182 },
            { "marill", 183 },
            { "azumarill", 184 },
            { "sudowoodo", 185 },
            { "politoed", 186 },
            { "hoppip", 187 },
            { "skiploom", 188 },
            { "jumpluff", 189 },
            { "aipom", 190 },
            { "sunkern", 191 },
            { "sunflora", 192 },
            { "yanma", 193 },
            { "wooper", 194 },
            { "quagsire", 195 },
            { "espeon", 196 },
            { "umbreon", 197 },
            { "murkrow", 198 },
            { "slowking", 199 },
            { "misdreavus", 200 },
            { "unown", 201 },
            { "wobbuffet", 202 },
            { "girafarig", 203 },
            { "pineco", 204 },
            { "forretress", 205 },
            { "dunsparce", 206 },
            { "gligar", 207 },
            { "steelix", 208 },
            { "snubbull", 209 },
            { "granbull", 210 },
            { "qwilfish", 211 },
            { "scizor", 212 },
            { "shuckle", 213 },
            { "heracross", 214 },
            { "sneasel", 215 },
            { "teddiursa", 216 },
            { "ursaring", 217 },
            { "slugma", 218 },
            { "magcargo", 219 },
            { "swinub", 220 },
            { "piloswine", 221 },
            { "corsola", 222 },
            { "remoraid", 223 },
            { "octillery", 224 },
            { "delibird", 225 },
            { "mantine", 226 },
            { "skarmory", 227 },
            { "houndour", 228 },
            { "houndoom", 229 },
            { "kingdra", 230 },
            { "phanpy", 231 },
            { "donphan", 232 },
            { "porygon2", 233 },
            { "stantler", 234 },
            { "smeargle", 235 },
            { "tyrogue", 236 },
            { "hitmontop", 237 },
            { "smoochum", 238 },
            { "elekid", 239 },
            { "magby", 240 },
            { "miltank", 241 },
            { "blissey", 242 },
            { "raikou", 243 },
            { "entei", 244 },
            { "suicune", 245 },
            { "larvitar", 246 },
            { "pupitar", 247 },
            { "tyranitar", 248 },
            { "lugia", 249 },
            { "ho-oh", 250 },
            { "ho oh", 250 },
            { "celebi", 251 },
            { "treecko", 252 },
            { "grovyle", 253 },
            { "sceptile", 254 },
            { "torchic", 255 },
            { "combusken", 256 },
            { "blaziken", 257 },
            { "mudkip", 258 },
            { "marshtomp", 259 },
            { "swampert", 260 },
            { "poochyena", 261 },
            { "mightyena", 262 },
            { "zigzagoon", 263 },
            { "linoone", 264 },
            { "wurmple", 265 },
            { "silcoon", 266 },
            { "beautifly", 267 },
            { "cascoon", 268 },
            { "dustox", 269 },
            { "lotad", 270 },
            { "lombre", 271 },
            { "ludicolo", 272 },
            { "seedot", 273 },
            { "nuzleaf", 274 },
            { "shiftry", 275 },
            { "taillow", 276 },
            { "swellow", 277 },
            { "wingull", 278 },
            { "pelipper", 279 },
            { "ralts", 280 },
            { "kirlia", 281 },
            { "gardevoir", 282 },
            { "surskit", 283 },
            { "masquerain", 284 },
            { "shroomish", 285 },
            { "breloom", 286 },
            { "slakoth", 287 },
            { "vigoroth", 288 },
            { "slaking", 289 },
            { "nincada", 290 },
            { "ninjask", 291 },
            { "shedinja", 292 },
            { "whismur", 293 },
            { "loudred", 294 },
            { "exploud", 295 },
            { "makuhita", 296 },
            { "hariyama", 297 },
            { "azurill", 298 },
            { "nosepass", 299 },
            { "skitty", 300 },
            { "delcatty", 301 },
            { "sableye", 302 },
            { "mawile", 303 },
            { "aron", 304 },
            { "lairon", 305 },
            { "aggron", 306 },
            { "meditite", 307 },
            { "medicham", 308 },
            { "electrike", 309 },
            { "manectric", 310 },
            { "plusle", 311 },
            { "minun", 312 },
            { "volbeat", 313 },
            { "illumise", 314 },
            { "roselia", 315 },
            { "gulpin", 316 },
            { "swalot", 317 },
            { "carvanha", 318 },
            { "sharpedo", 319 },
            { "wailmer", 320 },
            { "wailord", 321 },
            { "numel", 322 },
            { "camerupt", 323 },
            { "torkoal", 324 },
            { "spoink", 325 },
            { "grumpig", 326 },
            { "spinda", 327 },
            { "trapinch", 328 },
            { "vibrava", 329 },
            { "flygon", 330 },
            { "cacnea", 331 },
            { "cacturne", 332 },
            { "swablu", 333 },
            { "altaria", 334 },
            { "zangoose", 335 },
            { "seviper", 336 },
            { "lunatone", 337 },
            { "solrock", 338 },
            { "barboach", 339 },
            { "whiscash", 340 },
            { "corphish", 341 },
            { "crawdaunt", 342 },
            { "baltoy", 343 },
            { "claydol", 344 },
            { "lileep", 345 },
            { "cradily", 346 },
            { "anorith", 347 },
            { "armaldo", 348 },
            { "feebas", 349 },
            { "milotic", 350 },
            { "castform", 351 },
            { "kecleon", 352 },
            { "shuppet", 353 },
            { "banette", 354 },
            { "duskull", 355 },
            { "dusclops", 356 },
            { "tropius", 357 },
            { "chimecho", 358 },
            { "absol", 359 },
            { "wynaut", 360 },
            { "snorunt", 361 },
            { "glalie", 362 },
            { "spheal", 363 },
            { "sealeo", 364 },
            { "walrein", 365 },
            { "clamperl", 366 },
            { "huntail", 367 },
            { "gorebyss", 368 },
            { "relicanth", 369 },
            { "luvdisc", 370 },
            { "bagon", 371 },
            { "shelgon", 372 },
            { "salamence", 373 },
            { "beldum", 374 },
            { "metang", 375 },
            { "metagross", 376 },
            { "regirock", 377 },
            { "regice", 378 },
            { "registeel", 379 },
            { "latias", 380 },
            { "latios", 381 },
            { "kyogre", 382 },
            { "groudon", 383 },
            { "rayquaza", 384 },
            { "jirachi", 385 },
            { "deoxys", 386 },
            { "turtwig", 387 },
            { "grotle", 388 },
            { "torterra", 389 },
            { "chimchar", 390 },
            { "monferno", 391 },
            { "infernape", 392 },
            { "piplup", 393 },
            { "prinplup", 394 },
            { "empoleon", 395 },
            { "starly", 396 },
            { "staravia", 397 },
            { "staraptor", 398 },
            { "bidoof", 399 },
            { "bibarel", 400 },
            { "kricketot", 401 },
            { "kricketune", 402 },
            { "shinx", 403 },
            { "luxio", 404 },
            { "luxray", 405 },
            { "budew", 406 },
            { "roserade", 407 },
            { "cranidos", 408 },
            { "rampardos", 409 },
            { "shieldon", 410 },
            { "bastiodon", 411 },
            { "burmy", 412 },
            { "wormadam", 413 },
            { "mothim", 414 },
            { "combee", 415 },
            { "vespiquen", 416 },
            { "pachirisu", 417 },
            { "buizel", 418 },
            { "floatzel", 419 },
            { "cherubi", 420 },
            { "cherrim", 421 },
            { "shellos", 422 },
            { "gastrodon", 423 },
            { "ambipom", 424 },
            { "drifloon", 425 },
            { "drifblim", 426 },
            { "buneary", 427 },
            { "lopunny", 428 },
            { "mismagius", 429 },
            { "honchkrow", 430 },
            { "glameow", 431 },
            { "purugly", 432 },
            { "chingling", 433 },
            { "stunky", 434 },
            { "skuntank", 435 },
            { "bronzor", 436 },
            { "bronzong", 437 },
            { "bonsly", 438 },
            { "mime jr", 439 },
            { "mime-jr", 439 },
            { "happiny", 440 },
            { "chatot", 441 },
            { "spiritomb", 442 },
            { "gible", 443 },
            { "gabite", 444 },
            { "garchomp", 445 },
            { "munchlax", 446 },
            { "riolu", 447 },
            { "lucario", 448 },
            { "hippopotas", 449 },
            { "hippowdon", 450 },
            { "skorupi", 451 },
            { "drapion", 452 },
            { "croagunk", 453 },
            { "toxicroak", 454 },
            { "carnivine", 455 },
            { "finneon", 456 },
            { "lumineon", 457 },
            { "mantyke", 458 },
            { "snover", 459 },
            { "abomasnow", 460 },
            { "weavile", 461 },
            { "magnezone", 462 },
            { "lickilicky", 463 },
            { "rhyperior", 464 },
            { "tangrowth", 465 },
            { "electivire", 466 },
            { "magmortar", 467 },
            { "togekiss", 468 },
            { "yanmega", 469 },
            { "leafeon", 470 },
            { "glaceon", 471 },
            { "gliscor", 472 },
            { "mamoswine", 473 },
            { "porygon z", 474 },
            { "porygon-z", 474 },
            { "gallade", 475 },
            { "probopass", 476 },
            { "dusknoir", 477 },
            { "froslass", 478 },
            { "rotom", 479 },
            { "uxie", 480 },
            { "mesprit", 481 },
            { "azelf", 482 },
            { "dialga", 483 },
            { "palkia", 484 },
            { "heatran", 485 },
            { "regigigas", 486 },
            { "giratina", 487 },
            { "cresselia", 488 },
            { "phione", 489 },
            { "manaphy", 490 },
            { "darkrai", 491 },
            { "shaymin", 492 },
            { "arceus", 493 },
            { "victini", 494 },
            { "snivy", 495 },
            { "servine", 496 },
            { "serperior", 497 },
            { "tepig", 498 },
            { "pignite", 499 },
            { "emboar", 500 },
            { "oshawott", 501 },
            { "dewott", 502 },
            { "samurott", 503 },
            { "patrat", 504 },
            { "watchog", 505 },
            { "lillipup", 506 },
            { "herdier", 507 },
            { "stoutland", 508 },
            { "purrloin", 509 },
            { "liepard", 510 },
            { "pansage", 511 },
            { "simisage", 512 },
            { "pansear", 513 },
            { "simisear", 514 },
            { "panpour", 515 },
            { "simipour", 516 },
            { "munna", 517 },
            { "musharna", 518 },
            { "pidove", 519 },
            { "tranquill", 520 },
            { "unfezant", 521 },
            { "blitzle", 522 },
            { "zebstrika", 523 },
            { "roggenrola", 524 },
            { "boldore", 525 },
            { "gigalith", 526 },
            { "woobat", 527 },
            { "swoobat", 528 },
            { "drilbur", 529 },
            { "excadrill", 530 },
            { "audino", 531 },
            { "timburr", 532 },
            { "gurdurr", 533 },
            { "conkeldurr", 534 },
            { "tympole", 535 },
            { "palpitoad", 536 },
            { "seismitoad", 537 },
            { "throh", 538 },
            { "sawk", 539 },
            { "sewaddle", 540 },
            { "swadloon", 541 },
            { "leavanny", 542 },
            { "venipede", 543 },
            { "whirlipede", 544 },
            { "scolipede", 545 },
            { "cottonee", 546 },
            { "whimsicott", 547 },
            { "petilil", 548 },
            { "lilligant", 549 },
            { "basculin", 550 },
            { "sandile", 551 },
            { "krokorok", 552 },
            { "krookodile", 553 },
            { "darumaka", 554 },
            { "darmanitan", 555 },
            { "maractus", 556 },
            { "dwebble", 557 },
            { "crustle", 558 },
            { "scraggy", 559 },
            { "scrafty", 560 },
            { "sigilyph", 561 },
            { "yamask", 562 },
            { "cofagrigus", 563 },
            { "tirtouga", 564 },
            { "carracosta", 565 },
            { "archen", 566 },
            { "archeops", 567 },
            { "trubbish", 568 },
            { "garbodor", 569 },
            { "zorua", 570 },
            { "zoroark", 571 },
            { "minccino", 572 },
            { "cinccino", 573 },
            { "gothita", 574 },
            { "gothorita", 575 },
            { "gothitelle", 576 },
            { "solosis", 577 },
            { "duosion", 578 },
            { "reuniclus", 579 },
            { "ducklett", 580 },
            { "swanna", 581 },
            { "vanillite", 582 },
            { "vanillish", 583 },
            { "vanilluxe", 584 },
            { "deerling", 585 },
            { "sawsbuck", 586 },
            { "emolga", 587 },
            { "karrablast", 588 },
            { "escavalier", 589 },
            { "foongus", 590 },
            { "amoonguss", 591 },
            { "frillish", 592 },
            { "jellicent", 593 },
            { "alomomola", 594 },
            { "joltik", 595 },
            { "galvantula", 596 },
            { "ferroseed", 597 },
            { "ferrothorn", 598 },
            { "klink", 599 },
            { "klang", 600 },
            { "klinklang", 601 },
            { "tynamo", 602 },
            { "eelektrik", 603 },
            { "eelektross", 604 },
            { "elgyem", 605 },
            { "beheeyem", 606 },
            { "litwick", 607 },
            { "lampent", 608 },
            { "chandelure", 609 },
            { "axew", 610 },
            { "fraxure", 611 },
            { "haxorus", 612 },
            { "cubchoo", 613 },
            { "beartic", 614 },
            { "cryogonal", 615 },
            { "shelmet", 616 },
            { "accelgor", 617 },
            { "stunfisk", 618 },
            { "mienfoo", 619 },
            { "mienshao", 620 },
            { "druddigon", 621 },
            { "golett", 622 },
            { "golurk", 623 },
            { "pawniard", 624 },
            { "bisharp", 625 },
            { "bouffalant", 626 },
            { "rufflet", 627 },
            { "braviary", 628 },
            { "vullaby", 629 },
            { "mandibuzz", 630 },
            { "heatmor", 631 },
            { "durant", 632 },
            { "deino", 633 },
            { "zweilous", 634 },
            { "hydreigon", 635 },
            { "larvesta", 636 },
            { "volcarona", 637 },
            { "cobalion", 638 },
            { "terrakion", 639 },
            { "virizion", 640 },
            { "tornadus", 641 },
            { "thundurus", 642 },
            { "reshiram", 643 },
            { "zekrom", 644 },
            { "landorus", 645 },
            { "kyurem", 646 },
            { "keldeo", 647 },
            { "meloetta", 648 },
            { "genesect", 649 },
            { "chespin", 650 },
            { "quilladin", 651 },
            { "chesnaught", 652 },
            { "fennekin", 653 },
            { "braixen", 654 },
            { "delphox", 655 },
            { "froakie", 656 },
            { "frogadier", 657 },
            { "greninja", 658 },
            { "bunnelby", 659 },
            { "diggersby", 660 },
            { "fletchling", 661 },
            { "fletchinder", 662 },
            { "talonflame", 663 },
            { "scatterbug", 664 },
            { "spewpa", 665 },
            { "vivillon", 666 },
            { "litleo", 667 },
            { "pyroar", 668 },
            { "flabebe", 669 },
            { "floette", 670 },
            { "florges", 671 },
            { "skiddo", 672 },
            { "gogoat", 673 },
            { "pancham", 674 },
            { "pangoro", 675 },
            { "furfrou", 676 },
            { "espurr", 677 },
            { "meowstic", 678 },
            { "honedge", 679 },
            { "doublade", 680 },
            { "aegislash", 681 },
            { "spritzee", 682 },
            { "aromatisse", 683 },
            { "swirlix", 684 },
            { "slurpuff", 685 },
            { "inkay", 686 },
            { "malamar", 687 },
            { "binacle", 688 },
            { "barbaracle", 689 },
            { "skrelp", 690 },
            { "dragalge", 691 },
            { "clauncher", 692 },
            { "clawitzer", 693 },
            { "helioptile", 694 },
            { "heliolisk", 695 },
            { "tyrunt", 696 },
            { "tyrantrum", 697 },
            { "amaura", 698 },
            { "aurorus", 699 },
            { "sylveon", 700 },
            { "hawlucha", 701 },
            { "dedenne", 702 },
            { "carbink", 703 },
            { "goomy", 704 },
            { "sliggoo", 705 },
            { "goodra", 706 },
            { "klefki", 707 },
            { "phantump", 708 },
            { "trevenant", 709 },
            { "pumpkaboo", 710 },
            { "gourgeist", 711 },
            { "bergmite", 712 },
            { "avalugg", 713 },
            { "noibat", 714 },
            { "noivern", 715 },
            { "xerneas", 716 },
            { "yveltal", 717 },
            { "zygarde", 718 }
        };



        public Form1()
        {
            InitializeComponent();

        }

        private int[] findBaseStats(int pkmn_id) { 
            int[] stats_int = new int[]{0,0,0,0,0,0};
            string[] stats_str = new string[] { "0", "0", "0", "0", "0", "0" }; ;
            int line_num = (pkmn_id - 1) * 6;

            for (int i = 0; i < 6; i++) {
                stats_str[i] = System.IO.File.ReadLines("C:/Users/Zadow/Documents/Visual Studio 2013/Projects/PokemonIVCalculator/PokemonIVCalculator/PokemonBaseStats.txt").Skip(line_num).Take(1).First();
                line_num++;
            }

            string[] output;
            int[] baseStats = new int[] { 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < 6; i++)
            {
                output = stats_str[i].Split(',');
                baseStats[i] = Int32.Parse(output[2]);
                Console.WriteLine(baseStats[i]);
            }



            return baseStats;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string actualdata = string.Empty;
            char[] entereddata = textBox2.Text.ToCharArray();
            foreach (char aChar in entereddata.AsEnumerable()) {
                if (Char.IsDigit(aChar)) {
                    actualdata = actualdata + aChar;
                }
                else{
                    actualdata.Replace(aChar, ' ');
                    actualdata.Trim();
                }
            }
            textBox2.Text = actualdata;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void IVSPD_Click(object sender, EventArgs e)
        {

        }


        private void BoxLevel_TextChanged_1(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(BoxLevel.Text, out parsedValue))
            {
                BoxLevel.Text = "";
            }
        }

        private void statHP_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(statHP.Text, out parsedValue))
            {
                statHP.Text = "";
            }
        }

        private void statATK_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(statATK.Text, out parsedValue))
            {
                statATK.Text = "";
            }
        }

        private void statDEF_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(statDEF.Text, out parsedValue))
            {
                statDEF.Text = "";
            }
        }

        private void statSPDEF_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(statSPDEF.Text, out parsedValue))
            {
                statSPDEF.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            BoxSpecies.DataSource = new BindingSource(Ids, null);
            BoxSpecies.DisplayMember = "Key";
            BoxSpecies.ValueMember = "Value";

            BoxNature.DataSource = new BindingSource(natures, null);
            BoxNature.DisplayMember = "Key";
            BoxNature.ValueMember = "Value";


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void statSPATK_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(statSPATK.Text, out parsedValue))
            {
                statSPATK.Text = "";
            }
        }

        private void statSPD_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(statSPD.Text, out parsedValue))
            {
                statSPD.Text = "";
            }
        }

        private void EVHP_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(EVHP.Text, out parsedValue))
            {
                EVHP.Text = "";
            }
        }

        private void EVATK_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(EVATK.Text, out parsedValue))
            {
                EVATK.Text = "";
            }
        }

        private void EVDEF_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(EVDEF.Text, out parsedValue))
            {
                EVDEF.Text = "";
            }
        }

        private void EVSPATK_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(EVSPATK.Text, out parsedValue))
            {
                EVSPATK.Text = "";
            }
        }

        private void EVSPDEF_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(EVSPDEF.Text, out parsedValue))
            {
                EVSPDEF.Text = "";
            }
        }

        private void EVSPD_TextChanged(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(EVSPD.Text, out parsedValue))
            {
                EVSPD.Text = "";
            }
        }
        public bool doesPokemonExist(string speciesname) {
            if (Ids.ContainsKey(speciesname)) {
                return true;
            }
            return false;
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            updatePokemonImage();
            char[] charsToTrim = { '[', ' ', ']', ',', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string nameraw = BoxSpecies.Text;
            string name = nameraw.Trim(charsToTrim);
            name = name.ToLower();

            if (!doesPokemonExist(name)) {
                labelerror.Text = "Pokemon Name does not exist!";
                return;
            }

            int id = Ids[name];

            labelerror.Text = "";

            if (statHP.Text == "" || statATK.Text == "" || statDEF.Text == "" || statSPATK.Text == "" || statSPDEF.Text == "")
            {
                labelerror.Text = "Error : Please fill in all stats";

        
            }
            else {

                int[] results = findBaseStats(id);
                
                Console.WriteLine(results[0]);
                Console.WriteLine(results[1]);
                Console.WriteLine(results[2]);
                Console.WriteLine(results[3]);
                Console.WriteLine(results[4]);
                Console.WriteLine(results[5]);

                /*Actually calculate the IVs!!*/
                calculateIVs(results);
                 
            }
        }

        private void BoxSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePokemonImage();

            }

        public void updatePokemonImage() {
            labelerror.Text = "";
            char[] charsToTrim = { '[', ' ', ']', ',', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string nameraw = BoxSpecies.Text;
            string name = nameraw.Trim(charsToTrim);
            name = name.ToLower();

            if (!doesPokemonExist(name))
            {
                labelerror.Text = "Pokemon Name does not exist!";
                return;
            }

            int id = Ids[name];

            
            // FileNotFoundExceptions are handled here.
            if (File.Exists("C:/Users/Zadow/Documents/Visual Studio 2013/Projects/PokemonIVCalculator/PokemonIVCalculator/img/sprites/" + id + ".gif"))
            {
                pictureBox2.Image = Image.FromFile("C:/Users/Zadow/Documents/Visual Studio 2013/Projects/PokemonIVCalculator/PokemonIVCalculator/img/sprites/" + id + ".gif");
            }

                
          

            return;
        }

        private void BoxSpecies_TextChanged(object sender, EventArgs e)
        {
            updatePokemonImage();
        }

        public void calculateIVs(int[] baseStats) {
            labelerror.Text = "";
            int HPStat = Int32.Parse(statHP.Text); ;
            int HPEV = Int32.Parse(EVHP.Text);;

            int ATKEV = Int32.Parse(EVATK.Text);
            int ATKStat = Int32.Parse(statATK.Text);

            int DEFEV = Int32.Parse(EVDEF.Text); ;
            int DEFStat = Int32.Parse(statDEF.Text); ;

            int SPATKEV = Int32.Parse(EVSPATK.Text); ;
            int SPATKStat = Int32.Parse(statSPATK.Text); ;

            int SPDEFEV = Int32.Parse(EVSPDEF.Text); ;
            int SPDEFStat = Int32.Parse(statSPDEF.Text); ;

            int SPDEV = Int32.Parse(EVSPD.Text); ;
            int SPDStat = Int32.Parse(statSPD.Text); ;
            
            int level = Int32.Parse(BoxLevel.Text);

            float natATK = 1;
            float natDEF = 1;
            float natSPATK = 1;
            float natSPDEF = 1;
            float natSPD = 1;

            string nature = BoxNature.Text;

            /*Positive Nature Buffs*/
            if (nature == "Lonely" || nature == "Brave" || nature == "Adamant" || nature == "Naughty") { natATK = 1.1f; }
            if (nature == "Bold" || nature == "Relaxed" || nature == "Impish" || nature == "Lax") { natDEF = 1.1f; }
            if (nature == "Timid" || nature == "Hasty" || nature == "Jolly" || nature == "Naive") { natSPD = 1.1f; }
            if (nature == "Modest" || nature == "Mild" || nature == "Quiet" || nature == "Rash") { natSPATK = 1.1f; }
            if (nature == "Calm" || nature == "Gentle" || nature == "Sassy" || nature == "Careful") { natATK = 1.1f; }
      
            /*Negative Nature DeBuffs*/
            if (nature == "Bold" || nature == "Timid" || nature == "Modest" || nature == "Calm") { natATK = 0.9f; }
            if (nature == "Lonely" || nature == "Hasty" || nature == "Mild" || nature == "Gentle") { natDEF = 0.9f; }
            if (nature == "Adamant" || nature == "Impish" || nature == "Jolly" || nature == "Careful") { natSPATK = 0.9f; }
            if (nature == "Naughty" || nature == "Lax" || nature == "Naive" || nature == "Rash") { natSPDEF = 0.9f; }
            if (nature == "Brave" || nature == "Relaxed" || nature == "Quiet" || nature == "Sassy") { natSPD = 0.9f; }

            /*calculate HP IV*//*
            This is the right formula (there is a minimum and maximum.)
            HP IV Min=Ceiling(((Stat-10-Level)*(100/Level))-2*Base-EP)
            HP IV Max=Floor((Stat-10+0.99999...-Level)*(100/Level)-2*Base-EP)

            Other IV Min=Ceiling((Ceiling(Stat/Nature)-5)*(100/Level)-2*Base-EP)
            Other IV Max=Floor((Ceiling((Stat+0.99999...)/Nature)-5)*(100/Level)-2*Base-EP)
            */

            double HPIVMin = Math.Ceiling(((HPStat - 10d - level) * (100 / level)) - 2 * baseStats[0] - HPEV);
            double HPIVMax = Math.Floor((HPStat - 10 + 0.99999 - level) * (100 / level) - 2 * baseStats[0] - HPEV);

            double ATKIVMin = Math.Ceiling((Math.Ceiling(ATKStat / natATK) - 5) * (100 / level) - 2 * baseStats[1] - ATKEV);
            double ATKIVMax = Math.Floor((Math.Ceiling((ATKStat + 0.99999) / natATK) - 5) * (100 / level) - 2 * baseStats[1] - ATKEV);

            double DEFIVMin = Math.Ceiling((Math.Ceiling(DEFStat / natDEF) - 5) * (100 / level) - 2 * baseStats[2] - DEFEV);
            double DEFIVMax = Math.Floor((Math.Ceiling((DEFStat + 0.99999) / natDEF) - 5) * (100 / level) - 2 * baseStats[2] - DEFEV); 

            double SPATKIVMin = Math.Ceiling((Math.Ceiling(SPATKStat / natSPATK) - 5) * (100 / level) - 2 * baseStats[3] - SPATKEV);
            double SPATKIVMax = Math.Floor((Math.Ceiling((SPATKStat + 0.99999) / natSPATK) - 5) * (100 / level) - 2 * baseStats[3] - SPATKEV);

            double SPDEFIVMin = Math.Ceiling((Math.Ceiling(SPDEFStat / natSPDEF) - 5) * (100 / level) - 2 * baseStats[4] - SPDEFEV);
            double SPDEFIVMax = Math.Floor((Math.Ceiling((SPDEFStat + 0.99999) / natSPDEF) - 5) * (100 / level) - 2 * baseStats[4] - SPDEFEV);

            double SPDIVMin = Math.Ceiling((Math.Ceiling(SPDStat / natSPD) - 5) * (100 / level) - 2 * baseStats[5] - SPDEV);
            double SPDIVMax = Math.Floor((Math.Ceiling((SPDStat + 0.99999) / natSPD) - 5) * (100 / level) - 2 * baseStats[5] - SPDEV);

            if (HPIVMax < 0 || ATKIVMax < 0 || DEFIVMax < 0 || SPATKIVMax < 0 || SPDEFIVMax < 0 || SPDIVMax < 0 ||
                HPIVMax > 31 || ATKIVMax > 31 || DEFIVMax > 31 || SPATKIVMax > 31 || SPDEFIVMax > 31 || SPDIVMax > 31)
            {
                labelerror.Text = "Error : Double check your Stats and EVs";
                IVHP.Text = "-";
                IVATK.Text = "-";
                IVDEF.Text = "-";
                IVSPATK.Text = "-";
                IVSPDEF.Text = "-";
                IVSPD.Text = "-";
            }
            else {
                IVHP.Text = (HPIVMin + "-" + HPIVMax).ToString();
                IVATK.Text = (ATKIVMin + "-" + ATKIVMax).ToString();
                IVDEF.Text = (DEFIVMin + "-" + DEFIVMax).ToString();
                IVSPATK.Text = (SPATKIVMin + "-" + SPATKIVMax).ToString();
                IVSPDEF.Text = (SPDEFIVMin + "-" + SPDEFIVMax).ToString();
                IVSPD.Text = (SPDIVMin + "-" + SPDIVMax).ToString();

            }

            return;

        }

    }
}
