namespace FerreteriaNetCore.DAO.NHibernet
{
    public class NHibernetFactory : IDAOFactory
    {
        public override IUserDAO UserDAO { get; }
    }
}
