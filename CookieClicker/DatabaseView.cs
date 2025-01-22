using System.Timers;
using Timer = System.Timers.Timer;

namespace FirstWinForm;

public partial class DatabaseView : Form
{
    private static System.Timers.Timer aTimer;
    public int NumOfCookies;
    public int Plus = 1;
    public int TimerPlus = 0;
    public int ClickPosition = 30;
    public int TimerPosition = 30;
    public DatabaseView()
    {
        InitializeComponent();
    }

    void PrintCookies()
    {
        CookieLabel.Text = $"Cookies: {NumOfCookies}";
    }


    private void button_Click(object sender, EventArgs e)
    {
        NumOfCookies += Plus;
        PrintCookies();

    }

    private void upgradeButton_Click(object sender, EventArgs e)
    {
        if (NumOfCookies >= 10)
        {
            Plus++;
            NumOfCookies -= 10;
            var picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(32, 32),
                Location = new Point(ClickPosition, 100),
                Image = Image.FromFile("jonkler.png"),
                
            };
            this.Controls.Add(picture);
            ClickPosition += 40;
        }

        PrintCookies();
    }

    private void upgradeButtonTimer_Click(object sender, EventArgs e)
    {
        if (NumOfCookies >= 20)
        {
            count++;
            if (count == 1)
            {
                SetTimer();
                TimerPlus++;
                NumOfCookies -= 20;
            }
            if (count > 1)
            {
                NumOfCookies -= 20;
                TimerPlus++;
            }

            PrintCookies();
            var picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(32, 32),
                Location = new Point(TimerPosition, 325),
                Image = Image.FromFile("jonkler.png"),
                
            };
            this.Controls.Add(picture);
            TimerPosition += 40;
        }
    }
    private void SetTimer()
    {
        aTimer = new Timer(1000);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        NumOfCookies += TimerPlus;
        PrintCookies();
    }

    int count = 0;


}