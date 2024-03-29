﻿using MB.Infrastructure.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Pages
{
    public class IndexModel : PageModel
    {
        public List<ArticleQueryView> Articles { get; set; }

        private readonly IArticleQuery _articleQuery;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IArticleQuery articleQuery)
        {
            _logger = logger;
            _articleQuery = articleQuery;
        }

        public void OnGet()
        {
            Articles = _articleQuery.GetArticles();
        }
    }
}