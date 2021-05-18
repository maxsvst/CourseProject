
namespace CourseProj
{
    partial class IncomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeForm));
            this.sumField = new System.Windows.Forms.TextBox();
            this.commentField = new System.Windows.Forms.TextBox();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.sourceField = new System.Windows.Forms.ComboBox();
            this.addIncomeButton = new System.Windows.Forms.Button();
            this.incomeImage = new System.Windows.Forms.PictureBox();
            this.walletField = new System.Windows.Forms.ComboBox();
            this.cashCheck = new System.Windows.Forms.CheckBox();
            this.cardCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.incomeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // sumField
            // 
            this.sumField.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumField.ForeColor = System.Drawing.Color.Black;
            this.sumField.Location = new System.Drawing.Point(133, 345);
            this.sumField.Margin = new System.Windows.Forms.Padding(6);
            this.sumField.Name = "sumField";
            this.sumField.Size = new System.Drawing.Size(337, 48);
            this.sumField.TabIndex = 3;
            this.sumField.Text = "Сумма";
            this.sumField.Enter += new System.EventHandler(this.sumField_Enter);
            this.sumField.Leave += new System.EventHandler(this.sumField_Leave);
            // 
            // commentField
            // 
            this.commentField.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentField.ForeColor = System.Drawing.Color.Black;
            this.commentField.Location = new System.Drawing.Point(133, 492);
            this.commentField.Margin = new System.Windows.Forms.Padding(6);
            this.commentField.Name = "commentField";
            this.commentField.Size = new System.Drawing.Size(337, 48);
            this.commentField.TabIndex = 5;
            this.commentField.Text = "Комментарий";
            this.commentField.Enter += new System.EventHandler(this.commentField_Enter);
            this.commentField.Leave += new System.EventHandler(this.commentField_Leave);
            // 
            // dateField
            // 
            this.dateField.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateField.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateField.Location = new System.Drawing.Point(133, 418);
            this.dateField.MaxDate = new System.DateTime(2021, 5, 18, 0, 0, 0, 0);
            this.dateField.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(337, 48);
            this.dateField.TabIndex = 4;
            this.dateField.Value = new System.DateTime(2021, 5, 18, 0, 0, 0, 0);
            // 
            // sourceField
            // 
            this.sourceField.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sourceField.ForeColor = System.Drawing.Color.Black;
            this.sourceField.FormattingEnabled = true;
            this.sourceField.Items.AddRange(new object[] {
            "Хуй",
            "Жопа",
            "Говно"});
            this.sourceField.Location = new System.Drawing.Point(133, 273);
            this.sourceField.Name = "sourceField";
            this.sourceField.Size = new System.Drawing.Size(337, 48);
            this.sourceField.TabIndex = 2;
            this.sourceField.Text = "Источник";
            // 
            // addIncomeButton
            // 
            this.addIncomeButton.BackColor = System.Drawing.Color.AliceBlue;
            this.addIncomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addIncomeButton.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.addIncomeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.addIncomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addIncomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIncomeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addIncomeButton.ForeColor = System.Drawing.Color.Black;
            this.addIncomeButton.Location = new System.Drawing.Point(124, 592);
            this.addIncomeButton.Name = "addIncomeButton";
            this.addIncomeButton.Size = new System.Drawing.Size(355, 80);
            this.addIncomeButton.TabIndex = 0;
            this.addIncomeButton.Text = "Добавить доход";
            this.addIncomeButton.UseVisualStyleBackColor = false;
            this.addIncomeButton.Click += new System.EventHandler(this.addIncomeButton_Click);
            // 
            // incomeImage
            // 
            this.incomeImage.Image = ((System.Drawing.Image)(resources.GetObject("incomeImage.Image")));
            this.incomeImage.Location = new System.Drawing.Point(133, -19);
            this.incomeImage.Name = "incomeImage";
            this.incomeImage.Size = new System.Drawing.Size(323, 182);
            this.incomeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.incomeImage.TabIndex = 12;
            this.incomeImage.TabStop = false;
            // 
            // walletField
            // 
            this.walletField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.walletField.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.walletField.ForeColor = System.Drawing.Color.Black;
            this.walletField.FormattingEnabled = true;
            this.walletField.Items.AddRange(new object[] {
            "хуй",
            "жопс",
            "говен"});
            this.walletField.Location = new System.Drawing.Point(133, 169);
            this.walletField.Name = "walletField";
            this.walletField.Size = new System.Drawing.Size(337, 48);
            this.walletField.TabIndex = 1;
            // 
            // cashCheck
            // 
            this.cashCheck.AutoSize = true;
            this.cashCheck.Checked = true;
            this.cashCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cashCheck.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashCheck.Location = new System.Drawing.Point(145, 233);
            this.cashCheck.Name = "cashCheck";
            this.cashCheck.Size = new System.Drawing.Size(125, 26);
            this.cashCheck.TabIndex = 13;
            this.cashCheck.Text = "Наличные";
            this.cashCheck.UseVisualStyleBackColor = true;
            this.cashCheck.CheckedChanged += new System.EventHandler(this.cashCheck_CheckedChanged);
            // 
            // cardCheck
            // 
            this.cardCheck.AutoSize = true;
            this.cardCheck.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardCheck.ForeColor = System.Drawing.Color.Black;
            this.cardCheck.Location = new System.Drawing.Point(327, 233);
            this.cardCheck.Name = "cardCheck";
            this.cardCheck.Size = new System.Drawing.Size(143, 26);
            this.cardCheck.TabIndex = 14;
            this.cardCheck.Text = "Безаличные";
            this.cardCheck.UseVisualStyleBackColor = true;
            this.cardCheck.CheckedChanged += new System.EventHandler(this.cardCheck_CheckedChanged);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 739);
            this.Controls.Add(this.cardCheck);
            this.Controls.Add(this.cashCheck);
            this.Controls.Add(this.incomeImage);
            this.Controls.Add(this.addIncomeButton);
            this.Controls.Add(this.sourceField);
            this.Controls.Add(this.walletField);
            this.Controls.Add(this.dateField);
            this.Controls.Add(this.commentField);
            this.Controls.Add(this.sumField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(632, 786);
            this.MinimumSize = new System.Drawing.Size(632, 786);
            this.Name = "IncomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IncomeForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.incomeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sumField;
        private System.Windows.Forms.TextBox commentField;
        private System.Windows.Forms.DateTimePicker dateField;
        private System.Windows.Forms.ComboBox sourceField;
        private System.Windows.Forms.Button addIncomeButton;
        private System.Windows.Forms.PictureBox incomeImage;
        private System.Windows.Forms.ComboBox walletField;
        private System.Windows.Forms.CheckBox cashCheck;
        private System.Windows.Forms.CheckBox cardCheck;
    }
}