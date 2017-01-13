using EloBuddy;

namespace AramBuddy
{
    public static class MyHero
    {
        public static AIHeroClient Instance => Player.Instance;
        public static float LastTurretAttack;
    }
}
