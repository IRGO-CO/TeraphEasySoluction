namespace InitialWebApi.Model
{
    public interface ISessionsRepository
    {
        void Add(Sessions sessions);

        List<Sessions> Get();
    }
}
