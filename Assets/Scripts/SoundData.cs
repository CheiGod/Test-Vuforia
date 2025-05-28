using UnityEngine;

[CreateAssetMenu(fileName = "SoundData", menuName = "Scriptable Objects/SoundData")]
public class SoundData : ScriptableObject
{
    public string MusicName;
    public string danceName;
    public TextAsset notesConfig;
    public float speed;

}
