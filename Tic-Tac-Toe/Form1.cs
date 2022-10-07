using Tic_Tac_Toe;
namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private int player;
        private Button[] buttons;
        private TechFuncs service;
        public Form1()
        {
            InitializeComponent();
            player = 1;
            buttons = new Button[] { button1, button2, button3, button4, button5,
                button6, button7, button8, button9 };
            service =new TechFuncs(buttons);
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    player = 2;
                    
                    break;
                case 2:
                    player = 1;
                    sender.GetType().GetProperty("Text").SetValue(sender, "O");

                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            label1.Text = "Игрок " + player;
            service.Check_win(player);
            
            
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            foreach (Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
                player = 1;
            };
        }
    }
}

