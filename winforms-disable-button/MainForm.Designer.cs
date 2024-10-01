namespace winforms_disable_button
{
    partial class MainForm
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
            customButton = new ButtonEx();
            checkBoxDisable = new CheckBox();
            SuspendLayout();
            // 
            // customButton
            // 
            customButton.ForeColorDisabled = Color.Red;
            customButton.Location = new Point(109, 101);
            customButton.Name = "customButton";
            customButton.Size = new Size(112, 34);
            customButton.TabIndex = 0;
            customButton.Text = "Custom";
            customButton.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisable
            // 
            checkBoxDisable.AutoSize = true;
            checkBoxDisable.Location = new Point(239, 105);
            checkBoxDisable.Name = "checkBoxDisable";
            checkBoxDisable.Size = new Size(96, 29);
            checkBoxDisable.TabIndex = 1;
            checkBoxDisable.Text = "Disable";
            checkBoxDisable.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 244);
            Controls.Add(checkBoxDisable);
            Controls.Add(customButton);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ButtonEx customButton;
        private CheckBox checkBoxDisable;
    }
}
