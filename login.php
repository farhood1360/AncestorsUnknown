<?php

session_start();
include_once 'include/functions.php';
$user = new User();

if ($user->get_session())
{
	header("home.php");
}

if ($_SERVER["REQUEST_METHOD"] == "POST") 
{ 
	$login = $user->check_login($_POST['emailusername'], $_POST['password']);
	if ($login) 
	{
		// Login Success
		header("login.php");
	} 
	else 
	{
		// Login Failed
		$messag= 'Username or password is not correct!';
	}
}
