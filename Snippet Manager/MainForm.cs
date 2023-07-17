using SnippetManager.Containers;

namespace SnippetManager;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        CreateData();
    }

    readonly List<XmlPathContainer> paths = new();
    void CreateData()
    {
        var index = snippetList.FirstDisplayedScrollingRowIndex;

        paths.Clear();
        snippetList.Rows.Clear();

        foreach (var item in SnippetList.GetAll())
        {
            paths.Add(item);
            snippetList.Rows.Add(item.XmlData.CodeSnippet.Header.Title, "Modify");
        }

        try
        {
            snippetList.FirstDisplayedScrollingRowIndex = index;
        }
        catch (ArgumentOutOfRangeException) { }
    }

    private void snippetList_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex != 1)
            return;

        var info = paths[e.RowIndex];
        using var dialog = new SeeMore(info);
        dialog.ShowDialog();

        CreateData();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        using var dialog = new CreateSnippet();
        DialogResult result = dialog.ShowDialog();

        CreateData();

        if (result == DialogResult.OK)
        {
            int indexOf = paths.FindIndex(x => x.XmlData.CodeSnippet.Header.Shortcut == dialog.ShortcutString);

            snippetList.ClearSelection();
            snippetList.Rows[indexOf].Selected = true;
            snippetList.FirstDisplayedScrollingRowIndex = indexOf;
        }
    }
}
