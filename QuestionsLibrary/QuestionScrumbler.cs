using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LFSR_GEFFE_RC4;

namespace QuestionsLibrary
{
	/// <summary>
	/// Дешифровка с помощью шифратора RC4 представляет собой тот же 
	/// процесс что и шифровка.
	/// </summary>
	public static class QuestionScrumbler
	{
		private static string _key = "QCJIJFG32SA123LOP";
		
		public static void CryptAllQuestion( Question[] questions )
		{
			RC4 scrumbler = new RC4( _key.ToByteArray() );

			foreach( Question question in questions )
			{
				byte[] cipherQuestionText = scrumbler.Crypt( question.QuestionText.ToByteArray() );
				byte[] cipherCallFriend = scrumbler.Crypt( question.CallFriend.ToByteArray() );
				byte[] cipherHelpPublic = scrumbler.Crypt( question.HelpPublic.ToByteArray() );
				question.Answers = CryptAllAnswer( question.Answers );
				question.QuestionText = cipherQuestionText.ToText();
				question.CallFriend = cipherCallFriend.ToText();
				question.HelpPublic = cipherHelpPublic.ToText();
			}
		}

		private static Answer[] CryptAllAnswer( Answer[] answers )
		{
			RC4 scrumbler = new RC4( _key.ToByteArray() );

			for ( int i = 0; i < answers.Length; i++ )
			{
				byte[] cipherAnswer = scrumbler.Crypt( answers[ i ].AnswerText.ToByteArray() );
				answers[ i ].AnswerText = cipherAnswer.ToText();
			}

			return answers;
		}
	}

	public static class ConvertExtentions
	{
		public static byte[] ToByteArray( this string text )
		{
			return Encoding.Default.GetBytes( text );
		}

		public static string ToText( this byte[] textInByte )
		{
			return Encoding.Default.GetString( textInByte );
		}
	}
}
