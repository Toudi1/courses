

using EventsAndMulticastDelegates;

//create audi system
AudioSystem audioSystem = new AudioSystem();
//create rendering system
RenderingEngine renderingEngine = new RenderingEngine();

Player player1 = new Player("John");
Player player2 = new Player("Dick");

//start audio system and rendering
GameEventManager.OnGameStart();

Console.WriteLine("Game is running... Pres any key to end the game.");

//pause
Console.ReadKey();

//shutdown rendering engine and audio system

GameEventManager.OnGameOver();

