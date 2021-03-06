using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadTextureRoom2 : MonoBehaviour {
	//public string url = "http://1.rsumka.z8.ru/wall.jpg";
	string url; 

	//public string url_floor = "http://1.rsumka.z8.ru/floor.jpg"; 
	//public string url_ceiling = "http://1.rsumka.z8.ru/ceiling.jpg"; 
	string url_floor; 
	string url_ceiling; 

	public GameObject wall_1;
	public GameObject wall_2;
	public GameObject wall_3;
	public GameObject wall_4;
	public GameObject wall_5;
	public GameObject wall_6;
	public GameObject floor;
	public GameObject ceiling;
	public GameObject go_text;
	// Use this for initialization

	//void Start() {
//	go_text.GetComponent<Text>().text= Application.persistentDataPath + "/wall.jpg"; 
//	}
	public void Load () {
		url = "file://" +Application.persistentDataPath + "/wall_с.jpg"; 
		url_floor =  "file://" + Application.persistentDataPath + "/floor_с.jpg"; 
		url_ceiling = "file://" + Application.persistentDataPath + "/ceiling_с.jpg"; 

		float x_scale = 1f;
		float y_scale = 1f;

		string path_wall = Application.persistentDataPath + "/wall_c.jpg"; 
		string path_floor = Application.persistentDataPath + "/floor.jpg"; 
		string path_ceiling = Application.persistentDataPath + "/ceiling.jpg"; 

		Texture2D tex_wall = new Texture2D (1024, 1024, TextureFormat.RGB24,false,false);
		Texture2D tex_floor = new Texture2D (1024, 1024, TextureFormat.RGB24,false,false);
		Texture2D tex_ceiling = new Texture2D (1024, 1024, TextureFormat.RGB24,false,false);

		if (tex_wall.LoadImage (System.IO.File.ReadAllBytes (path_wall))) {

			//go_text.GetComponent<Text> ().text = result.ToString ();
			tex_wall.Compress (false);

			Material wall_1_mat = wall_1.GetComponent<Renderer> ().material;
			wall_1_mat.mainTexture = tex_wall;
			wall_1_mat.mainTextureScale = new Vector2 (x_scale, y_scale);
			//		wall_1_mat.shader = Shader.Find ("Mobile/Diffuse");

			Material wall_2_mat = wall_2.GetComponent<Renderer> ().material;
			wall_2_mat.mainTexture = tex_wall;
			wall_2_mat.mainTextureScale = new Vector2 (x_scale, y_scale);
			//		wall_2_mat.shader = Shader.Find ("Mobile/Diffuse");

			Material wall_3_mat = wall_3.GetComponent<Renderer> ().material;
			wall_3_mat.mainTexture = tex_wall;
			wall_3_mat.mainTextureScale = new Vector2 (x_scale, y_scale);
			//		wall_3_mat.shader = Shader.Find ("Mobile/Diffuse");

			Material wall_4_mat = wall_4.GetComponent<Renderer> ().material;
			wall_4_mat.mainTexture = tex_wall;
			wall_4_mat.mainTextureScale = new Vector2 (x_scale, y_scale);
			//		wall_4_mat.shader = Shader.Find ("Mobile/Diffuse");

			Material wall_5_mat = wall_5.GetComponent<Renderer> ().material;
			wall_5_mat.mainTexture = tex_wall;
			wall_5_mat.mainTextureScale = new Vector2 (x_scale, y_scale);
			//		wall_5_mat.shader = Shader.Find ("Mobile/Diffuse");

			Material wall_6_mat = wall_6.GetComponent<Renderer> ().material;
			wall_6_mat.mainTexture = tex_wall;
			wall_6_mat.mainTextureScale = new Vector2 (x_scale, y_scale);
			//		wall_6_mat.shader = Shader.Find ("Mobile/Diffuse");
		}

		if ((floor != null)&&(tex_floor.LoadImage (System.IO.File.ReadAllBytes (path_floor)))) {
			tex_floor.Compress (false);
			Material floor_mat = floor.GetComponent<Renderer> ().material;
			floor_mat.mainTexture = tex_floor;
			floor_mat.mainTextureScale = new Vector2 (x_scale, y_scale);

		}

		if ((ceiling != null)&&(tex_ceiling.LoadImage (System.IO.File.ReadAllBytes (path_ceiling)))) {
			tex_ceiling.Compress (false);
			Material ceiling_mat = ceiling.GetComponent<Renderer> ().material;
			ceiling_mat.mainTexture = tex_ceiling;
			//		ceiling_mat.mainTextureScale = new Vector2 (5f, 5f);
		}

	

			
	
	//	StartCoroutine (CoroutineWall ());
	//	StartCoroutine (CoroutineFloor ());
	//	StartCoroutine (CoroutineCeiling ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	IEnumerator CoroutineWall() { 
		        
		WWW www = new WWW(url); 
		         
		yield return www; 

		float x_scale = 3f;
		float y_scale = 3f;

		if ((wall_1!=null)&&(www.error==null)) {
		Material wall_1_mat = wall_1.GetComponent<Renderer> ().material;
		wall_1_mat.mainTexture = www.texture;
			wall_1_mat.mainTextureScale = new Vector2 (x_scale, y_scale);
//		wall_1_mat.shader = Shader.Find ("Mobile/Diffuse");
		}

		if ((wall_2!=null)&&(www.error==null)) {
		Material wall_2_mat = wall_2.GetComponent<Renderer> ().material;
		wall_2_mat.mainTexture = www.texture;
					wall_2_mat.mainTextureScale = new Vector2 (x_scale, y_scale);
		//		wall_2_mat.shader = Shader.Find ("Mobile/Diffuse");
		}

		if ((wall_3!=null)&&(www.error==null)) {
		Material wall_3_mat = wall_3.GetComponent<Renderer> ().material;
		wall_3_mat.mainTexture = www.texture;
			wall_3_mat.mainTextureScale = new Vector2 (x_scale, y_scale);
		//		wall_3_mat.shader = Shader.Find ("Mobile/Diffuse");
		}

		if ((wall_4!=null)&&(www.error==null)) {
		Material wall_4_mat = wall_4.GetComponent<Renderer> ().material;
		wall_4_mat.mainTexture = www.texture;
			wall_4_mat.mainTextureScale = new Vector2 (x_scale, y_scale);
		//		wall_4_mat.shader = Shader.Find ("Mobile/Diffuse");
		}





	}

	IEnumerator CoroutineFloor() { 
		WWW www = new WWW (url_floor); 
		yield return www; 
	
		if ((floor != null)&&(www.error==null)) {
			Material floor_mat = floor.GetComponent<Renderer> ().material;
			floor_mat.mainTexture = www.texture;
	    floor_mat.mainTextureScale = new Vector2 (3f, 3f);

		}
	}

	IEnumerator CoroutineCeiling() { 
		WWW www = new WWW (url_ceiling); 
		yield return www; 

		if ((ceiling != null)&&(www.error==null)) {
			Material ceiling_mat = ceiling.GetComponent<Renderer> ().material;
			ceiling_mat.mainTexture = www.texture;
	//		ceiling_mat.mainTextureScale = new Vector2 (5f, 5f);
		}
	}

}
