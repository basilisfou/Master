/*συνάρτηση που ενεργοποιείται με το πάτημα του κουμπιου subtotal*/
function TotalCheckedValues() 
 {
	
	var x = document.getElementById("subtotal_button");   /* αντιστοίχηση του κουμπιού subtotal με την μεταβλητή x */

	var check1 = document.getElementById("check_box_T-Shirt"); /* αντιστοίχηση του check box με id : check_box_T-Shirt με την μεταβλητή check 1 , παρόμοια για τις υπόλοιπες 2 σειρές */
	var check2 = document.getElementById("check_box_ball");
	var check3 = document.getElementById("check_box_Shoes");
	var total = 0;  /* αρχικοποίηση μεταβλητης */
		
		if(	check1.checked == true)  /* άμα είναι τσεκαρισμένο το ckeck box με id: check_box_T-Shirt τότε προχωράμε στην συνθήκη , παρόμοια και για τις υπόλοιπες συνθήκες  */
		{ 
			total = total +	parseFloat(check1.value); /* στην μεταβλητη total προσθέτεται η τιμή του check_box_T-Shirt + η total με την τιμή που έχει ήδη , ParseFloat : μετατρέπει την τιμή value σε πραγματικό*/
		}
		if( check2.checked == true) 
			{ 
				total = total + parseFloat(check2.value); 
			}
		if( check3.checked == true) 
		{ 
			total = total + parseFloat(check3.value); 
		}
		
		document.getElementById("Total_textbox").value = total;	/* εξισώνεται η μεταβλητή με id : Total με το value του text με id Total_textbox , ουσιαστικά αναγράφεται η τιμή της μεταβλητής μέσα στο πεδίο του textbox */
}


/* συνάρτηση που ελέγχει τα στοιχεία που έχει δώσει ο χρήστης */
function Validate() 
{
	var name = document.getElementById("Text_name").value; /* αντιστοίχηση του value του στοιχείου σε μία μεταβλητή , ουσιαστικά ότι γράφει ο χρήστης αντιστοίχιζεται με την μεταβλητή , παρόμοια και για τις υπόλοιπες γραμμές*/
	var address = document.getElementById("Address_order").value; 
	var numberCard = document.getElementById("Card_number").value;
	var town = document.getElementById("Town").value;
	var security_Code = document.getElementById("passwordCard").value;
	var country = document.getElementById("Country_order").value;
	var expiration_Date = document.getElementById("DateCard").value;
	var submit = "true"; /* μεταβλητή  που στην συνέχεια θα παίξει τον ρόλο της ενεργοποίησης του κουμπιού με id: proceed_button */
	if (name.length < 5) /* συνθήκη που ενεργοποιείται άν το μήκος του string της μεταβλητής name είναι μικρότερο από 5 παρόμοια και για τις υπόλοιπες συνθήκες  */
	{
		alert("Give valid name"); /* παράγεται ένα alert message box που αναγράφει στον χρήστη ότι περικλείεται μέσα στις αγκύλες */
		submit = "false"; /* το submit γίνεται false  */
	}
	if (address.length <10)
	{
		alert("Give valid address");
		submit = "false";
	}
	if ((numberCard != "1111222233334444")) /* υποτηθέμενος αριθμός κάρτας υπάρχει σε ένα txt αρχείο */
	{
		alert("Give valid number Card");
		submit = "false";
	}
	if (town.length <= 0)
	{
		alert("Give valid town");
		submit = "false";
	}
	if ((security_Code.length <3) && (security_Code.length > 5))
	{
		alert("Give valid security code");
		submit = "false";
	}
	if (country.length < 3)
	{
		alert("Give valid security code");
		submit = "false";
	}
	if(expiration_Date.length < 7)
	{
		alert("Give valid expiration_Date");
		submit = "false";
	}
	
	if (submit == "true") /* ενεργοποίση του button σε περίπτωση που ο χρήστης έχει γεμίσει τα κενά σωστά αλλίως δεν μπορεί να προχωρίσει στην αγορά */
		document.getElementById("proceed_button").disabled = false; /* το κουμπί είναι απενεργωποιημένο από τον κώδικα στην HTML και με αυτόν τον τρόπο ενεργωποιείται*/
}
/* ενεργοποιείται με το πάτημα του κουμπιου proceed */
function MsgBox() 
{
	var x = document.getElementById("proceed_button"); /* αντιστοίχηση του κουμπιου με την μεταβλητή x */
	var r = confirm("If you are sure Proceed\nPrice: " + document.getElementById("Total_textbox").value + " €"); /* αναπαραγωγή του message box  confirm  σε περίπτωση που ο χρήστης πατήσει οκ τότε η μεταβλητή που αντιστοιχίζεται με το στοιχείο (r) παίρνει την τιμή true ειδάλλως την τιμή false */
	if (r == true ) 
	{
		if(document.getElementById("Total_textbox").value > 0 ) /* μόνο αν οι χρήστης έχει επιλέξει προϊόν μπορεί να συνεχίσει στην συνθήκη */
			alert("Congratulation!! the products have been purchased");
		else 
			alert("Please select products to purchase");
	}
}