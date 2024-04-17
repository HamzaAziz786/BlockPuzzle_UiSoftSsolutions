using UnityEngine;
using System.Collections;

public class MainScreen : MonoBehaviour 
{
    /// <summary>
    /// Raises the play button pressed event.
    /// </summary>
    private void Start()
    {
        AdsController.instance.ShowAd(AdType.BANNER , 1);
    }
    public void OnPlayButtonPressed()
	{
		if (InputManager.Instance.canInput ()) {
			AudioManager.Instance.PlayButtonClickSound ();
			StackManager.Instance.selectModeScreen.Activate();
		}
	}

}
