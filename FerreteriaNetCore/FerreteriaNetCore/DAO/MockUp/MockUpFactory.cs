namespace FerreteriaNetCore.DAO.MockUp
{
    public class MockUpFactory : IDAOFactory
    {
        public override IUserDAO UserDAO { get; }
    }
}
