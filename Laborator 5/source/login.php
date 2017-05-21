<?php
$db=mysqli_connect("localhost","root","","yahtzee");
if(isset($_POST['submit1']))
{
    $username=mysql_real_escape_string($_POST['username']);
    $password=mysql_real_escape_string($_POST['password']);
    $password=md5($password); 
    $sql="SELECT * FROM users WHERE username='$username' AND password='$password'";
    $result=mysqli_query($db,$sql);
    if(mysqli_num_rows($result)==1)
    {
        $_SESSION['username']=$username;
        header("location:index.php");
    }
 
}
?>