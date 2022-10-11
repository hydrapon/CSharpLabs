namespace LabTwo
{
    partial class menuForm
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
            this.menuBtnTask1 = new System.Windows.Forms.Button();
            this.MenuLable = new System.Windows.Forms.Label();
            this.menuBtnTask2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuBtnTask1
            // 
            this.menuBtnTask1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtnTask1.Location = new System.Drawing.Point(24, 72);
            this.menuBtnTask1.Name = "menuBtnTask1";
            this.menuBtnTask1.Size = new System.Drawing.Size(80, 60);
            this.menuBtnTask1.TabIndex = 0;
            this.menuBtnTask1.Text = "Задача 1";
            this.menuBtnTask1.UseVisualStyleBackColor = true;
            this.menuBtnTask1.Click += new System.EventHandler(this.menuBtnTask1_Click);
            // 
            // MenuLable
            // 
            this.MenuLable.AutoSize = true;
            this.MenuLable.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuLable.Location = new System.Drawing.Point(314, 9);
            this.MenuLable.Name = "MenuLable";
            this.MenuLable.Size = new System.Drawing.Size(93, 37);
            this.MenuLable.TabIndex = 1;
            this.MenuLable.Text = "Меню";
            // 
            // menuBtnTask2
            // 
            this.menuBtnTask2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuBtnTask2.Location = new System.Drawing.Point(123, 72);
            this.menuBtnTask2.Name = "menuBtnTask2";
            this.menuBtnTask2.Size = new System.Drawing.Size(80, 60);
            this.menuBtnTask2.TabIndex = 2;
            this.menuBtnTask2.Text = "Задача 2";
            this.menuBtnTask2.UseVisualStyleBackColor = true;
            this.menuBtnTask2.Click += new System.EventHandler(this.menuBtnTask2_Click);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuBtnTask2);
            this.Controls.Add(this.MenuLable);
            this.Controls.Add(this.menuBtnTask1);
            this.Name = "menuForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button menuBtnTask1;
        private Label MenuLable;
        private Button menuBtnTask2;
    }
}