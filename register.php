<?php # Script 1.5- register.php

/* Name: Commerce Web Portal/ Register Page
*  Author: Farhood Rashidi
*  Date: 07/29/2014
*  This page defines the user object and gets the user's first name, username, password, and email and then displays the confirmation message or error message. 
*/

include_once 'include/functions.php';
$user = new User();

// Checking for user logged in or not
if ($user->get_session())
{
	header("home.php");
}

if ($_SERVER["REQUEST_METHOD"] == "POST") 
{
	$register = $user->register_user($_POST['name'], $_POST['username'], $_POST['password'], $_POST['email']);
	if ($register) 
	{
		// Registration Success
		echo 'Registration successful.<br><a href="login.php">Click here</a> to login';
	} 
	else 
	{
		// Registration Failed
		echo 'Registration failed. Email or Username already exits. please try again!';
	}
}
