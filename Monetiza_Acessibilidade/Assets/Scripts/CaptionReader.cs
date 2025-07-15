using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class CaptionReader : MonoBehaviour
{
    VideoPlayer videoPlayer;

    [SerializeField] VideoClip[] videoClips;

    bool isPaused;

    void Start()
    {
        GameEvents.Instance.OnMouseEnter += ReadCaption;

        videoPlayer = GetComponent<VideoPlayer>();

        if (SceneManager.GetActiveScene().buildIndex != 0 && SceneManager.GetActiveScene().buildIndex != 6)
        {
            videoPlayer.clip = videoClips[0];
            videoPlayer.Play();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            videoPlayer.clip = videoClips[3];
            videoPlayer.Play();
        }
    }

    void Update()
    {
        if (videoPlayer.isPaused && !isPaused)
        {
            videoPlayer.clip = null;
            isPaused = true;
        }
    }

    void ReadCaption(int id)
    {
        for (int i = 0; i < videoClips.Length; i++)
        {
            if (id == i)
            {
                videoPlayer.Stop();
                videoPlayer.clip = videoClips[i];
                videoPlayer.Play();
                isPaused = false;
            }
        }
    }
}