using SnippetManager.XmlComponents;

#nullable disable
namespace SnippetManager.Containers;

// Struct containing a deserialized data of the snippet and path to the code snippet file.

public struct XmlPathContainer
{
    public FileInfo Path { get; set; }
    public CodeSnippets XmlData { get; set; }
}
