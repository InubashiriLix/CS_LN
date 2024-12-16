using System;

namespace inherit_namespace
{
    public class Animal
    {
        private int attack_value = 10;

        private int blood = 100;
        public int Blood
        {
            get
            {
                if (blood <= 0)
                    return 0;
                else
                    return blood;
            }
            set { blood = Math.Max(value, 0); }
        }

        public int Attack_value
        {
            get { return attack_value; }
            set { attack_value = Math.Max(attack_value, 0); }
        }

        public void eat(string food)
        {
            Console.WriteLine($"eating {food}");
        }

        public void attacked(int hurt)
        {
            Blood -= hurt;
            Console.WriteLine($"attacked, blood = {Blood}");
        }

        public void attact(Animal target)
        {
            target.attacked(10);
        }

        public virtual void buck()
        {
            Console.WriteLine("buck");
        }
    }

    public class Dog : Animal
    {
        public override void buck()
        {
            base.buck();
            Console.WriteLine("Wonf Caonima!");
        }

        public void buck(int times)
        {
            for (int i = 0; i < times; i++)
            {
                buck();
                eat("Shit");
            }
        }

        public static void main()
        {
            Dog d = new Dog();
            d.buck();
            d.buck(3);
        }
    }
}
