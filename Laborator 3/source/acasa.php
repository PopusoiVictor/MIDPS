
<!DOCTYPE HTML>
<html>
<head>
<title> SMOTRAMD </title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<link href='http://fonts.googleapis.com/css?family=Anaheim' rel='stylesheet' type='text/css'>
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
<!--slider-->
<script type="text/javascript" src="js/modernizr.custom.53451.js"></script>
<script type="text/javascript" src="js/jquery.min.js"></script>
<script type="text/javascript" src="js/jquery.gallery.js"></script>
<script type="text/javascript">
		$(function() {
		$('#dg-container').gallery({
		autoplay	:	true
	});
});

</script>
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
<div class="container">
	<section id="dg-container" class="dg-container">
			<div class="dg-wrapper">
					<a href="#"><img src="images/img.jpg" alt="image1" /></a>
					<a href="#"><img src="images/audir8.jpg" alt="image2" /></a>
					<a href="#"><img src="images/audii.jpg" alt="image3" /></a>
					<a href="#"><img src="images/bmw520.jpg" alt="image4" /></a>
					<a href="#"><img src="images/mustang.jpg" alt="image5" /></a>
					<a href="#"><img src="images/lambo.jpg" alt="image1" /></a>
					<a href="#"><img src="images/vol.jpg" alt="image2" /></a>
					<a href="#"><img src="images/audi2.jpg" alt="image3" /></a>
			</div>
	</section>
</div>
<div class="main">
	<div class="section group">
		<div class="grid_1_of_4 images_1_of_4">
			  <a href="details.php"><img src="images/MD/ferr.jpg"></a>
			   <a href="details.php"><h3>Ferrari</h3></a>
		</div>
		<div class="grid_1_of_4 images_1_of_4">
			  <a href="404.php"><img src="images/audiq7.jpg"></a>
			   <a href="404.php"><h3>Audi</h3></a>
		</div>
		<div class="grid_1_of_4 images_1_of_4">
			  <a href="404.php"><img src="images/bmwtuning.jpg"></a>
			   <a href="404.php"><h3>BMW</h3></a>
		</div>
		<div class="grid_1_of_4 images_1_of_4">
			  <a href="404.php"><img src="images/mercCL.jpg"></a>
			   <a href="404.php"><h3>Mercedes</h3></a>
		</div>
			<div class="clear"></div>
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
