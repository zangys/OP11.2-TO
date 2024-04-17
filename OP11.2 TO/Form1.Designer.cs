namespace TrainManagementSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows
        private void InitializeComponent()
        {
            this.listBoxTrains = new System.Windows.Forms.ListBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonGenerateDestination = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTrains
            // 
            this.listBoxTrains.FormattingEnabled = true;
            this.listBoxTrains.HorizontalScrollbar = true;
            this.listBoxTrains.ItemHeight = 16;
            this.listBoxTrains.Location = new System.Drawing.Point(12, 12);
            this.listBoxTrains.Name = "listBoxTrains";
            this.listBoxTrains.Size = new System.Drawing.Size(374, 292);
            this.listBoxTrains.TabIndex = 0;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(12, 318);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(159, 17);
            this.labelDestination.TabIndex = 1;
            this.labelDestination.Text = "Введите пункт назнач:";
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(177, 315);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(209, 22);
            this.textBoxDestination.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 353);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(184, 29);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Найти поезда";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonGenerateDestination
            // 
            this.buttonGenerateDestination.Location = new System.Drawing.Point(202, 353);
            this.buttonGenerateDestination.Name = "buttonGenerateDestination";
            this.buttonGenerateDestination.Size = new System.Drawing.Size(184, 29);
            this.buttonGenerateDestination.TabIndex = 4;
            this.buttonGenerateDestination.Text = "Случайный пункт";
            this.buttonGenerateDestination.UseVisualStyleBackColor = true;
            this.buttonGenerateDestination.Click += new System.EventHandler(this.buttonGenerateDestination_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 397);
            this.Controls.Add(this.buttonGenerateDestination);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxDestination);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.listBoxTrains);
            this.Name = "Form1";
            this.Text = "Train Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTrains;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonGenerateDestination;
    }
}
