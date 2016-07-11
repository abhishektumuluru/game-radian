using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class menuStateManager : MonoBehaviour
{
    public Sprite audioOn;
    public Sprite audioOff;
    public Image buttonImage;
	public bool adHidden = true;

	void Awake()
	{
		DontDestroyOnLoad(this);
	}
    
    public void LoadScene(string Scene)
    {
        mainMenuPlayer.isMuted = PlayerPrefs.GetInt("muted") != 0 ? true : false;
        playerMovement.tapCount = 0;
        playerMovement.isDead = false;
        ObsLooper.hasFallen = false;
        if (Scene == "gameOverScene")
        {
            playerMovement.isDead = true;
            ObsLooper.hasFallen = true;
        }
        SceneManager.LoadScene(Scene);
		if (!adHidden)
		{
			
			AdManager.Instance.hideBanner();
			adHidden = true;
		}
		showAdOnScene(Scene);
    }

    public void MuteGame()
    {
        bool checkingIfMuted = mainMenuPlayer.isMuted;
        checkingIfMuted = !checkingIfMuted;
        mainMenuPlayer.isMuted = checkingIfMuted;
        if (checkingIfMuted)
        {
            AudioListener.volume = 0;
            buttonImage.sprite = audioOff;
        }
        else
        {
            AudioListener.volume = 1;
            buttonImage.sprite = audioOn;
        }
        PlayerPrefs.SetInt("muted", checkingIfMuted ? 0 : 1);
    }

	private void showAdOnScene(string Scene)
	{
		if (adHidden) {
			if (Scene == "InfoScene") {
				AdManager.Instance.showBanner ();
				adHidden = false;
			} else if (Scene == "gameOverScene") {
				if (ObsLooper.numTimesPlayed % 6 != 0) {
					if (ObsLooper.numTimesPlayed % 2 == 0) {
						AdManager.Instance.showBanner ();
						adHidden = false;
					}
				} else {
					AdManager.Instance.showInterstitial ();
					adHidden = false;
				}
			} else {
				AdManager.Instance.hideBanner ();
				adHidden = true;
			}
		}
	}
}