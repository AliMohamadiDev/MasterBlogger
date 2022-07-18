using MB.Application.Contracts.ArticleCategory;

namespace MB.Domain.ArticleCategoryAgg;

public interface IArticleCategoryRepository
{
    List<ArticleCategory> GetAll();
    ArticleCategory Get(long id);
    void Add(ArticleCategory entity);
    void Save();
    bool Exists(string title);
}