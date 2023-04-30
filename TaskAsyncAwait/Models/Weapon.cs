namespace TaskAsyncAwait.Models
{
    internal class Weapon
    {
        //public Weapon(BulletType setBulletType, int numberOfRounds)
        //{
        //    Count++;
        //    Id = Count;
        //    BulletTypeWeapon = setBulletType;
        //    NumberOfRounds = numberOfRounds;
        //    for (int i = 1; i <= NumberOfRounds; i++)
        //    {
        //        cartridges.Enqueue(i);
        //    }
        //}

        //public int Id { get; set; }
        //public static int Count { get; set; }
        //public BulletType BulletTypeWeapon { get; }
        //public int NumberOfRounds { get; }

        //List<BulletType> weapons = new List<BulletType>();
        //Queue<int> cartridges = new Queue<int>();


        //public void Fire()
        //{
        //    Console.WriteLine("Bullet type: " + BulletTypeWeapon);
        //    Console.WriteLine("Number of rounds: " + cartridges.Count);

        //    Console.WriteLine("Shoots....");
        //    cartridges.Dequeue();
        //}

        //public void Fill(BulletType bullet)
        //{
        //    weapons.Add(bullet);
        //}

        //public void PullTrigger()
        //{
        //    cartridges.Peek();
        //}

        public Weapon(string bulletType, int numberOfBullets)
        {
            _count++;
            Id = _count;
            BulletType = bulletType;
            NumberOfBullets = numberOfBullets;
        }


        private static int _count;
        public int Id { get; set; }
        public string BulletType { get; set; }
        public int NumberOfBullets { get; set; }


        List<Bullet> bullets = new List<Bullet>();


        public void Fire()
        {
            Console.WriteLine("Bullet type: " + BulletType);
            Console.WriteLine("Bullet left: " + NumberOfBullets);

            Console.WriteLine("Fire....");
            NumberOfBullets--;
        }

        public void Fill(Bullet bullet)
        {
            bullets.Add(bullet);
        }

        public void PullTrigger()
        {
            Console.WriteLine(NumberOfBullets);
        }
    }
}
