using FerreteriaNetCore.DAO.MockUp;
using FerreteriaNetCore.DAO.NHibernet;


namespace FerreteriaNetCore.DAO
{
    public abstract class IDAOFactory
    {
        public static IDAOFactory Create()
        {
            string mode = "mockup";

            if (mode == "mockup")
            {
                return new MockUpFactory();
            }
            else if (mode == "nhibernet")
            {
                return new NHibernetFactory();
            }

            return null;
        }

        public abstract IUserDAO UserDAO { get; }
    }
}
