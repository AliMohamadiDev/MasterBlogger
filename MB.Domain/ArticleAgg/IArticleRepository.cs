﻿using MB.Application.Contracts.Article;

namespace MB.Domain.ArticleAgg;

public interface IArticleRepository
{
    List<ArticleViewModel> GetList();
    void CreateAndSave(Article entity);
}