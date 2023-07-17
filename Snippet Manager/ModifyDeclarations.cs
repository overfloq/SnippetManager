using SnippetManager.XmlComponents.Optional;
using System.Collections.ObjectModel;
using System.Data;
using System.Text;

namespace SnippetManager;

public partial class ModifyDeclarations : Form
{
    private readonly List<SnippetLiteral> literals;
    private List<SnippetLiteral> __lit_reference;

    public ModifyDeclarations(List<SnippetLiteral> literals)
    {
        __lit_reference = literals;
        this.literals = new(literals.Select(x => Helper.DeepClone(x)!));

        InitializeComponent();
        EnableControls(false);

        foreach (var literal in literals)
        {
            listBox1.Items.Add(literal.ID);
        }
    }

    private void listBox1_DoubleClick(object sender, EventArgs e)
    {
        int index = listBox1.SelectedIndex;
        if (index == -1)
        {
            EnableControls(false);
            return;
        }

        _currentIndex = index;

        SnippetLiteral literal = literals[index];

        id.Text = literal.ID;
        tooltip.Text = literal.ToopTip;
        defaultvalue.Text = literal.DefaultValue;
        editable.Checked = literal.IsEditable;
        function.Text = literal.Function ?? string.Empty;

        EnableControls(true);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        listBox1.Items.Add("newDeclaration");
        literals.Add(new()
        {
            ID = "newDeclaration",
            IsEditable = true
        });
    }

    void EnableControls(bool value)
    {
        editable.Enabled = id.Enabled = tooltip.Enabled = defaultvalue.Enabled = function.Enabled
            = value;
    }

    private int _currentIndex = -1;
    private void button2_Click(object sender, EventArgs e)
    {
        int index = listBox1.SelectedIndex;
        listBox1.Items.RemoveAt(index);
        literals.RemoveAt(index);
    }

    private void id_TextChanged(object sender, EventArgs e)
    {
        if (listBox1.SelectedIndex != _currentIndex) return;
        listBox1.Items[_currentIndex] = literals[_currentIndex].ID = id.Text;
        id.Focus();
    }

    private void tooltip_TextChanged(object sender, EventArgs e)
    {
        if (listBox1.SelectedIndex != _currentIndex) return;
        literals[_currentIndex].ToopTip = tooltip.Text;
    }

    private void defaultvalue_TextChanged(object sender, EventArgs e)
    {
        if (listBox1.SelectedIndex != _currentIndex) return;
        literals[_currentIndex].DefaultValue = defaultvalue.Text;
    }

    private void function_TextChanged(object sender, EventArgs e)
    {
        if (listBox1.SelectedIndex != _currentIndex) return;
        literals[_currentIndex].Function = function.TextLength == 0 ? null : function.Text;
    }

    private void editable_CheckedChanged(object sender, EventArgs e)
    {
        if (listBox1.SelectedIndex != _currentIndex) return;
        literals[_currentIndex].IsEditable = editable.Checked;
        editable.Focus();
    }

    private void ModifyDeclarations_Load(object sender, EventArgs e)
    {

    }

    private readonly ReadOnlyCollection<char> _allowedIdChars =
        new("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ_-0123456789".ToCharArray());

    private void button3_Click(object sender, EventArgs e)
    {
        var problems = new List<string>();

        foreach (var item in literals)
        {
            if (!item.ID.All(_allowedIdChars.Contains))
            {
                problems.Add($"{item.ID} contains illegal chars '{string.Concat(item.ID.Except(_allowedIdChars))}'");
            }

            if (literals.Count(x => x.ID == item.ID) > 1)
            {
                problems.Add($"'{item.ID}' is not used only once!");
            }
        }

        if (problems.Count > 0)
        {
            StringBuilder builder = new();
            int counter = 0;
            foreach (var item in problems)
                builder.AppendLine($"{++counter}. {item}");

            MessageBox.Show($"Problems ({problems.Count}) found, cannot save.\n\n{builder}");
            return;
        }

        __lit_reference.Clear();
        literals.ForEach(__lit_reference.Add);

        Close();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        EnableControls(_currentIndex == listBox1.SelectedIndex);
        button1.Enabled = button2.Enabled = (listBox1.SelectedIndex != -1);
    }
}
