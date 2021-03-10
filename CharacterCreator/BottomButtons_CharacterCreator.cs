using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomButtons_CharacterCreator : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip goForwardSound;
    public AudioClip cancelSound;
    public GameObject fadeObject;

    public void OnClickBack(string sceneName)
    {
        StartCoroutine(GoBackward(sceneName));
    }

    public void OnClickForward(string sceneName)
    {
        // save stuff
        audioSource.PlayOneShot(goForwardSound);
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator GoBackward(string sceneName)
    {
        audioSource.PlayOneShot(cancelSound);
        yield return new WaitForSecondsRealtime(.25f);
        // SceneManager.LoadScene(sceneName);
        LoadScene(sceneName);
    }

    void LoadScene(string sceneName)
    {
        fadeObject.GetComponent<Fade>().LoadNextLevel(sceneName);
    }
}
