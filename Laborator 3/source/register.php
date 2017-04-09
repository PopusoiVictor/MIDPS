<?php
session_start();
//conectare la baza de date
$db=mysqli_connect("localhost","root","","smotramd");
if(isset($_POST['submit']))
{
    $username=mysql_real_escape_string($_POST['username']);
    $email=mysql_real_escape_string($_POST['email']);
    $password=mysql_real_escape_string($_POST['password']);
    $password2=mysql_real_escape_string($_POST['password2']); 
    $telephone=mysql_real_escape_string($_POST['telephone']);
     if($password==$password2)
     {           //Cream userul
            $password=md5($password); 
            $sql="INSERT INTO users(username,email,password,telephone) VALUES('$username','$email','$password','$telephone')";
            mysqli_query($db,$sql);  
            $_SESSION['username']=$username;
            header("location:login.php");
    }
    else
    {
      $_SESSION['message']="Parola introdusa nu coincide!";   
     }
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
	   <div class="login">
			   	   <span><a href="login.php"><img src="images/autentificare.png" alt="" title="Autentificare"></a></span>
			   </div>
			   <div class="register">
			   	   <span><a href="register.php"><img src="images/inregistrare.png" alt="" title="Inregistrare"></a></span>
			   </div>
			 <div class="clear"></div>
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
<body>
<div class="main">
<div class="main1">
        <form class="form-4" method="post" action="register.php">
            <?php
              if(isset($_SESSION['message'])) {
                    echo "<div style='color:#FF0000';id='error_msg'>".$_SESSION['message']."</div>";
                  unset($_SESSION['message']);
              }
          ?>
            <h1>Inregistrare</h1>
            <p>
                <label for="register">Username</label>
                <input type="text" name="username" placeholder="Username" required>
            </p>
            <p>
                <label for="password">E-mail</label>
                <input type="text" name='email' placeholder="Email" required> 
            </p>
            <p>
                <label for="password">Password</label>
                <input type="password" name='password' placeholder="Password" required> 
            </p>
             <p>
                <label for="password">Confirm Password</label>
                <input type="password" name='password2' placeholder="Confirm Password" required> 
            </p>
            <p>
                <label for="password">Telephone</label>
                <input type="text" name='telephone' placeholder="Telephone" required> 
            </p>
            <p>
                <input type="submit" name="submit" value="Inregistrare">
            </p>       
        </form>​​
</div>
</div>
</body>
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