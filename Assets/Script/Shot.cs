using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject LegooPrefab;
    public Transform spawnPoint; 
    public float LegooSpeed = 10f;
    public float TimeToDestroyTheLegoo = 3f;
    public SingletonPickUp inventory;

    private bool collidedWithLegoo = false;
    float ammunitations;

    private void Start()
    {
        ammunitations = PlayerPrefs.GetInt("LegooPlayerPref");
    }
    void Update()
    {

        //Debug.Log($"Ammunitations: { ammunitations.ToString()}");
        if (Input.GetKeyDown(KeyCode.H) && ammunitations > 0) 
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
        GameObject Legoo = Instantiate(LegooPrefab, spawnPoint.position, spawnPoint.rotation);
      

        Rigidbody rb = Legoo.GetComponent<Rigidbody>(); 
        rb.velocity = spawnPoint.forward * LegooSpeed;
        
        rb.AddForce(LegooSpeed * spawnPoint.forward * Time.fixedDeltaTime, ForceMode.Impulse);

        Destroy(Legoo, TimeToDestroyTheLegoo);
        ammunitations--;
        PlayerPrefs.SetInt("LegooPlayerPref", PlayerPrefs.GetInt("LegooPlayerPref") - 1);
        Debug.Log($"Ammunitations: { PlayerPrefs.GetInt("LegooPlayerPref") }");
    }
}