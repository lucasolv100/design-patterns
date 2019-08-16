using System;

namespace adapter
{
    public class EnemyTank : IEnemyAttack
    {
        Random generator = new Random();
        public void FireGun()
        {
            int attackDamage = generator.Next(10) + 1;
            Console.WriteLine("Tank inimigo fez " + attackDamage + "dano!");
        }

        public void Control(string pilot)
        {
            Console.WriteLine(pilot + "está no comando do tanque agora!");
        }

        public void Movement()
        {
            int movement = generator.Next(5) + 1;
            Console.WriteLine("Tank inimigo andou " + movement + "metros!");
        }
    }
}