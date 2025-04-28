//created by ksumakers1

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SimpleStudyStopwatch
{
    
    public partial class form_stopwatch : Form
    {
        private bool isRunning = false;
        private string subject;
        private DateTime startTime;
        private TimeSpan elapsedTime = TimeSpan.Zero;
        private TimeSpan currentElapsedTime;
        public form_stopwatch()
        {
            InitializeComponent();
            btn_start.Enabled = false;
            btn_stop.Enabled = false;
            btn_Reset.Enabled = false;
            side_Panel.Location = new Point (-200, 0);
            this.FormClosing += Form1_FormClosing;

            if (Theme.isDarkTheme) {rdbtn_dark.Checked = true;}
            else {rdbtn_light.Checked = true;}
        }

        private void UpdateAllControls(Color backColor, Color textColor)
        {
            this.BackColor = backColor;

            void UpdateControls(Control control)
            {
                control.BackColor = backColor;
                control.ForeColor = textColor;

                if (control is TextBox txt)
                {
                    txt.BackColor = Color.White;
                    txt.ForeColor = Color.Black;
                }

                foreach (Control child in control.Controls)
                {
                    UpdateControls(child);
                }
            }

            foreach (Control control in this.Controls)
            {
                UpdateControls(control);
            }
        }

        private void updateRGBvalue()
        {
            Color backColor, textColor;

            if (rdbtn_light.Checked)
            {
                backColor = Color.White;
                textColor = Color.Black;
                Theme.isDarkTheme = false;
            }
            else
            {
                backColor = Color.FromArgb(64, 64, 64);
                textColor = Color.White;
                Theme.isDarkTheme = true;
            }
            Theme.t_BackColor = backColor;
            Theme.t_TextColor = textColor;
            UpdateAllControls(backColor, textColor);
        }

        private void UpdateBtnState()
        {
            btn_start.Enabled = !isRunning && subject.Length >= 3;
            btn_stop.Enabled = isRunning;
            btn_Reset.Enabled = !(label_stopwatch.Text == "00:00:00") && !isRunning;
            txtSubject.Enabled = !isRunning;
            btn_viewStats.Enabled = !isRunning && label_stopwatch.Text == "00:00:00";

            if (Theme.isDarkTheme)
            {
                if (!txtSubject.Enabled) label_enterSubject.ForeColor = Color.Gray;
                else label_enterSubject.ForeColor = Color.White;
            }
            else
            {
                if (!txtSubject.Enabled) label_enterSubject.ForeColor = Color.Gray;
                else label_enterSubject.ForeColor = Color.Black;
            }
        }

        private void form_stopwatch_Load(object sender, EventArgs e)
        {
        }

        private void txtSubject_TextChanged(object sender, EventArgs e)
        {
            subject = txtSubject.Text;
            UpdateBtnState();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                startTime = DateTime.Now;
                timer1.Start();
                subject = txtSubject.Text;
                UpdateBtnState();
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if(isRunning)
            {
                isRunning = false;
                timer1.Stop();
                elapsedTime += DateTime.Now - startTime;
                UpdateBtnState();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentElapsedTime = elapsedTime + (DateTime.Now - startTime);
            label_stopwatch.Text = currentElapsedTime.ToString(@"hh\:mm\:ss");
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            isRunning = false;
            string folderPath = Path.Combine(Application.StartupPath, "data");
            string filePath = Path.Combine(folderPath, "study_stats.csv");
            double totalMinutes = currentElapsedTime.TotalMinutes;
            timer1.Stop();
            elapsedTime = TimeSpan.Zero;
            label_stopwatch.Text = elapsedTime.ToString(@"hh\:mm\:ss");

            UpdateBtnState();

            if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
            File.AppendAllText(filePath, $"{subject},{totalMinutes}\n");

            txtSubject.Text = " ";
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (side_Panel.Left < 0)
            {
                side_Panel.Left = 0;
            }
            else
            {
                side_Panel.Left = -side_Panel.Width;
            }
        }

        private void rdbtn_light_CheckedChanged(object sender, EventArgs e)
        {
            updateRGBvalue();
        }

        private void rdbtn_dark_CheckedChanged(object sender, EventArgs e)
        {
            updateRGBvalue();
        }

        private void label_Subject_Click(object sender, EventArgs e)
        {
        }

        private void btn_viewStats_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;
            form2.Show();
            this.Hide();
        }

        private void side_Panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
