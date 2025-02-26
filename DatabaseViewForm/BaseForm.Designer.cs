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
        ErrorLabel = new System.Windows.Forms.Label();
        SuspendLayout();
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
        Text = "BaseForm";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label ErrorLabel;

    #endregion
}