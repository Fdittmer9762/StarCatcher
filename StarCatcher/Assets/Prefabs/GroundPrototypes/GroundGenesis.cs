using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GroundGenesis : MonoBehaviour {

    public Vector3 gen;
    public GameObject[] hazards;
    public GameObject[] groundPieces;
    //public List<GameObject> topGroundPieces;
    public int groundH;
    public int gHMax, gHMin;

	void Start () {
        groundH = RandomNum(gHMax, gHMin);
        gen.y = Statics.levleHeight;
        StartCoroutine(GroundGen(gen, groundH, Statics.levleHeight));
	}

    IEnumerator GroundGen (Vector3 genPos, int gH, int h){
        genPos.y = h;
        while (h > gH + 1) {
            genPos.y-= Statics.gridSizeY;
            h--;
            //yield return null;
        }
        int rand = RandomNum(0, hazards.Length);
        MovePiece(genPos, hazards[rand]);//move random hazard to genPos;
        //hazards.RemoveAt(rand);//remove object from list
        genPos.y -= Statics.gridSizeY;
        h--;
        /*rand = 0; // *** 0 should be replaced with the list leingth, unable to impliment currently
        MovePiece(genPos, topGroundPieces[rand]); //sellects a random part and places it at genPos
        genPos.y -= Statics.; // moves genpos down
        h--;*/ //*** moves temp height down, not sure if necessary
        while (h > 0) {
            rand = RandomNum(0, groundPieces.Length);
            MovePiece(genPos, groundPieces[rand]);//move ground to genPos;
            //groundPieces.RemoveAt(rand);//remove object from list
            genPos.y -= Statics.gridSizeY;
            h--;
        }
        yield return new WaitForSeconds(Statics.levelWidth/Statics.gridSizeX); //may need to rework with local/instanced int although it may work better keeping it universal to avoid any issues
        groundH = RandomNum(gHMax, gHMin);
        StartCoroutine(GroundGen(gen, groundH, Statics.levleHeight));
    }

    void MovePiece(Vector3 pos, GameObject obj) {
        Transform objpos = obj.GetComponent<Transform>();
        //objpos.Translate(pos, Space.World);
        objpos.position = pos;
        Debug.Log(pos);
    }

    int RandomNum(int max, int min) {
        return Random.Range(max, min);
    }

}
