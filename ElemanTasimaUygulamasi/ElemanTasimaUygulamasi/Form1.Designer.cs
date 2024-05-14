namespace ElemanTasimaUygulamasi
{
	partial class Form1
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
			this.lstLeft = new System.Windows.Forms.ListBox();
			this.btnMoveRight = new System.Windows.Forms.Button();
			this.btnMoveLeft = new System.Windows.Forms.Button();
			this.lstRight = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lstLeft
			// 
			this.lstLeft.FormattingEnabled = true;
			this.lstLeft.ItemHeight = 24;
			this.lstLeft.Location = new System.Drawing.Point(12, 12);
			this.lstLeft.Name = "lstLeft";
			this.lstLeft.Size = new System.Drawing.Size(174, 292);
			this.lstLeft.TabIndex = 0;
			// 
			// btnMoveRight
			// 
			this.btnMoveRight.Location = new System.Drawing.Point(213, 96);
			this.btnMoveRight.Name = "btnMoveRight";
			this.btnMoveRight.Size = new System.Drawing.Size(112, 41);
			this.btnMoveRight.TabIndex = 1;
			this.btnMoveRight.Text = ">>>";
			this.btnMoveRight.UseVisualStyleBackColor = true;
			this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
			// 
			// btnMoveLeft
			// 
			this.btnMoveLeft.Location = new System.Drawing.Point(213, 143);
			this.btnMoveLeft.Name = "btnMoveLeft";
			this.btnMoveLeft.Size = new System.Drawing.Size(112, 41);
			this.btnMoveLeft.TabIndex = 2;
			this.btnMoveLeft.Text = "<<<";
			this.btnMoveLeft.UseVisualStyleBackColor = true;
			this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
			// 
			// lstRight
			// 
			this.lstRight.FormattingEnabled = true;
			this.lstRight.ItemHeight = 24;
			this.lstRight.Location = new System.Drawing.Point(350, 12);
			this.lstRight.Name = "lstRight";
			this.lstRight.Size = new System.Drawing.Size(174, 292);
			this.lstRight.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 319);
			this.Controls.Add(this.lstRight);
			this.Controls.Add(this.btnMoveLeft);
			this.Controls.Add(this.btnMoveRight);
			this.Controls.Add(this.lstLeft);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstLeft;
		private System.Windows.Forms.Button btnMoveRight;
		private System.Windows.Forms.Button btnMoveLeft;
		private System.Windows.Forms.ListBox lstRight;
	}
}

