using System.Xml;
using System.Xml.Serialization;

namespace SnippetManager.Containers;

// Class containing the user settings. These settings are for modifying only minimum of this tool, so
// settings are not made to be modified by user. It's main purspose is fixing a problems, like adding
// a custom Visual Studio snippets path, changing language or modifying default author.

[XmlRoot("Settings")]
public class SettingsContainer
{
#nullable disable
    [XmlElement("Author")]
    public string DefaultAuthor { get; init; }

    [XmlElement("Language")]
    public string Language { get; init; }

    [XmlArrayItem("Path")]
    [XmlArray("SnippetPaths")]
    public List<string> SnippetPaths { get; init; }
#nullable restore

    [XmlIgnore]
    public static SettingsContainer Default { get; }

    static SettingsContainer()
    {
        // Load settings to the memory on first access. This ensures that data will be loaded only once
        // and only on first use, not on application startup (actually settings are also readed on startup).

        var path = Environment.ProcessPath;
        var xmlPath = Path.ChangeExtension(path, ".xml");

        if (path == null || xmlPath == null)
            throw new NullReferenceException($"{nameof(xmlPath)}, {nameof(path)}: unexpected null value(s)");

        if (File.Exists(xmlPath))
        {
            // If the settings file already exists, just load it into memory.

            var xmlReader = new XmlSerializer(typeof(SettingsContainer));
            SettingsContainer? settings = (SettingsContainer?)xmlReader.Deserialize(XmlReader.Create(xmlPath));

            if (settings == null)
                throw new NullReferenceException($"{nameof(settings)}: unexpected null value");

            Default = settings;
        }
        else
        {
            // If the settings file does not exist, then we need to create a new one and load it into memory.

            var xmlWriter = new XmlSerializer(typeof(SettingsContainer));
            var instance = new SettingsContainer()
            {
                DefaultAuthor = Environment.UserName,
                SnippetPaths = new()
                {
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"Documents\Visual Studio 2022\Code Snippets\Visual C#\My Code Snippets"),
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"Documents\Visual Studio 2019\Code Snippets\Visual C#\My Code Snippets")
                },
                Language = "csharp"
            };

            Default = instance;
            using var fileStream = File.OpenWrite(xmlPath);

            xmlWriter.Serialize(fileStream, Default);
        }
    }
}
