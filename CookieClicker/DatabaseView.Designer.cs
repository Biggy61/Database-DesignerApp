namespace FirstWinForm;

partial class DatabaseView
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseView));
        CookieLabel = new System.Windows.Forms.Label();
        button = new System.Windows.Forms.Button();
        upgradeButtonClick = new System.Windows.Forms.Button();
        upgradeButtonTimer = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // CookieLabel
        // 
        CookieLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
        CookieLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)238));
        CookieLabel.Location = new System.Drawing.Point(260, 26);
        CookieLabel.Name = "CookieLabel";
        CookieLabel.Size = new System.Drawing.Size(249, 56);
        CookieLabel.TabIndex = 3;
        CookieLabel.Text = "Cookies: 0";
        // 
        // button
        // 
        button.Font = new System.Drawing.Font("Vladimir Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button.Location = new System.Drawing.Point(260, 184);
        button.Name = "button";
        button.Size = new System.Drawing.Size(222, 79);
        button.TabIndex = 4;
        button.Text = "Click";
        button.UseVisualStyleBackColor = true;
        button.Click += button_Click;
        // 
        // upgradeButtonClick
        // 
        upgradeButtonClick.Location = new System.Drawing.Point(50, 153);
        upgradeButtonClick.Name = "upgradeButtonClick";
        upgradeButtonClick.Size = new System.Drawing.Size(129, 44);
        upgradeButtonClick.TabIndex = 5;
        upgradeButtonClick.Text = "Upgade click: 10";
        upgradeButtonClick.UseVisualStyleBackColor = true;
        upgradeButtonClick.Click += upgradeButton_Click;
        // 
        // upgradeButtonTimer
        // 
        upgradeButtonTimer.AccessibleName = "";
        upgradeButtonTimer.Location = new System.Drawing.Point(50, 270);
        upgradeButtonTimer.Name = "upgradeButtonTimer";
        upgradeButtonTimer.Size = new System.Drawing.Size(129, 50);
        upgradeButtonTimer.TabIndex = 6;
        upgradeButtonTimer.Text = "Upgrade every second : 20";
        upgradeButtonTimer.UseVisualStyleBackColor = true;
        upgradeButtonTimer.Click += upgradeButtonTimer_Click;
        // 
        // DatabaseView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackgroundImage = ((System.Drawing.Image)resources.GetObject("$this.BackgroundImage"));
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(upgradeButtonTimer);
        Controls.Add(upgradeButtonClick);
        Controls.Add(button);
        Controls.Add(CookieLabel);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button upgradeButtonTimer;

    private System.Windows.Forms.Button button;

    private System.Windows.Forms.Label CookieLabel;

    private System.Windows.Forms.Button upgradeButtonClick;

    #endregion
}