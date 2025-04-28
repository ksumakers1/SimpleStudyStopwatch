
namespace SimpleStudyStopwatch
{
    partial class form_stopwatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_stopwatch));
            this.label_stopwatch = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btn_viewStats = new System.Windows.Forms.Button();
            this.side_Panel = new System.Windows.Forms.Panel();
            this.rdbtn_dark = new System.Windows.Forms.RadioButton();
            this.rdbtn_light = new System.Windows.Forms.RadioButton();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.label_enterSubject = new System.Windows.Forms.Label();
            this.side_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_stopwatch
            // 
            this.label_stopwatch.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label_stopwatch, "label_stopwatch");
            this.label_stopwatch.ForeColor = System.Drawing.Color.White;
            this.label_stopwatch.Name = "label_stopwatch";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btn_start, "btn_start");
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Name = "btn_start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btn_stop, "btn_stop");
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btn_Reset, "btn_Reset");
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubject.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txtSubject, "txtSubject");
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.TextChanged += new System.EventHandler(this.txtSubject_TextChanged);
            // 
            // btn_viewStats
            // 
            this.btn_viewStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btn_viewStats, "btn_viewStats");
            this.btn_viewStats.ForeColor = System.Drawing.Color.White;
            this.btn_viewStats.Name = "btn_viewStats";
            this.btn_viewStats.UseVisualStyleBackColor = false;
            this.btn_viewStats.Click += new System.EventHandler(this.btn_viewStats_Click);
            // 
            // side_Panel
            // 
            this.side_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.side_Panel.Controls.Add(this.rdbtn_dark);
            this.side_Panel.Controls.Add(this.rdbtn_light);
            resources.ApplyResources(this.side_Panel, "side_Panel");
            this.side_Panel.Name = "side_Panel";
            this.side_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.side_Panel_Paint);
            // 
            // rdbtn_dark
            // 
            resources.ApplyResources(this.rdbtn_dark, "rdbtn_dark");
            this.rdbtn_dark.ForeColor = System.Drawing.Color.White;
            this.rdbtn_dark.Name = "rdbtn_dark";
            this.rdbtn_dark.TabStop = true;
            this.rdbtn_dark.UseVisualStyleBackColor = true;
            this.rdbtn_dark.CheckedChanged += new System.EventHandler(this.rdbtn_dark_CheckedChanged);
            // 
            // rdbtn_light
            // 
            resources.ApplyResources(this.rdbtn_light, "rdbtn_light");
            this.rdbtn_light.ForeColor = System.Drawing.Color.White;
            this.rdbtn_light.Name = "rdbtn_light";
            this.rdbtn_light.TabStop = true;
            this.rdbtn_light.UseVisualStyleBackColor = true;
            this.rdbtn_light.CheckedChanged += new System.EventHandler(this.rdbtn_light_CheckedChanged);
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btn_Menu, "btn_Menu");
            this.btn_Menu.ForeColor = System.Drawing.Color.White;
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // label_enterSubject
            // 
            resources.ApplyResources(this.label_enterSubject, "label_enterSubject");
            this.label_enterSubject.ForeColor = System.Drawing.Color.White;
            this.label_enterSubject.Name = "label_enterSubject";
            // 
            // form_stopwatch
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.side_Panel);
            this.Controls.Add(this.btn_viewStats);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.label_stopwatch);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label_enterSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_stopwatch";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.form_stopwatch_Load);
            this.side_Panel.ResumeLayout(false);
            this.side_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_stopwatch;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btn_viewStats;
        private System.Windows.Forms.Panel side_Panel;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.RadioButton rdbtn_dark;
        private System.Windows.Forms.RadioButton rdbtn_light;
        private System.Windows.Forms.Label label_enterSubject;
    }
}

