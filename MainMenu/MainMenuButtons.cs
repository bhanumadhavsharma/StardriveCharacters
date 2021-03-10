using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip buttonPress;
    public GameObject fadeObject;

    private void Awake()
    {
        audioSource = FindObjectOfType<Canvas>().gameObject.GetComponent<AudioSource>();
        fadeObject = FindObjectOfType<Fade>().gameObject;
    }

    public void CharacterButtonClick()
    {
        if (buttonPress != null)
        {
            //FindObjectOfType<AudioSource>().PlayOneShot(buttonPress, 1);
            audioSource.PlayOneShot(buttonPress, 1);
        }
        Debug.Log(this.gameObject.name + "was clicked.");
    }

    public void NewCharacterButtonClick()
    {
        if(buttonPress != null)
        {
            //FindObjectOfType<AudioSource>().PlayOneShot(buttonPress, 1);
            audioSource.PlayOneShot(buttonPress, 1);
        }
        Debug.Log(this.gameObject.name + "was clicked.");
        // SceneManager.LoadScene("NewCharacter");
        LoadScene("NewCharacter");
    }

    void LoadScene(string sceneName)
    {
        fadeObject.GetComponent<Fade>().LoadNextLevel(sceneName);
    }
}
