namespace Q1
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
			this.numbertxt = new System.Windows.Forms.TextBox();
			this.resultlbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// numbertxt
			// 
			this.numbertxt.Location = new System.Drawing.Point(183, 116);
			this.numbertxt.MaxLength = 2;
			this.numbertxt.Name = "numbertxt";
			this.numbertxt.Size = new System.Drawing.Size(100, 22);
			this.numbertxt.TabIndex = 0;
			this.numbertxt.TextChanged += new System.EventHandler(this.numbertxt_TextChanged);
			// 
			// resultlbl
			// 
			this.resultlbl.AutoSize = true;
			this.resultlbl.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultlbl.Location = new System.Drawing.Point(355, 119);
			this.resultlbl.Name = "resultlbl";
			this.resultlbl.Size = new System.Drawing.Size(57, 16);
			this.resultlbl.TabIndex = 1;
			this.resultlbl.Text = "resultlbl";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.resultlbl);
			this.Controls.Add(this.numbertxt);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox numbertxt;
		private System.Windows.Forms.Label resultlbl;
	}
}

