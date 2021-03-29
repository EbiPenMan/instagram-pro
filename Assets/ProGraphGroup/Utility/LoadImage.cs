using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace ProGraphGroup.Utility
{
    [RequireComponent(typeof(Image))]
    public class LoadImage : MonoBehaviour
    {

        public Sprite defaultImage = null;
        public GameObject loading = null;
        GameObject pic = null;
        public void GetSprite(string picturePathAndName, bool isExternal)
        {
            pic = this.gameObject;
            
            if(defaultImage != null)
                pic.GetComponent<Image>().sprite = defaultImage;

            if(loading != null)
                loading.SetActive(true);
                
            if (!isExternal)
            {
                Debug.Log("Loading From Inside");
                Sprite sprite = Resources.Load(picturePathAndName, typeof(Sprite)) as Sprite;
                pic.GetComponent<Image>().sprite = sprite;
                Image imageComponent = pic.GetComponent<Image>();
                Color imageColor = imageComponent.color;
                imageColor.a = 1f;
                imageComponent.color = imageColor;
                if(loading != null)
                    loading.SetActive(false);
            }
            else
            {

                Debug.Log("Loading From Outside: " + picturePathAndName);
                StartCoroutine(DownloadImg(picturePathAndName));

            }

        }

        IEnumerator DownloadImg(string url)
        {
            Texture2D texture = new Texture2D(1, 1);
            WWW www = new WWW(url);
            yield return www;
            www.LoadImageIntoTexture(texture);

            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
            pic.GetComponent<Image>().sprite = sprite;
            Image imageComponent = pic.GetComponent<Image>();
            Color imageColor = imageComponent.color;
            imageColor.a = 1f;
            imageComponent.color = imageColor;
            if(loading != null)
                loading.SetActive(false);
            StopCoroutine("DownloadImg");
        }

    }
}