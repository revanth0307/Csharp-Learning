using Character;
class Program
{
    static void Main(string[] args)
    {
        
        Warrior test = new Warrior("Test", 100, 30, 10);
        Mage nav = new Mage("Nav", 80, 35, 5);
        Dragon rev = new Dragon("Revanth", 200, 40, 20);

        
        test.Attack(nav);
        nav.Defend();
        rev.BreatheFire(test);   
        rev.Defend();
        test.Defend();

        
        Game game = new Game();
        game.Battle(test, nav);
        game.Battle(rev, test);
        game.Battle(nav, rev);
    }
}