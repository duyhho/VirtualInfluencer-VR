using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class VideoManager : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        StartCoroutine(DelayPlay(24, "https://benamreview.github.io/360VideosUnity/video3.mp4"));
        StartCoroutine(DelayPlay(34, "https://benamreview.github.io/360VideosUnity/video4.mp4"));


    }

    public void Play() {
        videoPlayer.Play();
    }
    public void Pause() {
        videoPlayer.Pause();
    }
    public void Stop() {
        videoPlayer.Stop();
    }
    public void URLToVideo(string url) {
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = url;
        videoPlayer.Prepare();
        videoPlayer.prepareCompleted += VideoPlayer_prepareCompleted;
    }
    void VideoPlayer_prepareCompleted(VideoPlayer source) {
        Play();
    }

    IEnumerator DelayPlay(int secs, string URL)
    {
        yield return new WaitForSeconds(secs);
        URLToVideo(URL);
    }
}
