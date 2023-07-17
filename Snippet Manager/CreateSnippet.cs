using SnippetManager.Containers;
using SnippetManager.XmlComponents;
using SnippetManager.XmlComponents.Optional;

namespace SnippetManager;

public partial class CreateSnippet : Form
{
    public string ShortcutString => textBox2.Text;
    public CreateSnippet()
    {
        InitializeComponent();

        textBox3.Text = SettingsContainer.Default.DefaultAuthor;
    }

    private void CreateSnippet_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        string title = textBox1.Text;
        string shortcut = textBox2.Text;

        if (title.Length == 0)
        {
            MessageBox.Show("Title should not be empty as it's the display name of the snippet. Consider not keeping this box empty.",
                "No Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!Validators.Shortcut(shortcut) ||
            SnippetList.OnlyWhere(x => x.XmlData.CodeSnippet.Header.Shortcut.Equals(shortcut, StringComparison.OrdinalIgnoreCase)).Count > 0)
        {
            MessageBox.Show("Shortcut seems to contain invalid characters, has an invalid length or already exists, please review this parameter.",
                "Invalid Shortcut", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var obj = new CodeSnippets();

        obj.CodeSnippet.Header = new()
        {
            Title = title,
            Shortcut = shortcut,
            Author = textBox3.Text,
            SnippetTypes = new() { Types.Expansion },
            Description = $"Code snippet for {title}"
        };

        SnippetSerializer serializer = new();

        using var fileStream = Helper.OpenWrite(Helper.PathFromShortcut(shortcut));
        serializer.Serialize(fileStream, obj);

        DialogResult = DialogResult.OK;
    }
}
