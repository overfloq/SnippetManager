using SnippetManager.Containers;

namespace SnippetManager;

// Static class providing simple access to list all available code snippets as XmlPathContainer supporting filtering.

internal static class SnippetList
{
    public static List<XmlPathContainer> GetAll()
    {
        var list = new List<XmlPathContainer>();

        foreach (var file in Values.Snippets.GetFiles("*.snippet", SearchOption.AllDirectories))
        {
            using var reader = Helper.OpenRead(file.FullName);

            var content = new SnippetSerializer()
                              .Deserialize(reader);

            if (content != null)
            {
                list.Add(new()
                {
                    Path = file,
                    XmlData = content
                });
            }
        }

        return list;
    }

    public static List<XmlPathContainer> OnlyWhere(Func<XmlPathContainer, bool> condition)
        => GetAll().Where(condition).ToList();
}
