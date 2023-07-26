using UnityEngine;
using System.Collections;
 
public class SomeScript: MonoBehaviour {
 
void Update(){
if(Input.anyKey){
Application.LoadLevel("MenuScreen");
}
}
}