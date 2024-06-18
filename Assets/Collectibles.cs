using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public bool isCoins, isSpeedUp;
    public float speedUpDuration;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player2"))
        {
            if (isCoins)
            {
                Test playerScript = other.GetComponent<Test>();
                playerScript.score++;
                Destroy(gameObject);
            }
            if (isSpeedUp)
            {
                playerScript.moveSpeed += 5f;
                Destroy(gameObject);
            }
        }
    }

}
