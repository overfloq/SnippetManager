namespace SnippetManager;

// Static class providing string validations.

internal static class Validators
{
    private static readonly char[] _shortcut = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();

    public static bool Shortcut(string name) => name.Length > 0 && name.All(x => _shortcut.Contains(x));
}
