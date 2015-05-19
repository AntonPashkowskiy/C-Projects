using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using PlayersConnector;

namespace Game
{
	public partial class RecordTable : Form
	{
		private string _pathToFile = null;
		private List<Player> _recordList;
		private bool _listIsChanged;
 
		public RecordTable( string pathToDirectory )
		{
			InitializeComponent();
			
			if ( pathToDirectory == null )
			{
				throw new ArgumentNullException( "Путь к файлу с рекордами повреждён" );
			}

			CreateDataGridViewTable();

			_pathToFile = Path.Combine( pathToDirectory, @"Рекорды\", Environment.MachineName.ToString() + "_Records.bin" );
		
			Player[] arrayOfPlayers = PlayersSerializator.ReadPlayersFromFile( _pathToFile );
			InitializePlayersList( arrayOfPlayers );
		}

		public void Add( Player player )
		{
			_recordList.Add( player );
			_recordList.Sort();

			if ( _recordList.Count > dgvRecordTable.RowCount )
			{
				dgvRecordTable.RowCount = _recordList.Count;
			}

			for ( int i = 0; i < _recordList.Count; i++ )
			{
				dgvRecordTable.Rows[ i ].SetValues( _recordList[ i ].Name,
													CategoryToString( _recordList[ i ].Category ),
													string.Format( "{0:F2}", _recordList[ i ].ResultInPercent ) );
			}

			_listIsChanged = true;
		}

		public void SaveChanges()
		{
			if ( _recordList.Count != 0 && _listIsChanged )
			{
				PlayersSerializator.WritePlayersInFile( _pathToFile, _recordList.ToArray() );
				_listIsChanged = false;
			}
		}

		private string CategoryToString( ProgrammingLanguage category )
		{
			string categoryName = null;

			switch( category )
			{
				case ProgrammingLanguage.CPP : categoryName = "C++"; break;
				case ProgrammingLanguage.CSharp: categoryName = "C#"; break;
				case ProgrammingLanguage.C: categoryName = "C"; break;
				case ProgrammingLanguage.SuperProger: categoryName = "ТыЖПрограммист"; break;
			}

			return categoryName;
		}

		#region Методы создания таблицы рекордов

		private void CreateDataGridViewTable()
		{
			dgvRecordTable.ColumnCount = 3;
			dgvRecordTable.RowCount = 100;
			dgvRecordTable.Columns[ 0 ].Name = "Имя";
			dgvRecordTable.Columns[ 1 ].Name = "Категория";
			dgvRecordTable.Columns[ 2 ].Name = "Результат";
		}
		
		private void InitializePlayersList( Player[] arrayOfPlayers )
		{
			if ( arrayOfPlayers != null )
			{
				_recordList = arrayOfPlayers.ToList<Player>();
				_recordList.Sort();

				if ( _recordList.Count > dgvRecordTable.RowCount )
				{
					dgvRecordTable.RowCount = _recordList.Count;
				}

				for ( int i = 0; i < _recordList.Count; i++ )
				{
					dgvRecordTable.Rows[ i ].SetValues( _recordList[ i ].Name,
														CategoryToString( _recordList[ i ].Category ),
														string.Format( "{0:F2}", _recordList[ i ].ResultInPercent ) );
				}
			}
			else
			{
				_recordList = new List<Player>();
			}
		}

		#endregion
	}
}
