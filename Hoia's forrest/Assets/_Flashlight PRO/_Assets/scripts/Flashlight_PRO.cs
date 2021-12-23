using UnityEngine;
using System.Collections;




public class Flashlight_PRO : MonoBehaviour 
{
	[Space(10)]
	[SerializeField()] GameObject Lights; // all light effects and spotlight
	[SerializeField()] AudioSource switch_sound; // audio of the switcher
	[SerializeField()] ParticleSystem dust_particles; // dust particles



	public Light spotlight;
	private Material ambient_light_material;
	private Color ambient_mat_color;
	private bool is_enabled = true;
	public bool drainOverTime;
	public float maxBrightness;
	public float minBrightness;
	public float drainRate;
	public float amount;









	// Use this for initialization
	void Start () 
	{
		// cache components
		spotlight = Lights.transform.Find ("Spotlight").GetComponent<Light> ();
		ambient_light_material = Lights.transform.Find ("ambient").GetComponent<Renderer> ().material;
		ambient_mat_color = ambient_light_material.GetColor ("_TintColor");
	}



	/// <summary>
	/// changes the intensivity of lights from 0 to 100.
	/// call this from other scripts.
	/// </summary

	private void Update()
    {
		spotlight.intensity = Mathf.Clamp(spotlight.intensity, minBrightness, maxBrightness);
		if (drainOverTime == true && is_enabled == true)
        {
			if(spotlight.intensity > minBrightness)
            {
				spotlight.intensity -= Time.deltaTime * (drainRate / 1000);
            }
        }
		
		

        if (Input.GetKeyDown(KeyCode.F))
        {
			Switch();
        }
    }



	/// <summary>
	/// switch current state  ON / OFF.
	/// call this from other scripts.
	/// </summary>
	public void Switch()
	{
		is_enabled = !is_enabled; 

		Lights.SetActive (is_enabled);

		if (switch_sound != null)
			switch_sound.Play ();
	}





	/// <summary>
	/// enables the particles.
	/// </summary>
	public void Enable_Particles(bool value)
	{
		if(dust_particles != null)
		{
			if(value)
			{
				dust_particles.gameObject.SetActive(true);
				dust_particles.Play();
			}
			else
			{
				dust_particles.Stop();
				dust_particles.gameObject.SetActive(false);
			}
		}
	}

	public void ReplaceBattery()
    {
		spotlight.intensity += amount;
    }


}
