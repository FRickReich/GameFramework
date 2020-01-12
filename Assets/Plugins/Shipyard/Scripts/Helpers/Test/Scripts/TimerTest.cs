using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using Game.Helper;
using Game.Internationalization;

public class TimerTest : MonoBehaviour
{
    private Timer gameTimer;

    public i18n converter;
	public Languages language;
    public TMP_Text gameTimeText;
    public TMP_Text resumeButtonText;
    public TMP_Text pauseButtonText;

    // Start is called before the first frame update
    void Start()
    {
        converter = new i18n(language, "helpers");
        gameTimer = new Timer();

        resumeButtonText.text = converter.GetMessage("test.helpers.timer.resumeTimeButton");
        pauseButtonText.text = converter.GetMessage("test.helpers.timer.pauseTimeButton");
    }

    // Update is called once per frame
    void Update()
    {
        converter.language = language;

        gameTimeText.text = converter.GetMessage("test.helpers.timer.gameTimeText", converter.secondsToTime(gameTimer.elapsed));
    }

    public void PauseTime()
    {
        gameTimer.Stop();
    }
    public void ResumeTime()
    {
        gameTimer.Resume();
    }
}
