using SnippetManager.XmlComponents;
using System.Xml;
using System.Xml.Serialization;

namespace SnippetManager;

// Class providing a "more managed and elegant" way of serializing Snippet into XML, for example it'll
// erase file content before writing and minimalizes creation of new XmlSerializer(Type)

public class SnippetSerializer
{
    private readonly XmlSerializer serializer;

    public SnippetSerializer()
    {
        serializer = new XmlSerializer(typeof(CodeSnippets));
    }

    public void Serialize(Stream output, CodeSnippets obj)
    {
        output.SetLength(0);
        output.Seek(0, SeekOrigin.Begin);

        serializer.Serialize(output, obj);
    }

    public CodeSnippets? Deserialize(Stream input)
    {
        input.Seek(0, SeekOrigin.Begin);

        using XmlTextReader xmlReader = new(input);
        return (CodeSnippets?)serializer.Deserialize(xmlReader);

    }
}
