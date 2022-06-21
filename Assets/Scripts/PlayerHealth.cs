using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private int max_hp;
    private int hp;

    [SerializeField]
    private Image img_hp;

    [SerializeField]
    private GameObject DeathMenu;

    private void Start()
    {
        hp = max_hp;

        InvokeRepeating("ScoreTimer", 0.1f, 0.1f);
    }

    public void Damage(int dmg)
    {
        hp -= dmg;
        if (hp <= 0)
        {
            DeathMenu.SetActive(true);

            hp = 0;
        }

        img_hp.fillAmount = (float)hp / max_hp;
    }

    private void OnParticleCollision(GameObject other)
    {
        Damage(10);
    }

    private void ScoreTimer()
    {
        if(hp > 0)
        {
            Score.Instance.ChangeScore(1);
        }
    }
}
