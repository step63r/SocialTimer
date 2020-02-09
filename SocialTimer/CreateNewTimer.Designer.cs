namespace SocialTimer
{
    partial class CreateNewTimer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputMaxLP = new System.Windows.Forms.NumericUpDown();
            this.inputCurrentLP = new System.Windows.Forms.NumericUpDown();
            this.inputRecoverCycle = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCreateAsDefault = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputMaxLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCurrentLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputRecoverCycle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "最大値：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "現在値：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "回復周期：";
            // 
            // inputMaxLP
            // 
            this.inputMaxLP.Location = new System.Drawing.Point(65, 48);
            this.inputMaxLP.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.inputMaxLP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputMaxLP.Name = "inputMaxLP";
            this.inputMaxLP.Size = new System.Drawing.Size(105, 19);
            this.inputMaxLP.TabIndex = 1;
            this.inputMaxLP.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // inputCurrentLP
            // 
            this.inputCurrentLP.Location = new System.Drawing.Point(65, 81);
            this.inputCurrentLP.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.inputCurrentLP.Name = "inputCurrentLP";
            this.inputCurrentLP.Size = new System.Drawing.Size(105, 19);
            this.inputCurrentLP.TabIndex = 2;
            // 
            // inputRecoverCycle
            // 
            this.inputRecoverCycle.Location = new System.Drawing.Point(77, 114);
            this.inputRecoverCycle.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.inputRecoverCycle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputRecoverCycle.Name = "inputRecoverCycle";
            this.inputRecoverCycle.Size = new System.Drawing.Size(93, 19);
            this.inputRecoverCycle.TabIndex = 3;
            this.inputRecoverCycle.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "分 / LP";
            // 
            // inputName
            // 
            this.inputName.ForeColor = System.Drawing.Color.Gray;
            this.inputName.Location = new System.Drawing.Point(14, 12);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(252, 19);
            this.inputName.TabIndex = 4;
            this.inputName.Text = "名前を入力";
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            this.inputName.Enter += new System.EventHandler(this.inputName_Enter);
            this.inputName.Leave += new System.EventHandler(this.inputName_Leave);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Enabled = false;
            this.buttonCreate.Location = new System.Drawing.Point(12, 145);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(254, 23);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "完了";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonCreateAsDefault
            // 
            this.buttonCreateAsDefault.Enabled = false;
            this.buttonCreateAsDefault.Location = new System.Drawing.Point(12, 174);
            this.buttonCreateAsDefault.Name = "buttonCreateAsDefault";
            this.buttonCreateAsDefault.Size = new System.Drawing.Size(254, 23);
            this.buttonCreateAsDefault.TabIndex = 6;
            this.buttonCreateAsDefault.Text = "既存に設定し完了";
            this.buttonCreateAsDefault.UseVisualStyleBackColor = true;
            this.buttonCreateAsDefault.Click += new System.EventHandler(this.buttonCreateAsDefault_Click);
            // 
            // CreateNewTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 208);
            this.Controls.Add(this.buttonCreateAsDefault);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputRecoverCycle);
            this.Controls.Add(this.inputCurrentLP);
            this.Controls.Add(this.inputMaxLP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::SocialTimer.Properties.Settings.Default, "SetUpTimerDefaultSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = global::SocialTimer.Properties.Settings.Default.SetUpTimerDefaultSetting;
            this.MaximizeBox = false;
            this.Name = "CreateNewTimer";
            this.Text = "タイマーのセットアップ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateNewTimer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.inputMaxLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCurrentLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputRecoverCycle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inputMaxLP;
        private System.Windows.Forms.NumericUpDown inputCurrentLP;
        private System.Windows.Forms.NumericUpDown inputRecoverCycle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCreateAsDefault;
    }
}