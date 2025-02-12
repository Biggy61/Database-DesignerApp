using System.ComponentModel;

namespace DatabaseViewForm;

partial class BaseForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        PasswordButton = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        PasswordTextBox = new System.Windows.Forms.TextBox();
        ErrorLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // PasswordButton
        // 
        PasswordButton.Location = new System.Drawing.Point(528, 170);
        PasswordButton.Name = "PasswordButton";
        PasswordButton.Size = new System.Drawing.Size(178, 132);
        PasswordButton.TabIndex = 0;
        PasswordButton.Text = "Enter";
        PasswordButton.UseVisualStyleBackColor = true;
        PasswordButton.Click += PasswordButton_Click;
        PasswordButton.KeyDown += PasswordTextBox_KeyDown;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(337, 63);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(179, 42);
        label1.TabIndex = 1;
        label1.Text = "Lock In";
        // 
        // PasswordTextBox
        // 
        PasswordTextBox.Location = new System.Drawing.Point(175, 202);
        PasswordTextBox.Name = "PasswordTextBox";
        PasswordTextBox.Size = new System.Drawing.Size(310, 27);
        PasswordTextBox.TabIndex = 2;
        PasswordTextBox.Enter += PasswordTextBox_Enter;
        PasswordTextBox.Leave += PasswordTextBox_Leave;
        // 
        // ErrorLabel
        // 
        ErrorLabel.Location = new System.Drawing.Point(106, 380);
        ErrorLabel.Name = "ErrorLabel";
        ErrorLabel.Size = new System.Drawing.Size(300, 40);
        ErrorLabel.TabIndex = 3;
        // 
        // BaseForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(ErrorLabel);
        Controls.Add(PasswordTextBox);
        Controls.Add(label1);
        Controls.Add(PasswordButton);
        Text = "BaseForm";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label ErrorLabel;

    private System.Windows.Forms.TextBox PasswordTextBox;

    private System.Windows.Forms.Button PasswordButton;
    private System.Windows.Forms.Label label1;

    #endregion
}