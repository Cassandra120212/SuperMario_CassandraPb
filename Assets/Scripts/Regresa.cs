using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Regresa : MonoBehaviour
{
   private UIDocument menu;
   private Button Regresar;

   void OnEnable()
   {
       menu = GetComponent<UIDocument>();
       var root = menu.rootVisualElement;

       Regresar = root.Q<Button>("Regresa");
        Regresar.clicked += CerrarEscena;
       }

       void OnDisable()
       {
           Regresar.clicked -= CerrarEscena;
       }

       void CerrarEscena()
    {
        SceneManager.LoadScene("Menu");
    }
}
