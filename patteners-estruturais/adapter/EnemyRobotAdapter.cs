namespace adapter
{
    public class EnemyRobotAdapter : IEnemyAttack
    {
        EnemyRobot enemyRobot;

        public EnemyRobotAdapter(EnemyRobot newRobot)
        {
            enemyRobot = newRobot;
        }

        public void Control(string pilot)
        {
            this.enemyRobot.ReactWithHuman(pilot);
        }

        public void FireGun()
        {
            this.enemyRobot.SmashWithHands();
        }

        public void Movement()
        {
            this.enemyRobot.Movement();
        }
    }
}