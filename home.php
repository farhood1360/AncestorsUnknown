<?php # Script 1.2- home.php

/* Name: Commerce Web Portal/ Home Page
*  Author: Farhood Rashidi
*  Date: 07/29/2014
*  This page defines the user object and creates the login and logout sessions. 
*/

session_start();

//include_once 'include/functions.php';
$user = new User();
$uid = $_SESSION['uid'];

if (!$user->get_session())
{
	header("login.php");
}

if ($_GET['q'] == 'logout') 
{
	$user->user_logout();
	header("login.php");
}
