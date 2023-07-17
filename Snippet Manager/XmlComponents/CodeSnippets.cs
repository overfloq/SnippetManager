using System.Xml.Serialization;

#nullable disable
namespace SnippetManager.XmlComponents;

// Root XML element of entire file

[XmlRoot("CodeSnippets", Namespace = "http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet")]
public class CodeSnippets
{
    [XmlElement("CodeSnippet")]
    public SnippetData CodeSnippet { get; set; } = new();
}
