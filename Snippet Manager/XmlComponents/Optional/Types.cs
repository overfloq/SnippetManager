using System.Xml.Serialization;

namespace SnippetManager.XmlComponents.Optional;

// Determines, where the code snippet should be used.

public enum Types : int
{
    // Write a specific code to the editor with $end$ (cursor position)
    [XmlEnum("Expansion")]
    Expansion,

    // Surrounds selected code ($selected$) with the code with $end$ (cursor position)
    [XmlEnum("SurroundsWith")]
    SurroundsWith,

    // Used for refactoring code, cannot be used as a custom snippet
    [XmlEnum("Refactoring")]
    Refactoring
}
