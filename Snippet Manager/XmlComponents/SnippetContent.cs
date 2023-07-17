using SnippetManager.XmlComponents.Optional;
using System.Xml.Serialization;

namespace SnippetManager.XmlComponents;

// Content of the code snippet

public class SnippetContent
{
    [XmlArray("Declarations")]
    [XmlArrayItem("Literal")]
    public List<SnippetLiteral> Declarations { get; set; } = new();

    [XmlElement("Code")]
    public Code CodeContent { get; set; } = new();
}