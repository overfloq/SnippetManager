namespace SnippetManager;

partial class ModifyDeclarations
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
        button2 = new Button();
        button1 = new Button();
        defaultvalue = new TextBox();
        label3 = new Label();
        tooltip = new TextBox();
        label2 = new Label();
        id = new TextBox();
        editable = new CheckBox();
        label1 = new Label();
        listBox1 = new ListBox();
        function = new TextBox();
        label4 = new Label();
        button3 = new Button();
        SuspendLayout();
        // 
        // button2
        // 
        button2.Location = new Point(65, 254);
        button2.Name = "button2";
        button2.Size = new Size(36, 29);
        button2.TabIndex = 19;
        button2.Text = "-";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.Location = new Point(23, 254);
        button1.Name = "button1";
        button1.Size = new Size(36, 29);
        button1.TabIndex = 18;
        button1.Text = "+";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // defaultvalue
        // 
        defaultvalue.Location = new Point(342, 141);
        defaultvalue.Name = "defaultvalue";
        defaultvalue.Size = new Size(189, 27);
        defaultvalue.TabIndex = 17;
        defaultvalue.TextChanged += defaultvalue_TextChanged;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(238, 144);
        label3.Name = "label3";
        label3.Size = new Size(58, 20);
        label3.TabIndex = 16;
        label3.Text = "Default";
        // 
        // tooltip
        // 
        tooltip.Location = new Point(342, 67);
        tooltip.Multiline = true;
        tooltip.Name = "tooltip";
        tooltip.Size = new Size(189, 68);
        tooltip.TabIndex = 15;
        tooltip.TextChanged += tooltip_TextChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(238, 70);
        label2.Name = "label2";
        label2.Size = new Size(85, 20);
        label2.TabIndex = 14;
        label2.Text = "Description";
        // 
        // id
        // 
        id.Location = new Point(342, 34);
        id.Name = "id";
        id.Size = new Size(189, 27);
        id.TabIndex = 13;
        id.TextChanged += id_TextChanged;
        // 
        // editable
        // 
        editable.AutoSize = true;
        editable.Location = new Point(342, 207);
        editable.Name = "editable";
        editable.Size = new Size(100, 24);
        editable.TabIndex = 12;
        editable.Text = "Is editable";
        editable.UseVisualStyleBackColor = true;
        editable.CheckedChanged += editable_CheckedChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(238, 37);
        label1.Name = "label1";
        label1.Size = new Size(24, 20);
        label1.TabIndex = 11;
        label1.Text = "ID";
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 20;
        listBox1.Location = new Point(23, 24);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(174, 224);
        listBox1.TabIndex = 10;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        listBox1.DoubleClick += listBox1_DoubleClick;
        // 
        // function
        // 
        function.Location = new Point(342, 174);
        function.Name = "function";
        function.Size = new Size(189, 27);
        function.TabIndex = 21;
        function.TextChanged += function_TextChanged;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(238, 177);
        label4.Name = "label4";
        label4.Size = new Size(65, 20);
        label4.TabIndex = 20;
        label4.Text = "Function";
        // 
        // button3
        // 
        button3.Location = new Point(107, 254);
        button3.Name = "button3";
        button3.Size = new Size(90, 29);
        button3.TabIndex = 22;
        button3.Text = "Commit";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // ModifyDeclarations
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(555, 307);
        Controls.Add(button3);
        Controls.Add(function);
        Controls.Add(label4);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(defaultvalue);
        Controls.Add(label3);
        Controls.Add(tooltip);
        Controls.Add(label2);
        Controls.Add(id);
        Controls.Add(editable);
        Controls.Add(label1);
        Controls.Add(listBox1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "ModifyDeclarations";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Declarations";
        Load += ModifyDeclarations_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button2;
    private Button button1;
    private TextBox defaultvalue;
    private Label label3;
    private TextBox tooltip;
    private Label label2;
    private TextBox id;
    private CheckBox editable;
    private Label label1;
    private ListBox listBox1;
    private TextBox function;
    private Label label4;
    private Button button3;
}