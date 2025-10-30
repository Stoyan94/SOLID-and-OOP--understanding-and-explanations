Class Hierarchies

Български:

* Наследяването води до йерархии от класове и/или интерфейси в едно приложение.

* Това означава, че един базов клас съдържа общи характеристики, а наследниците го разширяват с конкретни свойства и поведение.


Пример с игри (Game):

Game(базов клас) - съдържа общи характеристики за всички игри
│
├─ MultiplePlayerGame
│   ├─ BoardGame
│   │   ├─ Chess
│   │   └─ Backgammon
│
└─ SinglePlayerGame
    ├─ Minesweeper
    └─ Solitaire

Game е базовият клас и съдържа общи характеристики за всички игри, като име на игра, брой играчи и т.н.

MultiplePlayerGame и SinglePlayerGame добавят специфични свойства за типа играчи.

Chess, Backgammon, Minesweeper, Solitaire наследяват всички характеристики и добавят специфично поведение за конкретната игра.


Ключова идея / Key takeaway:

Базовият клас държи общото, наследниците добавят специфично.







English:

Inheritance leads to hierarchies of classes and/or interfaces in an application.

This means a base class holds common characteristics, and the derived classes extend it with specific properties and behaviors.

Example with games (Game):

Game(base class) -holds common characteristics for all games
│
├─ MultiplePlayerGame
│   ├─ BoardGame
│   │   ├─ Chess
│   │   └─ Backgammon
│
└─ SinglePlayerGame
    ├─ Minesweeper
    └─ Solitaire


Game is the base class containing common characteristics such as name, number of players, etc.

MultiplePlayerGame and SinglePlayerGame add specific properties for the type of players.

Chess, Backgammon, Minesweeper, and Solitaire inherit all characteristics and add specific behavior for the concrete game.

💡 Key takeaway:

Base class holds the common stuff, derived classes add the specifics.