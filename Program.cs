using System;

namespace Class_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            RandomObjectOne randomObjectOne = new RandomObjectOne();
            randomObjectOne.shoe = false;
            randomObjectOne.film = 1665430895;
            randomObjectOne.master = 166633828.7090936;

            Everywhere everywhere = new Everywhere();
            everywhere.page = -2083026405;
            everywhere.you = -44950735.054251194;
            everywhere.yes = true;
            everywhere.seldom = -1463720493.4081783;
            everywhere.kitchen = -243917921;
            everywhere.he = false;
            randomObjectOne.everywhere = everywhere;

            Variety variety = new Variety();
            variety.damage = 2043690803;
            variety.explain = "power";
            variety.low = "tea";
            variety.small = "student";
            variety.carried = true;
            randomObjectOne.variety = variety;

            Science science = new Science();
            science.famous = "pink";
            science.crew = true;
            science.yesterday = "population";
            science.dinner = "seeing";
            science.missing = "church";
            science.characteristic = -1703576593.2464976;
            
            Orange orange = new Orange();
            orange.elephant = "extra";
            orange.company = true;
            orange.chosen = true;
            orange.able = -609121941.9580331;
            orange.telephone = false;
            orange.science = science;
            randomObjectOne.orange = orange;

            //--------------------------------------------------------------------------------------------------------------//

            RandomObjectTwo randomObjectTwo = new RandomObjectTwo();
            randomObjectTwo.minute = true;
            randomObjectTwo.girl = 1851572840;
            randomObjectTwo.born = "pain";
            randomObjectTwo.enter = false;
            randomObjectTwo.variety = -63040943.838376045;

            Everyone everyone = new Everyone();
            everyone.remain = "rich";
            everyone.due = 1376431728;
            everyone.lost = "drive";
            everyone.worried = 71376782;
            everyone.meet = true;
            everyone.scared = false;

            Bound bound = new Bound();
            bound.everyone = everyone;
            bound.constantly = true;
            bound.introduced = 85726606;
            bound.bright = 1683594661.8046618;
            bound.shelter = 26200111.76448822;
            bound.torn = -1347100654;
            randomObjectTwo.bound = bound;

            //--------------------------------------------------------------------------------------------------------------//

            RandomObjectThree randomObjectThree = new RandomObjectThree();
            randomObjectThree.dot = "accident";
            randomObjectThree.political = "common";
            randomObjectThree.pig = false;
            randomObjectThree.tune = "travel";
            randomObjectThree.warm = false;

            Dish dish = new Dish();
            dish.practical = 923109013;
            dish.stomach = false;
            dish.suppose = false;
            dish.lucky = "act";
            dish.through = false;
            dish.crop = "handsome";

            Whale whale = new Whale();
            whale.comfortable = "skill";
            whale.develop = "central";
            whale.tent = false;
            whale.wrong = true;
            whale.found = false;
            whale.dish = dish;
            randomObjectThree.whale = whale;

            //--------------------------------------------------------------------------------------------------------------//

            RandomObjectFour randomObjectFour = new RandomObjectFour();
            randomObjectFour.express = "zoo";
            randomObjectFour.popular = "popular";
            randomObjectFour.funny = "wrong";
            randomObjectFour.instrument = false;
            randomObjectFour.wall = 1562802207;

            Curious curious = new Curious();
            curious.copper = true;
            curious.review = 1656645595.9986258;
            curious.wagon = -1571905342.6107655;
            curious.far = false;
            curious.rush = "quite";
            curious.lost = "share";

            Necessary necessary = new Necessary();
            necessary.curious = curious;
            necessary.cry = true;
            necessary.flies = true;
            necessary.natural = "quiet";
            necessary.row = false;
            necessary.edge = "political";
            randomObjectFour.necessary = necessary;

            //--------------------------------------------------------------------------------------------------------------//

            RandomObjectFive randomObjectFive = new RandomObjectFive();
            randomObjectFive.refused = "atom";
            randomObjectFive.these = 1276884459.7748518;
            randomObjectFive.love = true;
            randomObjectFive.flame = true;
            randomObjectFive.frog = false;

            Ear ear = new Ear();
            ear.square = "join";
            ear.five = true;
            ear.scene = false;
            ear.keep = 676540099;
            ear.major = "bean";
            ear.who = "boy";

            Money money = new Money();
            money.manner = false;
            money.therefore = true;
            money.shop = true;
            money.may = "gray";
            money.ear = ear;
            money.circle = true;
            randomObjectFive.money = money;

        }

        public class RandomObjectOne
        {
            public bool shoe { get; set; }
            public Everywhere everywhere { get; set; }
            public Variety variety { get; set; }
            public Orange orange { get; set; }
            public int film { get; set; }
            public double master { get; set; }

        }
        public class Everywhere
        {
            public int page { get; set; }
            public double you { get; set; }
            public bool yes { get; set; }
            public double seldom { get; set; }
            public int kitchen { get; set; }
            public bool he { get; set; }

        }
        public class Variety
        {
            public int damage { get; set; }
            public string explain { get; set; }
            public string low { get; set; }
            public string small { get; set; }
            public bool carried { get; set; }

        }
        public class Orange
        {
            public string elephant { get; set; }
            public bool company { get; set; }
            public Science science { get; set; }
            public bool chosen { get; set; }
            public double able { get; set; }
            public bool telephone { get; set; }
        }
        public class Science
        {
            public string famous { get; set; }
            public bool crew { get; set; }
            public string yesterday { get; set; }
            public string dinner { get; set; }
            public string missing { get; set; }
            public double characteristic { get; set; }

        }
        public class RandomObjectTwo
        {
            public Bound bound { get; set; }
            public bool minute { get; set; }
            public int girl { get; set; }
            public string born { get; set; }
            public bool enter { get; set; }
            public double variety { get; set; }
        }
        public class Bound
        {
            public Everyone everyone { get; set; }
            public bool constantly { get; set; }
            public int introduced { get; set; }
            public double bright { get; set; }
            public double shelter { get; set; }
            public int torn { get; set; }
        }
        public class Everyone
        {
            public string remain { get; set; }
            public int due { get; set; }
            public string lost { get; set; }
            public int worried { get; set; }
            public bool meet { get; set; }
            public bool scared { get; set; }
        }
        public class RandomObjectThree
        {
            public Whale whale { get; set; }
            public string dot { get; set; }
            public string political { get; set; }
            public bool pig { get; set; }
            public string tune { get; set; }
            public bool warm { get; set; }

        }
        public class Whale
        {
            public string comfortable { get; set; }
            public string develop { get; set; }
            public bool tent { get; set; }
            public bool wrong { get; set; }
            public bool found { get; set; }
            public Dish dish { get; set; }
        }

        public class Dish
        {
            public int practical { get; set; }
            public bool stomach { get; set; }
            public bool suppose { get; set; }
            public string lucky { get; set; }
            public bool through { get; set; }
            public string crop { get; set; }
        }
        public class RandomObjectFour
        {
            public string express { get; set; }
            public string popular { get; set; }
            public string funny { get; set; }
            public Necessary necessary { get; set; }
            public bool instrument { get; set; }
            public int wall { get; set; }
        }
        public class Necessary
        {
            public Curious curious { get; set; }
            public bool cry { get; set; }
            public bool flies { get; set; }
            public string natural { get; set; }
            public bool row { get; set; }
            public string edge { get; set; }
        }
        public class Curious
        {
            public bool copper { get; set; }
            public double review { get; set; }
            public double wagon { get; set; }
            public bool far { get; set; }
            public string rush { get; set; }
            public string lost { get; set; }
        }
        public class RandomObjectFive
        {
            public string refused { get; set; }
            public Money money { get; set; }
            public double these { get; set; }
            public bool love { get; set; }
            public bool flame { get; set; }
            public bool frog { get; set; }
        }
        public class Money
        {
            public bool manner { get; set; }
            public bool therefore { get; set; }
            public bool shop { get; set; }
            public string may { get; set; }
            public Ear ear { get; set; }
            public bool circle { get; set; }
        }
        public class Ear
        {
            public string square { get; set; }
            public bool five { get; set; }
            public bool scene { get; set; }
            public int keep { get; set; }
            public string major { get; set; }
            public string who { get; set; }
        }
    }
}
