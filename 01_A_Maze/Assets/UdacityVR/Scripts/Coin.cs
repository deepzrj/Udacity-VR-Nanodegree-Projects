using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    // TODO: Create variables to reference the game objects we need access to
    public GameObject coin;
    // Declare a GameObject named 'coinPoofPrefab' and assign the 'CoinPoof' prefab to the field in Unity
    public GameObject coinPoofPrefab;
    public float speed = 10f;
  

    private void Start()
    {
        //coinPoof = coinPoofPrefab.GetComponent<ParticleSystem>();
    }

    void Update ()
    {
        // OPTIONAL-CHALLENGE: Animate the coin rotating
        // TIP: You could use a method from the Transform class

           coin.transform.Rotate(0f,speed, 0f);
	}


    public void OnCoinClicked() {
        /// Called when the 'Coin' game object is clicked
        /// - Displays a poof effect (handled by the 'CoinPoof' prefab)
        /// - Plays an audio clip (handled by the 'CoinPoof' prefab)
        Instantiate(coinPoofPrefab, coin.transform);
     
        ParticleSystem poof = coinPoofPrefab.GetComponent<ParticleSystem>();
        poof.Play();  /////why the poof effect aint shown?



        /// - Removes the coin from the scene
        Destroy(coin, 0.5f);


        // Prints to the console when the method is called
        Debug.Log ("'Coin.OnCoinClicked()' was called");

		// TODO: Display the poof effect and remove the coin from the scene
		// Use Instantiate() to create a clone of the 'CoinPoof' prefab at this coin's position and with the 'CoinPoof' prefab's rotation
		// Use Destroy() to delete the coin after for example 0.5 seconds
	}
}
