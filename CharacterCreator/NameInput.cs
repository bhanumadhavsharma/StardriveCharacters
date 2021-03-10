using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameInput : MonoBehaviour
{
    public bool nameAdded = false;
    public TMP_InputField nameInputField;
    public Image characterImage;

    private void Start()
    {
        nameInputField.onEndEdit.AddListener(delegate
        {
            OnNameInput(nameInputField);
        });
    }

    void OnNameInput(TMP_InputField inputField)
    {
        if (inputField.text.Length > 0 && !string.IsNullOrEmpty(inputField.text.ToString()))
        {
            nameAdded = true;
            Debug.Log("Name: " + inputField.text);
            // save name
        }
    }

    public void OnPictureClick()
    {
        Debug.Log("picture has been clicked");
        if (NativeGallery.IsMediaPickerBusy())
        {
            return;
        }
        PickImage(1024);
    }

    void PickImage(int maxSize)
    {
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
        {
            Debug.Log("Image path: " + path);
            if (path != null)
            {
                // Create Texture from selected image
                Texture2D texture = NativeGallery.LoadImageAtPath(path, maxSize);
                if (texture == null)
                {
                    Debug.Log("Couldn't load texture from " + path);
                    return;
                }

                // turn texture to sprite
                Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(.5f, .5f), 100f);
                Debug.Log("sprite created");
                // attach it to the button sprite
                characterImage.sprite = sprite;
            }
        }, "Select an image", "image/");

        Debug.Log("Permission result: " + permission);
    }
}
