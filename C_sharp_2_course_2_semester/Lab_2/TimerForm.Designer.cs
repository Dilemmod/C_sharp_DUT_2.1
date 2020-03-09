namespace L3_Task_4
{
    partial class TimerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_Ok.FlatAppearance.BorderSize = 0;
            this.btn_Ok.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Ok.Location = new System.Drawing.Point(291, 201);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(100, 50);
            this.btn_Ok.TabIndex = 0;
            this.btn_Ok.TabStop = false;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_Cancel.Font = new System.Drawing.Font("Mistral", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Cancel.Location = new System.Drawing.Point(291, 272);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 50);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.btn_Cancel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
    }
}

