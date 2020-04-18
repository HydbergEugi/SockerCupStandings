namespace SockerCupStandings
{
    partial class Standings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteMatch = new System.Windows.Forms.Button();
            this.UpdateMatch = new System.Windows.Forms.Button();
            this.insertMatch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1097, 550);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::SockerCupStandings.Properties.Resources.FootbalPitch;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1089, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Турнирная таблица";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(275, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(530, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Турнирная таблица чемпионата по футболу";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(79, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.Size = new System.Drawing.Size(922, 443);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::SockerCupStandings.Properties.Resources.FootballScore;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.DeleteMatch);
            this.tabPage2.Controls.Add(this.UpdateMatch);
            this.tabPage2.Controls.Add(this.insertMatch);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1089, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Матчи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(421, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сыгранные матчи";
            // 
            // DeleteMatch
            // 
            this.DeleteMatch.Location = new System.Drawing.Point(695, 476);
            this.DeleteMatch.Name = "DeleteMatch";
            this.DeleteMatch.Size = new System.Drawing.Size(106, 23);
            this.DeleteMatch.TabIndex = 3;
            this.DeleteMatch.Text = "Удалить матч";
            this.DeleteMatch.UseVisualStyleBackColor = true;
            this.DeleteMatch.Click += new System.EventHandler(this.DeleteMatch_Click);
            // 
            // UpdateMatch
            // 
            this.UpdateMatch.Location = new System.Drawing.Point(472, 476);
            this.UpdateMatch.Name = "UpdateMatch";
            this.UpdateMatch.Size = new System.Drawing.Size(106, 23);
            this.UpdateMatch.TabIndex = 2;
            this.UpdateMatch.Text = "Изменить матч";
            this.UpdateMatch.UseVisualStyleBackColor = true;
            this.UpdateMatch.Click += new System.EventHandler(this.UpdateMatch_Click);
            // 
            // insertMatch
            // 
            this.insertMatch.Location = new System.Drawing.Point(262, 476);
            this.insertMatch.Name = "insertMatch";
            this.insertMatch.Size = new System.Drawing.Size(106, 23);
            this.insertMatch.TabIndex = 1;
            this.insertMatch.Text = "Добавить матч";
            this.insertMatch.UseVisualStyleBackColor = true;
            this.insertMatch.Click += new System.EventHandler(this.insertMatch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(539, 387);
            this.dataGridView1.TabIndex = 0;
            // 
            // Standings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 554);
            this.Controls.Add(this.tabControl1);
            this.Name = "Standings";
            this.Text = "Чемпионат по футболу";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insertMatch;
        private System.Windows.Forms.Button UpdateMatch;
        private System.Windows.Forms.Button DeleteMatch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}