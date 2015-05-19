using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace QuestionsLibrary
{
	/// <summary>
	/// Класс для сохранения вопросов в файл
	/// Используется механизм сериализации и десериализации
	/// </summary>
	/// <exception cref = "Exception">
	/// ArgumentNullException
	/// ArgumentException
	/// </exception>
	public static class QuestionsConnector
	{
		private static string _path;

		//При записи по умолчанию файл сохранится в директорию с TestEditor.exe

		public static void SetExeDirectoryPath()
		{
			Assembly currentAssembly = Assembly.GetExecutingAssembly();

			//Используем EscapedCodeBase вместо CodeBase
			//для того что бы запрещённые символы не приводили 
			//к ошибкам в конструкторе Uri			
		
			string assemlyPath = new Uri( currentAssembly.EscapedCodeBase ).LocalPath;
			_path = Path.GetDirectoryName( assemlyPath );
		}

		public static void SetDirectoryPath( string path )
		{
			if ( path == null )
			{
				throw new ArgumentNullException();
			}

			_path = path;
		}

		public static void WriteQuestions( Question[] questions )
		{
			if ( questions == null )
			{
				throw new ArgumentNullException();
			}

			if ( _path == null )
			{
				SetExeDirectoryPath();
			}

			//клонируем вопросы
			questions = CloneAllQuestion( questions );

			//шифруем вопросы
			QuestionScrumbler.CryptAllQuestion( questions );

			BinaryFormatter formatter = new BinaryFormatter();

			using( FileStream stream = File.Open( _path, FileMode.OpenOrCreate ) )
			{
				formatter.Serialize( stream, questions );
			}
		}

		public static Question[] ReadQuestions( string path )
		{
			if ( path == null || !File.Exists( path ) )
			{
				throw new ArgumentException( "Неверно указан путь к файлу." );
			}
	
			BinaryFormatter formatter = new BinaryFormatter();
			Question[] result;

			using ( FileStream stream = File.Open( path, FileMode.Open, FileAccess.Read, FileShare.Read ) )
			{
				result = ( Question[] )formatter.Deserialize( stream );
			}

			//дешифруем вопросы
			QuestionScrumbler.CryptAllQuestion( result );

			return result;			
		}

		private static Question[] CloneAllQuestion( Question[] questions )
		{
			Question[] cloneQuestions = new Question[ questions.Length ];

			for ( int i = 0; i < questions.Length; i++ )
			{
				cloneQuestions[ i ] = (Question)questions[ i ].Clone();
			}

			return cloneQuestions;
		}
	}
}
