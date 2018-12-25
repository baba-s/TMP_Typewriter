using UnityEngine;

namespace KoganeUnityLib.Example
{
	public class Example : MonoBehaviour
	{
		public TMP_Typewriter   m_typewriter    ;
		public float            m_speed         ;

		private void Update()
		{
			if ( Input.GetKeyDown( KeyCode.Z ) )
			{
				// 1 文字ずつ表示する演出を再生
				m_typewriter.Play
				(
					text        : "ABCDEFG HIJKLMN OPQRSTU",
					speed       : m_speed,
					onComplete  : () => Debug.Log( "完了" )
				);
			}
			if ( Input.GetKeyDown( KeyCode.X ) )
			{
				// 1 文字ずつ表示する演出を再生（リッチテキスト対応）
				m_typewriter.Play
				(
					text        : @"<size=64>ABCDEFG</size> <color=red>HIJKLMN</color> <sprite=0> <link=""https://www.google.co.jp/"">OPQRSTU</link>",
					speed       : m_speed,
					onComplete  : () => Debug.Log( "完了" )
				);
			}
			if ( Input.GetKeyDown( KeyCode.C ) )
			{
				// 1 文字ずつ表示する演出を再生（スプライト対応）
				m_typewriter.Play
				(
					text        : @"<sprite=0><sprite=0><sprite=1><sprite=2><sprite=3><sprite=4><sprite=5><sprite=6><sprite=7><sprite=8><sprite=9><sprite=10>",
					speed       : m_speed,
					onComplete  : () => Debug.Log( "完了" )
				);
			}
			if ( Input.GetKeyDown( KeyCode.V ) )
			{
				// 演出をスキップ（onComplete は呼び出される）
				m_typewriter.Skip();
			}
			if ( Input.GetKeyDown( KeyCode.B ) )
			{
				// 演出をスキップ（onComplete は呼び出されない）
				m_typewriter.Skip( false );
			}
			if ( Input.GetKeyDown( KeyCode.N ) )
			{
				// 演出を一時停止
				m_typewriter.Pause();
			}
			if ( Input.GetKeyDown( KeyCode.M ) )
			{
				// 演出を再開
				m_typewriter.Resume();
			}
		}
	}
}