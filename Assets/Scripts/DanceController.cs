using UnityEngine;
using UnityEngine.Events;

public class DanceController : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onActivateSelectDance;
    [SerializeField]
    private UnityEvent _onSelectDance;
    [SerializeField]
    private Animator _CharacterAnimator;
    [SerializeField]
    private NotesManager _notesManager;
    private SoundData _currentSoundData;
    public void ActiveSelectedDance()
    {
        _onActivateSelectDance?.Invoke();
    }

    public void SelectDance(SoundData soundData)
    {
        _currentSoundData = soundData;
        _onSelectDance?.Invoke();
    }

    public void StartDance()
    {
        _CharacterAnimator.Play(_currentSoundData.danceName);
        SoundManager.instance.PlayMusic(_currentSoundData.MusicName);
        _notesManager.StartNotes(_currentSoundData.notesConfig, _currentSoundData.speed);
    }
}