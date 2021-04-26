namespace Mesai_Hesapla
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ad";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Soyad";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(12, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mesai Tarihi";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(15, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "Mesai Saati";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(79, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(234, 20);
			this.textBox1.TabIndex = 4;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(79, 48);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(234, 20);
			this.textBox2.TabIndex = 5;
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(12, 237);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 43);
			this.button1.TabIndex = 7;
			this.button1.Text = "Ad Kaydet";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(113, 165);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(203, 20);
			this.textBox3.TabIndex = 8;
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel1.Location = new System.Drawing.Point(1, 113);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(431, 26);
			this.panel1.TabIndex = 9;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(110, 202);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(203, 20);
			this.textBox4.TabIndex = 10;
			this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.Location = new System.Drawing.Point(110, 237);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 43);
			this.button2.TabIndex = 11;
			this.button2.Text = "Soyad Kaydet";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.Location = new System.Drawing.Point(212, 237);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 43);
			this.button3.TabIndex = 12;
			this.button3.Text = "Tarih Kaydet";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button4.Location = new System.Drawing.Point(307, 237);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 43);
			this.button4.TabIndex = 13;
			this.button4.Text = "Saat Kaydet";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(433, 292);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Haftalık Mesai Takibi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}

