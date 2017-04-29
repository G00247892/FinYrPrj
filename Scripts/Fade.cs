using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fade : MonoBehaviour {
    public static Fade Instance{ set; get;}

    public Image fadeImage;
    private bool isInTransition;
    private float transition;
    private bool isShowing;
    private float duration;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(transform.gameObject);
    }

    public void Fader(bool showing, float duration)
    {
        isShowing = showing;
        isInTransition = true;
        this.duration = duration;
        transition = (isShowing) ? 0 : 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            Fader(true, 1.25f);

        if (!isInTransition)
            return;
        transition += (isShowing) ? Time.deltaTime * (1 / duration) : -Time.deltaTime * (1 / duration);
        fadeImage.color = Color.Lerp(new Color(1, 1, 1, 0), Color.white, transition);
        if (transition > 1 || transition < 0)
            isInTransition = false;
    }
}
