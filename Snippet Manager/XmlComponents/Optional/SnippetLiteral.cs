using System.Xml.Serialization;

namespace SnippetManager.XmlComponents.Optional;

// Snippet literal can contain editable or non-editable value and/or function, which can be placed
// into the code snippet as $id$

public class SnippetLiteral
{
    [XmlAttribute("Editable")]
    public bool IsEditable { get; set; } = true;

    [XmlElement("ID")]
    public string ID { get; set; } = null!;

    [XmlElement("ToolTip")]
    public string? ToopTip { get; set; }

    [XmlElement("Default")]
    public string? DefaultValue { get; set; }

    [XmlElement("Function")]
    public string? Function { get; set; } = null;
}
