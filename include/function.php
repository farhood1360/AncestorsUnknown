<?php # Script 1.3- function.php

/* Name: Commerce Web Portal/ Function Page
*  Author: Farhood Rashidi
*  Date: 07/29/2014
*  This page defines the user class.
*/
	
# ************************** #
# ********** CLASSES ******* #
	
/* Class User
*  The class contains one attributes:
*    - private $db
*  The class contains six methods:
*   - __Constructor
*   - register_user()
*   - check_login()
*   - get_fullname()
*   - get_session() 
*   - user_logout() 
*/

include_once 'config.php';
class User
{
  private $db;

  //Database connect 
  public function __construct() 
  {
    $db = new DB_Class();
  }
  
  //Registration process 
  public function register_user($name, $username, $password, $email) 
  {
    $password = md5($password);
    $sql = mysql_query("SELECT uid from users WHERE username = '$username' or email = '$email'");
    $no_rows = mysql_num_rows($sql);
    if ($no_rows == 0) 
    {
      $result = mysql_query("INSERT INTO users(username, password, name, email) values ('$username', '$password','$name','$email')") or die(mysql_error());
      return $result;
    }
    else
    {
      return FALSE;
    }
  }

  // Login process
  public function check_login($emailusername, $password) 
  {
    $password = md5($password);
    $result = mysql_query("SELECT uid from users WHERE email = '$emailusername' or username='$emailusername' and password = '$password'");
    $user_data = mysql_fetch_array($result);
    $no_rows = mysql_num_rows($result);
    if ($no_rows == 1) 
    {
      $_SESSION['login'] = true;
      $_SESSION['uid'] = $user_data['uid'];
      return TRUE;
    }
    else
    {
      return FALSE;
    }
  }

   // Getting name
  public function get_fullname($uid) 
  {
    $result = mysql_query("SELECT name FROM users WHERE uid = $uid");
    $user_data = mysql_fetch_array($result);
    echo $user_data['name'];
  }

  // Getting session 
  public function get_session() 
  {
    return $_SESSION['login'];
  }

  // Logout 
  public function user_logout() 
  {
    $_SESSION['login'] = FALSE;
    session_destroy();
  }

}// End of User class.
	
# ********** END OF CLASSES ******* #
# ********************************* #
