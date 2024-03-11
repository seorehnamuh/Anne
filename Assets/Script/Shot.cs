using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject LegooPrefab;
    public Transform spawnPoint; 
    public float LegooSpeed = 10f;
    public float TimeToDestroyTheLegoo = 3f;
    public SingletonPickUp inventory;

    private bool collidedWithLegoo = false; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) && inventory.pickedPicksUps["Legoo"] > 0 ) 
        {
            ShootLegoo(); 
        }
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Legoo")) 
    //    {
    //        collidedWithLegoo = true; 
    //    }
    //}


    void ShootLegoo()
    {
        inventory.pickedPicksUps["Legoo"]--;
        GameObject Legoo = Instantiate(LegooPrefab, spawnPoint.position, spawnPoint.rotation);
      

        Rigidbody rb = Legoo.GetComponent<Rigidbody>(); 
        rb.velocity = spawnPoint.forward * LegooSpeed;
        
        rb.AddForce(LegooSpeed * spawnPoint.forward * Time.fixedDeltaTime, ForceMode.Impulse);

        Destroy(Legoo, TimeToDestroyTheLegoo);
       
    }
}