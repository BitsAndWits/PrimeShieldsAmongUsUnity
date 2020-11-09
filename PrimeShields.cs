using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrimeShields : MonoBehaviour
{
    public Image mainShield;
    public Image[] shieldCells;
    public GameObject TextComplete;

    void Start()
    {
        Randomizer();
    }

    void Randomizer()
    {
        List<int> randomCells = new List<int>();
        int number;

        for (int i = 0; i < Random.Range(2, 7); i++)
        {
            do
            {
                number = Random.Range(1, 7);
            } while (randomCells.Contains(number));
            randomCells.Add(number);
        }

        for (int i = 0; i < randomCells.Count; i++)
        {
            shieldCells[randomCells[i]].color = Color.red;
        }
        mainShield.color = new Color(1, 0, 0, 0.6f);
    }

    public void CheckShield()
    {
        for (int i = 0; i < shieldCells.Length; i++)
        {
            if (shieldCells[i].color == Color.red)
            {
                break;
            }

            if (i == shieldCells.Length - 1)
            {
                TextComplete.SetActive(true);
                mainShield.color = new Color(1, 1, 1, 0.6f);
            }
        }
    }
}
