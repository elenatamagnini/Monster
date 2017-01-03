using System;
using System.Windows.Forms;

namespace TestClassi
{
    class Monster
    {
        private string _name;
        public string name { get { return _name; } }


        private int _maxHp;
        public int maxHp
        { get { return _maxHp; } }


        public bool alive { get { return curHp > 0; } }

        private int _curHp;
        public int curHp
        {
            set
            {
                if (value < 0) value = 0;
                else if (value > _maxHp) value = _maxHp;
                _curHp = value;
            }

            get
            {
                return _curHp;
            }
        }


        public int _damage;
        public int damage { get { return _damage; } }


        private int _healFactor;
        public int healFactor
        {
            get
            {
                return _healFactor;
            }
            set
            {
                _healFactor = value;
            }
        }

        public string status
        {
            get
            {
                return curHp + "/" + maxHp + " HP";
            }
        }


        public Monster(string name, int maxHp, int damage, int healFactor = 0)
        {
            _name = name;

            if (maxHp < 1) maxHp = 1;
            _maxHp = maxHp;

            curHp = maxHp;

            if (damage < 0) damage = 0;
            _damage = damage;

            this.healFactor = healFactor;
            Console.WriteLine("test " + _healFactor);
            describe();
        }


        public string describe()
        {
            string output = "Questo è " + name + "\r\n";
            output += "HP: " + curHp + "\r\n";
            output += "DAMAGE: " + damage + "\r\n";

            return output;
        }

        public void describe(TextBox t)
        {
            t.Text = describe();
        }

        public void heal(Monster target)
        {
            if (healFactor == 0)
            {
                Console.WriteLine("Non hai il potere di curare nessuno");
                return;
            }

            if (curHp <= 0)
            {
                Console.WriteLine("Non puoi curare nessuno da morto");
                return;
            }

            if (target.curHp <= 0)
            {
                Console.WriteLine(target._name + " è esausto e non puoi resuscitarlo con la cura.");
                return;
            }

            target.curHp += healFactor;

            if (target.curHp > target.maxHp)
            {
                target.curHp = target.maxHp;
            }

            Console.WriteLine(name + " usa cura su " + target.name);
            Console.WriteLine(target.name + " è stato curato e ora ha " + target.status);
        }

        public void heal()
        {
            heal(this);
        }

        public virtual void attack(Monster target)
        {
            if (!alive)
            {
                Console.WriteLine("Non puoi attaccare nessuno da morto");
                return;
            }

            if (!target.alive)
            {
                Console.WriteLine(target.name + " è già esausto, non infierire.");
                return;
            }

            Console.WriteLine(name + " attacca " + target.name);
            Console.WriteLine(name + " fa " + damage + " danni a " + target.name);
            target.curHp -= damage;

            if (!target.alive) 
            {
                target.curHp = 0;
                Console.WriteLine(target.name + " è esausto.");
            } else
            {
                Console.WriteLine("a " + target.name + " rimangono " + target.curHp + " hp");
            }
        }
    }
}