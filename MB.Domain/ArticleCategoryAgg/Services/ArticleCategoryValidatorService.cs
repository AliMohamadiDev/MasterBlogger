using System.Data;

namespace MB.Domain.ArticleCategoryAgg.Services;

class ArticleCategoryValidatorService : IArticleCategoryValidatorService
{
    private readonly IArticleCategoryRepository _articleCategoryRepository;

    public ArticleCategoryValidatorService(IArticleCategoryRepository articleCategoryRepository)
    {
        _articleCategoryRepository = articleCategoryRepository;
    }

    public void CheckThatThisRecordAlreadyExists(string title)
    {
        if (_articleCategoryRepository.Exists(title))
            throw new DuplicateNameException("This record already exists in database.");
    }
}