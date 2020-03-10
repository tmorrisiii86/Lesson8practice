using System;

namespace Lesson8practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Fido", 4, 0, false, true, "Dog Bone");
            myDog.Bark();
            myDog.Eat();
            myDog.Sleep();

            DancingCat someCrazyCat = new DancingCat("electric slide", "Melo the dancing cat");
            someCrazyCat.Eat();
            someCrazyCat.Meow();
            someCrazyCat.AnnoyYou();
            someCrazyCat.Dance();

            Fish bigFish = new Fish(false);
            bigFish.Breath();

            int money = 0;
            money += bigFish.Sell();
            money += myDog.Sell();
            money += someCrazyCat.Sell();
            Console.WriteLine("After selling my pets, I have " + money);

            Customer customer1 = new Customer("Marcus", "Tadwell");
            customer1.membership.ChangeMembership(Membership.Level.Premium);
            customer1.membership.plan.ChangeRenewal(Plan.Renewal.Annually);
        }
    }
}
