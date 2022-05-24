using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update


    public GameManager gameManager;

    private void Start()
    {
        GameObject gameObject = GameObject.Find("GameManager");
        gameManager= gameObject.GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.AddCoinCount();
            Destroy(gameObject);
        }
    }
}
