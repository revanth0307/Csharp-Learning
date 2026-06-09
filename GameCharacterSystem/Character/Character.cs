
namespace Character
{
    public class Character
    {
        public string _name
        {
            get;
            set;
        }
        public int _health
        {
            get;
            set;
        }
        public int _attack
        {
            get;
            set;
        }
        public int _defense
        {
            get;
            set;
        }

        public Character(string name, int health, int attack, int defense)
        {
            this._name = name;
            this._health = health;
            this._attack = attack;
            this._defense = defense;
        }

        public virtual void Attack(Character target)
        {
            int damage = this._attack - target._defense;

            if (damage > 0)
            {
                target._health -= damage;
                Console.WriteLine($"{this._name} attacks {target._name} for {damage} damage!");

            }
            else
            {
                Console.WriteLine($"{this._name} attack hasno effect on {target._name}");

            }
        }
        public virtual void Defend()
        {
            Console.WriteLine($"{this._name} defends.");
        }
    }

    public class Warrior : Character
    {
        public Warrior(string name, int health, int attack, int defense) : base(name, health, attack, defense)
        {

        }
        public void Charge(Character target)
        {
            int damage = this._attack * 2 - target._defense;
            if (damage > 0)
            {
                target._health -= damage;
                Console.WriteLine($"{this._name} charges {target._name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{this._name}'s charge has no effect on {target._name}.");
            }
        }
        public override void Defend()
        {
            this._defense += 5;
            Console.WriteLine($"{this._name} defends and gains 5 defense.");
        }

    }

  public class Mage : Character
    {
        public Mage(string name, int health, int attack, int defense) : base(name, health, attack, defense)
        {
        }
        public void CastSpell(Character target)
        {
            int damage=this._attack * 3 - target._defense;
            if(damage>0)
            {
                target._health -= damage;
                Console.WriteLine($"{this._name} casts a spell on {target._name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{this._name}'s spell has no effect on {target._name}.");
            }
        }

        public sealed override void Defend() 
        {
            Console.WriteLine($"{this._name} cannot defend!");
        }

    }

   public class Dragon : Character
    {
        public Dragon(string name, int health, int attack, int defense)
            : base(name, health, attack, defense)
        {
        }

        public void BreatheFire(Character target)
        {
            int damage = this._attack * 4 - target._defense;
            if (damage > 0)
            {
                target._health -= damage;
                Console.WriteLine($"{this._name} breathes fire on {target._name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{this._name}'s fire has no effect on {target._name}.");
            }
        }

        public override void Attack(Character target)  
        {
            int damage = this._attack * 2 - target._defense;
            if (damage > 0)
            {
                target._health -= damage;
                Console.WriteLine($"{this._name} attacks {target._name} for {damage} damage!");
            }
            else
            {
                Console.WriteLine($"{this._name}'s attack has no effect on {target._name}.");
            }
        }

        public override void Defend()
        {
            this._defense += 10;
            Console.WriteLine($"{this._name} defends and gains 10 defense.");
        }
    }

  public  class Game
    {
        public void Battle(Character c1, Character c2)
        {
            Console.WriteLine($"Battle between {c1._name} and {c2._name} ---");

            while (c1._health > 0 && c2._health > 0)
            {
                c1.Attack(c2);          // c1 attacks c2

                if (c2._health > 0)      // only attacks back if still alive
                {
                    c2.Attack(c1);
                }
            }
            if (c1._health > 0)
                Console.WriteLine($"{c1._name} wins!");
            else
                Console.WriteLine($"{c2._name} wins!");
        }
    }

}