namespace OpenH264Sample
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.btnEncode = new System.Windows.Forms.Button();
			this.nudFps = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.pbxScreen = new System.Windows.Forms.PictureBox();
			this.btnDecode = new System.Windows.Forms.Button();
			this.btnTestA = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudFps)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxScreen)).BeginInit();
			this.SuspendLayout();
			// 
			// btnEncode
			// 
			this.btnEncode.Location = new System.Drawing.Point(9, 10);
			this.btnEncode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnEncode.Name = "btnEncode";
			this.btnEncode.Size = new System.Drawing.Size(56, 20);
			this.btnEncode.TabIndex = 0;
			this.btnEncode.Text = "Encode";
			this.btnEncode.UseVisualStyleBackColor = true;
			this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
			// 
			// nudFps
			// 
			this.nudFps.Location = new System.Drawing.Point(78, 11);
			this.nudFps.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.nudFps.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.nudFps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudFps.Name = "nudFps";
			this.nudFps.Size = new System.Drawing.Size(34, 20);
			this.nudFps.TabIndex = 1;
			this.nudFps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nudFps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(115, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "fps";
			// 
			// pbxScreen
			// 
			this.pbxScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbxScreen.Location = new System.Drawing.Point(9, 36);
			this.pbxScreen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.pbxScreen.Name = "pbxScreen";
			this.pbxScreen.Size = new System.Drawing.Size(331, 204);
			this.pbxScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxScreen.TabIndex = 3;
			this.pbxScreen.TabStop = false;
			// 
			// btnDecode
			// 
			this.btnDecode.Location = new System.Drawing.Point(146, 10);
			this.btnDecode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnDecode.Name = "btnDecode";
			this.btnDecode.Size = new System.Drawing.Size(56, 20);
			this.btnDecode.TabIndex = 4;
			this.btnDecode.Text = "Decode";
			this.btnDecode.UseVisualStyleBackColor = true;
			this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
			// 
			// btnTestA
			// 
			this.btnTestA.Location = new System.Drawing.Point(206, 9);
			this.btnTestA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnTestA.Name = "btnTestA";
			this.btnTestA.Size = new System.Drawing.Size(56, 20);
			this.btnTestA.TabIndex = 5;
			this.btnTestA.Text = "TEST A";
			this.btnTestA.UseVisualStyleBackColor = true;
			this.btnTestA.Click += new System.EventHandler(this.BtnTestA_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 250);
			this.Controls.Add(this.btnTestA);
			this.Controls.Add(this.btnDecode);
			this.Controls.Add(this.pbxScreen);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nudFps);
			this.Controls.Add(this.btnEncode);
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "frmMain";
			this.Text = "OpenH264Sample";
			((System.ComponentModel.ISupportInitialize)(this.nudFps)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxScreen)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.NumericUpDown nudFps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxScreen;
        private System.Windows.Forms.Button btnDecode;
		private System.Windows.Forms.Button btnTestA;
	}
}

