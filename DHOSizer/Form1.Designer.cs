namespace DHOSizer
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.tbX1 = new System.Windows.Forms.TextBox();
			this.tbY1 = new System.Windows.Forms.TextBox();
			this.tbWidth1 = new System.Windows.Forms.TextBox();
			this.tbHeight1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbHeight2 = new System.Windows.Forms.TextBox();
			this.tbWidth2 = new System.Windows.Forms.TextBox();
			this.tbY2 = new System.Windows.Forms.TextBox();
			this.tbX2 = new System.Windows.Forms.TextBox();
			this.chkMostTop = new System.Windows.Forms.CheckBox();
			this.tbnGet1 = new System.Windows.Forms.Button();
			this.btnGet2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(11, 135);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 57);
			this.button1.TabIndex = 0;
			this.button1.Text = "1번";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(190, 135);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(108, 57);
			this.button2.TabIndex = 1;
			this.button2.Text = "2번";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// tbX1
			// 
			this.tbX1.Location = new System.Drawing.Point(33, 47);
			this.tbX1.Name = "tbX1";
			this.tbX1.Size = new System.Drawing.Size(50, 21);
			this.tbX1.TabIndex = 2;
			this.tbX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbX1.TextChanged += new System.EventHandler(this.tbX1_TextChanged);
			// 
			// tbY1
			// 
			this.tbY1.Location = new System.Drawing.Point(114, 47);
			this.tbY1.Name = "tbY1";
			this.tbY1.Size = new System.Drawing.Size(50, 21);
			this.tbY1.TabIndex = 3;
			this.tbY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbY1.TextChanged += new System.EventHandler(this.tbY1_TextChanged);
			// 
			// tbWidth1
			// 
			this.tbWidth1.Location = new System.Drawing.Point(55, 74);
			this.tbWidth1.Name = "tbWidth1";
			this.tbWidth1.Size = new System.Drawing.Size(109, 21);
			this.tbWidth1.TabIndex = 4;
			this.tbWidth1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbWidth1.TextChanged += new System.EventHandler(this.tbWidth1_TextChanged);
			// 
			// tbHeight1
			// 
			this.tbHeight1.Location = new System.Drawing.Point(55, 101);
			this.tbHeight1.Name = "tbHeight1";
			this.tbHeight1.Size = new System.Drawing.Size(109, 21);
			this.tbHeight1.TabIndex = 5;
			this.tbHeight1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbHeight1.TextChanged += new System.EventHandler(this.tbHeight1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(13, 12);
			this.label1.TabIndex = 6;
			this.label1.Text = "X";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(95, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 12);
			this.label2.TabIndex = 7;
			this.label2.Text = "Y";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "Width";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 12);
			this.label4.TabIndex = 9;
			this.label4.Text = "Height";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(192, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 12);
			this.label5.TabIndex = 17;
			this.label5.Text = "Height";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(192, 77);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 12);
			this.label6.TabIndex = 16;
			this.label6.Text = "Width";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(273, 50);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(13, 12);
			this.label7.TabIndex = 15;
			this.label7.Text = "Y";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(192, 50);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(13, 12);
			this.label8.TabIndex = 14;
			this.label8.Text = "X";
			// 
			// tbHeight2
			// 
			this.tbHeight2.Location = new System.Drawing.Point(233, 101);
			this.tbHeight2.Name = "tbHeight2";
			this.tbHeight2.Size = new System.Drawing.Size(109, 21);
			this.tbHeight2.TabIndex = 13;
			this.tbHeight2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbHeight2.TextChanged += new System.EventHandler(this.tbHeight2_TextChanged);
			// 
			// tbWidth2
			// 
			this.tbWidth2.Location = new System.Drawing.Point(233, 74);
			this.tbWidth2.Name = "tbWidth2";
			this.tbWidth2.Size = new System.Drawing.Size(109, 21);
			this.tbWidth2.TabIndex = 12;
			this.tbWidth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbWidth2.TextChanged += new System.EventHandler(this.tbWidth2_TextChanged);
			// 
			// tbY2
			// 
			this.tbY2.Location = new System.Drawing.Point(292, 47);
			this.tbY2.Name = "tbY2";
			this.tbY2.Size = new System.Drawing.Size(50, 21);
			this.tbY2.TabIndex = 11;
			this.tbY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbY2.TextChanged += new System.EventHandler(this.tbY2_TextChanged);
			// 
			// tbX2
			// 
			this.tbX2.Location = new System.Drawing.Point(211, 47);
			this.tbX2.Name = "tbX2";
			this.tbX2.Size = new System.Drawing.Size(50, 21);
			this.tbX2.TabIndex = 10;
			this.tbX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbX2.TextChanged += new System.EventHandler(this.tbX2_TextChanged);
			// 
			// chkMostTop
			// 
			this.chkMostTop.AutoSize = true;
			this.chkMostTop.Location = new System.Drawing.Point(11, 13);
			this.chkMostTop.Name = "chkMostTop";
			this.chkMostTop.Size = new System.Drawing.Size(76, 16);
			this.chkMostTop.TabIndex = 18;
			this.chkMostTop.Text = "항상 위에";
			this.chkMostTop.UseVisualStyleBackColor = true;
			this.chkMostTop.CheckedChanged += new System.EventHandler(this.chkMostTop_CheckedChanged);
			// 
			// tbnGet1
			// 
			this.tbnGet1.Location = new System.Drawing.Point(126, 135);
			this.tbnGet1.Name = "tbnGet1";
			this.tbnGet1.Size = new System.Drawing.Size(38, 57);
			this.tbnGet1.TabIndex = 19;
			this.tbnGet1.Text = "가져오기";
			this.tbnGet1.UseVisualStyleBackColor = true;
			this.tbnGet1.Click += new System.EventHandler(this.tbnGet1_Click);
			// 
			// btnGet2
			// 
			this.btnGet2.Location = new System.Drawing.Point(304, 135);
			this.btnGet2.Name = "btnGet2";
			this.btnGet2.Size = new System.Drawing.Size(38, 57);
			this.btnGet2.TabIndex = 20;
			this.btnGet2.Text = "가져오기";
			this.btnGet2.UseVisualStyleBackColor = true;
			this.btnGet2.Click += new System.EventHandler(this.btnGet2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(355, 199);
			this.Controls.Add(this.btnGet2);
			this.Controls.Add(this.tbnGet1);
			this.Controls.Add(this.chkMostTop);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tbHeight2);
			this.Controls.Add(this.tbWidth2);
			this.Controls.Add(this.tbY2);
			this.Controls.Add(this.tbX2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbHeight1);
			this.Controls.Add(this.tbWidth1);
			this.Controls.Add(this.tbY1);
			this.Controls.Add(this.tbX1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "DHO Sizer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox tbX1;
		private System.Windows.Forms.TextBox tbY1;
		private System.Windows.Forms.TextBox tbWidth1;
		private System.Windows.Forms.TextBox tbHeight1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbHeight2;
		private System.Windows.Forms.TextBox tbWidth2;
		private System.Windows.Forms.TextBox tbY2;
		private System.Windows.Forms.TextBox tbX2;
		private System.Windows.Forms.CheckBox chkMostTop;
		private System.Windows.Forms.Button tbnGet1;
		private System.Windows.Forms.Button btnGet2;
	}
}

