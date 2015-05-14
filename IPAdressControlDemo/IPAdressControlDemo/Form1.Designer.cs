namespace IPAddressControlDemo
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.ipAddressControl1 = new IPAddressControlLibrary.IPAddressControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(400, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.ipAddressControl1;
            this.propertyGrid1.Size = new System.Drawing.Size(296, 396);
            this.propertyGrid1.TabIndex = 1;
            // 
            // ipAddressControl1
            // 
            this.ipAddressControl1.IPAddress = ((System.Net.IPAddress)(resources.GetObject("ipAddressControl1.IPAddress")));
            this.ipAddressControl1.Location = new System.Drawing.Point(12, 12);
            this.ipAddressControl1.Name = "ipAddressControl1";
            this.ipAddressControl1.Size = new System.Drawing.Size(181, 26);
            this.ipAddressControl1.TabIndex = 0;
            this.ipAddressControl1.IPAddressChanged += new System.EventHandler(this.ipAddressControl1_IPAddressChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.ipAddressControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IPAddressControlLibrary.IPAddressControl ipAddressControl1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Label label1;
    }
}

