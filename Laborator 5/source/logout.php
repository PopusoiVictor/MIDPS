<?php
$db=mysqli_connect("localhost","root","","yahtzee");
if(isset($_POST['submit2']))
{
session_destroy();
unset($_SESSION['username']);
header("location:index.php");
}
?>