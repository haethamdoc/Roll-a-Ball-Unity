using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    Transform collectibleTransform;
    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        collectibleTransform = gameObject.transform; 
    }

    // Update is called once per frame
    void Update()
    {
        collectibleTransform.Rotate(new Vector3(5f, 5f, 5f));
    }
     

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreManager.IncrementScore();
            gameObject.SetActive(false); 
        }
    }

}
