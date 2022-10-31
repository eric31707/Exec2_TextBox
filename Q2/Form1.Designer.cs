namespace Q2
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.resultlbl = new System.Windows.Forms.Label();
			this.datetxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.submitbtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// resultlbl
			// 
			this.resultlbl.AutoSize = true;
			this.resultlbl.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultlbl.Location = new System.Drawing.Point(118, 266);
			this.resultlbl.Name = "resultlbl";
			this.resultlbl.Size = new System.Drawing.Size(95, 27);
			this.resultlbl.TabIndex = 3;
			this.resultlbl.Text = "resultlbl";
			// 
			// datetxt
			// 
			this.datetxt.Location = new System.Drawing.Point(342, 100);
			this.datetxt.MaxLength = 33333333;
			this.datetxt.Name = "datetxt";
			this.datetxt.Size = new System.Drawing.Size(100, 22);
			this.datetxt.TabIndex = 2;
			this.datetxt.TextChanged += new System.EventHandler(this.datetxt_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(37, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "請輸入日期(yyyy/MM/dd)";
			// 
			// submitbtn
			// 
			this.submitbtn.Location = new System.Drawing.Point(493, 99);
			this.submitbtn.Name = "submitbtn";
			this.submitbtn.Size = new System.Drawing.Size(75, 23);
			this.submitbtn.TabIndex = 5;
			this.submitbtn.Text = "驗證";
			this.submitbtn.UseVisualStyleBackColor = true;
			this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.submitbtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.resultlbl);
			this.Controls.Add(this.datetxt);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label resultlbl;
		private System.Windows.Forms.TextBox datetxt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button submitbtn;
	}
}

