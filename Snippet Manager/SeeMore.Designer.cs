namespace SnippetManager.Containers;

partial class SeeMore
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
        label1 = new Label();
        label2 = new Label();
        textBox1 = new TextBox();
        button1 = new Button();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        title = new TextBox();
        description = new TextBox();
        shortcut = new TextBox();
        label3 = new Label();
        expansion = new CheckBox();
        surroundWith = new CheckBox();
        refactoring = new CheckBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        button2 = new Button();
        linkLabel1 = new LinkLabel();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(24, 19);
        label1.Name = "label1";
        label1.Size = new Size(75, 20);
        label1.TabIndex = 0;
        label1.Text = "Unknown";
        // 
        // label2
        // 
        label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(24, 39);
        label2.Name = "label2";
        label2.Size = new Size(629, 36);
        label2.TabIndex = 1;
        label2.Text = "This is an unknown code snippet";
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
        textBox1.Location = new Point(24, 87);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.ScrollBars = ScrollBars.Both;
        textBox1.Size = new Size(629, 135);
        textBox1.TabIndex = 2;
        // 
        // button1
        // 
        button1.Location = new Point(562, 425);
        button1.Name = "button1";
        button1.Size = new Size(91, 29);
        button1.TabIndex = 3;
        button1.Text = "Commit";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(30, 348);
        label6.Name = "label6";
        label6.Size = new Size(66, 20);
        label6.TabIndex = 7;
        label6.Text = "Use type";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(30, 315);
        label5.Name = "label5";
        label5.Size = new Size(64, 20);
        label5.TabIndex = 6;
        label5.Text = "Shortcut";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(30, 282);
        label4.Name = "label4";
        label4.Size = new Size(85, 20);
        label4.TabIndex = 5;
        label4.Text = "Description";
        // 
        // title
        // 
        title.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        title.Location = new Point(144, 253);
        title.Name = "title";
        title.Size = new Size(509, 25);
        title.TabIndex = 0;
        // 
        // description
        // 
        description.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        description.Location = new Point(144, 285);
        description.Name = "description";
        description.Size = new Size(509, 25);
        description.TabIndex = 1;
        // 
        // shortcut
        // 
        shortcut.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
        shortcut.Location = new Point(144, 318);
        shortcut.Name = "shortcut";
        shortcut.Size = new Size(181, 25);
        shortcut.TabIndex = 2;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(30, 250);
        label3.Name = "label3";
        label3.Size = new Size(38, 20);
        label3.TabIndex = 4;
        label3.Text = "Title";
        // 
        // expansion
        // 
        expansion.AutoSize = true;
        expansion.Location = new Point(3, 3);
        expansion.Name = "expansion";
        expansion.Size = new Size(98, 24);
        expansion.TabIndex = 8;
        expansion.Text = "Expansion";
        expansion.UseVisualStyleBackColor = true;
        expansion.CheckedChanged += expansion_CheckedChanged;
        // 
        // surroundWith
        // 
        surroundWith.AutoSize = true;
        surroundWith.Location = new Point(153, 3);
        surroundWith.Name = "surroundWith";
        surroundWith.Size = new Size(128, 24);
        surroundWith.TabIndex = 9;
        surroundWith.Text = "SurroundsWith";
        surroundWith.UseVisualStyleBackColor = true;
        surroundWith.CheckedChanged += surroundWith_CheckedChanged;
        // 
        // refactoring
        // 
        refactoring.AutoSize = true;
        refactoring.Location = new Point(363, 3);
        refactoring.Name = "refactoring";
        refactoring.Size = new Size(108, 24);
        refactoring.TabIndex = 10;
        refactoring.Text = "Refactoring";
        refactoring.UseVisualStyleBackColor = true;
        refactoring.CheckedChanged += refactoring_CheckedChanged;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.7040367F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.2959633F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 148F));
        tableLayoutPanel1.Controls.Add(expansion, 0, 0);
        tableLayoutPanel1.Controls.Add(refactoring, 2, 0);
        tableLayoutPanel1.Controls.Add(surroundWith, 1, 0);
        tableLayoutPanel1.Location = new Point(144, 349);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(509, 30);
        tableLayoutPanel1.TabIndex = 11;
        // 
        // button2
        // 
        button2.Location = new Point(423, 425);
        button2.Name = "button2";
        button2.Size = new Size(133, 29);
        button2.TabIndex = 12;
        button2.Text = "Declarations";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // linkLabel1
        // 
        linkLabel1.AutoSize = true;
        linkLabel1.LinkColor = Color.FromArgb(192, 0, 0);
        linkLabel1.Location = new Point(30, 425);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(170, 20);
        linkLabel1.TabIndex = 13;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Delete this code snippet";
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // SeeMore
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(682, 478);
        Controls.Add(linkLabel1);
        Controls.Add(button2);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(button1);
        Controls.Add(label4);
        Controls.Add(textBox1);
        Controls.Add(title);
        Controls.Add(description);
        Controls.Add(label2);
        Controls.Add(shortcut);
        Controls.Add(label1);
        Controls.Add(label3);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "SeeMore";
        StartPosition = FormStartPosition.CenterParent;
        Text = "See more";
        Load += SeeMore_Load;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox textBox1;
    private Button button1;
    private TextBox title;
    private Label label6;
    private Label label5;
    private Label label4;
    private TextBox description;
    private TextBox shortcut;
    private Label label3;
    private CheckBox expansion;
    private CheckBox surroundWith;
    private CheckBox refactoring;
    private TableLayoutPanel tableLayoutPanel1;
    private Button button2;
    private LinkLabel linkLabel1;
}