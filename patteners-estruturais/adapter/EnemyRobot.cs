using System;

namespace adapter
{
    public class EnemyRobot
    {
        Random generator = new Random();

        public void SmashWithHands(){
            int smashDamage = generator.Next(10) + 1;
            Console.WriteLine("O Robo inimigo causou " + smashDamage + "de dano com as mãos");
        }

        public void Movement(){
            int movement = generator.Next(10) + 1;
            Console.WriteLine("O Robo inimigo andou " + movement + " metros");
        }
        public void ReactWithHuman(string pilot){
            Console.WriteLine("O Robo inimigo vai contra o " + pilot);
        }
    }
}