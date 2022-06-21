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

    private void Start()
    {
        hp = max_hp;
    }

    public void Damage(int dmg)
    {
        hp -= dmg;
        if (hp <= 0)
        {
            print("morreu");

            hp = 0;
        }

        img_hp.fillAmount = (float)hp / max_hp;
    }

    private void OnParticleCollision(GameObject other)
    {
        Damage(5);
    }
}
