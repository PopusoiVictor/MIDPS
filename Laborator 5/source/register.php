<?php
session_start();
//conectare la baza de date
$db=mysqli_connect("localhost","root","","yahtzee");
if(isset($_POST['submit']))
{
    $username=mysql_real_escape_string($_POST['username']);
    $email=mysql_real_escape_string($_POST['email']);
    $password=mysql_real_escape_string($_POST['password']);
    $password2=mysql_real_escape_string($_POST['password2']); 
     if($password==$password2)
     {           //Cream userul
            $password=md5($password); 
            $sql="INSERT INTO users(username,email,password) VALUES('$username','$email','$password')";
            mysqli_query($db,$sql);  
            $_SESSION['username']=$username;
            header("location:index.php");
    }
    else
    {
      $_SESSION['message']=" The password does not coincide, please retry!";
    }
}
?>