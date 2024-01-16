using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Threading;

namespace LSH_AutoClicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);

        private const int MouseEV_Move = 0x0001;        /* mouse move 			*/
        private const int MouseEV_LeftDown = 0x0002;    /* left button down 	*/
        private const int MouseEV_LeftUp = 0x0004;  /* left button up 		*/
        private const int MouseEV_RightDown = 0x0008;   /* right button down 	*/
        private const int MouseEV_RightUp = 0x0010;


        private int interval_;
        private readonly ManualResetEvent stoppeing_event_ = new ManualResetEvent(false); //System.Threading;

        public static int PointX;
        public static int PointY;

        public static int StartInt;
        public static int StopInt;

        public static bool TickSwitch;


        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13; // Номер глобального LowLevel-хука на клавиатуру
        const int WM_KEYDOWN = 0x100; // Сообщения нажатия клавиши

        private LowLevelKeyboardProc _proc = hookProc;

        private static IntPtr hhook = IntPtr.Zero;

        public void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public static void UnHook()
        {
            UnhookWindowsHookEx(hhook);
        }

        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            /*            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)
                        {
                            int vkCode = Marshal.ReadInt32(lParam);
                            //////ОБРАБОТКА НАЖАТИЯ
                            if (vkCode.ToString() == "162")
                            {
                                MessageBox.Show("You pressed a CTR");
                            }
                            // return (IntPtr)1; // 키 입력 제거
                        }
                        else
                            return CallNextHookEx(hhook, code, (int)wParam, lParam);*/

            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                //////ОБРАБОТКА НАЖАТИЯ
                /*if (vkCode.ToString() == "162")
                {
                    MessageBox.Show("You pressed a CTR");
                }*/

                try
                {
                    int vkInt = int.Parse(vkCode.ToString());
                    if (vkInt >= 112)
                    {
                        int FCode = int.Parse(vkCode.ToString()) - 112;
                        if (FCode == StartInt && FCode == StopInt)
                        {
                            TickSwitch = !TickSwitch;
                        }
                        else
                        {
                            if (FCode == StartInt)
                            {
                                TickSwitch = true;
                            }

                            if (FCode == StopInt)
                            {
                                TickSwitch = false;
                            }
                        }
                    }
                } catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                // return (IntPtr)1; // 키 입력 제거
            }
            
            return CallNextHookEx(hhook, code, (int)wParam, lParam);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void MouseLeftClick()
        {
            /*mouse_event(MouseEV_LeftUp, 0, 0, 0, 0);*/
            mouse_event(MouseEV_LeftDown, 0, 0, 0, 0);
            mouse_event(MouseEV_LeftUp, 0, 0, 0, 0);

        }

        private void MouseRightClick()
        {
            /*mouse_event(MouseEV_RightDown, 0, 0, 0, 0);*/
            mouse_event(MouseEV_RightDown, 0, 0, 0, 0);
            mouse_event(MouseEV_RightUp, 0, 0, 0, 0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetHook();
            StartcomboBox.SelectedIndex = 4;
            StopcomboBox.SelectedIndex = 5;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnHook();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TickSelectTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar)) 
            { 
                e.Handled = true;
            }
        }

        private void CursorGetTimer_Tick(object sender, EventArgs e)
        {
            if (!TickSwitch) 
            {
                InfoLabel.Text = "동작안하는중임ㅇㅇ";
                InfoLabel.ForeColor = Color.Green;

                try
                {
                    PointX = Cursor.Position.X;
                    PointY = Cursor.Position.Y;
                    PointLableX.Text = "X: " + PointX.ToString();
                    PointLableY.Text = "Y: " + PointY.ToString();
                }
                catch (Exception ex) { }
            } else
            {
                InfoLabel.Text = "쌈@@뽕하게동작중!";
                InfoLabel.ForeColor = Color.Red;
            } 

        }

        private void StartcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*MessageBox.Show(StartcomboBox.SelectedIndex.ToString());*/
            StartInt = StartcomboBox.SelectedIndex;
        }

        private void StopcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopInt = StopcomboBox.SelectedIndex;
        }

        private void TickSelectButton_Click(object sender, EventArgs e)
        {
            try
            {
                ClickTick.Interval = int.Parse(TickSelectTextBox.Text);
                MessageBox.Show(ClickTick.Interval + "ms로 설정되었습니다.", "어쩔 적용성공");
            }
            catch (Exception ex) { }
        }

        private void ClickTick_Tick(object sender, EventArgs e)
        {
            if(TickSwitch)
            {
                try
                {
                    if (MousePcheckBox.Checked)
                    {
                        SetCursorPos(PointX, PointY);
                    }

                    if (MouseLeftcheckBox.Checked)
                    {
                        MouseLeftClick();
                    }

                    if (MouseRightcheckBox.Checked)
                    {
                        MouseRightClick();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void DevButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("어떻게 구했는지 모르겠지만 대충만들었다. \n Github: LSH9132", "WTF", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void ExButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("좌클릭 우클릭 동시 선택시 좌클릭 우선. \n 시작 정지 같은 키로 해두면 토글 기능 활성화. \n 시간 설정은 ms단위 (1000이 1초), 적용버튼 안누르면 적용 안됨. \n 마우스 고정시 오토마우스 동작 시간에 자동으로 시작 위치로 이동후 클릭됨. \n 짜빠게티는 맛있음.", "설명서다.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
