using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private int max_hp;
    private int hp;

    [SerializeField]
    private Image img_hp;

    [SerializeField]
    private GameObject DeathMenu;

    private float default_time;

    private void Start()
    {
        default_time = Time.timeScale;

        hp = max_hp;

        InvokeRepeating("ScoreTimer", 0.1f, 0.1f);
    }

    public void Damage(int dmg)
    {
        hp -= dmg;
        if (hp <= 0)
        {
            DeathMenu.SetActive(true);
            Time.timeScale = 0f;

            hp = 0;
        }

        img_hp.fillAmount = (float)hp / max_hp;
    }

    private void OnParticleCollision(GameObject other)
    {
        Damage(12);
    }

    private void ScoreTimer()
    {
        if(hp > 0)
        {
            Score.Instance.ChangeScore(1);
        }
    }

    #region menu
    public void TryAgain()
    {
        Time.timeScale = default_time;

        StaticVars.next_scene = "SampleScene";

        SceneManager.LoadScene("ChangeScene");
    }

    public void Quit()
    {
        Application.Quit();
    }
    #endregion
}
