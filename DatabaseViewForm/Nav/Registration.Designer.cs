using System.ComponentModel;

namespace DatabaseViewForm.Nav;

partial class Registration
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        BackButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // BackButton
        // 
        BackButton.Location = new System.Drawing.Point(345, 304);
        BackButton.Name = "BackButton";
        BackButton.Size = new System.Drawing.Size(106, 58);
        BackButton.TabIndex = 0;
        BackButton.Text = "Back";
        BackButton.UseVisualStyleBackColor = true;
        BackButton.Click += BackButton_Click;
        // 
        // Registration
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(BackButton);
        Size = new System.Drawing.Size(891, 742);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button BackButton;

    #endregion
}