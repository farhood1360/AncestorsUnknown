  function checkForNumber(fieldValue){
		var numberCheck = isNaN(fieldValue);
		if(numberCheck == true){
			window.alert("You must enter a numeric value!");
			return false;
		}else{
			return true;
	  }
  }
  
	function confirmSubmit(){
		var subError = false;
		var firstname = document.forms[0].fname.value;
		var email = document.forms[0].email.value;
		var phone = document.forms[0].phone.value;
		var lastname = document.forms[0].lname.value;
		var username = document.forms[0].username.value;
		var contact0 = document.forms[0].contactHow[0].checked;
		var contact1 = document.forms[0].contactHow[1].checked;
		
		if(name=="" || name=="Enter your first name"){
			window.alert("You must enter your first name.");
			return false;
		}
		if(name=="" || name=="Enter your last name"){
			window.alert("You must enter your last name.");
			return false;
		}else if( email=="" || email=="Enter your e-mail address"){
			window.alert("You must enter your email address.");
			return false;
		}else if(phone=="" || phone=="Enter your phone number"){
			window.alert("You must enter your phone number.");
			return false;
		}else if(area=="" || area=="Enter your first name"){
			window.alert("You must enter your username.");
			return false;
		}
	}
