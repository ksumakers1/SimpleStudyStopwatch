//created by ksumakers1

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace SimpleStudyStopwatch
{
    public partial class Form2 : Form
    {
        private string folderPath;
        private string filePath;

        public Form2()
        {
            InitializeComponent();
            folderPath = Path.Combine(Application.StartupPath, "data");
            filePath = Path.Combine(folderPath, "study_stats.csv");
            LoadSessions();
            UpdateAllControls();
            this.FormClosing += Form2_FormClosing1;
        }

        private void UpdateAllControls()
        {
            this.BackColor = Theme.t_BackColor;
            foreach (Control control in this.Controls)
            {
                UpdateControls(control);
            }
        }

        private void UpdateControls(Control control)
        {
            control.BackColor = Theme.t_BackColor;
            control.ForeColor = Theme.t_TextColor;

            if (control is TextBox)
            {
                control.BackColor = Color.White;
                control.ForeColor = Color.Black;
            }

            foreach (Control child in control.Controls)
            {
                UpdateControls(child);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void LoadSessions()
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                File.Create(filePath).Close();
            }

            Dictionary<string, double> subjectTotals = new Dictionary<string, double>();

            string[] allSessions = File.ReadAllLines(filePath);
            foreach (string session in allSessions)
            {
                string[] parts = session.Split(',');
                if (parts.Length >= 2 && double.TryParse(parts[1], out double minutes))
                {
                    string subject = parts[0];

                    if (subjectTotals.ContainsKey(subject))
                    {
                        subjectTotals[subject] += minutes;
                    }
                    else
                    {
                        subjectTotals.Add(subject, minutes);
                    }
                }
            }

            listBox1.Items.Clear();

            foreach (var subject in subjectTotals)
            {
                int hours = (int)(subject.Value / 60);
                int mins = (int)(subject.Value % 60);

                listBox1.Items.Add($"{subject.Key}: {hours}h {mins}m");
            }

            double totalMinutes = subjectTotals.Values.Sum();
            int totalHours = (int)(totalMinutes / 60);
            int totalMins = (int)(totalMinutes % 60);
            listBox1.Items.Add($"Total: {totalHours}h {totalMins}m");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            form_stopwatch form1 = new form_stopwatch();
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = this.Location;
            form1.Show();
            this.Hide();
        }

        private void Form2_FormClosing1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}