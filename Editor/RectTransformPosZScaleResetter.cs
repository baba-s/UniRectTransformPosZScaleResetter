using UnityEditor;
using UnityEngine;

namespace Kogane.Internal
{
	internal static class RectTransformPosZScaleResetter
	{
		[MenuItem( "CONTEXT/RectTransform/Reset Pos Z, Scale" )]
		private static void Hoge( MenuCommand command )
		{
			var rectTransform = ( RectTransform ) command.context;

			Undo.RecordObject( rectTransform, "Reset Pos Z, Scale" );

			var localPosition = rectTransform.localPosition;
			localPosition.z             = 0;
			rectTransform.localPosition = localPosition;

			rectTransform.localScale = Vector3.one;
		}
	}
}