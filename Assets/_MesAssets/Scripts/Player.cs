using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float _vitesse = 20f;

    private void Start()
    {
        // placer le joueur � la position de d�part
        transform.position = new Vector3(-42f, 0.5f, -42f);
    }

    private void Update()
    {
        MouvementsJoueur();
    }

    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        var direction = new Vector3(positionX, 0f, positionZ);
        // Normaliser la direction pour ne pas qu'elle d�passe la valeur 1
        direction.Normalize();

        // D�placer le joueur dans la direction du vecteur
        transform.Translate(direction * _vitesse * Time.deltaTime);
    }
}
