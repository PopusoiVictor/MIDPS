<!DOCTYPE HTML>
<html>
<head>
<title> SMOTRAMD </title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<link href='http://fonts.googleapis.com/css?family=Anaheim' rel='stylesheet' type='text/css'>
<link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
<!--image slider-->
<script type="text/javascript" src="js/jquery-1.7.2.min.js"></script> 
<script src="js/jquery-slider.js" type="text/javascript"></script>
<script src="js/easyResponsiveTabs.js" type="text/javascript"></script>
<link href="css/easy-responsive-tabs.css" rel="stylesheet" type="text/css" media="all"/>
<link rel="stylesheet" href="css/global.css">
<script src="js/slides.min.jquery.js"></script>
<script>
		$(function(){
			$('#products').slides({
				preload: true,
				preloadImage: 'img/loading.gif',
				effect: 'slide, fade',
				crossfade: true,
				slideSpeed: 350,
				fadeSpeed: 500,
				generateNextPrev: true,
				generatePagination: false
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
<div class="main">
<div class="main1">
<div class="details">
				  <div class="product-details">				
					<div class="images_3_of_2">
						<div id="container">
						   <div id="products_example">
							<div id="products">
								<div class="slides_container">
									<a href="#" target="_blank"><img src="images/Top 5/ferrari485 280x180.jpg" alt=" " /></a>
									<a href="#" target="_blank"><img src="images/Top 5/ferrari-485.jpg" alt=" " /></a>
									<a href="#" target="_blank"><img src="images/Top 5/ferrari--.jpg" alt=" " /></a>
								</div>
								<ul class="pagination">
									<li><a href="#"><img src="images/Top 5/ferrari485 180x140.jpg" alt=" " /></a></li>
									<li><a href="#"><img src="images/Top 5/ferrari_485.jpg" alt=" " /></a></li>
									<li><a href="#"><img src="images/Top 5/ferrari__.jpg" alt=" " /></a></li>
								</ul>
							</div>
						</div>
					</div>
				</div>
				<div class="desc span_3_of_2">
					<h2>Ferrari 458 Italia</h2><br\>
					<p>Capacitate cilindrica: 4499 cm3</p><br\>
					<p>Numar de locuri: 2</p><br\>
					<p>Numar de usi: 2 </p><br\>
					<p>Trepte: 7</p><br\>
					<p>Consumul de combustibil (combinat): 13.3 l/100 km</p><br\>
					<p>Consumul de combustibil (urban): 19.7 l/100 km</p><br\>
					<p>Consumul de combustibil (extraurban): 9.5 l/100 km</p><br\>					
			</div>
			<div class="clear"></div>
		  </div>
		<div class="product_desc">	
			<div id="horizontalTab" style="display: block; width: 100%; margin: 0px;">
				<ul class="resp-tabs-list">
					<li class="resp-tab-item resp-tab-active" aria-controls="tab_item-0" role="tab">Informatii</li>
					<div class="clear"></div>
				</ul>
				<div class="resp-tabs-container">
					<h2 class="resp-accordion resp-tab-active" role="tab" aria-controls="tab_item-0"><span class="resp-arrow"></span>Informatii</h2><div class="product-desc resp-tab-content resp-tab-content-active" style="display:block" aria-labelledby="tab_item-0">
						<p>Ferrari este un producător de mașini sport cu sediul în Maranello (Italia). Fondată în 1929 de Enzo Ferrari, ca Scuderia Ferrari, compania a sponsorizat piloți și a produs mașini de curse înainte de a produce mașini adecvate pentru a fi conduse pe drumurile publice. În 1969, Fiat a devenit acționar la Ferrari iar acum este proprietarul majoritar. În prezent, cel mai mare acționar al grupului Fiat, cu 90%, 5% din acțiuni a fost cumpărat în 2005 de către o companie din Emiratele Arabe Unite, iar restul aparține Piero Ferrari, fiul lui Enzo. Compania are sediul în Maranello lângă Bologna și Modena, Italia. În 2005, Ferrari a vândut 5.409 de unități, cu o creștere a vânzărilor de 8,7%, având o cifră de afaceri de 1,5 miliarde de euro. De-a lungul istoriei, compania a fost renumită pentru participarea continuă în curse, în special în Formula 1, unde a avut mare succes. Mașinile Ferrari sunt în general văzute ca un simbol al vitezei, luxului și bogăției.</p>	</div>
			</div>
		 </div>
	 </div>
	    <script type="text/javascript">
    $(document).ready(function () {
        $('#horizontalTab').easyResponsiveTabs({
            type: 'default', //Types: default, vertical, accordion           
            width: 'auto', //auto or any width like 600px
            fit: true   // 100% fit in a container
        });
    });
   </script>		
   <div class="content_bottom">
   	<div class="text-h1 top1 btm">
			<h2>Aici puteti urmari si alte masini de pe teritoriul Republicii Moldova</h2>
	  	</div>
 <div class="div2">
        <div id="mcts1">
        	<img src="images/MD/mustang.jpg" alt=""/>
        	<img src="images/MD/bantly.jpg" alt=""/>
        	<img src="images/MD/bmw.jpg" alt=""/>
        	<img src="images/MD/discovery.jpg" alt=""/>
        	<img src="images/MD/volvo.jpg" alt=""/>
        	<img src="images/MD/volk.jpg" alt=""/>
        	<img src="images/MD/range.jpg" alt=""/>
        	<img src="images/MD/bmwalb.jpg" alt=""/>
        	<img src="images/MD/merc.jpg" alt=""/>
       </div>
	</div>
</div>
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