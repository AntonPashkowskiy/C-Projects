namespace Game
{
	partial class Authorization
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Authorization ) );
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbCategory = new System.Windows.Forms.TextBox();
			this.tbResult = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbName
			// 
			this.tbName.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.tbName.Location = new System.Drawing.Point( 135, 43 );
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size( 173, 26 );
			this.tbName.TabIndex = 0;
			this.tbName.TextChanged += new System.EventHandler( this.CheckNameEntering );
			// 
			// tbCategory
			// 
			this.tbCategory.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.tbCategory.Location = new System.Drawing.Point( 135, 77 );
			this.tbCategory.MaxLength = 20;
			this.tbCategory.Name = "tbCategory";
			this.tbCategory.ReadOnly = true;
			this.tbCategory.Size = new System.Drawing.Size( 173, 26 );
			this.tbCategory.TabIndex = 1;
			// 
			// tbResult
			// 
			this.tbResult.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.tbResult.Location = new System.Drawing.Point( 135, 111 );
			this.tbResult.MaxLength = 20;
			this.tbResult.Name = "tbResult";
			this.tbResult.ReadOnly = true;
			this.tbResult.Size = new System.Drawing.Size( 173, 26 );
			this.tbResult.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.label1.Location = new System.Drawing.Point( 12, 46 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 40, 18 );
			this.label1.TabIndex = 3;
			this.label1.Text = "Имя";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.label2.Location = new System.Drawing.Point( 12, 80 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 83, 18 );
			this.label2.TabIndex = 4;
			this.label2.Text = "Категория";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.label3.Location = new System.Drawing.Point( 12, 114 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size( 80, 18 );
			this.label3.TabIndex = 5;
			this.label3.Text = "Результат";
			// 
			// btSave
			// 
			this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btSave.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.btSave.Location = new System.Drawing.Point( 101, 229 );
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size( 119, 40 );
			this.btSave.TabIndex = 6;
			this.btSave.Text = "Сохранить";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler( this.SavePlayerName );
			// 
			// Authorization
			// 
			this.AcceptButton = this.btSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size( 320, 308 );
			this.ControlBox = false;
			this.Controls.Add( this.btSave );
			this.Controls.Add( this.label3 );
			this.Controls.Add( this.label2 );
			this.Controls.Add( this.label1 );
			this.Controls.Add( this.tbResult );
			this.Controls.Add( this.tbCategory );
			this.Controls.Add( this.tbName );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ( ( System.Drawing.Icon )( resources.GetObject( "$this.Icon" ) ) );
			this.MaximizeBox = false;
			this.Name = "Authorization";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Сохранение результатов";
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbCategory;
		private System.Windows.Forms.TextBox tbResult;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btSave;
	}
}