<?php # Script 1.1- commerce.php

/* Name: Commerce Web Portal/ Check Out Page
*  Author: Farhood Rashidi
*  Date: 07/22/2014
*  This page defines and gets the user's first name, last name, credit card and expiration date.
*  Then displays the confirmation message or error message. 
*/
	
# ************************** #
# ********** CLASSES ******* #
	
/* Class Checkout
*  The class contains five attributes:
*    - private $first_name
*    - private $last_name
*    - private $credit
*    - private $expiration
*    - private $photo
* The class contains two methods:
*   - __Constructor
*   - set_form()
*/
	
class Checkout
{
  // Declare the attributes:
  private $first_name = "";
  private $last_name = "";
  private $credit = "";
  private $expiration = "";
  private $photo = NULL;
		
  // Constructor:
  function __construct($fname, $lname, $c, $e, $p)
  {
	$this->first_name = $fname;
	$this->last_name = $lname;
	$this->credit = $c;
	$this->expiration = $e;
	$this->photo = $p;
   }
		
   // Set a form method
   public function set_form()
   {
	if(isset($_POST["info"]))
	{
	   if(empty($_POST['first_name']) || empty($_POST['last_name']) || empty($_POST['credit']) || empty($_POST['expiration']) || $_FILES['photo']['error']>0 )
				{
					$message = "<p>You must enter your first name, last name, credit card number and expiration date. Click the submit button for registration agian." . $_FILES['photo']['error'];
				}
				else
				{
					if ($_FILES['photo']['size'] < 1000000)
					{
						$first_name = addslashes($_POST['first_name']);
						$Last_name = addslashes($_POST['last_name']);
						$credit = addslashes($_POST['credit']);
						$expiration = addslashes($_POST['expiration']);
						$photo = $_FILES['photo']['type'];
						$CommerceList = fopen("commercelist.txt", "ab");
						if(is_writeable("commercelist.txt"))
						{
							if(fwrite($CommerceList, $Last_name . "," . $first_name . "," . $credit . "," . $expiration . "," . $photo . "\n"))
							{
								$message = " <table border='1' align='center'>
									<tr>
										<td>First Name</td>
										<td>Last Name</td>
										<td>Credit Card Number</td>
										<td>Exprition Date</td>
										<td>Personal Image</td>
									</tr>
									<tr>
										<td align='center'>".$first_name."</td>
										<td align='center'>".$Last_name."</td>
										<td align='center'>".$credit."</td>
										<td align='center'>".$expiration."</td>
										<td align='center'>".$photo."</td>
									</tr>
								</table>" ;
							}
							else
							{
								$message = "Can not add your information to the commerce list!";
							}
						}
						else
						{
							$message =  "Can not write to the file.";
						}
					}
					else
					{
		        	$message =  "Please enter the small image.";
			}
			fclose($CommerceList);
	       	}
	     }
	return ($message);
  }
} // End of Checkout class.
	
# ********** END OF CLASSES ******* #
# ********************************* #
	
// Create a checkout form:
$customer = new Checkout();
$customer->first_name = $_POST['first_name'];
$customer->last_name = $_POST['last_name'];
$customer->credit = $_POST['credit'];
$customer->expiration = $_POST['expiration'];
$customer->photo = $_POST['photo'];
	
// Print the message:
$message = $customer->set_form();
