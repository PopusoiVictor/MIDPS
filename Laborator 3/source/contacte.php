<?php
session_start();
//conectare la baza de date
$db=mysqli_connect("localhost","root","","smotramd");
if(isset($_POST['submit']))
{
    $userName=mysql_real_escape_string($_POST['userName']);
    $userEmail=mysql_real_escape_string($_POST['userEmail']);
    $userPhone=mysql_real_escape_string($_POST['userPhone']);
    $userMsg=mysql_real_escape_string($_POST['userMsg']); 
        $sql="INSERT INTO mesaj(userName,userEmail,userPhone,userMsg) VALUES('$userName','$userEmail','$userPhone','$userMsg')";
            $result=mysqli_query($db,$sql);
        		header("location:contacte.php");
        	}
?>
<!DOCTYPE HTML>
<html>
<head>
<title> SMOTRAMD </title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<link href='http://fonts.googleapis.com/css?family=Anaheim' rel='stylesheet' type='text/css'>
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
</head>
<body>
<div class="wrap">
<div class="header">
	<div class="logo">
		<h1><a href="acasa.php"><img src="images/logo.png" alt=""></a></h1>
	</div>
	<div class="h_right">
	<div class="drp-dwn">
	</div>
	<div class="header_top_right">
	<?php require 'header.php' ?>
	</div>
	</div>
	<div class="clear"></div>
	<div class="h_main">
		<ul class="nav">
	        <li class="active"><a href="acasa.php">Acasa</a></li>
	        <li><a href="masini.php">Masini</a></li>
	        <li><a href="service.php">Service</a></li>
	        <li><a href="contacte.php">Contacte</a></li>
	     </ul>
	     <div class="search">
	    	<form>
	    		<input type="text" value="">
	    		<input type="submit" value="">
	    	</form>
		</div>
	<div class="clear"></div>
	</div>
</div>
<div class="main">
<div class="main1">
 	<div class="section group1">					
	<?php require 'header2.php' ?>	
	</div>
</div>
</div>
<div class="footer">
	<div class="f_left">
		<div class="copy">
				<p class="w3-link">© All Rights Reserved | Design by Popusoi Victor </p>
			</div>
		</div>
	 <div class="clear"></div>
</div>
</div>
</body>
</html>