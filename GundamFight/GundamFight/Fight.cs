using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GundamFight;
using System.Windows.Forms;

namespace GundamFight
{
    class Fight
    {
        public void test(int user)
        {
            string msg = "";
            

            Random r = new Random();
            int comp = r.Next(1, 4);
            if (user == comp)
            {
                msg = "비겼습니다.";
                //비기는거
            }
            else if (user-comp == 1 || user-comp == -2)
            {
                msg = "이겼습니다";
                //이기는거
            }
            else
            {
                msg = "졌습니다.";
                //지는거
            }
            MessageBox.Show(msg);
        }
    }
}
