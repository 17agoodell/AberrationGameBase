using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsText : MonoBehaviour {


	public Sprite Arrow;
	public enum States {NoChoice, GetUp, RemainInBed, WhatYear, WhyAmIHere, CanILeave, IFeelFine, IFeelCrap, Food, Water, WantToLeave, StayInBed, AttemptToLeave};
	public int optionSelection = 1;
	public States myState;
	public Text OptionText;


	// Use this for initialization
	void Awake () {
		myState = States.NoChoice;

	}

	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			optionSelection--;
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			optionSelection++;
		}
		if(myState == States.NoChoice) {
			state_NoChoice ();
		} else if (myState == States.GetUp) {
			state_GetUp ();
		} else if (myState == States.RemainInBed) {
			state_RemainInBed ();
		} else if (myState == States.WhatYear) {
			state_WhatYear ();
		} else if (myState == States.WhyAmIHere) {
			state_WhyAmIHere ();
		} else if (myState == States.CanILeave) {
			state_CanILeave ();
		} else if (myState == States.IFeelFine) {
			state_IFeelFine ();
		} else if (myState == States.IFeelCrap) {
			state_IFeelCrap ();
		} else if (myState == States.Food) {
			state_Food ();
		} else if (myState == States.Water) {
			state_Water ();
		} else if (myState == States.WantToLeave) {
			state_WantToLeave ();
		} else if (myState == States.StayInBed) {
			state_StayInBed ();
		} else if (myState == States.AttemptToLeave) {
			state_AttemptToLeave ();
		}
	
	}

	void state_NoChoice () {


		if (optionSelection > 2) {
			optionSelection = 1;
		}

		if (optionSelection < 1) {
			optionSelection = 2;
		}

		if (optionSelection == 1){
			OptionText.text = "<i>You wake up in a panic.</i> 'Where am I?'<i> You look around.</i>\n\n" + "<color=red>Get up.</color>\n" + "Remain in bed.";
		}

		if (optionSelection == 2){
			OptionText.text = "<i>You wake up in a panic.</i> 'Where am I?'<i> You look around.</i>\n\n" + "Get up.\n" + "<color=red>Remain in bed.</color>";
		}


		if (myState == States.NoChoice && optionSelection == 1 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.GetUp;
		}

		else if (myState == States.NoChoice && optionSelection == 2 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.RemainInBed;
		}

	
	}

	void state_GetUp () {

		if (optionSelection > 3) {
			optionSelection = 1;
		}

		if (optionSelection < 1) {
			optionSelection = 3;
		}

		if (optionSelection == 1){
			OptionText.text = "<i>You stand up and walk to the door, exiting the room. You go to the main desk, a woman greeting you.</i>\n" +
				"Desk worker: Miss Rine? You're awake!\n\n" +
				"<color=red>What year is it?</color>\n" +
				"Why am I here?\n" +
				"Can I leave?";

		}

		if (optionSelection == 2){
			OptionText.text = "<i>You stand up and walk to the door, exiting the room. You go to the main desk, a woman greeting you.</i>\n" +
				"Desk worker: Miss Rine? You're awake!\n\n" +
				"What year is it?\n" +
				"<color=red>Why am I here?</color>\n" +
				"Can I leave?";
		}

		if (optionSelection == 3){
			OptionText.text = "<i>You stand up and walk to the door, exiting the room. You go to the main desk, a woman greeting you.</i>\n" +
				"Desk worker: Miss Rine? You're awake!\n\n" +
				"What year is it?\n" +
				"Why am I here?\n" +
				"<color=red>Can I leave?</color>";
		}

		if (myState == States.GetUp && optionSelection == 1 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.WhatYear;
		}

		else if (myState == States.GetUp && optionSelection == 2 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.WhyAmIHere;
		}

		else if (myState == States.GetUp && optionSelection == 3 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.CanILeave;
		}

	}

	void state_RemainInBed () {

		if (optionSelection > 2) {
			optionSelection = 1;
		}

		if (optionSelection < 1) {
			optionSelection = 2;
		}

		if (optionSelection == 1){
			OptionText.text = "<i>You stay in bed. After a while, a nurse comes into the room.</i>\n"
				+ "Nurse: You’re awake! How are you feeling?”\n\n"
				+ "<color=red>I feel fine. (lie)</color>\n"
				+ "I feel like crap. (truth)";
			}

		if (optionSelection == 2){
			OptionText.text = "<i>You stay in bed. After a while, a nurse comes into the room.</i>\n"
				+ "Nurse: You’re awake! How are you feeling?”\n\n"
				+ "I feel fine. (lie)\n"
				+ "<color=red>I feel like crap. (truth)</color>";
				}

		if (myState == States.RemainInBed && optionSelection == 1 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.IFeelFine;
		}

		else if (myState == States.RemainInBed && optionSelection == 2 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.IFeelCrap;
		}

	}

	void state_WhatYear () {
		
		if (optionSelection > 2) {
			optionSelection = 1;
		}

		if (optionSelection < 1) {
			optionSelection = 2;
		}

		if (optionSelection == 1) {
			OptionText.text = "Desk worker: You’ve been asleep for quite some time. It’s 2014. Just turned fall a few days ago.\n"
				+ "'How long have I been out?'\n"
				+ "When did I get here?\n"
				+ "Desk worker: Some time in 2008, I believe. You’ve been one of our few chronic patients.\n\n"
				+ "<color=red>Why am I here?</color>\n"
				+ "Can I leave?";
		}



		if (optionSelection == 2) {
			OptionText.text = "Desk worker: You’ve been asleep for quite some time. It’s 2014. Just turned fall a few days ago.\n"
			+ "'How long have I been out?'\n"
			+ "When did I get here?\n"
			+ "Desk worker: Some time in 2008, I believe. You’ve been one of our few chronic patients.\n\n"
			+ "Why am I here?\n"
			+ "<color=red>Can I leave?</color>";
		}


		if (myState == States.WhatYear && optionSelection == 1 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.WhyAmIHere;
		}


		else if (myState == States.WhatYear && optionSelection == 2 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.CanILeave;
		}

	}

	void state_WhyAmIHere () {

		if (optionSelection > 2) {
			optionSelection = 1;
		}

		if (optionSelection < 1) {
			optionSelection = 2;
		}

		if (optionSelection == 1) {
			OptionText.text = "Desk worker: Dear, you’ve been in a coma for six years. I’m surprised you can even walk in your state.\n"
				+ "'Well, it’s not as easy as it looks…'\n"
				+ "<color=red>What year is it?</color>\n"
				+ "Can I leave?";
		}

		if (optionSelection == 2) {
			OptionText.text = "Desk worker: Dear, you’ve been in a coma for six years. I’m surprised you can even walk in your state.\n"
				+ "'Well, it’s not as easy as it looks…'\n"
				+ "What year is it?\n"
				+ "<color=red>Can I leave?</color>";
		}

		if (myState == States.WhyAmIHere && optionSelection == 1 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.WhatYear;
		}

		else if (myState == States.WhyAmIHere && optionSelection == 2 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.CanILeave;
		}

	}

	void state_CanILeave () {
		OptionText.text = "Desk worker: Without authorization from a legal guardian, we can’t release you from the hospital. Let me see…\n"
			+ "<i>The woman types into the computer, looking up her files.</i>\n"
			+ "Desk worker: It seems both your guardians are deceased, " +
			"and the orphanage you were placed under has been shut down for over three years\n now for misconduct.\n"
			+ "'What does that mean for me?'\n"
			+ "Desk worker: If you fill out this paperwork, you can be released momentarily.\n"
			+ "<i>You fill out the paperwork and hand it to the woman.</i>\n"
			+ "Desk worker: After we check your vitals, you are good to go."
			+ "<i>The screen goes black, then comes back with M at the door.</i>\n"
			+ "Desk worker: Hope you feel better, Miss Rine.\n"
			+ "<i>You walk out the door. SCENE END.</i>";


	}

	void state_IFeelFine () {


		if (optionSelection > 3) {
			optionSelection = 1;
		}

		if (optionSelection < 1) {
			optionSelection = 3;
		}

		if (optionSelection == 1) {
			OptionText.text = "Nurse: That’s good… But don’t sit up too fast, you might feel faint.\n"
			+ "<i>The nurse comes over, helping her adjust.</i>\n"
			+ "'Thank you.'\n"
			+ "Nurse: Do you need anything?\n\n"
			+ "<color=red>Food.</color>\n"
			+ "Water.\n"
			+ "I want to leave.";
		}

		if (optionSelection == 2) {
			OptionText.text = "Nurse: That’s good… But don’t sit up too fast, you might feel faint.\n"
			+ "<i>The nurse comes over, helping her adjust.</i>\n"
			+ "'Thank you.'\n"
			+ "Nurse: Do you need anything?\n\n"
			+ "Food.\n"
			+ "<color=red>Water.</color>\n"
			+ "I want to leave.";
		}

		if (optionSelection == 3) {
			OptionText.text = "Nurse: That’s good… But don’t sit up too fast, you might feel faint.\n"
				+ "<i>The nurse comes over, helping her adjust.</i>\n"
				+ "'Thank you.'\n"
				+ "Nurse: Do you need anything?\n\n"
				+ "Food.\n"
				+ "Water.\n"
				+ "<color=red>I want to leave.</color>";
		}

		if (myState == States.IFeelFine && optionSelection == 1 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.Food;
		}

		else if (myState == States.IFeelFine && optionSelection == 2 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.Water;
		}

		else if (myState == States.IFeelFine && optionSelection == 3 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.WantToLeave;
		}

	}

	void state_IFeelCrap () {
		if (optionSelection > 2) {
			optionSelection = 1;
		}

		if (optionSelection < 1) {
			optionSelection = 2;
		}

		if (optionSelection == 1) {
			OptionText.text = "Nurse: Oh, let me get you some pain killers. I’ll be just a minute.\n" +
			"<i>The nurse exits the room.</i>\n\n" +
			"<color=red>Stay in bed.</color>\n" +
			"Attempt to leave.";
		}

		else if (optionSelection ==2) {
			OptionText.text = "Nurse: Oh, let me get you some pain killers. I’ll be just a minute.\n" +
				"<i>The nurse exits the room.</i>\n\n" +
				"Stay in bed.\n" +
				"<color=red>Attempt to leave.</color>";
		}

		if (myState == States.IFeelCrap && optionSelection == 1 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.StayInBed;
		}

		else if (myState == States.IFeelCrap && optionSelection == 2 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.AttemptToLeave;
		}


	}

	void state_Food () {

		if (optionSelection > 2) {
			optionSelection = 1;
		}

		if (optionSelection < 1) {
			optionSelection = 2;
		}

		if (optionSelection == 1) {
			OptionText.text = "Nurse: Right now, you won’t be able to handle solid food, but we can get you something to eat.\n"
			+ "<i>The nurse walks over to the door and presses a button, speaking into the device above.</i>\n"
			+ "Nurse: Room 128, tray delivery please.\n"
			+ "She sits down in the chair next to the bed to wait. After a minute or so another nurse comes"
			+ "into the room with a tray and places it on the bed before leaving. There is a cup with a straw" +
			"poking out of it. M tries a bit of the food.\n"
			+ "It’s kind of gross.\n"
			+ "'...Thanks.'\n\n"
			+ "<color=red>Water.</color>\n"
			+ "I want to leave.";
		} else if (optionSelection == 2) {
			OptionText.text = "Nurse: Right now, you won’t be able to handle solid food, but we can get you something to eat.\n"
			+ "<i>The nurse walks over to the door and presses a button, speaking into the device above.</i>\n"
			+ "Nurse: Room 128, tray delivery please.\n"
			+ "She sits down in the chair next to the bed to wait. After a minute or so another nurse comes"
			+ "into the room with a tray and places it on the bed before leaving. There is a cup with a straw" +
			"poking out of it. M tries a bit of the food.\n"
			+ "It’s kind of gross.\n"
			+ "'...Thanks.'\n\n"
			+ "Water.\n"
			+ "<color=red>I want to leave.</color>";
		}

		if (myState == States.Food && optionSelection == 1 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.Water;
		} else if (myState == States.Food && optionSelection == 2 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.WantToLeave;
		}
	}
	

	void state_Water () {
				if (optionSelection > 2) {
					optionSelection = 1;
				}

				if (optionSelection < 1) {
					optionSelection = 2;
				}	

		if (optionSelection == 1) {
			OptionText.text = "Nurse: Alright, I’ll get you some.\n" +
				"<i>She goes to the sink in the room and fills up a cup, giving it to M. M drinks a bit of it and sets it on the table next to the bed.</i>\n" +
				"'Thanks.'\n\n" +
				"<color=red>Food.</color>\n" +
				"I want to leave.";
		}

		else if (optionSelection == 2) {
			OptionText.text = "Nurse: Alright, I’ll get you some.\n" +
				"<i>She goes to the sink in the room and fills up a cup, giving it to M. M drinks a bit of it and sets it on the table next to the bed.</i>\n" +
				"'Thanks.'\n\n" +
				"Food.\n" +
				"<color=red>I want to leave.</color>";
		}

		if (myState == States.Water && optionSelection == 1 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.Food;
		}
		else if (myState == States.Water && optionSelection == 2 && Input.GetKeyDown (KeyCode.Space)) {
			myState = States.WantToLeave;
		}

	}

	void state_WantToLeave () {
			OptionText.text = "Nurse: Miss Rine, you need to rest! You aren’t in a healthy state right now.\n" +
				"<i>'I'm fine.'</i>\n" +
				"<i>You try to sit up, the nurse protesting.</i>\n" +
				"Nurse: I suggest you <i>stay in your bed</i>.\n" +
				"<i>You look at her, confused but persistent. You try to get up again, but are pushed down by the nurse.</i>\n" +
				"Nurse: <i>Go back to sleep, little girl.</i>\n" +
				"<i>You gasp, a shock going through your body at the nurse's touch. You fall unconscious.</i>\n" +
				"SCENE END.";
		}

	void state_StayInBed () {
		OptionText.text = "<i>You remain in bed, waiting. The nurse returns in a minute or so with pills and a cup of water.</i>\n" +
			"Nurse: Here you are.\n" +
			"<i>You take the cup and swallow the pills, gulping down the water. You look at the nurse.</i>\n" +
			"Nurse: Better?\n" +
			"<i>You start feeling sleepy, and lie back down. The nurse's expression twists.</i>\n" +
			"Nurse: Goodnight, Miss Rine.\n" +
			"<i>You fall unconscious.</i>" +
			"SCENE END.";
	}
		

	void state_AttemptToLeave () {
		OptionText.text = "<i>You try getting out of bed, groaning in pain as you stand. You make your way to the door and look out, making sure" +
			"the hall is clear. You walk into the foyer, avoiding eye contact with the woman at the main desk. You make your way to the exit.</i>\n" +
			"Desk worker: Um, miss, you can't leave without written consent!\n" +
			"<i>You exit anyway, slipping into the shadows.</i>\n" +
			"SCENE END.";
	}

}

