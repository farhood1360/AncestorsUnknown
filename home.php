<?php

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

?>
//HTML Code
<a href="">LOGOUT</a>
<h1> Hello <?php $user->get_fullname($uid); ?></h1>
