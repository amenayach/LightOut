using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightOut.Managers;

namespace LightOut
{
    public partial class MainForm : Form
    {

        private const int LIGHTJUMP = 5;

        private Timer _timer = new Timer() { Interval = 100, Enabled = false };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {

                chRunWithWindows.Checked = HotKeyManager.IsAppInWinStartup();
                chRunWithWindows.CheckedChanged += ChRunWithWindows_CheckedChanged;

                trBrightness.Value = (int)BrightnessManager.GetBrightness();
                trBrightness.ValueChanged += TrBrightness_ValueChanged;

                _timer.Tick += _timer_Tick;
                _timer.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChRunWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (chRunWithWindows.Checked)
            {
                HotKeyManager.AddAppToWinStartup();
            }
            else
            {
                HotKeyManager.RemoveAppFromWinStartup();
            }
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if (
                    ModifierKeys.HasFlag(Keys.Control) &&
                    (HotKeyManager.GetAsyncKeyState(Keys.B) == -32767 || HotKeyManager.GetAsyncKeyState(Keys.B) == 32768)
                )
            {

                if (HotKeyManager.GetAsyncKeyState(Keys.Oemplus) == -32767 || HotKeyManager.GetAsyncKeyState(Keys.Oemplus) == 32768 ||
                    HotKeyManager.GetAsyncKeyState(Keys.Add) == -32767 || HotKeyManager.GetAsyncKeyState(Keys.Add) == 32768)
                {
                    if (trBrightness.Value < 100)
                    {
                        trBrightness.Value += trBrightness.Value + LIGHTJUMP > 100 ? 100 - trBrightness.Value : LIGHTJUMP;
                    }
                }
                else if (HotKeyManager.GetAsyncKeyState(Keys.OemMinus) == -32767 || HotKeyManager.GetAsyncKeyState(Keys.OemMinus) == 32768 ||
                    HotKeyManager.GetAsyncKeyState(Keys.Subtract) == -32767 || HotKeyManager.GetAsyncKeyState(Keys.Subtract) == 32768)
                {
                    if (trBrightness.Value > 0)
                    {
                        trBrightness.Value -= trBrightness.Value - LIGHTJUMP < 0 ? 0 : LIGHTJUMP;
                    }
                }

            }

            if (this.Visible && this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
            }
        }

        private void TrBrightness_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BrightnessManager.SetBrightness((byte)trBrightness.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ntfLightOut.Visible = false;
            _timer.Stop();
            _timer.Dispose();
        }

        private void chRunWithWindows_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ntfLightOut_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = !this.Visible;
        }
    }
}
