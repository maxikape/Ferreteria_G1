namespace FerreteriaNetCore.DAO.MockUp
{
    public class MockUpFactory : IDAOFactory
    {
        public override IUserDAO UserDAO { get { return new UserMockUp(); } }

        public override IProductDAO ProductDAO { get { return new ProductMockUp(); } }
    }
}
