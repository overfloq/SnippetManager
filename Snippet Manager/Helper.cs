using System.Text.Json;

namespace SnippetManager;

internal class Helper
{
    public static string PathFromShortcut(string shortcut)
    {
        return Path.Combine(Values.Snippets.FullName, Path.ChangeExtension(shortcut, ".snippet"));
    }

    public static T? DeepClone<T>(T obj)
        => JsonSerializer.Deserialize<T>(       // JSON is used instead of XML because of smaller
                JsonSerializer.Serialize(obj)); // size and most probably better performance.

    public static FileStream OpenRead(string file, FileMode mode = FileMode.OpenOrCreate) => new(file, mode, FileAccess.Read, FileShare.Read);
    public static FileStream OpenWrite(string file, FileMode mode = FileMode.OpenOrCreate) => new(file, mode, FileAccess.ReadWrite, FileShare.Read);
}
