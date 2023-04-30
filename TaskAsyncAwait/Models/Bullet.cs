using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAsyncAwait.Models
{
    internal class Bullet
    {
        public Bullet(string bulletType)
        {
            _count++;
            Id = _count;
            BulletType = bulletType;
        }


        private static int _count;
        public int Id { get; set; }
        public string BulletType { get; set; }

    }
}
