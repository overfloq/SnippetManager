using SnippetManager.Containers;

namespace SnippetManager;

// Application (readonly) values, that are initialized on it's first use.

internal class Values
{
#nullable disable
    public static readonly DirectoryInfo Snippets;
#nullable restore

    static Values()
    {
        // TODO: Select the folder with any release year and type (Community, Enterprise ...) + Other languages, not only C#

        var paths = SettingsContainer.Default.SnippetPaths;
        var path = paths.FirstOrDefault(Directory.Exists, null);

        if (path is null)
        {
            MessageBox.Show("No Visual Studio (with C#) installation detected. Please verify that VS is installed with proper components and try again.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(1);
        }
        else
        {
            Snippets = new(path);
        }
    }
}
