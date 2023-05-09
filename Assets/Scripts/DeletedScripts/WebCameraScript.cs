using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class WebCameraScript : MonoBehaviour
{
    public Image myCameraTexture;
    public Camera myCamera;
    private WebCamTexture _webCameraTexture;
    ScreenOrientation _oldOrientation;
    Quaternion _baseRotation;

    Sprite _oldSprite;

    private void Start()
    {
        _oldSprite = myCameraTexture.sprite;
        try
        {
            if(WebCamTexture.devices.Any())
            {
                _webCameraTexture = new WebCamTexture(Screen.height, Screen.width);//

                _baseRotation = myCamera.transform.rotation;
                myCamera.transform.localScale = new Vector3(1, 1f, 1);
                myCameraTexture.transform.localScale = new Vector3(1, 1f, 1);
            }

            _webCameraTexture.Play();
        }
        catch
        {

        }
    }

    private void Update()
    {
        if (_webCameraTexture.isPlaying)
        {
            Texture2D photo = new Texture2D(_webCameraTexture.height,
                _webCameraTexture.width);//

            photo.SetPixels(_webCameraTexture.GetPixels());
            photo.Apply();

            myCameraTexture.sprite = Sprite.Create(photo, new Rect(0, 0,
                _webCameraTexture.height, _webCameraTexture.width), new Vector2
                (0.5f, 0.5f));

            Resources.UnloadUnusedAssets();
            System.GC.Collect();
        }
    }

    public void ShowCamera() //ВРОДЕ КАК ненужный функционал (недописанный)
    {
        try
        {
            _webCameraTexture.Play();
        }
        catch
        {
        }
    }
}
