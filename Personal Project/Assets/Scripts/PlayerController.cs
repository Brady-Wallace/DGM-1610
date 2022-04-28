using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private float speed = 0.03f;
    private Rigidbody playerRb;
    private int life = 1;
    private bool hasKey;
    private Vector3 pos1;
    private Vector3 pos2;
    private Vector3 pos3;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    private int index = 0;
    public bool isGameActive;
    private Button button;
    public GameObject text;
    public GameObject powerUP;
    public GameObject key;
    public TextMeshProUGUI livesText;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;


    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        playerRb = GetComponent<Rigidbody>();
        pos1 = spawn1.transform.position;
        pos2 = spawn2.transform.position;
        pos3 = spawn3.transform.position;
        isGameActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive)
        {
            MovePlayer();
        }

        if (life == 0)
        {
            isGameActive = false;
            text.gameObject.SetActive(true);
            index = 0;
        }

        livesText.text = "Lives: " + life;

    }


    public void OnMouseDown()
    {
        isGameActive = true;
        text.gameObject.SetActive(false);
        life = 1;
        transform.position = pos1;
        cam1.gameObject.SetActive(true);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
    }

    //Moves the player using WASD or arrow keys
    void MovePlayer()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        
        transform.Translate(Vector3.forward * speed * verticalInput);
        transform.Translate(Vector3.right * speed * horizontalInput);

      
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("1up"))
        {
            powerUP.gameObject.SetActive(false);
            life++;
        }

        else if (other.gameObject.CompareTag("Key"))
        {
            key.gameObject.SetActive(false);
            hasKey = true;
        }

        else if (other.gameObject.CompareTag("Enemy"))
        {
            if (index == 0)
            {
                transform.position = pos1;
            }
            if (index == 1)
            {
                transform.position = pos2;
            }
            if (index == 2)
            {
                transform.position = pos3;
            }

            life--;
        }

        else if (other.gameObject.CompareTag("Exit") && hasKey)
        {
            if (index == 0)
            {
                cam1.gameObject.SetActive(false);
                cam2.gameObject.SetActive(true);
                transform.position = pos2;
                index++;
            }
            else if (index == 1)
            {
                cam2.gameObject.SetActive(false);
                cam3.gameObject.SetActive(true);
                transform.position = pos3;
                index++;
            }

            else if(index == 2)
            {
                isGameActive = false;
                text.gameObject.SetActive(true);
            }

            key.gameObject.SetActive(true);
            powerUP.gameObject.SetActive(true);
            hasKey = false;
         }

    }
}