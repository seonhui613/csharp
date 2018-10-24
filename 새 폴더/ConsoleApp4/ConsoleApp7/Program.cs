using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class MessageBoxTest
    {
        static void Main(string[] args)
        {
            MessageBox.Show("메세지");
            MessageBox.Show("메세지", "타이틀");

                DialogResult result1 = MessageBox.Show("메세지", "타이틀(두버튼)", 
                            MessageBoxButtons.YesNo);

            if (result1 == DialogResult.Yes) Console.WriteLine("Yes 클릭");
            else Console.WriteLine("NO 클릭");
            Console.WriteLine("1. ----------");

            DialogResult result2 = MessageBox.Show("메세지", "타이틀(Q,YesNoCancel)",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result2 == DialogResult.Yes) Console.WriteLine("yes 클릭");
            else if (result2 == DialogResult.No) Console.WriteLine("no 클릭");
            else if (result2 == DialogResult.Cancel) Console.WriteLine("cancel 클릭");
            Console.WriteLine("2---------");

            DialogResult result3 = MessageBox.Show("메세지", "타이틀(Q,default)",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            MessageBox.Show("메세지", "타이틀(메세지 우측 정렬, Error아이콘)",
                                        MessageBoxButtons.OKCancel,
                                        MessageBoxIcon.Error,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.RightAlign,
                                        true);
            MessageBox.Show("메세지", "타이틀(exclamation icon)",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);




        }
    }
}
