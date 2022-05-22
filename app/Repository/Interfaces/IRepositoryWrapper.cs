namespace library.Repository.Interfaces
{
    public interface IRepositoryWrapper
    {
        IAuthorRepository AuthorRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IBookRepository BookRepository { get; }
        IMemberRepository MemberRepository { get; }
        IPublisherRepository PublisherRepository { get; }

        void Save();
    }
}
