using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 public enum colors 
   {
        carreau,pique,trefle,coeur,
   }
 public enum numbers 
   {
        As,deux,trois,quatre,cinq,six,sept,huit,neuf,dix,Valet,Dame,Roi,
   }
public class ICards : ScriptableObject
{
    public colors _color;
    public numbers _numbers;
  
}
