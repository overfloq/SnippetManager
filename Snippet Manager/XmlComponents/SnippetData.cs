#nullable disable
using System.Xml.Serialization;

namespace SnippetManager.XmlComponents;

// Actual content of the CodeSnippet element

public class SnippetData
{
    [XmlElement("Header")]
    public SnippetHeader Header { get; set; } = new();

    [XmlElement("Snippet")]
    public SnippetContent Snippet { get; set; } = new();

    [XmlAttribute("Format")]
    public string Format { get; set; } = "1.0.0";
}