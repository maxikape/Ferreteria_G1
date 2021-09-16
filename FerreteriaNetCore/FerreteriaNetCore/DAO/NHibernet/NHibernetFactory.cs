namespace FerreteriaNetCore.DAO.NHibernet
{
    public class NHibernetFactory : IDAOFactory
    {
        public override IUserDAO UserDAO { get { return new UserNHibernet(); } }

        public override IProductDAO ProductDAO { get { return new ProductNHibernet(); } }
    }
}
