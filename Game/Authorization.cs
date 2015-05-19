using System;
using System.Windows.Forms;
using PlayersConnector;

namespace Game
{
	public partial class Authorization : Form
	{
		public string PlayerName { get; private set; }
		public bool NameHonestSaved { get; private set; }

		public Authorization( ProgrammingLanguage category, double resultInPercent )
		{
			InitializeComponent();

			btSave.Enabled = false;
			
			switch( category )
			{
				case ProgrammingLanguage.CPP: 
					tbCategory.Text = "C++";
					break;
				case ProgrammingLanguage.CSharp:
					tbCategory.Text = "C#";
					break;
				case ProgrammingLanguage.C:
					tbCategory.Text = "C";
					break;
				case ProgrammingLanguage.SuperProger:
					tbCategory.Text = "SuperProger";
					break;

			}

			tbResult.Text = string.Format( "{0:F2}", resultInPercent );
		}

		private void CheckNameEntering( object sender, EventArgs e )
		{
			if ( String.IsNullOrEmpty( tbName.Text ) || String.IsNullOrWhiteSpace( tbName.Text ) )
			{
				btSave.Enabled = false;
			}
			else
			{
				btSave.Enabled = true;
			}
		}

		private void SavePlayerName( object sender, EventArgs e )
		{
			PlayerName = tbName.Text;
			NameHonestSaved = true;
		}
	}
}
