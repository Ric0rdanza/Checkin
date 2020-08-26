namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CheckStudent = new System.Windows.Forms.Label();
            this.Arrived = new System.Windows.Forms.Button();
            this.Absence = new System.Windows.Forms.Button();
            this.AskLeave = new System.Windows.Forms.Button();
            this.CheckId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckStudent
            // 
            this.CheckStudent.AutoSize = true;
            this.CheckStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckStudent.Location = new System.Drawing.Point(164, 117);
            this.CheckStudent.Name = "CheckStudent";
            this.CheckStudent.Size = new System.Drawing.Size(233, 107);
            this.CheckStudent.TabIndex = 0;
            this.CheckStudent.Text = "姓名";
            this.CheckStudent.Click += new System.EventHandler(this.CheckStudent_Click);
            // 
            // Arrived
            // 
            this.Arrived.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Arrived.Location = new System.Drawing.Point(535, 68);
            this.Arrived.Name = "Arrived";
            this.Arrived.Size = new System.Drawing.Size(158, 68);
            this.Arrived.TabIndex = 1;
            this.Arrived.Text = "签到";
            this.Arrived.UseVisualStyleBackColor = true;
            this.Arrived.Click += new System.EventHandler(this.Arrived_Click);
            // 
            // Absence
            // 
            this.Absence.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Absence.Location = new System.Drawing.Point(535, 183);
            this.Absence.Name = "Absence";
            this.Absence.Size = new System.Drawing.Size(158, 68);
            this.Absence.TabIndex = 2;
            this.Absence.Text = "缺席";
            this.Absence.UseVisualStyleBackColor = true;
            this.Absence.Click += new System.EventHandler(this.Absence_Click);
            // 
            // AskLeave
            // 
            this.AskLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AskLeave.Location = new System.Drawing.Point(535, 298);
            this.AskLeave.Name = "AskLeave";
            this.AskLeave.Size = new System.Drawing.Size(158, 68);
            this.AskLeave.TabIndex = 3;
            this.AskLeave.Text = "请假";
            this.AskLeave.UseVisualStyleBackColor = true;
            this.AskLeave.Click += new System.EventHandler(this.Leave_Click);
            // 
            // CheckId
            // 
            this.CheckId.AutoSize = true;
            this.CheckId.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckId.Location = new System.Drawing.Point(165, 251);
            this.CheckId.Name = "CheckId";
            this.CheckId.Size = new System.Drawing.Size(231, 54);
            this.CheckId.TabIndex = 4;
            this.CheckId.Text = "00000000";
            this.CheckId.Click += new System.EventHandler(this.StudentId_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 95);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckId);
            this.Controls.Add(this.AskLeave);
            this.Controls.Add(this.Absence);
            this.Controls.Add(this.Arrived);
            this.Controls.Add(this.CheckStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CheckStudent;
        private System.Windows.Forms.Button Arrived;
        private System.Windows.Forms.Button Absence;
        private System.Windows.Forms.Button AskLeave;
        private System.Windows.Forms.Label CheckId;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

