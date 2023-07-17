using SnippetManager.XmlComponents.Optional;

namespace SnippetManager.Containers;

public partial class SeeMore : Form
{
    XmlPathContainer _container;
    public SeeMore(XmlPathContainer info)
    {
        InitializeComponent();
        _container = info;

        var data = info.XmlData;


        title.Text = label1.Text = data.CodeSnippet.Header.Title;
        label2.Text = $"{(data.CodeSnippet.Header.Author.Length == 0 ? "" : $"By {data.CodeSnippet.Header.Author}; ")}" +
            data.CodeSnippet.Header.Description;

        textBox1.Text = data.CodeSnippet.Snippet.CodeContent.ContentCDATA[0].InnerText;
        description.Text = data.CodeSnippet.Header.Description;
        shortcut.Text = data.CodeSnippet.Header.Shortcut;

        expansion.Checked = data.CodeSnippet.Header.SnippetTypes.Contains(Types.Expansion);
        surroundWith.Checked = data.CodeSnippet.Header.SnippetTypes.Contains(Types.SurroundsWith);
        refactoring.Checked = data.CodeSnippet.Header.SnippetTypes.Contains(Types.Refactoring);
    }

    private void SeeMore_Load(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        new ModifyDeclarations(_container.XmlData.CodeSnippet.Snippet.Declarations)
            .ShowDialog();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!Validators.Shortcut(shortcut.Text))
        {
            MessageBox.Show("Shortcut seems to contain invalid characters, has an invalid length or already exists, please review this parameter.",
                "Invalid Shortcut", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (title.TextLength == 0)
        {
            MessageBox.Show("Title should not be empty as it's the display name of the snippet. Consider not keeping this box empty.",
                "No Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        ApplyLocalData(); // save to xml object

        SnippetSerializer serializer = new();

        using var fileStream = Helper.OpenWrite(_container.Path.FullName, FileMode.Create);
        serializer.Serialize(fileStream, _container.XmlData);

        Close();
    }

    private void ApplyLocalData()
    {
        var xml = _container.XmlData;

        xml.CodeSnippet.Header.Title = title.Text;
        xml.CodeSnippet.Header.Description = description.Text;
        xml.CodeSnippet.Header.Shortcut = shortcut.Text;

        var list = new List<Types>();

        if (expansion.Checked) list.Add(Types.Expansion);
        if (surroundWith.Checked) list.Add(Types.SurroundsWith);
        if (refactoring.Checked) list.Add(Types.Refactoring);

        xml.CodeSnippet.Header.SnippetTypes = list;
        xml.CodeSnippet.Snippet.CodeContent.Content = textBox1.Text;
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        if (MessageBox.Show("Are you sure? Deleting a code snippet is an unreversible operation!", "Delete snippet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            != DialogResult.Yes) return;

        File.Delete(_container.Path.FullName);
        if (File.Exists(_container.Path.FullName))
        {
            MessageBox.Show("Operation failed. File is still located at:\n" + _container.Path.FullName,
                "No Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Close();
    }

    private void expansion_CheckedChanged(object sender, EventArgs e)
    {
        if (!surroundWith.Checked && !refactoring.Checked)
            expansion.Checked = true;
    }

    private void surroundWith_CheckedChanged(object sender, EventArgs e)
    {
        if (!expansion.Checked && !refactoring.Checked)
            surroundWith.Checked = true;
    }

    private void refactoring_CheckedChanged(object sender, EventArgs e)
    {
        if (!surroundWith.Checked && !expansion.Checked)
            refactoring.Checked = true;
    }
}
