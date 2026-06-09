public class NewsArticle
{
    public string Title { get; set; }
    public string Category { get; set; }

    public NewsArticle(string title, string category)
    {
        Title = title;
        Category = category;
    }
}

public delegate void ArticleAddedDelegate(object sender, NewsArticle article);
public delegate void ArticleRemovedDelegate(object sender, NewsArticle article);
public delegate void ArticleFilteredDelegate(object sender, string category);

public class NewsArticleCollection
{
    private List<NewsArticle> articles;
    public event ArticleAddedDelegate articleAddedHandler;
    public event ArticleRemovedDelegate articleRemovedHandler;
    private Dictionary<string, ArticleFilteredDelegate> filterHandlers;

    public NewsArticleCollection()
    {
        articles = new List<NewsArticle>();
        filterHandlers = new Dictionary<string, ArticleFilteredDelegate>();
    }

    public void RegisterArticleAddedHandler(
        ArticleAddedDelegate handler)
    {
        articleAddedHandler += handler;
    }

    public void RegisterArticleRemovedHandler(
        ArticleRemovedDelegate handler)
    {
        articleRemovedHandler += handler;
    }

    public void RegisterArticleFilteredHandler(
        string category,
        ArticleFilteredDelegate handler)
    {
        if (!filterHandlers.ContainsKey(category))
        {
            filterHandlers[category] = null;
        }

        filterHandlers[category] += handler;
    }

    public void AddArticle(NewsArticle article)
    {
        articles.Add(article);

        articleAddedHandler?.Invoke(this, article);
    }

    public void RemoveArticle(NewsArticle article)
    {
        if (articles.Remove(article))
        {
            articleRemovedHandler?.Invoke(this, article);
        }
    }

    public List<NewsArticle> FilterArticlesByCategory(string category)
    {
        List<NewsArticle> filteredArticles =
            new List<NewsArticle>();

        foreach (NewsArticle article in articles)
        {
            if (article.Category == category)
            {
                filteredArticles.Add(article);
            }
        }

        if (filterHandlers.ContainsKey(category))
        {
            filterHandlers[category]?.Invoke(this, category);
        }

        return filteredArticles;
    }
}

class Program
{
    static void Main(string[] args)
    {
        NewsArticleCollection collection =
            new NewsArticleCollection();

        // Register add event
        collection.RegisterArticleAddedHandler(OnArticleAdded);

        // Register remove event
        collection.RegisterArticleRemovedHandler(OnArticleRemoved);

        // Register Sports filter event using lambda
        collection.RegisterArticleFilteredHandler(
            "Sports",
            (sender, category) =>
            {
                Console.WriteLine(
                    $"Articles filtered by category '{category}'");
            });

        // Create articles
        NewsArticle article1 =
            new NewsArticle(
                "India wins Cricket World Cup",
                "Sports");

        NewsArticle article2 =
            new NewsArticle(
                "New iPhone Release",
                "Technology");

        NewsArticle article3 =
            new NewsArticle(
                "Olympics 2028 Preparation Begins",
                "Sports");

        // Add articles
        collection.AddArticle(article1);
        collection.AddArticle(article2);
        collection.AddArticle(article3);

        Console.WriteLine();

        // Filter Sports articles
        List<NewsArticle> sportsArticles =
            collection.FilterArticlesByCategory("Sports");

        Console.WriteLine("Sports Articles:");

        foreach (NewsArticle article in sportsArticles)
        {
            Console.WriteLine(
                $"{article.Title} ({article.Category})");
        }

        Console.WriteLine();

        // Remove a Sports article
        collection.RemoveArticle(article1);

        Console.WriteLine();

        // Filter again
        sportsArticles =
            collection.FilterArticlesByCategory("Sports");

        Console.WriteLine("Sports Articles After Removal:");

        foreach (NewsArticle article in sportsArticles)
        {
            Console.WriteLine(
                $"{article.Title} ({article.Category})");
        }
    }

    static void OnArticleAdded(
        object sender,
        NewsArticle article)
    {
        Console.WriteLine(
            $"Article added: {article.Title} ({article.Category})");
    }

    static void OnArticleRemoved(
        object sender,
        NewsArticle article)
    {
        Console.WriteLine(
            $"Article removed: {article.Title} ({article.Category})");
    }
}