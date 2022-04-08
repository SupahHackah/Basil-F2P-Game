/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class LevelWindow : MonoBehaviour
{
    
    private Text levelText;
    private Image experienceBarImage;
    private LevelingSystem levelingSystem;

    private void Awake()
    {
        levelText = transform.Find("levelText").GetComponent<Text>();
        experienceBarImage = transform.Find("experienceBar").Find("bar").GetComponent<Image>();

        transform.Find("experience5Btn").GetComponent<Button_UI>().ClickFunc = () => levelingSystem.AddExperience(5);
        transform.Find("experience50Btn").GetComponent<Button_UI>().ClickFunc = () => levelingSystem.AddExperience(50);
        transform.Find("experience500Btn").GetComponent<Button_UI>().ClickFunc = () => levelingSystem.AddExperience(500);
    }

    private void SetExperienceBarSize(float experienceNormalized)
    {
        experienceBarImage.fillAmount = experienceNormalized;
    }

    private void SetLevelNumber(int levelNumber)
    {
        levelText.text = "LEVEL \n" + (levelNumber + 1);
    }

    public void SetLevelingSystem(LevelingSystem levelingSystem)
    {
        // Set the LevelingSystem object
        this.levelingSystem = levelingSystem;

        // Update the starting values
        SetLevelNumber(levelingSystem.GetLevelNumber());
        SetExperienceBarSize(levelingSystem.GetExperienceNormalized());

        // Subscribe to the changed events
        levelingSystem.OnExperienceChanged += LevelingSystem_OnExperienceChanged;
        levelingSystem.OnLevelChanged += LevelingSystem_OnLevelChanged;
    
    }

    private void LevelingSystem_OnExperienceChanged(object sender, System.EventArgs e) 
    {
        // Level changed, update text
        SetLevelNumber(levelingSystem.GetLevelNumber());
    }

    private void LevelingSystem_OnLevelChanged(object sender, System.EventArgs e)
    {
        // Experience changed, update bar size
        SetExperienceBarSize(levelingSystem.GetExperienceNormalized());
    }

}
*/