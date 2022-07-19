using MB.Application.Contracts.Article;
using MB.Domain.ArticleAgg;

namespace MB.Application;

public class ArticleApplication : IArticleApplication
{
    private readonly IArticleRepository _articleRepository;

    public ArticleApplication(IArticleRepository articleRepository)
    {
        _articleRepository = articleRepository;
    }

    public List<ArticleViewModel> GetList()
    {
        return _articleRepository.GetList();
    }

    public void Create(CreateArticle command)
    {
        var article = new Article(command.Title, command.ShortDescription, command.Image, command.Content,
            command.ArticleCategoryId);
        _articleRepository.CreateAndSave(article);
    }

    public void Edit(EditArticle command)
    {
        var article = _articleRepository.Get(command.Id);
        article.Edit(command.Title, command.ShortDescription, command.Image, command.Content,
            command.ArticleCategoryId);
        _articleRepository.Save();
    }

    public EditArticle Get(long id)
    {
        var artcle = _articleRepository.Get(id);
        return new EditArticle
        {
            Id = artcle.Id,
            Title = artcle.Title,
            ShortDescription = artcle.ShortDescription,
            Image = artcle.Image,
            Content = artcle.Content,
            ArticleCategoryId = artcle.ArticleCategoryId
        };
    }
}