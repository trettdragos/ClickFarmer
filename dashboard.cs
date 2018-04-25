using System;
using System.Drawing;
using System.Windows.Forms;
 
public class DashBoard : Form
{
    static public void Main ()
    {
        Application.Run (new DashBoard ());
    }
 	Label count;
    public DashBoard ()
    {
    	this.Size = new Size(1280, 720);
    	this.Text = "Click Farmer";
        Button b = new Button ();
        b.Text = "Click Me!";
        b.Height = 100;
        b.Width = 200;
        b.Font = new Font(b.Font.FontFamily, 20);
        b.Left = (this.Width - b.Width)/2;
        b.Top = (this.Height - b.Height)/2;
        b.Click += new EventHandler (Button_Click);
        Controls.Add (b);
        count = new Label();
        count.Text = "0";
        Label showMoney = new Label();
        showMoney.Text = "Your balance:";
        showMoney.Left = 50;
        showMoney.Top = 10;
        showMoney.Width = 150;
        count.Top = 10;
        showMoney.Font = new Font(showMoney.Font.FontFamily, 15);
        count.Font = new Font(count.Font.FontFamily, 15);
        count.Left = 50+showMoney.Width;
        Controls.Add(showMoney);
        Controls.Add(count);
    }
 
    private void Button_Click (object sender, EventArgs e)
    {
    	int nr = Int32.Parse(count.Text);
    	count.Text = (nr+1).ToString();
    }
}
