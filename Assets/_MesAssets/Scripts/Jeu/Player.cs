using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float _vitesse = 20f;
    private Rigidbody _rb;

    private void Start()
    {
        // placer le joueur à la position de départ
        transform.position = new Vector3(-42f, 0.5f, -42f);

        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MouvementsJoueur();
    }

    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        var direction = new Vector3(positionX, 0f, positionZ);
        // Normaliser la direction pour ne pas qu'elle dépasse la valeur 1
        direction.Normalize();

        // Applique une force sur le corps physique dans la direction du vecteur
        //_rb.AddForce(direction * _vitesse * Time.fixedDeltaTime);
        
        //Change la vitesse du corps physique dans la direction du vecteur
        _rb.velocity = direction * _vitesse * Time.fixedDeltaTime;
    }
}
