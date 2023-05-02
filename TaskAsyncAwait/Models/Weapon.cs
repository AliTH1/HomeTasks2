namespace TaskAsyncAwait.Models
{
    internal class Weapon
    {

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
