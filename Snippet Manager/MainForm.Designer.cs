namespace SnippetManager;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        label1 = new Label();
        button1 = new Button();
        snippetList = new DataGridView();
        name = new DataGridViewTextBoxColumn();
        modify = new DataGridViewButtonColumn();
        ((System.ComponentModel.ISupportInitialize)snippetList).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.ForeColor = Color.Gray;
        label1.Location = new Point(379, 51);
        label1.Name = "label1";
        label1.Size = new Size(170, 149);
        label1.TabIndex = 5;
        label1.Text = "View or edit Visual Studio code snippets. You cannot modify or view pre-installed snippets!";
        // 
        // button1
        // 
        button1.Location = new Point(389, 425);
        button1.Name = "button1";
        button1.Size = new Size(153, 29);
        button1.TabIndex = 4;
        button1.Text = "Create New";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // snippetList
        // 
        snippetList.AllowUserToAddRows = false;
        snippetList.AllowUserToDeleteRows = false;
        snippetList.AllowUserToResizeColumns = false;
        snippetList.AllowUserToResizeRows = false;
        snippetList.BackgroundColor = Color.FromArgb(224, 224, 224);
        snippetList.BorderStyle = BorderStyle.None;
        snippetList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        snippetList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        snippetList.Columns.AddRange(new DataGridViewColumn[] { name, modify });
        snippetList.EnableHeadersVisualStyles = false;
        snippetList.GridColor = Color.FromArgb(224, 224, 224);
        snippetList.Location = new Point(30, 28);
        snippetList.MultiSelect = false;
        snippetList.Name = "snippetList";
        snippetList.ReadOnly = true;
        snippetList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        snippetList.RowHeadersVisible = false;
        snippetList.RowHeadersWidth = 51;
        snippetList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.ForeColor = Color.DimGray;
        dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
        dataGridViewCellStyle2.SelectionForeColor = Color.White;
        snippetList.RowsDefaultCellStyle = dataGridViewCellStyle2;
        snippetList.RowTemplate.Height = 29;
        snippetList.Size = new Size(326, 426);
        snippetList.TabIndex = 3;
        snippetList.CellContentClick += snippetList_CellContentClick;
        // 
        // name
        // 
        name.HeaderText = "Display Name";
        name.MinimumWidth = 6;
        name.Name = "name";
        name.ReadOnly = true;
        name.Width = 230;
        // 
        // modify
        // 
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        modify.DefaultCellStyle = dataGridViewCellStyle1;
        modify.FlatStyle = FlatStyle.Flat;
        modify.HeaderText = "";
        modify.MinimumWidth = 6;
        modify.Name = "modify";
        modify.ReadOnly = true;
        modify.Text = "Modify";
        modify.Width = 95;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(579, 483);
        Controls.Add(label1);
        Controls.Add(button1);
        Controls.Add(snippetList);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "MainForm";
        ShowIcon = false;
        Text = "Snippet Manager";
        Load += MainForm_Load;
        ((System.ComponentModel.ISupportInitialize)snippetList).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Label label1;
    private Button button1;
    private DataGridView snippetList;
    private DataGridViewTextBoxColumn name;
    private DataGridViewButtonColumn modify;
}