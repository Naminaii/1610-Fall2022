using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit_3_Lab : MonoBehaviour
{
    public class AwakeAndStart : MonoBehaviour
    {
        void Awake ()
        {
            Debug.Log("Awake called.");
        }
    
    
    void Start ()
    {
        Debug.Log("Start called.");
    }
}
    
public class Guest : MonoBehaviour 
{
    public string Greeting;
    
    void Start () 
    {
        Debug.Log("Welcome to Death's Bar," + myName + "Drink what you want. There's no point worrying about liver damage if you're already dead.");
    }
}
    public class ColorChangeReaction : MonoBehaviour
        {
            void Update()
            {
                 if (Input.GetKeyDown(KeyCode.R))
                {
                    GetComponent<Renderer> ().material.color = Color.red;
                }
                if (Input.GetKeyDown(KeyCode.G))
                {
                    GetComponent<Renderer>().material.color = Color.green;
                }
                if (Input.GetKeyDown(KeyCode.B))
                {
                 GetComponent<Renderer>().material.color = Color.blue;
                }
             }
        }

public class NumberStuff : MonoBehaviour
    {   
    int myInt = 6;
    
    void Start ()
    {
         myInt = MultiplyByTwo(myInt);
        Debug.Log (myInt);
    }
    
    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }
    }

public class DropItLikeItsHot : MonoBehaviour
{
    void Start ()
    {
        //this line is there to tell me the x position of my object

        /*Hi there!
         * this is two lines!
         * */
        Debug.Log(transform.position.x);
        
        if(transform.position.y <= 5f)
        {
            Debug.Log ("Let the bodies hit the floor!");
        }
    }
}

 /* functions */
 void Start () 
 {
   // Since this object as an child the (0, 0, 0) position will be the same as the players. So we can just add to the zero vector and it will be position correctly. 
 
   moveToPosition = new Vector3 (0, 2, -0.01f); // 2 meters above/ 0.01 meters behind
 // If you are allowed to rotate your camera the change the -0.01 to 0
 
 // The following function decides how long to stare at the player before moving
   LookAtPlayerFor (3.5f) ; // waits for 3.5 seconds then starts 
 }
 
 Enumarator LookAtPlayerFor (float time) {
   yield return new WaitForSeconds (time);
    started = true;
 }

public class CoffeeServe : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    
void Update ()
{
    if(Input.GetKeyDown(KeyCode.Space))
    TemperatureTest();
    
    coffeeTemperature -= Time.deltaTime * 3f;
}

void TemperatureTest ()
{
    if(coffeeTemperature > hotLimitTemperature)
    {
        print("Coffee is too hot.");
    }
       
    else if(coffeeTemperature < coldLimitTemperature)
    {
        print("Coffee is too cold.");
    }

    else
    {
     print("Coffee is just right.");
    }
    }
}

public class EnemyGenerator : MonoBehaviour
{
    int numEnemies = 3;
    
    
    void Start ()
    {
        for(int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
}

public class Washing : MonoBehaviour
{
    int platesInTheSink = 4;
    
    
    void Start ()
    {
        while(cupsInTheSink > 0)
        {
            Debug.Log ("I washed a plate!");
            cupsInTheSink--;
        }
    }
}

public class CarryOn : MonoBehaviour 
{
    void Start()
    {
        bool shouldContinue = false;
        
        do
        {
            print ("Welcome Guests");
            
        }while(shouldContinue == true);
    }
}

public class NumberPlacing : MonoBehaviour 
{   
    void Start () 
    {
        string[] ranks = new string[3];
        
        strings[0] = "First place";
        strings[1] = "Second place";
        strings[2] = "Third place";
        
        foreach(string item in ranks)
        {
            print (item);
        }
    }
}

public class ScopeAndAccessModifiers : MonoBehaviour
{
    public int alpha = 5;
    private int beta = 0;
    private int gamma = 5;
    
    private AnotherClass myOtherClass;
    
    void Start ()
    {
        alpha = 29;
        
        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }
}

 void Example (int pens, int crayons)
  {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
  }
    
    
    void Update () 
    {
        Debug.Log("Alpha is set to: " + alpha);
    } 
}

public class AnotherClass
{
    public int apples;
    public int bananas;
    
    
    private int stapler;
    private int tape;
    
    
    public void FruitMachine (int apples, int banannas)
    {
        int answer;
        answer = apples + bananas;
        Debug.Log("Fruit total: " + answer);
    }
    
    
    private void OfficeSort (int stapler, int tape)
    {
        int answer;
        answer = stapler + tape;
        Debug.Log("Office Supplies total: " + answer);
    }
}

public class TickyTocky : MonoBehaviour
{
    void FixedUpdate ()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }
    
    void Update ()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}

public class LightSwitch : MonoBehaviour
{
    private Light myLight;
    
    void Start ()
    {
        myLight = GetComponent<Light>();
    }
    
    void Update ()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}

public class ActiveObjects : MonoBehaviour
{
    void Start ()
    {
        gameObject.SetActive(false);
    }
}

public class CheckState : MonoBehaviour
{
    public GameObject myObject;
    
    void Start ()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }
}

public class IcanMove : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    
    
    void Update ()
    {
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}

public class Vision : MonoBehaviour
{
    public Transform target;
    
    void Update ()
    {
        transform.LookAt(target);
    }
}

void Update ()
{
    light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);
}

void Update ()
{
    light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
}

public class DestroyBasic : MonoBehaviour
{
    void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}

public class Destruction : MonoBehaviour
{
    public GameObject other;
    
    void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(other);
        }
    }
}

public class ComponentDeath : MonoBehaviour
{
    void Update ()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}

public class AxisExample : MonoBehaviour
{
    public float range;
    public Text textOutput;
    
    void Update () 
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range; 
        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");  
    }
}

public class AxisRaw : MonoBehaviour
{
    public float range;
    public Text textOutput;
    
    void Update () 
    {
        float h = Input.GetAxisRaw("Horizontal");
        float xPos = h * range;
        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned: " + h.ToString("F2");  
    }
}

public class DualAxisExample : MonoBehaviour 
{
    public Text horizontalValueDisplayText;
    public Text verticalValueDisplayText;
    public float hRange;
    public float vRange;
    
    void Update ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;
        transform.position = new Vector3(xPos, 0, vPos);
        horizontalValueDisplayText.text = h.ToString("F2");
        verticalValueDisplayText.text = v.ToString("F2");
    }
}

public class MouseClick : MonoBehaviour
{
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown ()
    {
        rb.AddForce(-transform.forward * 500f);
        rb.useGravity = true;
    }
}

public class UseComponents : MonoBehaviour
{
    public GameObject otherGameObject;
    
    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;
    
    void Awake ()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }
    
    void Start ()
    {
        boxCol.size = new Vector3(3,3,3);
        Debug.Log("The player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
    }
}

public class Wins : MonoBehaviour
{
    public int playerScore = 15;
}

public class PeopleDie : MonoBehaviour
{
    public int numberOfPlayerDeaths = 4;
}

public class TimeTable : MonoBehaviour
{
    public float speed = 8f; 
    public float countdown = 3.0f;
    
    void Update ()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0.0f)
            light.enabled = true;
         if(Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
    }   
}

public class DatatypeScript : MonoBehaviour 
{
    void Start () 
    {
        //Value type variable
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);
        
        //Reference type variable
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);
    }
}

public class SingleCharacterScript : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        
        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
    }
    
    public Stuff myStuff = new Stuff(10, 7, 25);
    public float speed;
    public float turnSpeed;
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;
    
    
    void Update ()
    {
        Movement();
        Shoot();
    }
   
    void Movement ()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        
        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
    
    void Shoot ()
    {
        if(Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;
        }
    }
}

    public Stuff ()
        {
            bullets = 1;
            grenades = 1;
            rockets = 1;
        }
    }
    
    // Creating an Instance (an Object) of the Stuff class
    public Stuff myStuff = new Stuff(50, 5, 5);
    
    public Stuff myOtherStuff = new Stuff(50, 1.5f);
    
    void Start()
    {
        Debug.Log(myStuff.bullets); 
    }
}

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;
    
    
    private Inventory inventory;
 }   

 void Awake ()
{
    inventory = GetComponent<Inventory>();
}

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;

    private Inventory inventory;
   
void Awake ()
{
 inventory = GetComponent<Inventory>();
}
    
 void Update ()
{
  Shoot();
}

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody rocketPrefab;
    public Transform barrelEnd;
    
    
    void Update ()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.forward * 5000);
        }
 }
    
public class RocketDestruction : MonoBehaviour
{
    void Start()
    {
        Destroy (gameObject, 1.5f);
    }
}

public class Lists : MonoBehaviour
{
    public GameObject[] players;

    void Start ()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        
        for(int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number "+i+" is named "+players[i].name);
        }
    }
}

public class Tome : MonoBehaviour 
{
    public GameObject target;

    void Start()
    {
        Invoke ("SpawnObject", 2);
    }
    
    void SpawnObject()
    {
        Instantiate(target, new Vector3(0, 2, 0), Quaternion.identity);
    }
}

public class RepeatingTome : MonoBehaviour 
{
    public GameObject target;
    
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
    }
    
    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(target, new Vector3(x, 2, z), Quaternion.identity);
    }
}

public class EnumScript : MonoBehaviour 
{
    enum Direction {North, East, South, West};

        void Start () 
    {
        Direction myDirection;
        
        myDirection = Direction.North;
    }
    
    Direction ReverseDirection (Direction dir)
    {
        if(dir == Direction.North)
            dir = Direction.South;
        else if(dir == Direction.South)
            dir = Direction.North;
        else if(dir == Direction.East)
            dir = Direction.West;
        else if(dir == Direction.West)
            dir = Direction.East;
        
        return dir;     
    }
}

public class ConversationScript : MonoBehaviour 
{
    public int convo = 5;
    
    
    void Greet()
    {
        switch (intelligence)
        {
        case 5:
            print ("Good evening, welcome to Death's Bar. What can I get you started with?");
            break;
        case 4:
            print ("......");
            break;
        case 3:
            print ("Do you want to play pool?");
            break;
        case 2:
            print ("My wife doesn't know I come here. Please keep it that way.");
            break;
        case 1:
            print ("I like the band. It's nice.");
            break;
        default:
            print ("Choose someone to talk to.");
            break;
        }
    }
}
