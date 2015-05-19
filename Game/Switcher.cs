using System;
using System.Windows.Forms;
using PlayersConnector;

namespace Game
{
	public partial class Switcher : Form
	{
		public ProgrammingLanguage Category { get; private set; }

		public Switcher()
		{
			InitializeComponent();
		}

		private void StartTest( object sender, EventArgs e )
		{
			if ( rbCpp.Checked )
			{
				Category = ProgrammingLanguage.CPP;
			}
			else if ( rbCs.Checked )
			{
				Category = ProgrammingLanguage.CSharp;
			}
			else if ( rbC.Checked )
			{
				Category = ProgrammingLanguage.C;
			}
			else
			{
				Category = ProgrammingLanguage.SuperProger;
			}
		}
	}
}
