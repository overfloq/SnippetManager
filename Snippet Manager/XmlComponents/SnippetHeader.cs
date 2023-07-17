using SnippetManager.XmlComponents.Optional;
using System.Xml.Serialization;

#nullable disable
namespace SnippetManager.XmlComponents;

// Code snippet header

public class SnippetHeader
{
    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("Shortcut")]
    public string Shortcut { get; set; }

    [XmlElement("Description")]
    public string Description { get; set; }

    [XmlElement("Author")]
    public string Author { get; set; }

    [XmlArray("SnippetTypes")]
    [XmlArrayItem("SnippetType")]
    public List<Types> SnippetTypes { get; set; } = new();
}