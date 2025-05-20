using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _buttons;

    [SerializeField]
    private string _appearAnimationName;

    [SerializeField]
    private string _dissapearAnimationName;

    [SerializeField]
    private float _buttonsAppearDelay;

    public void ShareButtons()
    {
        StartCoroutine(ShowButtonsWithDelay());
    }

    private IEnumerator ShowButtonsWithDelay()
    {
        foreach(GameObject button in _buttons)
        {
            button.GetComponent<Animator>().Play(_appearAnimationName);
            yield return new WaitForSeconds(_buttonsAppearDelay);
        }
    }

    public void HideButtons()
    {
        foreach(GameObject button in _buttons)
        {
            button.GetComponent<Animator>().Play(_dissapearAnimationName);
        }
    }
}
