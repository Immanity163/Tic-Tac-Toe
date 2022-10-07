using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe;

namespace Tic_Tac_Toe
{
    internal class TechFuncs
    {
        private Button[] buttons;
        
        public TechFuncs(Button[] buttons)
        {
            this.buttons = buttons;
           
        }
        internal void Check_win(int player)
        {
            for (int i = 0; i < 7; i += 3)
            {
                if (buttons[i].Text == buttons[i + 1].Text && buttons[i].Text == buttons[i + 2].Text
                    && buttons[i].Text != "" )
                {
                    win_state(player);
                }

            }for (int i = 0; i < 3; i++)
            {
                if (buttons[i].Text == buttons[i+3].Text && buttons[i].Text == buttons[i + 6].Text
                    && buttons[i].Text != "")
                {
                    win_state(player);
                }
            }
            if (
                (
                (buttons[0].Text == buttons[4].Text &&
                buttons[4].Text == buttons[8].Text) ||
                (buttons[2].Text == buttons[4].Text &&
                buttons[4].Text == buttons[6].Text)
                    ) && buttons[4].Text != ""

                )
            {
                win_state(player);
            }
            if (buttons.All(button =>button.Text =="X" || button.Text == "O"))
            {
                win_state();
            }
        }

        private void win_state(int player = 3 )
        {
            switch (player)
            {
                case 1:
                    MessageBox.Show("Выиграл игрок 2","Победа!");
                    break;
                case 2:
                    MessageBox.Show("Выиграл игрок 1","Победа!");
                    break;
                case 3:
                    MessageBox.Show("Ничья","Ничья!");
                    break;
            }

            foreach (Button button in buttons)
            {
                button.Text = "";
                button.Enabled = true;
                
            };
        }
    }
}
