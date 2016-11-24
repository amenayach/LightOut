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

        private bool _lock = false;

        private BrightnessManager _brightnessManager;

        private KeyInterceptor _interceptor;

        private const int LIGHTJUMP = 5;
        
        public MainForm()
        {
            InitializeComponent();

            _brightnessManager = new BrightnessManager();

            _interceptor = new KeyInterceptor();
            _interceptor.KeyCaptured += _interceptor_KeyCaptured;
            _interceptor.Hook(this);

        }

        private void _interceptor_KeyCaptured(object sender, Keys keyCode)
        {
            if (ModifierKeys.HasFlag(Keys.Control) && ModifierKeys.HasFlag(Keys.Alt))
            {
                if (keyCode == Keys.Oemplus || keyCode == Keys.Add)
                {

                    if (trBrightness.Value < 100)
                    {
                        trBrightness.Value += trBrightness.Value + LIGHTJUMP > 100 ? 100 - trBrightness.Value : LIGHTJUMP;
                    }

                }
                else if (keyCode == Keys.OemMinus || keyCode == Keys.Subtract)
                {

                    if (trBrightness.Value > 0)
                    {
                        trBrightness.Value -= trBrightness.Value - LIGHTJUMP < 0 ? 0 : LIGHTJUMP;
                    }

                }

            }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {

                chRunWithWindows.Checked = HotKeyManager.IsAppInWinStartup();
                chRunWithWindows.CheckedChanged += ChRunWithWindows_CheckedChanged;

                trBrightness.Value = (int)_brightnessManager.GetBrightness();
                trBrightness.ValueChanged += TrBrightness_ValueChanged;
                
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

        private void TrBrightness_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (!_lock)
                {

                    _lock = true;

                    _brightnessManager.SetBrightness((byte)trBrightness.Value);

                    _lock = false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _lock = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ntfLightOut.Visible = false;
        }

        private void chRunWithWindows_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ntfLightOut_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                WindowState = FormWindowState.Normal;
                Visible = !Visible;

            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
