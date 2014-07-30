<?php # Script 1.5- config.php

/* Name: Commerce Web Portal/ Config Page
*  Author: Farhood Rashidi
*  Date: 07/29/2014
*  This page defines and gets the user's username, password, database, and localhost.
*/

define('DB_SERVER', 'localhost');
define('DB_USERNAME', 'username');
define('DB_PASSWORD', 'password');
define('DB_DATABASE', 'database');

class DB_Class 
{
	function __construct() 
	{
		$connection = mysql_connect(DB_SERVER, DB_USERNAME, DB_PASSWORD) or 
		die('Oops connection error -> ' . mysql_error());
		mysql_select_db(DB_DATABASE, $connection) 
		or die('Database error -> ' . mysql_error());
	}
}
