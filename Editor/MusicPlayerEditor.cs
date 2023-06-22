using UnityEditor;
using UnityEngine;
using Radgar.AudioPlayer;

namespace Radgar.editor
{
    [CustomEditor(typeof(MusicPlayer))]
    public class MusicPlayerEditor : Editor
    {
        private Vector2 scrollPosition;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            MusicPlayer musicPlayer = (MusicPlayer)target;

            EditorGUILayout.BeginVertical(GUI.skin.box);

            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);

            if (GUILayout.Button("Play Next Song"))
            {
                musicPlayer.PlayNextSong();
            }

            if (GUILayout.Button("Play Previous Song"))
            {
                musicPlayer.PlayPreviousSong();
            }

            if (GUILayout.Button("Pause Music"))
            {
                musicPlayer.PausePlayMusic();
            }

            if (GUILayout.Button("Continue Music"))
            {
                musicPlayer.ContinuePlayMusic();
            }

            EditorGUILayout.EndScrollView();

            EditorGUILayout.EndVertical();
        }
    } 
}
