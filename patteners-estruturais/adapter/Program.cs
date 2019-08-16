using System;

namespace adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyTank tank = new EnemyTank();
            EnemyRobot r2d2 = new EnemyRobot();
            IEnemyAttack robotAdapter = new EnemyRobotAdapter(r2d2);

            Console.WriteLine("==========  ROBO ============");
            robotAdapter.Control("Carlos");
            robotAdapter.Movement();
            robotAdapter.FireGun();
            
            Console.WriteLine("==========  PILOT ============");
            tank.Control("Carlos");
            tank.Movement();
            tank.FireGun();
        }
    }
}
