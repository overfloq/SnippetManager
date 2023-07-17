using SnippetManager.Containers;
using System.Xml;
using System.Xml.Serialization;

namespace SnippetManager.XmlComponents;

// Code XML element containing other XML attributes, like Language.

[XmlRoot("Code")]
public class Code
{
    [XmlAttribute("Language")]
    public string Language { get; set; } = SettingsContainer.Default.Language;

    [XmlIgnore]
    public string? Content { get; set; } = "$end$";

    [XmlText]
    public XmlNode[] ContentCDATA
    {
        get
        {
            var dummy = new XmlDocument();
            return new XmlNode[] { dummy.CreateCDataSection(Content) };
        }
        set
        {
            if (value == null || value.Length == 0)
            {
                Content = null;
                return;
            }

            var node = value[0];
            if (node is XmlCDataSection cdataSection)
            {
                Content = cdataSection.Value;
            }
            else
            {
                Content = node.Value;
            }
        }
    }
}
