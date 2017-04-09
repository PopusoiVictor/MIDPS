<?php include 'select_list.php'; ?>
<!DOCTYPE HTML>
<html>
<head>
<title> SMOTRAMD </title>
<script src="js/ajax_select.js" type="text/javascript"></script>
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
<div class="boxes">
		<h2>Service auto Republica Moldova</h2>
		<div class="image group">
		<div class="images_2_of_2">
		<a href="#"><img src="images/service.jpg" alt=" " /></a>
		<div class="ajax">
			<form action="" method="post";>
		 Alege: <?php echo $re_html;?>
				</form>
			</div>
		</div>
		<div class="span_2_of_2">
			<p>Service-ul are o gama larga de servicii! Găsiţi cea mai apropiată unitate de service auto. V-a oferim servicii de mare calitate cum ar fi:
			<p>1.Reparatie motoarelor diesel - benzin</p><br\>
			<p>2.Reparatie cutii de viteze automat</p><br\>
			<p>3.Reparatie sistem de franare</p><br\>
			<p>4.Reparatie sistem de directie hidraulice,mecanice si electrice Reparatii sistem de alimentare</p><br\>
			<p>5.Reparatii sistem de racire a motorului</p><br\>
			<p>6.Reparatii sisteme electronice, electrice</p><br\>
			<p>7.Reparatii suspensie</p><br\>
			<p>8.Reparatie-schimbare ambreiaj</p><br\>
			<p>9.Reglarea geometrie roti</p><br\>
			<p>10.Diagnostica computerizata</p><br\>
			<p>11.Schimb curea de distributie si pompe</p><br\>
			<p>12.Schimb ulei, filtre si lichide consumabile</p><br\>
			<p>13.Schimb rulmenti, amortizoare</p><br\>
			<p>14.Schimb pompelor hidraulice.</p><br\>
		</div>
	  <div class="clear"></div>
</div>
		<div class="repair">
		<div class="text-h1 top1 btm">
			<h2>Aici puteti vedea unele videouri</h2>
	  	</div>
		     <section>
				<ul class="lb-album">
					<li>
						<video controls="controls" width="220" height="200">
						<source src="video/1.mp4" type="video/mp4">
					</li>
					<li>
						<video controls="controls" width="220" height="200">
						<source src="video/2.mp4" type="video/mp4">
					</li>
					<li>
						<video controls="controls" width="220" height="200">
						<source src="video/4.mp4" type="video/mp4">
					</li>
					<li>
						<video controls="controls" width="220" height="200">
						<source src="video/6.mp4" type="video/mp4">
					</li>
				</ul>
				</section>
				</div>
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