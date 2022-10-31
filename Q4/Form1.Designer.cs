namespace Q4
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
			this.calcubtn = new System.Windows.Forms.Button();
			this.carlbl = new System.Windows.Forms.Label();
			this.peoplelbl = new System.Windows.Forms.Label();
			this.cartxt = new System.Windows.Forms.TextBox();
			this.peopletxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// calcubtn
			// 
			this.calcubtn.Location = new System.Drawing.Point(360, 132);
			this.calcubtn.Name = "calcubtn";
			this.calcubtn.Size = new System.Drawing.Size(75, 23);
			this.calcubtn.TabIndex = 0;
			this.calcubtn.Text = "計算";
			this.calcubtn.UseVisualStyleBackColor = true;
			this.calcubtn.Click += new System.EventHandler(this.calcubtn_Click);
			// 
			// carlbl
			// 
			this.carlbl.AutoSize = true;
			this.carlbl.Location = new System.Drawing.Point(65, 80);
			this.carlbl.Name = "carlbl";
			this.carlbl.Size = new System.Drawing.Size(53, 12);
			this.carlbl.TabIndex = 1;
			this.carlbl.Text = "有幾輛車";
			// 
			// peoplelbl
			// 
			this.peoplelbl.AutoSize = true;
			this.peoplelbl.Location = new System.Drawing.Point(65, 204);
			this.peoplelbl.Name = "peoplelbl";
			this.peoplelbl.Size = new System.Drawing.Size(65, 12);
			this.peoplelbl.TabIndex = 2;
			this.peoplelbl.Text = "有幾位乘客";
			// 
			// cartxt
			// 
			this.cartxt.Location = new System.Drawing.Point(177, 70);
			this.cartxt.Name = "cartxt";
			this.cartxt.Size = new System.Drawing.Size(100, 22);
			this.cartxt.TabIndex = 3;
			// 
			// peopletxt
			// 
			this.peopletxt.Location = new System.Drawing.Point(177, 194);
			this.peopletxt.Name = "peopletxt";
			this.peopletxt.Size = new System.Drawing.Size(100, 22);
			this.peopletxt.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.peopletxt);
			this.Controls.Add(this.cartxt);
			this.Controls.Add(this.peoplelbl);
			this.Controls.Add(this.carlbl);
			this.Controls.Add(this.calcubtn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button calcubtn;
		private System.Windows.Forms.Label carlbl;
		private System.Windows.Forms.Label peoplelbl;
		private System.Windows.Forms.TextBox cartxt;
		private System.Windows.Forms.TextBox peopletxt;
	}
}

