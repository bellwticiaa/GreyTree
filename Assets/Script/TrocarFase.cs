using UnityEngine;
using UnityEngine.SceneManagement;
 
public class TrocarFase : MonoBehaviour
{
    // Nome da cena para a qual você deseja mudar
    [SerializeField]
    private string nomeProximaFase;
 
    private void OnTriggerEnter2D(Collider2D collision){
        IrProximaFase();
 
    }
 
    private void IrProximaFase(){
        SceneManager.LoadScene(this.nomeProximaFase);
    }
 
 
 
   
}