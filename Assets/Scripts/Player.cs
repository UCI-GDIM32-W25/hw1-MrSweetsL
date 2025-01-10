using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _plantCountUI.UpdateSeeds(_numSeeds, 0);
    }

    private void Update()
    {

        PlantSeed();

        //Player WASD movement
        if(Input.GetKey(KeyCode.W)) {

            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);

        }   

        if(Input.GetKey(KeyCode.S)) {

            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
            
        }   

        if(Input.GetKey(KeyCode.A)) {

            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
            
        }  

        if(Input.GetKey(KeyCode.D)) {

            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
            
        }    
    }

    public void PlantSeed()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {

            Debug.Log("Seed Planted");

            //GameObject plantSeeds = Instantiate(_plantPrefab) as GameObject;

        }
    }
}
