namespace UI_Foot_Trafic
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAttention = new System.Windows.Forms.Label();
            this.buttonMarks = new System.Windows.Forms.Button();
            this.buttonConnectCamera = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelAttention);
            this.panel1.Location = new System.Drawing.Point(21, 492);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 61);
            this.panel1.TabIndex = 0;
            // 
            // labelAttention
            // 
            this.labelAttention.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAttention.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttention.Location = new System.Drawing.Point(0, 0);
            this.labelAttention.Name = "labelAttention";
            this.labelAttention.Size = new System.Drawing.Size(970, 61);
            this.labelAttention.TabIndex = 0;
            this.labelAttention.Text = "!!! ВНИМАНИЕ ПЕШИХОД !!!";
            this.labelAttention.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMarks
            // 
            this.buttonMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMarks.Location = new System.Drawing.Point(765, 373);
            this.buttonMarks.Name = "buttonMarks";
            this.buttonMarks.Size = new System.Drawing.Size(226, 61);
            this.buttonMarks.TabIndex = 1;
            this.buttonMarks.Text = "Разметка";
            this.buttonMarks.UseVisualStyleBackColor = true;
            // 
            // buttonConnectCamera
            // 
            this.buttonConnectCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnectCamera.Location = new System.Drawing.Point(765, 281);
            this.buttonConnectCamera.Name = "buttonConnectCamera";
            this.buttonConnectCamera.Size = new System.Drawing.Size(226, 68);
            this.buttonConnectCamera.TabIndex = 2;
            this.buttonConnectCamera.Text = "Подключение камеры";
            this.buttonConnectCamera.UseVisualStyleBackColor = true;
            this.buttonConnectCamera.Click += new System.EventHandler(this.buttonConnectCamera_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(829, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(829, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(785, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(762, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pass :";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(21, 22);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(536, 347);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 565);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonConnectCamera);
            this.Controls.Add(this.buttonMarks);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Foot trafic";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAttention;
        private System.Windows.Forms.Button buttonMarks;
        private System.Windows.Forms.Button buttonConnectCamera;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}