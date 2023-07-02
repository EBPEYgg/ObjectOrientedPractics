namespace ObjectOrientedPractics.Services
{
    internal static class IdGenerator
    {
        public static int GetNextId(int id)
        {
            return id++;
        }
    }
}
