
namespace PingoHelpApp
{
    partial class Lab
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.AuthorInfo = new System.Windows.Forms.TabPage();
            this.Info = new System.Windows.Forms.Label();
            this.MainTask = new System.Windows.Forms.TabPage();
            this.ResultOut = new System.Windows.Forms.DataGridView();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.DoTask = new System.Windows.Forms.Button();
            this.EnterK = new System.Windows.Forms.TextBox();
            this.EnterN = new System.Windows.Forms.TextBox();
            this.EnterNK = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.AuthorInfo.SuspendLayout();
            this.MainTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultOut)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.AuthorInfo);
            this.tabControl.Controls.Add(this.MainTask);
            this.tabControl.Location = new System.Drawing.Point(0, -1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(656, 299);
            this.tabControl.TabIndex = 1;
            // 
            // AuthorInfo
            // 
            this.AuthorInfo.Controls.Add(this.Info);
            this.AuthorInfo.Location = new System.Drawing.Point(4, 29);
            this.AuthorInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuthorInfo.Name = "AuthorInfo";
            this.AuthorInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AuthorInfo.Size = new System.Drawing.Size(648, 266);
            this.AuthorInfo.TabIndex = 0;
            this.AuthorInfo.Text = "О программе";
            this.AuthorInfo.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Info.Location = new System.Drawing.Point(9, 9);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(647, 297);
            this.Info.TabIndex = 0;
            this.Info.Text = resources.GetString("Info.Text");
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // MainTask
            // 
            this.MainTask.Controls.Add(this.ResultOut);
            this.MainTask.Controls.Add(this.ErrorLabel);
            this.MainTask.Controls.Add(this.DoTask);
            this.MainTask.Controls.Add(this.EnterK);
            this.MainTask.Controls.Add(this.EnterN);
            this.MainTask.Controls.Add(this.EnterNK);
            this.MainTask.Location = new System.Drawing.Point(4, 29);
            this.MainTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTask.Name = "MainTask";
            this.MainTask.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTask.Size = new System.Drawing.Size(648, 266);
            this.MainTask.TabIndex = 1;
            this.MainTask.Text = "Задание";
            this.MainTask.UseVisualStyleBackColor = true;
            this.MainTask.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // ResultOut
            // 
            this.ResultOut.AllowUserToDeleteRows = false;
            this.ResultOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultOut.Location = new System.Drawing.Point(9, 91);
            this.ResultOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResultOut.Name = "ResultOut";
            this.ResultOut.ReadOnly = true;
            this.ResultOut.RowHeadersWidth = 51;
            this.ResultOut.RowTemplate.Height = 25;
            this.ResultOut.Size = new System.Drawing.Size(350, 152);
            this.ResultOut.TabIndex = 7;
            this.ResultOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(397, 84);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorLabel.TabIndex = 5;
            // 
            // DoTask
            // 
            this.DoTask.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoTask.Location = new System.Drawing.Point(397, 108);
            this.DoTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoTask.Name = "DoTask";
            this.DoTask.Size = new System.Drawing.Size(207, 111);
            this.DoTask.TabIndex = 4;
            this.DoTask.Text = "Вывести последовательности";
            this.DoTask.UseVisualStyleBackColor = true;
            this.DoTask.Click += new System.EventHandler(this.DoTask_Click);
            // 
            // EnterK
            // 
            this.EnterK.Location = new System.Drawing.Point(541, 45);
            this.EnterK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnterK.Name = "EnterK";
            this.EnterK.Size = new System.Drawing.Size(62, 27);
            this.EnterK.TabIndex = 2;
            // 
            // EnterN
            // 
            this.EnterN.Location = new System.Drawing.Point(541, 9);
            this.EnterN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EnterN.Name = "EnterN";
            this.EnterN.Size = new System.Drawing.Size(62, 27);
            this.EnterN.TabIndex = 1;
            // 
            // EnterNK
            // 
            this.EnterNK.AutoSize = true;
            this.EnterNK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterNK.Location = new System.Drawing.Point(9, 9);
            this.EnterNK.Name = "EnterNK";
            this.EnterNK.Size = new System.Drawing.Size(482, 56);
            this.EnterNK.TabIndex = 0;
            this.EnterNK.Text = "Введите длину выводимых последовательностей:\r\nВведите максимальное натуральное чи" +
    "сло членов:";
            // 
            // Lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(654, 289);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Lab";
            this.Text = "Lab1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.AuthorInfo.ResumeLayout(false);
            this.AuthorInfo.PerformLayout();
            this.MainTask.ResumeLayout(false);
            this.MainTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage AuthorInfo;
        private System.Windows.Forms.TabPage MainTask;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.TextBox EnterK;
        private System.Windows.Forms.TextBox EnterN;
        private System.Windows.Forms.Label EnterNK;
        private System.Windows.Forms.Button DoTask;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.DataGridView ResultOut;
    }
}

