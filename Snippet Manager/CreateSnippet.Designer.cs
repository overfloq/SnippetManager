namespace SnippetManager;

partial class CreateSnippet
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
        label3 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        label4 = new Label();
        button1 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(23, 31);
        label1.Name = "label1";
        label1.Size = new Size(38, 20);
        label1.TabIndex = 0;
        label1.Text = "Title";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(23, 64);
        label2.Name = "label2";
        label2.Size = new Size(64, 20);
        label2.TabIndex = 1;
        label2.Text = "Shortcut";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(23, 97);
        label3.Name = "label3";
        label3.Size = new Size(54, 20);
        label3.TabIndex = 2;
        label3.Text = "Author";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(129, 28);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(281, 27);
        textBox1.TabIndex = 3;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(129, 61);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(281, 27);
        textBox2.TabIndex = 4;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(129, 94);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(281, 27);
        textBox3.TabIndex = 5;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.ForeColor = Color.Gray;
        label4.Location = new Point(23, 147);
        label4.Name = "label4";
        label4.Size = new Size(387, 40);
        label4.TabIndex = 6;
        label4.Text = "All other parameters except author can be modified later\r\nafter snippet creation.";
        // 
        // button1
        // 
        button1.Location = new Point(23, 216);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 7;
        button1.Text = "Create";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // CreateSnippet
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(448, 270);
        Controls.Add(button1);
        Controls.Add(label4);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "CreateSnippet";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Create New";
        Load += CreateSnippet_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private Label label4;
    private Button button1;
}